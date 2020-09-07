/*
 * Author: Hans Ahorro
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Candlehearth Coffee.
    /// </summary>
    /// <remarks>
    /// The initial size of the drink is small,
    /// comes with or without ice, caffeinated/decaf,
    /// and allows for cream to be added.
    /// </remarks>
    public class CandlehearthCoffee
    {
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
        private Size size = Size.Small;

        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; set => ice = value; }

        /// <summary>
        /// Whether the drink is caffeinated or not.
        /// </summary>
        public bool Decaf { get => decaf; set => decaf = value; }

        /// <summary>
        /// Whether the drink has room for cream or not.
        /// </summary>
        public bool RoomForCream { get => roomForCream; set => roomForCream = value; }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: return 0.75;
                }
            }
        }

        /// <summary>
        /// The amount of calories in the drink.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: return 7;
                }
            }
        }

        /// <summary>
        /// Special instructions attached to the drink.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (ice) list.Add("Add ice");
                if (roomForCream) list.Add("Add cream");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Candlehearth Coffee.
        /// </summary>
        public CandlehearthCoffee()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size} {(decaf ? "Decaf " : "")}Candlehearth Coffee";
        }
    }
}
