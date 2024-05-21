namespace GildedRoseKata;

public class SulfurasHandOfRagnarosItem : Item
{
    public SulfurasHandOfRagnarosItem(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", sellIn, quality)
    {
    }

    public override bool IsExpired()
    {
        return false;
    }

    public override void UpdateSellByDate()
    {
    }


    public override void UpdateQuality()
    {
    }
}