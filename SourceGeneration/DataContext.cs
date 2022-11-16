namespace SourceGeneration
{
    /// <summary>
    /// データのコンテキスト
    /// </summary>
    public class DataContext
    {
        #region Properties

        /// <summary>
        /// 名前空間のパスを取得します。
        /// </summary>
        public string NamespacePath { get; set; }

        /// <summary>
        /// クラス名(英)を取得します。
        /// </summary>
        public string ClassNameEnglish { get; set; }

        /// <summary>
        /// クラス名(日)を取得します。
        /// </summary>
        public string ClassNameJapanese { get; set; }

        /// <summary>
        /// プロパティのコレクションを取得します。
        /// </summary>
        public ICollection<DataContextProperty> Properties { get; set; }

        #endregion
    }
}
