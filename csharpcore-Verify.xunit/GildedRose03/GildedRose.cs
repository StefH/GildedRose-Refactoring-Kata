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
            var itemIsAgedBrie = ItemIsAgedBrie(item);
            var itemIsBackStagePasses = ItemIsBackStagesPass(item);
            var itemCanBeChanged = ItemCanBeChanged(item);
            
            if (!itemIsAgedBrie && !itemIsBackStagePasses)
            {
                if (ItemCanBeDecreasedFurther(item))
                {
                    if (itemCanBeChanged)
                    {
                        DecreaseQualityForItem(item);
                    }
                }
            }
            else
            {
                if (IsItemQualityLessThanMax(item))
                {
                    IncreaseQualityForItem(item);

                    if (itemIsBackStagePasses)
                    {
                        IncreaseQualityForBackStagePasses(item);
                    }
                }
            }

            if (itemCanBeChanged)
            {
                DecreaseSellInDaysForItem(item);
            }

            if (IsItemExpired(item))
            {
                ProcessExpired(item);
            }
        }
    }

    private static void ProcessExpired(Item item)
    {
        if (ItemIncreasesWhenExpired(item))
        {
            if (IsItemQualityLessThanMax(item))
            {
                IncreaseQualityForItem(item);
            }
        }
        else
        {
            if (ItemIsBackStagesPass(item))
            {
                SetItemQualityToMin(item);
            }
            else
            {
                if (ItemCanBeDecreasedFurther(item) && ItemCanBeChanged(item))
                {
                    DecreaseQualityForItem(item);
                }
            }
        }
    }

    private static void IncreaseQualityForBackStagePasses(Item item)
    {
        if (item.SellInDays < CONCERT_NEAR_DAYS)
        {
            if (IsItemQualityLessThanMax(item))
            {
                IncreaseQualityForItem(item);
            }
        }

        if (item.SellInDays < CONCERT_VERY_NEAR_DAYS)
        {
            if (IsItemQualityLessThanMax(item))
            {
                IncreaseQualityForItem(item);
            }
        }
    }

    private static bool ItemIsSulfuras(Item item)
    {
        return item.Name == ITEM_SULFURAS;
    }

    private static bool ItemIsAgedBrie(Item item)
    {
        return item.Name == ITEM_AGEDBRIE;
    }

    private static bool ItemIsBackStagesPass(Item item)
    {
        return item.Name == ITEM_BACKSTAGEPASSES;
    }

    private static bool ItemCanBeChanged(Item item)
    {
        return !ItemIsSulfuras(item);
    }

    private static bool ItemIncreasesWhenExpired(Item item)
    {
        return ItemIsAgedBrie(item);
    }

    private static void SetItemQualityToMin(Item item)
    {
        item.Quality = MIN_ITEM_QUALITY;
    }

    private static void DecreaseSellInDaysForItem(Item item)
    {
        item.SellInDays -= DAY;
    }

    private static void DecreaseQualityForItem(Item item)
    {
        item.Quality -= DAILY_QUALITY_DECREASE;
    }

    private static void IncreaseQualityForItem(Item item)
    {
        item.Quality += DAILY_QUALITY_INCREASE;
    }

    private static bool IsItemExpired(Item item)
    {
        return item.SellInDays < MIN_ITEM_SELLINDAYS;
    }

    private static bool ItemCanBeDecreasedFurther(Item item)
    {
        return item.Quality > MIN_ITEM_QUALITY;
    }

    private static bool IsItemQualityLessThanMax(Item item)
    {
        return item.Quality < MAX_ITEM_QUALITY;
    }
}