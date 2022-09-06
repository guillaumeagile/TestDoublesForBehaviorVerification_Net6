using src;
using src.Core.Behaviors;
using System.IO;  
namespace src.Core.Utilities
{
    public class IOFileReader : ICanReadFile
    {
        public string ReadAllText(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}