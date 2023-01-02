﻿namespace SourceGeneration.Port.Adapters.TemporaryData
{
    /// <summary>
    /// コンテキスト
    /// </summary>
    public class Context
    {
        #region Constructors

        /// <summary>
        /// コンテキストを初期化します。
        /// </summary>
        /// <param name="usings">using ディレクティブのコレクション</param>
        /// <param name="namespacePath">名前空間のパス</param>
        /// <param name="classNameEnglish">クラス名(英)</param>
        /// <param name="classNameJapanese">クラス名(日)</param>
        /// <param name="properties">プロパティのコレクション</param>
        public Context(
            IReadOnlyCollection<string> usings,
            string namespacePath,
            string classNameEnglish,
            string classNameJapanese,
            IReadOnlyCollection<PropertyContext> properties)
        {
            Usings = usings;
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
            Properties = properties;
        }

        #endregion

        #region Properties

        /// <summary>
        /// using ディレクティブのコレクションを取得します。
        /// </summary>
        public IReadOnlyCollection<string> Usings { get; }

        /// <summary>
        /// 名前空間のパスを取得します。
        /// </summary>
        public string NamespacePath { get; }

        /// <summary>
        /// クラス名(英)を取得します。
        /// </summary>
        public string ClassNameEnglish { get; }

        /// <summary>
        /// クラス名(日)を取得します。
        /// </summary>
        public string ClassNameJapanese { get; }

        /// <summary>
        /// プロパティのコレクションを取得します。
        /// </summary>
        public IReadOnlyCollection<PropertyContext> Properties { get; }

        #endregion
    }
}
