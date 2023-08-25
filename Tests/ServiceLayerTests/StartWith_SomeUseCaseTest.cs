using FluentAssertions;
using FluentAssertions.LanguageExt;
using LanguageExt;
using NUnit.Framework;
using src.Core.Adapters;
using src.ServiceLayer;

namespace Tests.ServiceLayerTests;

public class StartWith_SomeUseCaseTest
{
    [Test]
    public void YourFirstTest_()
    {
        var sut = new SomeUseCase();

        sut.GrabTheUsefullData().Should().BeSome();
        sut.GrabTheUsefullData().Should().Be(4);
        //just to be sure we are ready to *prove* things
    }
    
    [Test]
    public void Your2ndTest_YouWantTheValueToBeTakenFromAnExternalSystem()
    {
        // what do you want to do?
        // inject the external system as a dependency?
        // mock it or fake it.
        var sut = new SomeUseCase();

        sut.GrabTheUsefullData().Should().BeSome();
        sut.GrabTheUsefullData().Should().Be(4);
    }
}