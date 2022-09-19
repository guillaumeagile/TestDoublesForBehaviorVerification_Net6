using NUnit.Framework;
using src.Core.Adapters;
using Tests.SocialBasedTests;

namespace Tests.Adapters;

public class FileReaderTests : CanReadFileTests
{
    [SetUp]
    public void Setup()
    {
        _sut = new IOFileReader();
    }
}