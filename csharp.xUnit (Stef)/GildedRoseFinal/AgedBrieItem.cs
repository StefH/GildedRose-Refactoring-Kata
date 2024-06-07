namespace GildedRoseKata;

public class AgedBrieItem : Item
{
    private const int QUALITY_INCREASE_BEFORE_EXPIRY = 1;
    private const int QUALITY_INCREASE_AFTER_EXPIRY = 2;

    public AgedBrieItem(int sellInDays, int quality) : base("Aged Brie", sellInDays, quality)
    {
    }

    public override void UpdateQuality()
    {
        IncreaseQuality(IsExpired() ? QUALITY_INCREASE_AFTER_EXPIRY : QUALITY_INCREASE_BEFORE_EXPIRY);
    }
}
