using NUnit.Framework;
using Tests.SharedBehaviorTests;

namespace Tests.Doubles;

public class FileReaderTests : CanReadFileTests
{

    [SetUp]
    public void Setup()
    {
        _sut = new FakeFileReaderWriter();
    }
}