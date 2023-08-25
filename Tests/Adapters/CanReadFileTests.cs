using System;
using NUnit.Framework;
using src.Core.Adapters;
using Tests.SharedBehaviorTests;

namespace Tests.Adapters;

public class FileReaderTests : CanReadFileTests
{
    [SetUp]
    public void Setup()
    {
        _sut = new IOFileReader();
    }
}