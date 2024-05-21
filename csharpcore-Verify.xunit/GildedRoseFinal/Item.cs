namespace GildedRoseKata;

public abstract class Item
{
    public const int MAX_ITEM_QUALITY = 50;
    public const int MIN_ITEM_QUALITY = 0;

    public string Name { get; }
    public int SellInDays { get; private set; }
    public int Quality { get; protected set; }

    public virtual bool IsExpired() => SellInDays < 0;

    protected Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellInDays = sellIn;
        Quality = quality;
    }

    public virtual void UpdateSellByDate()
    {
        SellInDays--;
    }

    protected void DecreaseQuality(int amount)
    {
        if (Quality - amount < MIN_ITEM_QUALITY)
        {
            Quality = MIN_ITEM_QUALITY;
            return;
        }

        Quality -= amount;
    }

    protected void IncreaseQuality(int amount)
    {
        if (Quality + amount > MAX_ITEM_QUALITY)
        {
            Quality = MAX_ITEM_QUALITY;
            return;
        }

        Quality += amount;
    }

    public abstract void UpdateQuality();

    public override string ToString()
    {
        return Name + ", " + SellInDays + ", " + Quality;
    }
}