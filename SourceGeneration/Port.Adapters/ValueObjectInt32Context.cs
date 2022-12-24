namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(符号付き 32 ビット整数)のコンテキスト
    /// </summary>
    public class ValueObjectInt32Context
    {
        #region Constructors

        /// <summary>
        /// 値オブジェクト(符号付き 32 ビット整数)のコンテキストを初期化します。
        /// </summary>
        /// <param name="namespacePath">名前空間のパス</param>
        /// <param name="classNameEnglish">クラス名(英)</param>
        /// <param name="classNameJapanese">クラス名(日)</param>
        /// <param name="minimumValue">最小値</param>
        /// <param name="maximumValue">最大値</param>
        /// <param name="defaultValue">デフォルト値</param>
        public ValueObjectInt32Context(
            string namespacePath,
            string classNameEnglish,
            string classNameJapanese,
            int minimumValue,
            int maximumValue,
            int defaultValue)
        {
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;
            DefaultValue = defaultValue;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 名前空間のパスを取得します。
        /// </summary>
        public string NamespacePath { get; }

        /// <summary>
        /// クラス名(英)を取得します。
        /// </summary>
        public string ClassNameEnglish { get; }

        /// <summary>
        /// クラス名(日)を取得します。
        /// </summary>
        public string ClassNameJapanese { get; }

        /// <summary>
        /// 最小値を取得します。
        /// </summary>
        public int MinimumValue { get; }

        /// <summary>
        /// 最大値を取得します。
        /// </summary>
        public int MaximumValue { get; }

        /// <summary>
        /// デフォルト値を取得します。
        /// </summary>
        public int DefaultValue { get; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{nameof(ValueObjectInt32Context)} {{ {nameof(NamespacePath)} = {NamespacePath}, {nameof(ClassNameEnglish)} = {ClassNameEnglish}, {nameof(ClassNameJapanese)} = {ClassNameJapanese}, {nameof(MinimumValue)} = {MinimumValue}, {nameof(MaximumValue)} = {MaximumValue}, {nameof(DefaultValue)} = {DefaultValue} }}";
        }

        #endregion
    }
}
