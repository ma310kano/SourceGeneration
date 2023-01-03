using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Mvvm;
using Reactive.Bindings;
using SourceGeneration.Application;
using SourceGeneration.Application.Command;
using System;
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

        /// <summary>
        /// 変換元のディレクトリーパス
        /// </summary>
        private readonly string _sourceDirPath;

        /// <summary>
        /// 変換先のディレクトリーパス
        /// </summary>
        private readonly string _destinationDirPath;

        #endregion

        #region Constructors

        /// <summary>
        /// 1つのファイルを変換する画面(ViewModel)を初期化します。
        /// </summary>
        /// <param name="configuration">設定</param>
        /// <param name="fileConversionService">ファイルを変換するサービス</param>
        public SingleFileConversionViewModel(
            IConfiguration configuration,
            IFileConversionApplicationService fileConversionService)
        {
            _fileConversionService = fileConversionService;

            SourceFilePath = new ReactivePropertySlim<string>();
            SelectSourceFileCommand = new ReactiveCommand().WithSubscribe(SelectSourceFile);
            ConvertFileCommand = new AsyncReactiveCommand().WithSubscribe(ConvertFileAsync);

            {
                IConfigurationSection fileConversionSection = configuration.GetSection("FileSystem:FileConversion");

                {
                    string? sourceDirPath =  fileConversionSection.GetValue<string>("DefaultSourceDirectoryPath");
                    if (sourceDirPath is null) throw new InvalidOperationException("変換元のディレクトリーパスを取得できません。");

                    _sourceDirPath = sourceDirPath;
                }

                {
                    string? destinationDirPath = fileConversionSection.GetValue<string>("DefaultDestinationDirectoryPath");
                    if (destinationDirPath is null) throw new InvalidOperationException("変換先のディレクトリーパスを取得できません。");

                    _destinationDirPath = destinationDirPath;
                }
            }
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
            CommonOpenFileDialog dialog = new()
            {
                InitialDirectory = _sourceDirPath,
                RestoreDirectory = true,
            };

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
                InitialDirectory = _destinationDirPath,
                IsFolderPicker = true,
                RestoreDirectory = true,
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
