using FluentAssertions;
using FluentAssertions.LanguageExt;
using LanguageExt;
using NUnit.Framework;
using src.Core.Adapters;
using src.ServiceLayer;

namespace Tests.ServiceLayerTests;

public class SomeUseCaseTest
{
    [Test]
    public void Test_()
    {
        var sut = new SomeUseCase();

        sut.GrabTheUsefullData().Should().BeSome();
        sut.GrabTheUsefullData().Should().Be(4);
    }
}