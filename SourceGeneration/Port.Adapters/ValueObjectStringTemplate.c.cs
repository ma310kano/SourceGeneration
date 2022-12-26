namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(文字列)のテンプレート
    /// </summary>
    public partial class ValueObjectStringTemplate
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly ValueObjectStringContext _context;

        #endregion

        #region Constructors

        /// <summary>
        /// 値オブジェクト(文字列)のテンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public ValueObjectStringTemplate(ValueObjectStringContext context)
        {
            _context = context;
        }

        #endregion
    }
}
