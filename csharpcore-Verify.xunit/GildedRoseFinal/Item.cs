using System;

namespace GildedRoseKata;

public abstract class Item
{
    public const int MAX_ITEM_QUALITY = 50;
    public const int MIN_ITEM_QUALITY = 0;

    public string Name { get; }

    public int SellInDays { get; private set; }

    public int Quality { get; protected set; }

    public virtual bool IsExpired() => SellInDays < 0;

    protected Item(string name, int sellInDays, int quality)
    {
        Name = name;
        SellInDays = sellInDays;
        Quality = quality;
    }

    public virtual void UpdateSellByDate()
    {
        SellInDays--;
    }

    protected void DecreaseQuality(int amount)
    {
        Quality = Math.Max(Quality - amount, MIN_ITEM_QUALITY);
    }

    protected void IncreaseQuality(int amount)
    {
        Quality = Math.Min(Quality + amount, MAX_ITEM_QUALITY);
    }

    public abstract void UpdateQuality();

    public override string ToString()
    {
        return Name + ", " + SellInDays + ", " + Quality;
    }
}