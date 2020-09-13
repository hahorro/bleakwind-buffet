/*
 * Author: Hans Ahorro
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;

using System.Linq;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ListOfEntreesShouldBeAssignableToInterfaceOrderItem()
        {
            var entrees = Menu.Entrees();
            for (var i = 0; i < entrees.Count(); i++)
            {
                Assert.IsAssignableFrom<IOrderItem>(entrees.ElementAt(i));
            }
        }

        [Fact]
        public void ListOfSidesShouldBeAssignableToInterfaceOrderItem()
        {
            var sides = Menu.Sides();
            for (var i = 0; i < sides.Count(); i++)
            {
                Assert.IsAssignableFrom<IOrderItem>(sides.ElementAt(i));
            }
        }

        [Fact]
        public void ListOfDrinksShouldBeAssignableToInterfaceOrderItem()
        {
            var drinks = Menu.Drinks();
            for (var i = 0; i < drinks.Count(); i++)
            {
                Assert.IsAssignableFrom<IOrderItem>(drinks.ElementAt(i));
            }
        }

        [Fact]
        public void ListOfEntreesShouldBeAssignableToBaseEntreeClass()
        {
            var entrees = Menu.Entrees();
            for (var i = 0; i < entrees.Count(); i++)
            {
                Assert.IsAssignableFrom<Entree>(entrees.ElementAt(i));
            }
        }

        [Fact]
        public void ListOfSidesShouldBeAssignableToBaseSideClass()
        {
            var sides = Menu.Sides();
            for (var i = 0; i < sides.Count(); i++)
            {
                Assert.IsAssignableFrom<Side>(sides.ElementAt(i));
            }
        }

        [Fact]
        public void ListOfDrinksShouldBeAssignableToBaseDrinkClass()
        {
            var drinks = Menu.Drinks();
            for (var i = 0; i < drinks.Count(); i++)
            {
                Assert.IsAssignableFrom<Drink>(drinks.ElementAt(i));
            }
        }

        [Fact]
        public void ListOfAllItemsShouldBeAssignableToInterfaceOrderItem()
        {
            var fullMenu = Menu.FullMenu();
            for (var i = 0; i < fullMenu.Count(); i++)
            {
                Assert.IsAssignableFrom<IOrderItem>(fullMenu.ElementAt(i));
            }
        }

        [Fact]
        public void ListOfEntreesShouldBeCorrect()
        {
            var entrees = Menu.Entrees();
            Assert.Collection(entrees,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item)
            );
        }

        [Fact]
        public void ListOfSidesShouldBeCorrect()
        {
            var sides = Menu.Sides();
            Assert.Collection(sides,
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Small, ((DragonbornWaffleFries)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Medium, ((DragonbornWaffleFries)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Large, ((DragonbornWaffleFries)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Small, ((FriedMiraak)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Medium, ((FriedMiraak)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Large, ((FriedMiraak)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Small, ((MadOtarGrits)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Medium, ((MadOtarGrits)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Large, ((MadOtarGrits)item).Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Small, ((VokunSalad)item).Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Medium, ((VokunSalad)item).Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Large, ((VokunSalad)item).Size);
                }
            );
        }

        [Fact]
        public void ListOfDrinksShouldBeCorrect()
        {
            var drinks = Menu.Drinks();
            Assert.Collection(drinks,
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Small, ((AretinoAppleJuice)item).Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Medium, ((AretinoAppleJuice)item).Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Large, ((AretinoAppleJuice)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Small, ((CandlehearthCoffee)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Medium, ((CandlehearthCoffee)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Large, ((CandlehearthCoffee)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Small, ((MarkarthMilk)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Medium, ((MarkarthMilk)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Large, ((MarkarthMilk)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Small, ((WarriorWater)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Medium, ((WarriorWater)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Large, ((WarriorWater)item).Size);
                }
            );
        }

        [Fact]
        public void ListOfAllItemsShouldBeCorrect()
        {
            var fullMenu = Menu.FullMenu();
            Assert.Collection(fullMenu,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Small, ((DragonbornWaffleFries)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Medium, ((DragonbornWaffleFries)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Large, ((DragonbornWaffleFries)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Small, ((FriedMiraak)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Medium, ((FriedMiraak)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Large, ((FriedMiraak)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Small, ((MadOtarGrits)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Medium, ((MadOtarGrits)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Large, ((MadOtarGrits)item).Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Small, ((VokunSalad)item).Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Medium, ((VokunSalad)item).Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Large, ((VokunSalad)item).Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Small, ((AretinoAppleJuice)item).Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Medium, ((AretinoAppleJuice)item).Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Large, ((AretinoAppleJuice)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Small, ((CandlehearthCoffee)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Medium, ((CandlehearthCoffee)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Large, ((CandlehearthCoffee)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Small, ((MarkarthMilk)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Medium, ((MarkarthMilk)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Large, ((MarkarthMilk)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Small, ((WarriorWater)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Medium, ((WarriorWater)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Large, ((WarriorWater)item).Size);
                }
            );
        }
    }
}
