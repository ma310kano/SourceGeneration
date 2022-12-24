namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(UUID)のコンテキスト
    /// </summary>
    public class ValueObjectUuidContext
    {
        #region Constructors

        /// <summary>
        /// 値オブジェクト(UUID)のコンテキストを初期化します。
        /// </summary>
        /// <param name="namespacePath">名前空間のパス</param>
        /// <param name="classNameEnglish">クラス名(英)</param>
        /// <param name="classNameJapanese">クラス名(日)</param>
        public ValueObjectUuidContext(
            string namespacePath,
            string classNameEnglish,
            string classNameJapanese)
        {
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
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

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(ValueObjectUuidContext)} {{ {nameof(NamespacePath)} = {NamespacePath}, {nameof(ClassNameEnglish)} = {ClassNameEnglish}, {nameof(ClassNameJapanese)} = {ClassNameJapanese} }}";
        }

        #endregion
    }
}
