using SourceGeneration.Application.Data;

namespace SourceGeneration.Application
{
    /// <summary>
    /// ファイル種別のクエリサービス
    /// </summary>
    public interface IFileTypeQueryService
    {
        #region Methods

        /// <summary>
        /// ファイル種別を検索します。
        /// </summary>
        /// <returns>検索したファイル種別データのコレクションを返します。</returns>
        IEnumerable<FileTypeData> Query();

        /// <summary>
        /// ファイル種別を検索します。
        /// </summary>
        /// <returns>検索したファイル種別データのコレクションを返します。</returns>
        Task<IEnumerable<FileTypeData>> QueryAsync();

        #endregion
    }
}
