namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(文字列)のコンテキスト
    /// </summary>
    public class ValueObjectStringContext
    {
        #region Constructors

        /// <summary>
        /// 値オブジェクト(文字列)のコンテキストを初期化します。
        /// </summary>
        /// <param name="namespacePath">名前空間のパス</param>
        /// <param name="classNameEnglish">クラス名(英)</param>
        /// <param name="classNameJapanese">クラス名(日)</param>
        /// <param name="pattern">パターン</param>
        /// <param name="patternDescription">パターンの説明</param>
        public ValueObjectStringContext(
            string namespacePath,
            string classNameEnglish,
            string classNameJapanese,
            string pattern,
            string patternDescription)
        {
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
            Pattern = pattern;
            PatternDescription = patternDescription;
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
        /// パターンを取得します。
        /// </summary>
        public string Pattern { get; }

        /// <summary>
        /// パターンの説明を取得します。
        /// </summary>
        public string PatternDescription { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(ValueObjectStringContext)} {{ {nameof(NamespacePath)} = {NamespacePath}, {nameof(ClassNameEnglish)} = {ClassNameEnglish}, {nameof(ClassNameJapanese)} = {ClassNameJapanese}, {nameof(Pattern)} = {Pattern}, {nameof(PatternDescription)} = {PatternDescription} }}";
        }

        #endregion
    }
}
