namespace GildedRoseKata.Calculators;

using System;

public class ConjuredQualityCalculator : IQualityCalculator
{
    public void UpdateQuality(Item item)
    {
        item.SellIn -= 1;
        var reduceQualityBy = item.SellIn < 0 ? 4 : 2;
        item.Quality =  Math.Max(0, item.Quality - reduceQualityBy);
    }
}