using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class ConjuredItemTests
{
    [Fact]
    public void UpdateQuality_DecreasesQualityByTwo_BeforeExpiry()
    {
        // Arrange
        var conjuredItem = new ConjuredItem("Test Item", 5, 10);

        // Act
        conjuredItem.UpdateQuality();

        // Assert
        Assert.Equal(8, conjuredItem.Quality);
        Assert.Equal(5, conjuredItem.SellInDays);
    }

    [Fact]
    public void UpdateQuality_DecreasesQualityByFour_AfterExpiry()
    {
        // Arrange
        var conjuredItem = new ConjuredItem("Test Item", -1, 10);

        // Act
        conjuredItem.UpdateQuality();

        // Assert
        Assert.Equal(6, conjuredItem.Quality);
        Assert.Equal(-1, conjuredItem.SellInDays);
    }
}