namespace SourceGeneration.Application.Data
{
    /// <summary>
    /// ファイル種別のデータ
    /// </summary>
    public class FileTypeData
    {
        #region Constructors

        /// <summary>
        /// ファイル種別のデータを初期化します。
        /// </summary>
        /// <param name="fileTypeId">ファイル種別ID</param>
        /// <param name="fileTypeName">ファイル種別名</param>
        /// <param name="fileName">ファイル名</param>
        public FileTypeData(FileTypeId fileTypeId, string fileTypeName, string fileName)
        {
            FileTypeId = fileTypeId;
            FileTypeName = fileTypeName;
            FileName = fileName;
        }

        #endregion

        #region Properties

        /// <summary>
        /// ファイル種別IDを取得します。
        /// </summary>
        public FileTypeId FileTypeId { get; }

        /// <summary>
        /// ファイル種別名を取得します。
        /// </summary>
        public string FileTypeName { get; }

        /// <summary>
        /// ファイル名を取得します。
        /// </summary>
        public string FileName { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(FileTypeData)} {{ {nameof(FileTypeId)} = {FileTypeId}, {nameof(FileTypeName)} = {FileTypeName}, {nameof(FileName)} = {FileName} }}";
        }

        #endregion
    }
}
