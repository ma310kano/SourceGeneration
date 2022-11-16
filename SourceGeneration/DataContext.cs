namespace SourceGeneration
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
            IEnumerable<DataContextProperty> properties)
        {
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
            Properties = properties.ToList();
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
        /// プロパティのコレクションを取得します。
        /// </summary>
        public IReadOnlyCollection<DataContextProperty> Properties { get; }

        #endregion
    }
}
