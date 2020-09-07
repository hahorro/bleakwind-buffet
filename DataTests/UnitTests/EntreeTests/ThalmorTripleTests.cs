/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var entree = new ThalmorTriple();
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var entree = new ThalmorTriple();
            entree.Bun = false;
            Assert.False(entree.Bun);
            entree.Bun = true;
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var entree = new ThalmorTriple();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
            entree.Ketchup = true;
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var entree = new ThalmorTriple();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
            entree.Mustard = true;
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var entree = new ThalmorTriple();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
            entree.Pickle = true;
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var entree = new ThalmorTriple();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
            entree.Cheese = true;
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var entree = new ThalmorTriple();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
            entree.Tomato = true;
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var entree = new ThalmorTriple();
            entree.Lettuce = false;
            Assert.False(entree.Lettuce);
            entree.Lettuce = true;
            Assert.True(entree.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var entree = new ThalmorTriple();
            entree.Mayo = false;
            Assert.False(entree.Mayo);
            entree.Mayo = true;
            Assert.True(entree.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            var entree = new ThalmorTriple();
            entree.Bacon = false;
            Assert.False(entree.Bacon);
            entree.Bacon = true;
            Assert.True(entree.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var entree = new ThalmorTriple();
            entree.Egg = false;
            Assert.False(entree.Egg);
            entree.Egg = true;
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new ThalmorTriple();
            Assert.Equal(8.32, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new ThalmorTriple();
            Assert.Equal((uint)943, entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            var entree = new ThalmorTriple();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
            entree.Tomato = includeTomato;
            entree.Lettuce = includeLettuce;
            entree.Mayo = includeMayo;
            entree.Bacon = includeBacon;
            entree.Egg = includeEgg;
            if (!includeBun) Assert.Contains("Hold bun", entree.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", entree.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", entree.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", entree.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", entree.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", entree.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", entree.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", entree.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", entree.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", entree.ToString());
        }
    }
}