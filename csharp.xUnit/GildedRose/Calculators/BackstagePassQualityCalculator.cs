namespace GildedRoseKata.Calculators;

using System;

public class BackstagePassQualityCalculator : IQualityCalculator
{
    public void UpdateQuality(Item item)
    {
        item.SellIn -= 1;
        item.Quality = Math.Min(50, item.SellIn < 0
            ? 0
            : item.Quality + item.SellIn switch
            {
                < 0 => -item.Quality,
                < 5 => 3,
                < 10 => 2,
                _ => 1
            });
    }
}