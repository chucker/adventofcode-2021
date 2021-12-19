using NUnit.Framework;

using System.Threading.Tasks;

namespace Day3.Tests;

public class Tests
{
    [Test]
    public async Task Test1()
    {
        var runner = new Parser("test-input.txt");

        var arrays = await runner.ParseIntoBitArrays();

        Assert.That(arrays.Length == 12);
        Assert.That(arrays[0][0] == false);
        Assert.That(arrays[1][0] == true);

        var mostCommonBit_Pos1 = Parser.GetMostCommonBit(arrays, 0);
        Assert.AreEqual(true, mostCommonBit_Pos1);

        var mostCommonBit_Pos2 = Parser.GetMostCommonBit(arrays, 1);
        Assert.AreEqual(false, mostCommonBit_Pos2);

        var leastCommonBit_Pos1 = Parser.GetLeastCommonBit(arrays, 0);
        Assert.AreEqual(false, leastCommonBit_Pos1);

        Assert.AreEqual(22, Parser.GetGamma(arrays));
        Assert.AreEqual(9, Parser.GetEpsilon(arrays));
    }
}
