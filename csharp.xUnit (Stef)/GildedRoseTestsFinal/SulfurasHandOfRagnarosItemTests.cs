using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class SulfurasHandOfRagnarosItemTests
{
    [Fact]
    public void DoesNeverExpire()
    {
        // Arrange
        const int sellInDays = -1;
        var sulfurasHandOfRagnarosItem = new SulfurasHandOfRagnarosItem(sellInDays);

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
        var sulfurasHandOfRagnarosItem = new SulfurasHandOfRagnarosItem(sellInDays);

        // Act
        sulfurasHandOfRagnarosItem.UpdateQuality();

        // Assert
        Assert.Equal(sellInDays, sulfurasHandOfRagnarosItem.SellInDays);
        Assert.Equal(80, sulfurasHandOfRagnarosItem.Quality);
    }
}