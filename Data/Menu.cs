/*
 * Author: Hans Ahorro
 * Class name: Menu.cs
 * Purpose: Static class used to represent the menu of items
 */

using System;
// using System.Reflection;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A static class representing the menu of items.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets the possible order types
        /// </summary>
        public static string[] OrderTypes
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }

        /// <summary>
        /// Returns a list of entrees.
        /// </summary>
        /// <returns>The list of entrees.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            //var classes = Assembly.GetExecutingAssembly().GetTypes();
            var entrees = new List<IOrderItem>
            {
                new BriarheartBurger(),
                new DoubleDraugr(),
                new GardenOrcOmelette(),
                new PhillyPoacher(),
                new SmokehouseSkeleton(),
                new ThalmorTriple(),
                new ThugsTBone()
            };

            //var entrees = new List<IOrderItem>();

            //foreach(Type t in classes)
            //{
            //    if (t.Namespace == "BleakwindBuffet.Data.Entrees")
            //    {
            //        if (typeof(Entree).IsAssignableFrom(t))
            //        {
            //            entrees.Add(t as IOrderItem);
            //        }
            //    }
            //}

            return entrees;
        }

        /// <summary>
        /// Returns a list of sides.
        /// </summary>
        /// <returns>The list of sides.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            var sides = new List<IOrderItem>
            {
                // Without object initializer, the size defaults to small.
                new DragonbornWaffleFries(),
                new DragonbornWaffleFries() { Size = Size.Medium },
                new DragonbornWaffleFries() { Size = Size.Large },
                new FriedMiraak(),
                new FriedMiraak() { Size = Size.Medium },
                new FriedMiraak() { Size = Size.Large },
                new MadOtarGrits(),
                new MadOtarGrits() { Size = Size.Medium },
                new MadOtarGrits() { Size = Size.Large },
                new VokunSalad(),
                new VokunSalad() { Size = Size.Medium },
                new VokunSalad() { Size = Size.Large }
            };

            return sides;
        }

        /// <summary>
        /// Returns a list of drinks.
        /// </summary>
        /// <returns>The list of drinks.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var drinks = new List<IOrderItem>
            {
                // Without object initializer, the size defaults to small.
                // Soda flavor defaults to cherry if not specified inside
                // the object initializer.
                new AretinoAppleJuice(),
                new AretinoAppleJuice() { Size = Size.Medium },
                new AretinoAppleJuice() { Size = Size.Large },
                new CandlehearthCoffee(),
                new CandlehearthCoffee() { Size = Size.Medium },
                new CandlehearthCoffee() { Size = Size.Large },
                new MarkarthMilk(),
                new MarkarthMilk() { Size = Size.Medium },
                new MarkarthMilk() { Size = Size.Large },
                new SailorSoda(),
                new SailorSoda() { Flavor = SodaFlavor.Blackberry },
                new SailorSoda() { Flavor = SodaFlavor.Grapefruit },
                new SailorSoda() { Flavor = SodaFlavor.Lemon },
                new SailorSoda() { Flavor = SodaFlavor.Peach },
                new SailorSoda() { Flavor = SodaFlavor.Watermelon },
                new SailorSoda() { Size = Size.Medium },
                new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Blackberry },
                new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit },
                new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Lemon },
                new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Peach },
                new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Watermelon },
                new SailorSoda() { Size = Size.Large },
                new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Blackberry },
                new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Grapefruit },
                new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Lemon },
                new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Peach },
                new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Watermelon },
                new WarriorWater(),
                new WarriorWater() { Size = Size.Medium },
                new WarriorWater() { Size = Size.Large },
            };

            return drinks;
        }

        /// <summary>
        /// Returns a list of all items.
        /// </summary>
        /// <returns>The list of all items.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            var fullMenu = new List<IOrderItem>();

            foreach(IOrderItem item in Entrees())
            {
                fullMenu.Add(item);
            }
            foreach (IOrderItem item in Sides())
            {
                fullMenu.Add(item);
            }
            foreach (IOrderItem item in Drinks())
            {
                fullMenu.Add(item);
            }

            return fullMenu;
        }

        /// <summary>
        /// Searches the menu for matching items
        /// </summary>
        /// <param name="menu">The collection of menu items</param>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of menu items</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menu, string terms)
        {
            var results = new List<IOrderItem>();

            // Return all menu items if search is blank
            if (terms == null) return menu;

            // Check ToString method return value
            foreach (IOrderItem item in menu)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters range of calories
        /// </summary>
        /// <param name="movies">The collection of menu items</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            // check for proper range applied
            if (min > max) return results;

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters range of prices
        /// </summary>
        /// <param name="movies">The collection of menu items</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            // check for proper range applied
            if (min > max) return results;

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
