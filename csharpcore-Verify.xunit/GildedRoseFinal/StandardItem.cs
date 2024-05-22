namespace GildedRoseKata;

public class StandardItem : Item
{
    private const int DAILY_QUALITY_DECREASE_BEFORE_EXPIRY = 1;
    private const int DAILY_QUALITY_DECREASE_AFTER_EXPIRY = 2;

    public StandardItem(string name, int sellInDays, int quality) : base(name, sellInDays, quality)
    {
    }

    public override void UpdateQuality()
    {
        if (IsExpired())
        {
            DecreaseQuality(DAILY_QUALITY_DECREASE_AFTER_EXPIRY);
        }
        else
        {
            DecreaseQuality(DAILY_QUALITY_DECREASE_BEFORE_EXPIRY);
        }
    }
}