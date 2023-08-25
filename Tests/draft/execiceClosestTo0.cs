using System;
using System.Collections.Generic;
using System.Linq;
using Castle.Core.Configuration;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.draft;
//https://www.codingame.com/ide/puzzle/temperatures
public class ExerciceClosestTo0
{
    [Test]
    public void ZeroIs0()
    {
        var actual = CloseTo0(new List<int> { 0 });
        actual.Should().Be(0);
    }


    [Test]
    public void Simple()
    {
        var actual = CloseTo0(new List<int> { 1, -2, -8, 4, 5 });
        actual.Should().Be(1);
    }
    
    [Test]
    public void Simple_0()
    {
        var actual = CloseTo0_classic(new List<int> { 0 });
        actual.Should().Be(0);
    }
    
    [Test]
    public void Simple_empty()
    {
        var actual = CloseTo0_classic(new List<int> {  });
        actual.Should().Be(0);
    }


    
[Test]
    public void Negative()
    {
        var actual = CloseTo0_classic(new List<int> { -12, -5, 5 });
        actual.Should().Be(5);
    }
    private int CloseTo0(List<int> list) =>
        list.MinBy(e =>
            {
                return e switch
                {
                    < 0 => -e,
                    _ => e
                };
            }
        );


    private int CloseTo0_classic(List<int> list)
    {
        if (!list.Any())
            list.Add(0);
        return list.OrderByDescending(e => e).MinBy(Math.Abs);
       // return list.OrderByDescending(e=>e).FirstOrDefault()..MinBy(Math.Abs);
    }
}