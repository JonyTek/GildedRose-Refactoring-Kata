namespace GildedRoseTests.Calculators;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GildedRoseKata;
using GildedRoseKata.Calculators;
using Shouldly;
using Xunit;

public class ConjuredQualityCalculatorData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [1, 9, 24];
        yield return [2, 8, 22];
        yield return [3, 7, 20];
        yield return [4, 6, 18];
        yield return [5, 5, 16];
        yield return [6, 4, 14];
        yield return [7, 3, 12];
        yield return [8, 2, 10];
        yield return [9, 1, 8];
        yield return [10, 0, 6];
        yield return [11, -1, 2];
        yield return [12, -2, 0];
        yield return [13, -3, 0];
        yield return [14, -4, 0];
        yield return [15, -5, 0];
        yield return [16, -6, 0];
        yield return [17, -7, 0];
        yield return [18, -8, 0];
        yield return [19, -9, 0];
        yield return [20, -10, 0];
        yield return [21, -11, 0];
        yield return [22, -12, 0];
        yield return [23, -13, 0];
        yield return [24, -14, 0];
        yield return [25, -15, 0];
        yield return [26, -16, 0];
        yield return [27, -17, 0];
        yield return [28, -18, 0];
        yield return [29, -19, 0];
        yield return [30, -20, 0];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class ConjuredQualityCalculatorSpecs
{
    [Theory]
    [ClassData(typeof(ConjuredQualityCalculatorData))]
    public void ShouldUpdateQuality(int day, int expectedSellIn, int expectedQuality)
    {
        var item = new ConjuredManaCake(10, 26);
        var calculator = new ConjuredQualityCalculator();

        foreach (var i in Enumerable.Range(1, day))
        {
            calculator.UpdateQuality(item);
        }

        item.SellIn.ShouldBe(expectedSellIn);
        item.Quality.ShouldBe(expectedQuality);
    }
}