using System.IO;
using src.Core.Behaviors;

namespace src.Core.Adapters;

public class IOFileReader : ICanReadFile
{
    public string ReadAllText(string filePath)
    {
        return File.ReadAllText(filePath);
    }
}