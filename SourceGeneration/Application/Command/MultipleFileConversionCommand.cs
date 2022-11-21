namespace SourceGeneration.Application.Command
{
    /// <summary>
    /// 複数のファイルを変換するコマンド
    /// </summary>
    public class MultipleFileConversionCommand
    {
        #region Constructors

        /// <summary>
        /// 複数のファイルを変換するコマンドを初期化します。
        /// </summary>
        /// <param name="sourceDirectoryPath">変換元のディレクトリーパス</param>
        /// <param name="destinationDirectoryPath">変換先のディレクトリーパス</param>
        public MultipleFileConversionCommand(
            string sourceDirectoryPath,
            string destinationDirectoryPath)
        {
            SourceDirectoryPath = sourceDirectoryPath;
            DestinationDirectoryPath = destinationDirectoryPath;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 変換元のディレクトリーパスを取得します。
        /// </summary>
        public string SourceDirectoryPath { get; }

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
            return $"{nameof(MultipleFileConversionCommand)} {{ {nameof(SourceDirectoryPath)} = {SourceDirectoryPath}, {nameof(DestinationDirectoryPath)} = {DestinationDirectoryPath} }}";
        }

        #endregion
    }
}
