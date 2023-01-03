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
    /// 複数のファイルを変換する画面(ViewModel)
    /// </summary>
    internal class MultipleFileConversionViewModel : BindableBase
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
        /// 複数のファイルを変換する画面(ViewModel)を初期化します。
        /// </summary>
        /// <param name="configuration">設定</param>
        /// <param name="fileConversionService">ファイルを変換するサービス</param>
        public MultipleFileConversionViewModel(
            IConfiguration configuration,
            IFileConversionApplicationService fileConversionService)
        {
            _fileConversionService = fileConversionService;

            SourceDirectoryPath = new ReactivePropertySlim<string>();
            SelectSourceDirectoryCommand = new ReactiveCommand().WithSubscribe(SelectSourceDirectory);
            ConvertFileCommand = new AsyncReactiveCommand().WithSubscribe(ConvertFile);

            {
                IConfigurationSection fileConversionSection = configuration.GetSection("FileSystem:FileConversion");

                {
                    string? sourceDirPath = fileConversionSection.GetValue<string>("DefaultSourceDirectoryPath");
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
        /// 変換元のディレクトリーパスを取得します。
        /// </summary>
        public ReactivePropertySlim<string> SourceDirectoryPath { get; }

        /// <summary>
        /// 変換元のディレクトリーを選択するコマンドを取得します。
        /// </summary>
        public ReactiveCommand SelectSourceDirectoryCommand { get; }

        /// <summary>
        /// ファイルを変換するコマンドを取得します。
        /// </summary>
        public AsyncReactiveCommand ConvertFileCommand { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 変換元のディレクトリーを選択します。
        /// </summary>
        private void SelectSourceDirectory()
        {
            CommonOpenFileDialog dialog = new()
            {
                InitialDirectory = _sourceDirPath,
                IsFolderPicker = true,
                RestoreDirectory = true,
            };

            CommonFileDialogResult result = dialog.ShowDialog();
            if (result != CommonFileDialogResult.Ok) return;

            SourceDirectoryPath.Value = dialog.FileName;
        }

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <returns>非同期処理を返します。</returns>
        private async Task ConvertFile()
        {
            CommonOpenFileDialog dialog = new()
            {
                InitialDirectory = _destinationDirPath,
                IsFolderPicker = true,
                RestoreDirectory = true,
            };

            CommonFileDialogResult result = dialog.ShowDialog();
            if (result != CommonFileDialogResult.Ok) return;

            MultipleFileConversionCommand command = new(
                SourceDirectoryPath.Value,
                dialog.FileName);

            await _fileConversionService.ConvertFileAsync(command);
        }

        #endregion
    }
}
