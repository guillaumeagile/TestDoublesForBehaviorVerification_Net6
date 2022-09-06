using NUnit.Framework;
using src.Core.Behaviors;

namespace Tests.SocialBasedTests;

public abstract class CanReadFileTests
{
     protected ICanReadFile _sut;

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