namespace SourceGeneration
{
    /// <summary>
    /// ファイルの種別
    /// </summary>
    public enum FileTypeId
    {
        /// <summary>
        /// 値オブジェクト(UUID)
        /// </summary>
        ValueObjectUuid = 1,

        /// <summary>
        /// 値オブジェクト(符号付き 32 ビット整数)
        /// </summary>
        ValueObjectInt32,

        /// <summary>
        /// 値オブジェクト(文字列 - 文字列数)
        /// </summary>
        ValueObjectStringLength,

        /// <summary>
        /// 値オブジェクト(文字列 - パターン)
        /// </summary>
        ValueObjectStringPattern,

        /// <summary>
        /// エンティティ
        /// </summary>
        Entity,

        /// <summary>
        /// データ
        /// </summary>
        Data,

        /// <summary>
        /// 一時データ
        /// </summary>
        TemporaryData,
    }
}
