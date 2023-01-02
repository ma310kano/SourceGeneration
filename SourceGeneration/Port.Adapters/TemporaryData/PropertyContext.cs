namespace SourceGeneration.Port.Adapters.TemporaryData
{
    /// <summary>
    /// プロパティのコンテキスト
    /// </summary>
    public class PropertyContext
    {
        #region Constructors

        /// <summary>
        /// プロパティのコンテキストを初期化します。
        /// </summary>
        /// <param name="attributes">属性のコレクション</param>
        /// <param name="typeName">型名</param>
        /// <param name="propertyNameEnglish">プロパティ名(英)</param>
        /// <param name="propertyNameJapanese">プロパティ名(日)</param>
        public PropertyContext(
            IReadOnlyCollection<string> attributes,
            string typeName,
            string propertyNameEnglish,
            string propertyNameJapanese)
        {
            Attributes = attributes;
            TypeName = typeName;
            PropertyNameEnglish = propertyNameEnglish;
            PropertyNameJapanese = propertyNameJapanese;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 属性のコレクションを取得します。
        /// </summary>
        public IReadOnlyCollection<string> Attributes { get; }

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

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(DataContextProperty)} {{ {nameof(Attributes)} = {Attributes}, {nameof(TypeName)} = {TypeName}, {nameof(PropertyNameEnglish)} = {PropertyNameEnglish} }}";
        }

        #endregion
    }
}
