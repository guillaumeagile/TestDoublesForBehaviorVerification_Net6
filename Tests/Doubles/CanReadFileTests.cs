using NUnit.Framework;
using Tests.SharedBehaviorTests;

namespace Tests.Doubles;

public class FileReaderTests : CanReadFileTests
{
    public override int Price
    {
        get => 0;
        set { ; }
    }

    [SetUp]
    public void Setup()
    {
        _sut = new FakeFileReaderWriter();
    }
}