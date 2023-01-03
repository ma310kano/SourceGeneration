using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using SourceGeneration.Application;
using SourceGeneration.Application.Command;
using SourceGeneration.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Threading.Tasks;

namespace ConversionApp.ViewModels
{
    /// <summary>
    /// ファイルを新規作成する画面(ViewModel)
    /// </summary>
    public class NewFileCreationViewModel : BindableBase, INavigationAware
    {
        #region Fields

        /// <summary>
        /// ファイル種別のクエリサービス
        /// </summary>
        private readonly IFileTypeQueryService _fileTypeQueryService;

        /// <summary>
        /// ファイルを作成するアプリケーションサービス
        /// </summary>
        private readonly IFileCreationApplicationService _fileCreationApplicationService;

        /// <summary>
        /// 作成先のディレクトリーパス
        /// </summary>
        private readonly string _destinationDirPath;

        #endregion

        #region Constructors

        /// <summary>
        /// ファイルを新規作成する画面(ViewModel)を初期化します。
        /// </summary>
        /// <param name="configuration">設定</param>
        /// <param name="fileTypeQueryService">ファイル種別のクエリサービス</param>
        /// <param name="fileCreationApplicationService">ファイルを作成するアプリケーションサービス</param>
        public NewFileCreationViewModel(
            IConfiguration configuration,
            IFileTypeQueryService fileTypeQueryService,
            IFileCreationApplicationService fileCreationApplicationService)
        {
            _fileTypeQueryService = fileTypeQueryService;
            _fileCreationApplicationService = fileCreationApplicationService;

            FileTypeItems = new ReactiveCollection<FileTypeItemViewModel>(Scheduler.Immediate);
            FileTypeItem = new ReactivePropertySlim<FileTypeItemViewModel>();
            CreateFileCommand = new AsyncReactiveCommand().WithSubscribe(CreateFileAsync);

            {
                string? destinationDirPath = configuration.GetValue<string>("FileSystem:FileCreation:DefaultDestinationDirectoryPath");
                if (destinationDirPath is null) throw new InvalidOperationException("作成先のディレクトリーパスが取得できません。");

                _destinationDirPath = destinationDirPath;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// ファイル種別の項目のコレクションを取得します。
        /// </summary>
        public ReactiveCollection<FileTypeItemViewModel> FileTypeItems { get; }

        /// <summary>
        /// ファイル種別の項目を取得します。
        /// </summary>
        public ReactivePropertySlim<FileTypeItemViewModel> FileTypeItem { get; }

        /// <summary>
        /// ファイルを作成するコマンドを取得します。
        /// </summary>
        public AsyncReactiveCommand CreateFileCommand { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 引数で渡されたコンテキストのターゲットとなる画面かどうかを返します。
        /// </summary>
        /// <param name="navigationContext">遷移時のコンテキストを表します。</param>
        /// <returns>ターゲットとなる画面の場合は、 <c>true</c>。それ以外の場合は、 <c>false</c>。</returns>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// 画面から離れるときに呼び出されます。
        /// </summary>
        /// <param name="navigationContext">遷移時のコンテキストを表します。</param>
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        /// <summary>
        /// 画面に遷移してきたときに呼び出されます。
        /// </summary>
        /// <param name="navigationContext">遷移時のコンテキストを表します。</param>
        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            await Query();
        }

        /// <summary>
        /// ファイル種別を検索します。
        /// </summary>
        /// <returns>非同期処理を返します。</returns>
        private async Task Query()
        {
            IEnumerable<FileTypeData> fileTypes = await _fileTypeQueryService.QueryAsync();

            IList<FileTypeItemViewModel> fileTypeItems = new List<FileTypeItemViewModel>();
            foreach (FileTypeData fileType in fileTypes)
            {
                FileTypeItemViewModel fileTypeItem = new(fileType);
                fileTypeItems.Add(fileTypeItem);
            }

            FileTypeItems.Clear();
            FileTypeItems.AddRangeOnScheduler(fileTypeItems);

            FileTypeItem.Value = FileTypeItems.First();
        }

        /// <summary>
        /// ファイルを作成します。
        /// </summary>
        private async Task CreateFileAsync()
        {
            CommonSaveFileDialog dialog = new()
            {
                DefaultFileName = FileTypeItem.Value.FileName.Value,
                InitialDirectory = _destinationDirPath,
                RestoreDirectory = true,
            };

            dialog.Filters.Add(new CommonFileDialogFilter("JSON ファイル (*.json)", "*.json"));
            dialog.Filters.Add(new CommonFileDialogFilter("すべてのファイル (*.*)", "*.*"));

            CommonFileDialogResult result = dialog.ShowDialog();
            if (result != CommonFileDialogResult.Ok) return;

            FileCreationCommand command = new(FileTypeItem.Value.FileTypeId.Value, dialog.FileName);

            await _fileCreationApplicationService.CreateAsync(command);
        }

        #endregion
    }
}
