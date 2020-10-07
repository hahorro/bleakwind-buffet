/*
 * Author: Zachery Brunner
 * Edited by: Hans Ahorro
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAssignableToInterfaceOrderItem()
        {
            var entree = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            var entree = new GardenOrcOmelette();
            Assert.True(entree.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            var entree = new GardenOrcOmelette();
            Assert.True(entree.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            var entree = new GardenOrcOmelette();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            var entree = new GardenOrcOmelette();
            Assert.True(entree.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var entree = new GardenOrcOmelette();
            entree.Broccoli = false;
            Assert.False(entree.Broccoli);
            entree.Broccoli = true;
            Assert.True(entree.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var entree = new GardenOrcOmelette();
            entree.Mushrooms = false;
            Assert.False(entree.Mushrooms);
            entree.Mushrooms = true;
            Assert.True(entree.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var entree = new GardenOrcOmelette();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
            entree.Tomato = true;
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var entree = new GardenOrcOmelette();
            entree.Cheddar = false;
            Assert.False(entree.Cheddar);
            entree.Cheddar = true;
            Assert.True(entree.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new GardenOrcOmelette();
            Assert.Equal(4.57, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new GardenOrcOmelette();
            Assert.Equal((uint)404, entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var entree = new GardenOrcOmelette();
            entree.Broccoli = includeBroccoli;
            entree.Mushrooms = includeMushrooms;
            entree.Tomato = includeTomato;
            entree.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", entree.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", entree.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", entree.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", entree.ToString());
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var entree = new GardenOrcOmelette();

            Assert.PropertyChanged(entree, "Broccoli", () =>
            {
                entree.Broccoli = true;
            });

            Assert.PropertyChanged(entree, "Broccoli", () =>
            {
                entree.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var entree = new GardenOrcOmelette();

            Assert.PropertyChanged(entree, "Mushrooms", () =>
            {
                entree.Mushrooms = true;
            });

            Assert.PropertyChanged(entree, "Mushrooms", () =>
            {
                entree.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var entree = new GardenOrcOmelette();

            Assert.PropertyChanged(entree, "Tomato", () =>
            {
                entree.Tomato = true;
            });

            Assert.PropertyChanged(entree, "Tomato", () =>
            {
                entree.Tomato = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var entree = new GardenOrcOmelette();

            Assert.PropertyChanged(entree, "Cheddar", () =>
            {
                entree.Cheddar = true;
            });

            Assert.PropertyChanged(entree, "Cheddar", () =>
            {
                entree.Cheddar = false;
            });
        }
    }
}