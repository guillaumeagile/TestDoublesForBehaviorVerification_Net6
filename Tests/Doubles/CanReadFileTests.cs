using NUnit.Framework;
using Tests.SocialBasedTests;

namespace Tests.Doubles;

public class FileReaderTests : CanReadFileTests
{

    public override int Price
    {
        get { return 0; }
        set {  ; }
    }

    [SetUp]
    public void Setup()
    {
        _sut = new FakeFileReaderWriter();
    }
}