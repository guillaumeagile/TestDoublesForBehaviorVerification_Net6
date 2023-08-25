using NUnit.Framework;
using Tests.SharedBehaviorTests;

namespace Tests.zDoublesThatWeAreNotGoingToUse;

public class FakeFileReaderTests : CanReadFileTests
{

    [SetUp]
    public void Setup()
    {
        _sut = new FakeFileReaderWriter();
    }
}