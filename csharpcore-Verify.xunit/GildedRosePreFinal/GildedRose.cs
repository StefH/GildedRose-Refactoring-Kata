using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose(IEnumerable<Item> items)
{
    public void UpdateQuality()
    {
        foreach (var item in items)
        {
            item.UpdateSellByDate();
            item.UpdateQuality();
        }
    }
}