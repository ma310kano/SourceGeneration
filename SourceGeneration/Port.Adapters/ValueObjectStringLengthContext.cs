namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(文字列数)のコンテキスト
    /// </summary>
    public class ValueObjectStringLengthContext
    {
        #region Constructors

        /// <summary>
        /// 値オブジェクト(文字列パターン)のコンテキストを初期化します。
        /// </summary>
        /// <param name="namespacePath">名前空間のパス</param>
        /// <param name="classNameEnglish">クラス名(英)</param>
        /// <param name="classNameJapanese">クラス名(日)</param>
        /// <param name="maximumLength">最大文字数</param>
        public ValueObjectStringLengthContext(
            string namespacePath,
            string classNameEnglish,
            string classNameJapanese,
            int maximumLength)
        {
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
            MaximumLength = maximumLength;
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
        /// 最大文字数を取得します。
        /// </summary>
        public int MaximumLength { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(ValueObjectStringPatternContext)} {{ {nameof(NamespacePath)} = {NamespacePath}, {nameof(ClassNameEnglish)} = {ClassNameEnglish}, {nameof(ClassNameJapanese)} = {ClassNameJapanese}, {nameof(MaximumLength)} = {MaximumLength} }}";
        }

        #endregion

    }
}
