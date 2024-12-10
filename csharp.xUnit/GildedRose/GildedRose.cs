using System.Collections.Generic;

namespace GildedRoseKata;

using Calculators;

public class GildedRose(IList<Item> items)
{
    public void UpdateQuality()
    {
        foreach (var item in items)
        {
            IQualityCalculator calculator = item switch
            {
                AgedBrie => new AgedBrieQualityCalculator(),
                SulfurasHandOfRagnaros => new LegendaryQualityCalculator(),
                BackstagePassesToATAFKAL80ETCConcert => new BackstagePassQualityCalculator(),
                ConjuredManaCake => new ConjuredQualityCalculator(),
                _ => new StandardQualityCalculator(),
            };
            
            calculator.UpdateQuality(item);
        }
    }
}
