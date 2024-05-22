using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string ITEM_AGEDBRIE = "Aged Brie";
    private const string ITEM_BACKSTAGEPASSES = "Backstage passes to a TAFKAL80ETC concert";
    private const string ITEM_SULFURAS = "Sulfuras, Hand of Ragnaros";

    private const int MAX_ITEM_QUALITY = 50;
    private const int MIN_ITEM_QUALITY = 0;

    private const int MIN_ITEM_SELLINDAYS = 0;

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
        foreach (var item in _items)
        {
            if (item.Name != ITEM_AGEDBRIE && item.Name != ITEM_BACKSTAGEPASSES)
            {
                if (item.Quality > MIN_ITEM_QUALITY)
                {
                    if (item.Name != ITEM_SULFURAS)
                    {
                        item.Quality -= DAILY_QUALITY_INCREASE;
                    }
                }
            }
            else
            {
                if (item.Quality < MAX_ITEM_QUALITY)
                {
                    item.Quality += DAILY_QUALITY_INCREASE;

                    if (item.Name == ITEM_BACKSTAGEPASSES)
                    {
                        if (item.SellInDays < CONCERT_NEAR_DAYS)
                        {
                            if (item.Quality < MAX_ITEM_QUALITY)
                            {
                                item.Quality += DAILY_QUALITY_INCREASE;
                            }
                        }

                        if (item.SellInDays < CONCERT_VERY_NEAR_DAYS)
                        {
                            if (item.Quality < MAX_ITEM_QUALITY)
                            {
                                item.Quality += DAILY_QUALITY_INCREASE;
                            }
                        }
                    }
                }
            }

            if (item.Name != ITEM_SULFURAS)
            {
                item.SellInDays -= DAY;
            }

            if (item.SellInDays < MIN_ITEM_SELLINDAYS)
            {
                if (item.Name != ITEM_AGEDBRIE)
                {
                    if (item.Name != ITEM_BACKSTAGEPASSES)
                    {
                        if (item.Quality > MIN_ITEM_QUALITY)
                        {
                            if (item.Name != ITEM_SULFURAS)
                            {
                                item.Quality -= DAILY_QUALITY_DECREASE;
                            }
                        }
                    }
                    else
                    {
                        item.Quality -= item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MAX_ITEM_QUALITY)
                    {
                        item.Quality += DAILY_QUALITY_INCREASE;
                    }
                }
            }
        }
    }
}