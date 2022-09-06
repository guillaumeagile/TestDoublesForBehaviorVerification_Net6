using System.IO;
using src.Core.Behaviors;

namespace Tests.Doubles;

public class FakeFileReader : ICanReadFile
{
    public string ReadAllText(string filePath)
    {
        return @"{
    ""LargeurCarte"" : 3,
    ""LongueurCarte"" : 4
}";
    }
}