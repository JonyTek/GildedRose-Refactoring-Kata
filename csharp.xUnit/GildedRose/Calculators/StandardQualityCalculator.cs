namespace GildedRoseKata.Calculators;

using System;

public class StandardQualityCalculator : IQualityCalculator
{
    public void UpdateQuality(Item item)
    {
        item.SellIn -= 1;
        var reduceQualityBy = item.SellIn < 0 ? 2 : 1;
        item.Quality = Math.Max(0, item.Quality == 0 ? 0 : item.Quality - reduceQualityBy);
    }
}