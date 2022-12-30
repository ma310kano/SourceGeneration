﻿namespace SourceGeneration.Port.Adapters
{
    /// <summary>
    /// エンティティのコンテキスト
    /// </summary>
    public class EntityContext
    {
        #region Constructors

        /// <summary>
        /// エンティティのコンテキストを初期化します。
        /// </summary>
        /// <param name="namespacePath">名前空間のパス</param>
        /// <param name="classNameEnglish">クラス名(英)</param>
        /// <param name="classNameJapanese">クラス名(日)</param>
        /// <param name="properties">プロパティのコレクション</param>
        public EntityContext(
            string namespacePath,
            string classNameEnglish,
            string classNameJapanese,
            IReadOnlyCollection<EntityContextProperty> properties)
        {
            NamespacePath = namespacePath;
            ClassNameEnglish = classNameEnglish;
            ClassNameJapanese = classNameJapanese;
            Properties = properties;
        }

        #endregion

        #region Properties

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
        public IReadOnlyCollection<EntityContextProperty> Properties { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return $"{nameof(EntityContext)} {{ {nameof(NamespacePath)} = {NamespacePath}, {nameof(ClassNameEnglish)} = {ClassNameEnglish}, {nameof(ClassNameJapanese)} = {ClassNameJapanese}, {nameof(Properties)} = {Properties} }}";
        }

        #endregion
    }
}