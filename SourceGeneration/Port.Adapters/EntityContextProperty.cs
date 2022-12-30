namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// エンティティのコンテキストのプロパティ
    /// </summary>
    public class EntityContextProperty
    {
        #region Constructors

        /// <summary>
        /// エンティティのコンテキストのプロパティ
        /// </summary>
        /// <param name="typeName">型名</param>
        /// <param name="propertyNameEnglish">プロパティ名(英)</param>
        /// <param name="propertyNameJapanese">プロパティ名(日)</param>
        /// <param name="isPrimaryKey">主キーかどうか</param>
        public EntityContextProperty(
            string typeName,
            string propertyNameEnglish,
            string propertyNameJapanese,
            bool isPrimaryKey)
        {
            TypeName = typeName;
            PropertyNameEnglish = propertyNameEnglish;
            PropertyNameJapanese = propertyNameJapanese;
            IsPrimaryKey = isPrimaryKey;
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
        /// 主キーかどうかを取得します。
        /// </summary>
        public bool IsPrimaryKey { get; }

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
            return $"{nameof(EntityContextProperty)} {{ {nameof(TypeName)} = {TypeName}, {nameof(PropertyNameEnglish)} = {PropertyNameEnglish}, {nameof(PropertyNameJapanese)} = {PropertyNameJapanese}, {nameof(IsPrimaryKey)} = {IsPrimaryKey} }}";
        }

        #endregion
    }
}
