namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// データのコンテキスト
    /// </summary>
    public class DataContext
    {
        #region Constructors

        /// <summary>
        /// データのコンテキストを初期化します。
        /// </summary>
        /// <param name="namespacePath">名前空間のパス</param>
        /// <param name="classNameEnglish">クラス名(英)</param>
        /// <param name="classNameJapanese">クラス名(日)</param>
        /// <param name="properties">プロパティのコレクション</param>
        public DataContext(
            string namespacePath,
            string classNameEnglish,
            string classNameJapanese,
            IReadOnlyCollection<DataContextProperty> properties)
        {
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
            Properties = properties;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 名前空間のパスを設定または取得します。
        /// </summary>
        public string NamespacePath { get; }

        /// <summary>
        /// クラス名(英)を設定または取得します。
        /// </summary>
        public string ClassNameEnglish { get; }

        /// <summary>
        /// クラス名(日)を設定または取得します。
        /// </summary>
        public string ClassNameJapanese { get; }

        /// <summary>
        /// プロパティのコレクションを設定または取得します。
        /// </summary>
        public IReadOnlyCollection<DataContextProperty> Properties { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(DataContext)} {{ {nameof(NamespacePath)} = {NamespacePath}, {nameof(ClassNameEnglish)} = {ClassNameEnglish}, {nameof(ClassNameJapanese)} = {ClassNameJapanese}, {nameof(Properties)} = {Properties} }}";
        }

        #endregion
    }
}
