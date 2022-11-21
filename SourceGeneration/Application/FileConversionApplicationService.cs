﻿using SourceGeneration.Application.Command;
using SourceGeneration.Port.Adapters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SourceGeneration.Application
{
    /// <summary>
    /// ファイルを変換するアプリケーションサービス
    /// </summary>
    public class FileConversionApplicationService : IFileConversionApplicationService
    {
        #region Methods

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        public void ConvertFile(SingleFileConversionCommand command)
        {
            ConvertFile(command.SourceFilePath, command.DestinationDirectoryPath);
        }

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>非同期処理を返します。</returns>
        public async Task ConvertFileAsync(SingleFileConversionCommand command)
        {
            await Task.Run(() => ConvertFile(command));
        }

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        public void ConvertFile(MultipleFileConversionCommand command)
        {
            DirectoryInfo sourceDirectory = new(command.SourceDirectoryPath);
            if (!sourceDirectory.Exists) throw new DirectoryNotFoundException();

            FileInfo[] files = sourceDirectory.GetFiles("*.json");
            foreach (FileInfo file in files)
            {
                ConvertFile(file.FullName, command.DestinationDirectoryPath);
            }
        }

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>非同期処理を返します。</returns>
        public async Task ConvertFileAsync(MultipleFileConversionCommand command)
        {
            await Task.Run(() => ConvertFile(command));
        }

        #region Non-Public methods

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="sourceFilePath">変換元のファイルパス</param>
        /// <param name="destinationDirectoryPath">変換先のディレクトリーパス</param>
        /// <exception cref="InvalidOperationException"></exception>
        private void ConvertFile(string sourceFilePath, string destinationDirectoryPath)
        {
            string json = File.ReadAllText(sourceFilePath);

            FileTypeContext context;
            {
                JsonSerializerOptions options = new()
                {
                    Converters =
                    {
                        new JsonStringEnumConverter()
                    }
                };

                FileTypeContext? rawContext = JsonSerializer.Deserialize<FileTypeContext>(json, options);
                if (rawContext is null) throw new InvalidOperationException();

                context = rawContext;
            }

            switch (context.FileType)
            {
                case FileTypeId.ValueObjectUuid:
                    ConvertValueObjectUuidFile(json, destinationDirectoryPath);
                    break;
                case FileTypeId.Data:
                    ConvertDataFile(json, destinationDirectoryPath);
                    break;
                default:
                    throw new InvalidOperationException("ファイル種別の定義がありません。");
            }
        }

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="json">JSON文字列</param>
        /// <param name="destinationDirectoryPath">変換先のディレクトリーパス</param>
        private static void ConvertValueObjectUuidFile(string json, string destinationDirectoryPath)
        {
            ValueObjectUuidContext context;
            {
                ValueObjectUuidContext? nullableContext = JsonSerializer.Deserialize<ValueObjectUuidContext>(json);
                if (nullableContext is null) throw new InvalidOperationException("無効な JSON ファイルです。");

                context = nullableContext;
            }

            string filePath;
            {
                string fileName = context.ClassNameEnglish + ".cs";
                filePath = Path.Combine(destinationDirectoryPath, fileName);
            }

            string contents;
            {
                ValueObjectUuidTemplate template = new(context);
                contents = template.TransformText();
            }

            File.WriteAllText(filePath, contents);
        }

        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="json">JSON文字列</param>
        /// <param name="destinationDirectoryPath">変換先のディレクトリーパス</param>
        private static void ConvertDataFile(string json, string destinationDirectoryPath)
        {
            DataContext context;
            {
                DataContext? nullableContext = JsonSerializer.Deserialize<DataContext>(json);
                if (nullableContext is null) throw new InvalidOperationException("無効な JSON ファイルです。");

                context = nullableContext;
            }

            string filePath;
            {
                string fileName = context.ClassNameEnglish + ".cs";
                filePath = Path.Combine(destinationDirectoryPath, fileName);
            }

            string contents;
            {
                DataTemplate template = new(context);
                contents = template.TransformText();
            }

            File.WriteAllText(filePath, contents);
        }

        #endregion

        #endregion
    }
}