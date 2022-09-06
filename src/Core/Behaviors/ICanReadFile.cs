namespace src.Core.Behaviors
{
    public interface ICanReadFile
    {
        string ReadAllText(string filePath);
    }
}