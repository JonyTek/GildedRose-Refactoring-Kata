namespace GildedRoseKata;

public class ElixirOfTheMongoose : Item
{
    public ElixirOfTheMongoose(int sellIn, int quality)
    {
        Name = "Elixir of the Mongoose";
        SellIn = sellIn;
        Quality = quality;
    }
}