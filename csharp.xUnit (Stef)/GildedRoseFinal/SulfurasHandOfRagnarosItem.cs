namespace GildedRoseKata;

public class SulfurasHandOfRagnarosItem : Item
{
    public SulfurasHandOfRagnarosItem(int sellInDays) : base("Sulfuras, Hand of Ragnaros", sellInDays, 80)
    {
    }

    public override bool IsExpired()
    {
        return false;
    }

    public override void UpdateSellInDays()
    {
    }

    public override void UpdateQuality()
    {
    }
}