using NUnit.Framework;
using src.Core.Adapters;
using Tests.SocialBasedTests;

namespace Tests.Adapters;

public class FileReaderTests : CanReadFileTests
{
    public override int Price { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    [SetUp]
    public void Setup()
    {
        _sut = new IOFileReader();
    }
}