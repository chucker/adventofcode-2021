using NUnit.Framework;

using System;
using System.Threading.Tasks;

namespace Day2.Tests;

public class Tests
{
    [Test]
    public async Task Test1()
    {
        var runner = new Runner("test-input.txt");

        var initialState = new State(0, 0);

        var result = await runner.GetResultAsync(initialState);

        Assert.AreEqual(15, result.Horizontal);
        Assert.AreEqual(10, result.Depth);

        Console.WriteLine(result.Depth * result.Horizontal);
        throw new Exception();
    }
}
