namespace GildedRoseKata;

public class StandardItem : Item
{
    public StandardItem(string name, int sellInDays, int quality) : base(name, sellInDays, quality)
    {
    }

    public override void UpdateQuality()
    {
        // TODO
    }
}