using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class AgedBrieItemTests
{
    [Fact]
    public void UpdateQuality_IncreasesQualityByOne_WhenNotExpired()
    {
        // Arrange
        var item = new AgedBrieItem(5, 10);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(11, item.Quality);
    }

    [Fact]
    public void UpdateQuality_IncreasesQualityByTwo_WhenExpired()
    {
        // Arrange
        var item = new AgedBrieItem(-1, 10);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(12, item.Quality);
    }
}