namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// ファイル種別のコンテキスト
    /// </summary>
    public class FileTypeContext
    {
        #region Constructors

        /// <summary>
        /// ファイル種別のコンテキストを初期化します。
        /// </summary>
        /// <param name="fileType">ファイル種別</param>
        public FileTypeContext(FileTypeId fileType)
        {
            FileType = fileType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// ファイル種別を設定または取得します。
        /// </summary>
        public FileTypeId FileType { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(FileTypeContext)} {{ {nameof(FileType)} = {FileType} }}";
        }

        #endregion
    }
}
