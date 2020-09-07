/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new ThugsTBone();
            Assert.Equal(6.44, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new ThugsTBone();
            Assert.Equal((uint)982, entree.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var entree = new ThugsTBone();
            Assert.Empty(entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", entree.ToString());
        }
    }
}