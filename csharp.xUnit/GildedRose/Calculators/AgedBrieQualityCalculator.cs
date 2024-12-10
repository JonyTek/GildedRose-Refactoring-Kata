namespace GildedRoseKata.Calculators;

using System;

public class AgedBrieQualityCalculator : IQualityCalculator
{
    public void UpdateQuality(Item item)
    {
        item.SellIn -= 1;
        var increaseQualityBy = item.SellIn < 0 ? 2 : 1;
        item.Quality = Math.Min(50, item.Quality + increaseQualityBy);
    }
}