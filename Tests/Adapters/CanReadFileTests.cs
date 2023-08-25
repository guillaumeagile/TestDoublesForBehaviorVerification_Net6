using System;
using NUnit.Framework;
using src.Core.Adapters;
using Tests.SharedBehaviorTests;

namespace Tests.Adapters;

public class FileSystemReaderTests : CanReadFileTests
{
    [SetUp]
    public void Setup()
    {
        _sut = new IOFileReader();
    }
}