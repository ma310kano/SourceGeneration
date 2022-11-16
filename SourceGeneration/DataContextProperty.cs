namespace SourceGeneration
{
    /// <summary>
    /// データのコンテキストのプロパティ
    /// </summary>
    public class DataContextProperty
    {
        #region Properties

        /// <summary>
        /// 型名を取得します。
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// プロパティ名(英)を取得します。
        /// </summary>
        public string PropertyNameEnglish { get; set;  }

        /// <summary>
        /// プロパティ名(日)を取得します。
        /// </summary>
        public string PropertyNameJapanese { get; set; }

        /// <summary>
        /// コンストラクターの引数名を取得します。
        /// </summary>
        public string ConstructorParameterName => PropertyNameEnglish[0..1].ToLower() + PropertyNameEnglish[1..];

        #endregion
    }
}
