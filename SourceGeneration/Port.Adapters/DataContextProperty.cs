namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// データのコンテキストのプロパティ
    /// </summary>
    public class DataContextProperty
    {
        #region Constructors

        /// <summary>
        /// データのコンテキストのプロパティを初期化します。
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
        public string ConstructorParameterName => PropertyNameEnglish[0..1].ToLower() + PropertyNameEnglish[1..];

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(DataContextProperty)} {{ {nameof(TypeName)} = {TypeName}, {nameof(PropertyNameEnglish)} = {PropertyNameEnglish}, {nameof(PropertyNameJapanese)} = {PropertyNameJapanese} }}";
        }

        #endregion
    }
}
