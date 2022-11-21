using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Mvvm;
using Reactive.Bindings;
using SourceGeneration.Application;
using SourceGeneration.Application.Command;
using System.Threading.Tasks;

namespace ConversionApp.ViewModels
{
    /// <summary>
    /// 1つのファイルを変換する画面(ViewModel)
    /// </summary>
    internal class SingleFileConversionViewModel : BindableBase
    {
        #region Fields

        /// <summary>
        /// ファイルを変換するサービス
        /// </summary>
        private readonly IFileConversionApplicationService _fileConversionService;

        #endregion

        #region Constructors

        /// <summary>
        /// 1つのファイルを変換する画面(ViewModel)を初期化します。
        /// </summary>
        /// <param name="fileConversionService">ファイルを変換するサービス</param>
        public SingleFileConversionViewModel(IFileConversionApplicationService fileConversionService)
        {
            _fileConversionService = fileConversionService;

            SourceFilePath = new ReactivePropertySlim<string>();
            SelectSourceFileCommand = new ReactiveCommand().WithSubscribe(SelectSourceFile);
            ConvertFileCommand = new AsyncReactiveCommand().WithSubscribe(ConvertFileAsync);
        }

        #endregion

        #region Properties

        /// <summary>
        /// 変換元のファイルパスを取得します。
        /// </summary>
        public ReactivePropertySlim<string> SourceFilePath { get; }

        /// <summary>
        /// 変換元のファイルを選択するコマンドを取得します。
        /// </summary>
        public ReactiveCommand SelectSourceFileCommand { get; }

        /// <summary>
        /// ファイルを変換するコマンドを取得します。
        /// </summary>
        public AsyncReactiveCommand ConvertFileCommand { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 変換元のファイルを選択します。
        /// </summary>
        private void SelectSourceFile()
        {
            CommonOpenFileDialog dialog = new();
            dialog.Filters.Add(new CommonFileDialogFilter("JSON ファイル (*.json)", "*.json"));
            dialog.Filters.Add(new CommonFileDialogFilter("すべてのファイル (*.*)", "*.*"));

            CommonFileDialogResult result = dialog.ShowDialog();
            if (result != CommonFileDialogResult.Ok) return;

            SourceFilePath.Value = dialog.FileName;
        }

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <returns>非同期処理を返します。</returns>
        private async Task ConvertFileAsync()
        {
            CommonOpenFileDialog dialog = new()
            {
                IsFolderPicker = true,
            };

            CommonFileDialogResult result = dialog.ShowDialog();
            if (result != CommonFileDialogResult.Ok) return;

            SingleFileConversionCommand command = new(
                SourceFilePath.Value,
                dialog.FileName);

            await _fileConversionService.ConvertFileAsync(command);
        }

        #endregion
    }
}
