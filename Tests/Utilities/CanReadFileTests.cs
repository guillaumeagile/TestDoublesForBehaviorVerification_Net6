using NUnit.Framework;
using src.Core.Utilities;
using Tests.SocialBasedTests;

namespace Tests.Utilities;

public class FileReaderTests : CanReadFileTests
{
    [SetUp]
    public void Setup()
    {
        _sut = new IOFileReader();
    }
}