namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// 値オブジェクト(符号付き 32 ビット整数)のテンプレート
    /// </summary>
    public partial class ValueObjectInt32Template
    {
        #region Fields

        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly ValueObjectInt32Context _context;

        #endregion

        #region Constructors

        /// <summary>
        /// 値オブジェクト(符号付き 32 ビット整数)のテンプレートを初期化します。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public ValueObjectInt32Template(ValueObjectInt32Context context)
        {
            _context = context;
        }

        #endregion
    }
}
