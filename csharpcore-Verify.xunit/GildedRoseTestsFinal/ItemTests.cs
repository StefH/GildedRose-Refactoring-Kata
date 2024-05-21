using GildedRoseKata;
using Xunit;

namespace GildedRoseKataTests;

public class ItemTests
{
    private class TestItem : Item
    {
        private readonly int _delta;

        public TestItem(int delta, string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            _delta = delta;
        }

        public override void UpdateQuality()
        {
            if (_delta > 0)
            {
                IncreaseQuality(_delta);
            }
            else
            {
                DecreaseQuality(-_delta);
            }
        }
    }

    [Fact]
    public void UpdateSellByDate_DecreasesSellInDaysByOne()
    {
        // Arrange
        var item = new TestItem(0, "Test Item", 5, 10);

        // Act
        item.UpdateSellByDate();

        // Assert
        Assert.Equal(4, item.SellInDays);
        Assert.Equal(10, item.Quality);
    }

    [Fact]
    public void IsExpired_ReturnsTrue_WhenSellInDaysIsNegative()
    {
        // Arrange
        var item = new TestItem(0, "Test Item", -1, 10);

        // Act
        var result = item.IsExpired();

        // Assert
        Assert.True(result);
        Assert.Equal(10, item.Quality);
    }

    [Fact]
    public void IsExpired_ReturnsFalse_WhenSellInDaysIsNonNegative()
    {
        // Arrange
        var item = new TestItem(0, "Test Item", 0, 10);

        // Act
        var result = item.IsExpired();

        // Assert
        Assert.False(result);
        Assert.Equal(10, item.Quality);
    }

    [Fact]
    public void UpdateQuality_DoesNotDecreaseBelowMinQuality()
    {
        // Arrange
        var item = new TestItem(-7, "Test Item", 5, 1);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(Item.MIN_ITEM_QUALITY, item.Quality);
    }

    [Fact]
    public void UpdateQuality_DoesNotIncreaseAboveMaxQuality()
    {
        // Arrange
        var item = new TestItem(7, "Test Item", 5, 49);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(Item.MAX_ITEM_QUALITY, item.Quality);
    }
}