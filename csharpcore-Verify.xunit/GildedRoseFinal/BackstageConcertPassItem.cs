namespace GildedRoseKata;

/// <summary>
/// "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
///
/// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert.
/// </summary>
public class BackstageConcertPassItem : Item
{
    private const int CONCERT_NEAR_DAYS = 10;
    private const int CONCERT_VERY_NEAR_DAYS = 5;
    private const int QUALITY_INCREASE_VERY_NEAR = 3;
    private const int QUALITY_INCREASE_NEAR = 2;
    private const int QUALITY_INCREASE_NORMAL = 1;

    public BackstageConcertPassItem(int sellIn, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
    {
    }
    public override void UpdateQuality()
    {
        if (IsExpired())
        {
            Quality = 0;
            return;
        }

        switch (SellInDays)
        {
            case < CONCERT_VERY_NEAR_DAYS:
                IncreaseQuality(QUALITY_INCREASE_VERY_NEAR);
                break;

            case < CONCERT_NEAR_DAYS:
                IncreaseQuality(QUALITY_INCREASE_NEAR);
                break;

            default:
                // Default increase
                IncreaseQuality(QUALITY_INCREASE_NORMAL);
                break;
        }
    }
}