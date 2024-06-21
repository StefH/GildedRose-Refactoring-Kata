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
            new StandardItem("+5 Dexterity Vest", 10, 20),
            new AgedBrieItem(2, 0),
            new StandardItem("Elixir of the Mongoose", 5, 7),
            new SulfurasHandOfRagnarosItem(0),
            new SulfurasHandOfRagnarosItem(-1),
            new BackstageConcertPassItem(15, 20),
            new BackstageConcertPassItem(10, 49),
            new BackstageConcertPassItem(5, 49),
            new ConjuredItem("Conjured Mana Cake", 3, 6)
        };

        var app = new GildedRose(items);

        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("Name, SellInDays, Quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j]);
            }
            Console.WriteLine("");
            app.Update();
        }
    }
}