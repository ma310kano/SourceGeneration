using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Mvvm;
using Reactive.Bindings;
using SourceGeneration.Application;
using SourceGeneration.Application.Command;
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

        #endregion

        #region Constructors

        /// <summary>
        /// 複数のファイルを変換する画面(ViewModel)を初期化します。
        /// </summary>
        /// <param name="fileConversionService">ファイルを変換するサービス</param>
        public MultipleFileConversionViewModel(IFileConversionApplicationService fileConversionService)
        {
            _fileConversionService = fileConversionService;

            SourceDirectoryPath = new ReactivePropertySlim<string>();
            SelectSourceDirectoryCommand = new ReactiveCommand().WithSubscribe(SelectSourceDirectory);
            ConvertFileCommand = new AsyncReactiveCommand().WithSubscribe(ConvertFile);
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
                IsFolderPicker = true,
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
                IsFolderPicker = true,
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
