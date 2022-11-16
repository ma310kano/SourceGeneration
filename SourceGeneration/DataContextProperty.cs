namespace SourceGeneration
{
    /// <summary>
    /// データのコンテキストのプロパティ
    /// </summary>
    public class DataContextProperty
    {
        #region Constructors

        /// <summary>
        /// データのプロパティのコンテキスト
        /// </summary>
        /// <param name="typeName">型名</param>
        /// <param name="propertyNameEnglish">プロパティ名(英)</param>
        /// <param name="propertyNameJapanese">プロパティ名(日)</param>
        public DataContextProperty(
            string typeName,
            string propertyNameEnglish,
            string propertyNameJapanese)
        {
            TypeName = typeName;
            PropertyNameEnglish = propertyNameEnglish;
            PropertyNameJapanese = propertyNameJapanese;
            ConstructorParameterName = propertyNameEnglish[0..1].ToLower() + propertyNameEnglish[1..];
        }

        #endregion

        #region Properties

        /// <summary>
        /// 型名を取得します。
        /// </summary>
        public string TypeName { get; }

        /// <summary>
        /// プロパティ名(英)を取得します。
        /// </summary>
        public string PropertyNameEnglish { get; }

        /// <summary>
        /// プロパティ名(日)を取得します。
        /// </summary>
        public string PropertyNameJapanese { get; }

        /// <summary>
        /// コンストラクターの引数名を取得します。
        /// </summary>
        public string ConstructorParameterName { get; }

        #endregion
    }
}
