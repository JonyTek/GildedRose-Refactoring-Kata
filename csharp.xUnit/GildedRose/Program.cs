using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var items = new List<Item>
        {
            new DexterityVest(10, 20),
            new AgedBrie(2, 0),
            new ElixirOfTheMongoose(5, 7),
            new SulfurasHandOfRagnaros(0),
            new SulfurasHandOfRagnaros(-1),
            new BackstagePassesToATAFKAL80ETCConcert(15, 20),
            new BackstagePassesToATAFKAL80ETCConcert(10, 49),
            new BackstagePassesToATAFKAL80ETCConcert(5, 49),
            new ConjuredManaCake(3, 6),
        };

        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }

            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}
