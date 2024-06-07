namespace GildedRoseKata;

/// <summary>
/// "Conjured" items degrade in Quality twice as fast as normal items
/// </summary>
public class ConjuredItem : StandardItem
{
    public ConjuredItem(string name, int sellInDays, int quality) : base(name, sellInDays, quality)
    {
    }

    public override void UpdateQuality()
    {
        if (IsExpired())
        {
            DecreaseQuality(DAILY_QUALITY_DEGREDATION_AFTER_EXPIRY * 2);
        }
        else
        {
            DecreaseQuality(DAILY_QUALITY_DEGREDATION_BEFORE_EXPIRY * 2);
        }
    }
}