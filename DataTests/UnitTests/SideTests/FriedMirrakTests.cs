﻿/*
 * Author: Zachery Brunner
 * Edited by: Hans Ahorro
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeAssignableToInterfaceOrderItem()
        {
            var side = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var side = new FriedMiraak();
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var side = new FriedMiraak();
            side.Size = Size.Large;
            Assert.Equal(Size.Large, side.Size);
            side.Size = Size.Medium;
            Assert.Equal(Size.Medium, side.Size);
            side.Size = Size.Small;
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var side = new FriedMiraak();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var side = new FriedMiraak();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var side = new FriedMiraak();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var side = new FriedMiraak();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var side = new FriedMiraak();

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Small;
            });
        }
    }
}