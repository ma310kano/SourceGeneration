using SourceGeneration.Application.Command;

namespace SourceGeneration.Application
{
    /// <summary>
    /// ファイルを変換するアプリケーションサービス
    /// </summary>
    public interface IFileConversionApplicationService
    {
        #region Methods

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        void ConvertFile(SingleFileConversionCommand command);

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>非同期処理を返します。</returns>
        Task ConvertFileAsync(SingleFileConversionCommand command);

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        void ConvertFile(MultipleFileConversionCommand command);

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>非同期処理を返します。</returns>
        Task ConvertFileAsync(MultipleFileConversionCommand command);

        #endregion
    }
}
