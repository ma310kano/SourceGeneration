using SourceGeneration.Application.Data;

namespace SourceGeneration.Application
{
    /// <summary>
    /// ファイル種別のクエリサービス
    /// </summary>
    public class FileTypeQueryService : IFileTypeQueryService
    {
        #region Methods

        /// <summary>
        /// ファイル種別を検索します。
        /// </summary>
        /// <returns>検索したファイル種別データのコレクションを返します。</returns>
        public IEnumerable<FileTypeData> Query()
        {
            IList<FileTypeData> fileTypes = new List<FileTypeData>()
            {
                new FileTypeData(FileTypeId.ValueObjectUuid, "値オブジェクト(UUID)", "valueobject_uuid.json"),
                new FileTypeData(FileTypeId.ValueObjectInt32, "値オブジェクト(符号付き 32 ビット整数)", "valueobject_int32.json"),
                new FileTypeData(FileTypeId.ValueObjectString, "値オブジェクト(文字列)", "valueobject_string.json"),
                new FileTypeData(FileTypeId.Data, "データ", "data.json"),
            };

            return fileTypes;
        }

        /// <summary>
        /// ファイル種別を検索します。
        /// </summary>
        /// <returns>検索したファイル種別データのコレクションを返します。</returns>
        public async Task<IEnumerable<FileTypeData>> QueryAsync()
        {
            return await Task.Run(Query);
        }

        #endregion
    }
}
