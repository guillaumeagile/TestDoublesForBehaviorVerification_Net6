using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.draft;

public class Exercice
{
   

    [Test]
    public void singleListOfNumbers()
    {
        var expected = MakeSingleListOfNumbers(4);
        expected.Should().Equal(1, 2, 3, 4);
    }

    [Test]
    public void ListOfNumbersShouldMultiply()
    {
        var input = MakeSingleListOfNumbers(4);
        var expected = MultiplyListOfNumbers(input, 4);
        expected.Should().Equal(4, 8, 12, 16);
    }

    [Test]
    public void MakeMultipliedLists()
    {
        var expected = MultipliedLists(2);
        expected.First().Should().Equal(1, 2);
        expected.Last().Should().Equal(2, 4);
    }
    
    public List<int> MakeSingleListOfNumbers(int size)
    {
        return Enumerable.Range(1, size).ToList();
    }

    private List<int> MultiplyListOfNumbers(List<int> input, int size)
    {
        return input.Select(x => x * size).ToList();
    }

    private List<List<int>> MultipliedLists(int size)
    {
        var seed = MakeSingleListOfNumbers(size);
        return seed.Select(number => MultiplyListOfNumbers(seed, number)).ToList();
    }
}