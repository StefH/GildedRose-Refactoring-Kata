using GildedRoseKata;
using Xunit;

namespace GildedRoseKataTests;

public class SulfurasHandOfRagnarosItemTests
{
    [Fact]
    public void DoesNeverExpire()
    {
        // Arrange
        const int sellInDays = -1;
        const int quality = 10;
        var sulfurasHandOfRagnarosItem = new SulfurasHandOfRagnarosItem(sellInDays, quality);

        // Act
        var isExpired = sulfurasHandOfRagnarosItem.IsExpired();

        // Assert
        Assert.False(isExpired);
    }

    [Fact]
    public void UpdateQuality_NeverChangesSellInDaysOrQuality()
    {
        // Arrange
        const int sellInDays = -1;
        const int quality = 99;
        var sulfurasHandOfRagnarosItem = new SulfurasHandOfRagnarosItem(sellInDays, quality);

        // Act
        sulfurasHandOfRagnarosItem.UpdateQuality();

        // Assert
        Assert.Equal(sellInDays, sulfurasHandOfRagnarosItem.SellInDays);
        Assert.Equal(quality, sulfurasHandOfRagnarosItem.Quality);
    }
}