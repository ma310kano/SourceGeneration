namespace SourceGeneration.Application.Command
{
    /// <summary>
    /// ファイルを作成するコマンド
    /// </summary>
    public class FileCreationCommand
    {
        #region Constructors

        /// <summary>
        /// ファイルを作成するコマンドを初期化します。
        /// </summary>
        /// <param name="fileTypeId">ファイル種別ID</param>
        /// <param name="destinationFilePath">作成先のファイルパス</param>
        public FileCreationCommand(FileTypeId fileTypeId, string destinationFilePath)
        {
            FileTypeId = fileTypeId;
            DestinationFilePath = destinationFilePath;
        }

        #endregion

        #region Properties

        /// <summary>
        /// ファイル種別IDを取得します。
        /// </summary>
        public FileTypeId FileTypeId { get; }

        /// <summary>
        /// 作成先のファイルパスを取得します。
        /// </summary>
        public string DestinationFilePath { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(FileCreationCommand)} {{ {nameof(FileTypeId)} = {FileTypeId}, {nameof(DestinationFilePath)} = {DestinationFilePath} }}";
        }

        #endregion
    }
}
