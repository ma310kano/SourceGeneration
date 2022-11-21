namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// データのテンプレート
    /// </summary>
    public partial class DataTemplate
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly DataContext _context;

        #endregion

        #region Constructors

        /// <summary>
        /// データのテンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public DataTemplate(DataContext context)
        {
            _context = context;
        }

        #endregion
    }
}
