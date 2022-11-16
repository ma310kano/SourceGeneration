using SourceGeneration;
using System.Text.Json;

DataContext context;
{
    string jsonString = File.ReadAllText(args[0]);
    DataContext? nullableContext = JsonSerializer.Deserialize<DataContext>(jsonString);
    if (nullableContext is null) throw new InvalidOperationException("無効な JSON ファイルです。");
    context = nullableContext;
}

string filePath;
{
    filePath = context.ClassNameEnglish + ".cs";
}

string contents;
{
    DataTemplate template = new(context);
    contents = template.TransformText();
}

File.WriteAllText(filePath, contents);
