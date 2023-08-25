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

        sut.KnowTheLargeurCarte().Should().BeSome();
        sut.KnowTheLargeurCarte().Should().Be(4);
    }
}