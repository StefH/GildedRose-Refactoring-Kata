using GildedRoseKata;
using Xunit;

namespace GildedRoseKataTests;

public class StandardItemTests
{
    [Fact]
    public void UpdateQuality_DecreasesQualityByOne_BeforeExpiry()
    {
        // Arrange
        var standardItem = new StandardItem("Test Item", 5, 10);

        // Act
        standardItem.UpdateQuality();

        // Assert
        Assert.Equal(9, standardItem.Quality);
        Assert.Equal(5, standardItem.SellInDays);
    }

    [Fact]
    public void UpdateQuality_DecreasesQualityByTwo_AfterExpiry()
    {
        // Arrange
        var standardItem = new StandardItem("Test Item", -1, 10);

        // Act
        standardItem.UpdateQuality();

        // Assert
        Assert.Equal(8, standardItem.Quality);
        Assert.Equal(-1, standardItem.SellInDays);
    }
}