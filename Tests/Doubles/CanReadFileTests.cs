using NUnit.Framework;
using Tests.SocialBasedTests;

namespace Tests.Doubles;

public class FileReaderTests : CanReadFileTests
{
    [SetUp]
    public void Setup()
    {
        _sut = new FakeFileReaderWriter();
    }
}