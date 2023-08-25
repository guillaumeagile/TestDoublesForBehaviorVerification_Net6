using System;
using src.Core.Behaviors;

namespace Tests.Doubles;

public class FakeFileReaderWriter : ICanReadFile, ICanWriteFile
{
    public string ReadAllText(string filePath)
    {
        return    @"{""LargeurCarte"" : 3, ""LongueurCarte"" : 4}";
    }

    public void WriteInFile(string filePath, string content)
    {
        throw new NotImplementedException();
    }
}