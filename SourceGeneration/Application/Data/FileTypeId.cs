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
        /// 値オブジェクト(文字列)
        /// </summary>
        ValueObjectString,

        /// <summary>
        /// エンティティ
        /// </summary>
        Entity,

        /// <summary>
        /// データ
        /// </summary>
        Data,
    }
}
