namespace SourceGeneration.Application.Command
{
    /// <summary>
    /// 1つのファイルを変換するコマンド
    /// </summary>
    public class SingleFileConversionCommand
    {
        #region Constructors

        /// <summary>
        /// 1つのファイルを変換するコマンドを初期化します。
        /// </summary>
        /// <param name="sourceFilePath">変換元のファイルパス</param>
        /// <param name="destinationDirectoryPath">変換先のディレクトリーパス</param>
        public SingleFileConversionCommand(
            string sourceFilePath,
            string destinationDirectoryPath)
        {
            SourceFilePath = sourceFilePath;
            DestinationDirectoryPath = destinationDirectoryPath;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 変換元のファイルパスを取得します。
        /// </summary>
        public string SourceFilePath { get; }

        /// <summary>
        /// 変換先のディレクトリーパスを取得します。
        /// </summary>
        public string DestinationDirectoryPath { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(SingleFileConversionCommand)} {{ {nameof(SourceFilePath)} = {SourceFilePath}, {nameof(DestinationDirectoryPath)} = {DestinationDirectoryPath} }}";
        }

        #endregion
    }
}
