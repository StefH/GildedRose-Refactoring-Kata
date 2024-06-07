namespace GildedRoseKata;

/// <summary>
/// "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
///
/// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert.
/// </summary>
public class BackstageConcertPassItem : Item
{
    public BackstageConcertPassItem(int sellInDays, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellInDays, quality)
    {
    }

    public override void UpdateQuality()
    {
        // TODO
    }
}