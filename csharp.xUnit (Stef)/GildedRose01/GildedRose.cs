using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string ITEM_AGEDBRIE = "Aged Brie";
    private const string ITEM_BACKSTAGEPASSES = "Backstage passes to a TAFKAL80ETC concert";
    private const string ITEM_SULFURAS = "Sulfuras, Hand of Ragnaros";

    private const int MAX_ITEM_QUALITY = 50;
    private const int MIN_ITEM_QUALITY = 0;

    private const int MIN_SELLIN = 0;

    private const int CONCERT_NEAR_DAYS = 11;
    private const int CONCERT_VERY_NEAR_DAYS = 6;

    private const int DAILY_QUALITY_INCREASE = 1;
    private const int DAILY_QUALITY_DECREASE = 1;

    private const int DAY = 1;

    private readonly IList<Item> _items;

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < _items.Count; i++)
        {
            if (_items[i].Name != ITEM_AGEDBRIE && _items[i].Name != ITEM_BACKSTAGEPASSES)
            {
                if (_items[i].Quality > MIN_ITEM_QUALITY)
                {
                    if (_items[i].Name != ITEM_SULFURAS)
                    {
                        _items[i].Quality -= DAILY_QUALITY_INCREASE;
                    }
                }
            }
            else
            {
                if (_items[i].Quality < MAX_ITEM_QUALITY)
                {
                    _items[i].Quality += DAILY_QUALITY_INCREASE;

                    if (_items[i].Name == ITEM_BACKSTAGEPASSES)
                    {
                        if (_items[i].SellIn < CONCERT_NEAR_DAYS)
                        {
                            if (_items[i].Quality < MAX_ITEM_QUALITY)
                            {
                                _items[i].Quality += DAILY_QUALITY_INCREASE;
                            }
                        }

                        if (_items[i].SellIn < CONCERT_VERY_NEAR_DAYS)
                        {
                            if (_items[i].Quality < MAX_ITEM_QUALITY)
                            {
                                _items[i].Quality += DAILY_QUALITY_INCREASE;
                            }
                        }
                    }
                }
            }

            if (_items[i].Name != ITEM_SULFURAS)
            {
                _items[i].SellIn -= DAY;
            }

            if (_items[i].SellIn < MIN_SELLIN)
            {
                if (_items[i].Name != ITEM_AGEDBRIE)
                {
                    if (_items[i].Name != ITEM_BACKSTAGEPASSES)
                    {
                        if (_items[i].Quality > MIN_ITEM_QUALITY)
                        {
                            if (_items[i].Name != ITEM_SULFURAS)
                            {
                                _items[i].Quality -= DAILY_QUALITY_DECREASE;
                            }
                        }
                    }
                    else
                    {
                        _items[i].Quality = MIN_ITEM_QUALITY;
                    }
                }
                else
                {
                    if (_items[i].Quality < MAX_ITEM_QUALITY)
                    {
                        _items[i].Quality += DAILY_QUALITY_INCREASE;
                    }
                }
            }
        }
    }
}