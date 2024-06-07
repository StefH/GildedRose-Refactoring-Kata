namespace GildedRoseKata;

public class StandardItem : Item
{
    protected const int DAILY_QUALITY_DEGREDATION_BEFORE_EXPIRY = 1;
    protected const int DAILY_QUALITY_DEGREDATION_AFTER_EXPIRY = 2;

    public StandardItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }

    public override void UpdateQuality()
    {
        if (IsExpired())
        {
            DecreaseQuality(DAILY_QUALITY_DEGREDATION_AFTER_EXPIRY);
        }
        else
        {
            DecreaseQuality(DAILY_QUALITY_DEGREDATION_BEFORE_EXPIRY);
        }
    }
}