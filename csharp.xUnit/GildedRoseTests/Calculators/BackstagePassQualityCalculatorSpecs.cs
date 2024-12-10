namespace GildedRoseTests.Calculators;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GildedRoseKata;
using GildedRoseKata.Calculators;
using Shouldly;
using Xunit;

public class BackstagePassQualityCalculatorSpecsData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [1, 14, 21];
        yield return [2, 13, 22];
        yield return [3, 12, 23];
        yield return [4, 11, 24];
        yield return [5, 10, 25];
        yield return [6, 9, 27];
        yield return [7, 8, 29];
        yield return [8, 7, 31];
        yield return [9, 6, 33];
        yield return [10, 5, 35];
        yield return [11, 4, 38];
        yield return [12, 3, 41];
        yield return [13, 2, 44];
        yield return [14, 1, 47];
        yield return [15, 0, 50];
        yield return [16, -1, 0];
        yield return [17, -2, 0];
        yield return [18, -3, 0];
        yield return [19, -4, 0];
        yield return [20, -5, 0];
        yield return [21, -6, 0];
        yield return [22, -7, 0];
        yield return [23, -8, 0];
        yield return [24, -9, 0];
        yield return [25, -10, 0];
        yield return [26, -11, 0];
        yield return [27, -12, 0];
        yield return [28, -13, 0];
        yield return [29, -14, 0];
        yield return [30, -15, 0];
        
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class BackstagePassQualityCalculatorSpecs
{
    [Theory]
    [ClassData(typeof(BackstagePassQualityCalculatorSpecsData))]
    public void ShouldUpdateQuality(int day, int expectedSellIn, int expectedQuality)
    {
        var item = new BackstagePassesToATAFKAL80ETCConcert(15, 20);
        var calculator = new BackstagePassQualityCalculator();

        foreach (var i in Enumerable.Range(1, day))
        {
            calculator.UpdateQuality(item);
        }

        item.SellIn.ShouldBe(expectedSellIn);
        item.Quality.ShouldBe(expectedQuality);
    }
}
