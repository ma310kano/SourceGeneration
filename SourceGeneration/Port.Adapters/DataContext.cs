namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// データのコンテキスト
    /// </summary>
    public class DataContext
    {
        #region Properties

        /// <summary>
        /// 名前空間のパスを設定または取得します。
        /// </summary>
        public string NamespacePath { get; set; }

        /// <summary>
        /// クラス名(英)を設定または取得します。
        /// </summary>
        public string ClassNameEnglish { get; set; }

        /// <summary>
        /// クラス名(日)を設定または取得します。
        /// </summary>
        public string ClassNameJapanese { get; set; }

        /// <summary>
        /// プロパティのコレクションを設定または取得します。
        /// </summary>
        public ICollection<DataContextProperty> Properties { get; set; }

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
