using NUnit.Framework;
using src.Core.Behaviors;
using src.Core.Utilities;

namespace Tests;

public class CanReadFileTests
{
    private ICanReadFile _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new IOFileReader();
    }

    [Test]
    public void FileIsProperlyRead()
    {
        var actual = _sut.ReadAllText("map.json");
        Assert.AreEqual(@"{
    ""LargeurCarte"" : 3,
    ""LongueurCarte"" : 4
}", actual);
    }
}