using GildedRoseKata;
using Xunit;

namespace GildedRoseKataTests;

public class BackstageConcertPassItemTests
{
    [Fact]
    public void UpdateQuality_IncreasesQualityByOne_WhenMoreThan10DaysLeft()
    {
        // Arrange
        var item = new BackstageConcertPassItem(11, 42);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(43, item.Quality);
    }

    [Fact]
    public void UpdateQuality_IncreasesQualityByTwo_WhenLessThan10DaysLeft()
    {
        // Arrange
        var item = new BackstageConcertPassItem(9, 42);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(44, item.Quality);
    }

    [Fact]
    public void UpdateQuality_IncreasesQualityByThree_LessThan5DaysLeft()
    {
        // Arrange
        var item = new BackstageConcertPassItem(4, 42);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(45, item.Quality);
    }

    [Fact]
    public void UpdateQuality_DropsQualityToZero_WhenExpired()
    {
        // Arrange
        var item = new BackstageConcertPassItem(-1, 42);

        // Act
        item.UpdateQuality();

        // Assert
        Assert.Equal(0, item.Quality);
    }
}