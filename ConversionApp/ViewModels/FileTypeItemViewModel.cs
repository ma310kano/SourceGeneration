using Reactive.Bindings;
using SourceGeneration;
using SourceGeneration.Application.Data;

namespace ConversionApp.ViewModels
{
    /// <summary>
    /// ファイルの種別の項目(ViewModel)
    /// </summary>
    public class FileTypeItemViewModel
    {
        #region Constructors

        /// <summary>
        /// ファイルの種別の項目(ViewModel)を初期化します。
        /// </summary>
        /// <param name="fileType">ファイル種別</param>
        public FileTypeItemViewModel(FileTypeData fileType)
        {
            FileTypeId = new ReactivePropertySlim<FileTypeId>(fileType.FileTypeId);
            FileTypeName = new ReactivePropertySlim<string>(fileType.FileTypeName);
            FileName = new ReactivePropertySlim<string>(fileType.FileName);
        }

        #endregion

        #region Properties

        /// <summary>
        /// ファイルの種別を取得します。
        /// </summary>
        public ReactivePropertySlim<FileTypeId> FileTypeId { get; }

        /// <summary>
        /// ファイルの種別名を取得します。
        /// </summary>
        public ReactivePropertySlim<string> FileTypeName { get; }

        /// <summary>
        /// ファイル名を取得します。
        /// </summary>
        public ReactivePropertySlim<string> FileName { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(FileTypeItemViewModel)} {{ {nameof(FileTypeId)} = {FileTypeId}, {nameof(FileTypeName)} = {FileTypeName}, {nameof(FileName)} = {FileName} }}";
        }

        #endregion
    }
}
