namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// エンティティのテンプレート
    /// </summary>
    public partial class EntityTemplate
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly EntityContext _context;

        #endregion

        #region Constructors

        /// <summary>
        /// エンティティのテンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public EntityTemplate(EntityContext context)
        {
            _context = context;
        }

        #endregion
    }
}
