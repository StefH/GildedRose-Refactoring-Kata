namespace GildedRoseKata;

public class AgedBrieItem : Item
{
    public AgedBrieItem(int sellInDays, int quality) : base("Aged Brie", sellInDays, quality)
    {
    }

    public override void UpdateQuality()
    {
        // TODO
    }
}