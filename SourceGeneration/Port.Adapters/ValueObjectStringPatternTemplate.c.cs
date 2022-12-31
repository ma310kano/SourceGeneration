namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(文字列パターン)のテンプレート
    /// </summary>
    public partial class ValueObjectStringPatternTemplate
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly ValueObjectStringPatternContext _context;

        #endregion

        #region Constructors

        /// <summary>
        /// 値オブジェクト(文字列)のテンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public ValueObjectStringPatternTemplate(ValueObjectStringPatternContext context)
        {
            _context = context;
        }

        #endregion
    }
}
