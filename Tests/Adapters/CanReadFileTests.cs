using System;
using NUnit.Framework;
using src.Core.Adapters;
using Tests.SharedBehaviorTests;

namespace Tests.Adapters;

public class FileReaderTests : CanReadFileTests
{
    public override int Price
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    [SetUp]
    public void Setup()
    {
        _sut = new IOFileReader();
    }
}