namespace SourceGeneration.Port.Adapters.TemporaryData
{
    /// <summary>
    /// テンプレート
    /// </summary>
    public partial class Template
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly Context _context;

        #endregion

        #region Constructors

        /// <summary>
        /// テンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public Template(Context context)
        {
            _context = context;
        }

        #endregion
    }
}
