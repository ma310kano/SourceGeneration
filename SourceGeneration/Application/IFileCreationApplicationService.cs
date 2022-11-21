using SourceGeneration.Application.Command;

namespace SourceGeneration.Application
{
    /// <summary>
    /// ファイルを作成するアプリケーションサービス
    /// </summary>
    public interface IFileCreationApplicationService
    {
        #region Methods

        /// <summary>
        /// ファイルを作成します。
        /// </summary>
        /// <param name="command">コマンド</param>
        void Create(FileCreationCommand command);

        /// <summary>
        /// ファイルを作成します。
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>非同期処理を返します。</returns>
        Task CreateAsync(FileCreationCommand command);

        #endregion
    }
}
