using SourceGeneration.Application.Command;
using System.Reflection;

namespace SourceGeneration.Application
{
    /// <summary>
    /// ファイルを作成するアプリケーションサービス
    /// </summary>
    public class FileCreationApplicationService : IFileCreationApplicationService
    {
        #region Methods

        /// <summary>
        /// ファイルを作成します。
        /// </summary>
        /// <param name="command">コマンド</param>
        public void Create(FileCreationCommand command)
        {
            string fileName = command.FileTypeId switch
            {
                FileTypeId.ValueObjectUuid => "valueobject_uuid.json",
                FileTypeId.ValueObjectInt32 => "valueobject_int32.json",
                FileTypeId.ValueObjectString => "valueobject_string.json",
                FileTypeId.Entity => "entity.json",
                FileTypeId.Data => "data.json",
                _ => throw new InvalidOperationException("ファイル種別が定義されていません。"),
            };

            string? executingDirPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (executingDirPath is null) throw new InvalidOperationException("実行中のアセンブリが取得できません。");

            string filePath = Path.Combine(executingDirPath, "templates", fileName);

            File.Copy(filePath, command.DestinationFilePath, overwrite: true);
        }

        /// <summary>
        /// ファイルを作成します。
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>非同期処理を返します。</returns>
        public async Task CreateAsync(FileCreationCommand command)
        {
            await Task.Run(() => Create(command));
        }

        #endregion
    }
}
