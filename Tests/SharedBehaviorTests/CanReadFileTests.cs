using NUnit.Framework;
using src.Core.Behaviors;

namespace Tests.SharedBehaviorTests;

public abstract class CanReadFileTests
{
    protected ICanReadFile _sut;
    
    [Test]
    public void FileIsProperlyRead()
    {
        var actual = _sut.ReadAllText("map.json");
        var expected = @"{""theUselessData"" : 3, ""theUsefullData"" : 4}";
        Assert.AreEqual(expected, actual);
    }
}