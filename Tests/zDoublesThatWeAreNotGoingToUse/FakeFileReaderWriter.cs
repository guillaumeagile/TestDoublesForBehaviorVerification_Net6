using System;
using src.Core.Behaviors;

namespace Tests.zDoublesThatWeAreNotGoingToUse;

public class FakeFileReaderWriter : ICanReadFile, ICanWriteFile
{
    //idea for future kata: introduce problem in filePath format (invalid char, for example;
    //but will not act the same if you run on windows or on Linux" 
    public string ReadAllText(string filePath)
    {
        return  @"{""theUselessData"" : 3, ""theUsefullData"" : 4}";
    }

    public void WriteInFile(string filePath, string content)
    {
        throw new NotImplementedException();
    }
}