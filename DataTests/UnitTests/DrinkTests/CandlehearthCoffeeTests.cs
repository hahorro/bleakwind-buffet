/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var drink = new CandlehearthCoffee();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var drink = new CandlehearthCoffee();
            Assert.False(drink.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var drink = new CandlehearthCoffee();
            Assert.False(drink.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var drink = new CandlehearthCoffee();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var drink = new CandlehearthCoffee();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var drink = new CandlehearthCoffee();
            drink.Decaf = true;
            Assert.True(drink.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var drink = new CandlehearthCoffee();
            drink.RoomForCream = true;
            Assert.True(drink.RoomForCream);
            drink.RoomForCream = false;
            Assert.False(drink.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var drink = new CandlehearthCoffee();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var drink = new CandlehearthCoffee();
            drink.Size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var drink = new CandlehearthCoffee();
            drink.Size = size;
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var drink = new CandlehearthCoffee();
            drink.Ice = includeIce;
            drink.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", drink.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", drink.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            var drink = new CandlehearthCoffee();
            drink.Decaf = decaf;
            drink.Size = size;
            Assert.Equal(name, drink.ToString());
        }
    }
}
