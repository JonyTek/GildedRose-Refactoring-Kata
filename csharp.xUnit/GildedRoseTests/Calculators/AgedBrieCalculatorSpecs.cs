namespace GildedRoseTests.Calculators;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GildedRoseKata;
using GildedRoseKata.Calculators;
using Shouldly;
using Xunit;

public class AgedBrieCalculatorSpecsData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [1, 1, 1];
        yield return [2, 0, 2];
        yield return [3, -1, 4];
        yield return [4, -2, 6];
        yield return [5, -3, 8];
        yield return [6, -4, 10];
        yield return [7, -5, 12];
        yield return [8, -6, 14];
        yield return [9, -7, 16];
        yield return [10, -8, 18];
        yield return [11, -9, 20];
        yield return [12, -10, 22];
        yield return [13, -11, 24];
        yield return [14, -12, 26];
        yield return [15, -13, 28];
        yield return [16, -14, 30];
        yield return [17, -15, 32];
        yield return [18, -16, 34];
        yield return [19, -17, 36];
        yield return [20, -18, 38];
        yield return [21, -19, 40];
        yield return [22, -20, 42];
        yield return [23, -21, 44];
        yield return [24, -22, 46];
        yield return [25, -23, 48];
        yield return [26, -24, 50];
        yield return [27, -25, 50];
        yield return [28, -26, 50];
        yield return [29, -27, 50];
        yield return [30, -28, 50];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class AgedBrieCalculatorSpecs
{
    [Theory]
    [ClassData(typeof(AgedBrieCalculatorSpecsData))]
    public void ShouldUpdateQuality(int day, int expectedSellIn, int expectedQuality)
    {
        var item = new AgedBrie(2, 0);
        var calculator = new AgedBrieQualityCalculator();

        foreach (var i in Enumerable.Range(1, day))
        {
            calculator.UpdateQuality(item);
        }

        item.SellIn.ShouldBe(expectedSellIn);
        item.Quality.ShouldBe(expectedQuality);
    }
}
