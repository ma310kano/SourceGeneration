namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(文字列数)のテンプレート
    /// </summary>
    public partial class ValueObjectStringLengthTemplate
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly ValueObjectStringLengthContext _context;

        #endregion

        #region Constructors

        /// <summary>
        /// 値オブジェクト(文字列数)のテンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public ValueObjectStringLengthTemplate(ValueObjectStringLengthContext context)
        {
            _context = context;
        }

        #endregion
    }
}
