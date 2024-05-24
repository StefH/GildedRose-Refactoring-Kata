namespace GildedRoseKata;

public class SulfurasHandOfRagnarosItem : Item
{
    public SulfurasHandOfRagnarosItem(int sellInDays, int quality) : base("Sulfuras, Hand of Ragnaros", sellInDays, quality)
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