using System;
using src.Core.Behaviors;

namespace Tests.Doubles;

public class FakeFileReaderWriter : ICanReadFile, ICanWriteFile
{
    //idea for future kata: introduce problem in filePath format (invalid char, for example;
    //but will not act the same if you run on windows or on *Nux" 
    public string ReadAllText(string filePath)
    {
        return    @"{""LargeurCarte"" : 3, ""LongueurCarte"" : 4}";
    }

    public void WriteInFile(string filePath, string content)
    {
        throw new NotImplementedException();
    }
}