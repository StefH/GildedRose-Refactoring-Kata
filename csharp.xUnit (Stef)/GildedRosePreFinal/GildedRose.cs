using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose(IEnumerable<Item> items)
{
    public void Update()
    {
        foreach (var item in items)
        {
            item.UpdateSellInDays();
            item.UpdateQuality();
        }
    }
}