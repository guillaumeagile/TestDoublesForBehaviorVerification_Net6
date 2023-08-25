namespace src.Core.Behaviors;

public interface ICanWriteFile
{
    void WriteInFile(string filePath, string content);
}