namespace SourceGeneration
{
    /// <summary>
    /// 値オブジェクト(UUID)のテンプレート
    /// </summary>
    public partial class ValueObjectUuidTemplate
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly ValueObjectUuidContext _context;

        #endregion

        #region Constructors

        /// <summary>
        /// 値オブジェクト(UUID)のテンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public ValueObjectUuidTemplate(ValueObjectUuidContext context)
        {
            _context = context;
        }

        #endregion
    }
}
