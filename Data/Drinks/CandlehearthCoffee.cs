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
    /// Comes with or without ice, caffeinated/decaf,
    /// and allows for cream to be added.
    /// </remarks>
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Whether the drink is caffeinated or not.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Whether the drink has room for cream or not.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: return 0.75;
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: return 7;
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (Ice) list.Add("Add ice");
                if (RoomForCream) list.Add("Add cream");

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
            return $"{Size} {(Decaf ? "Decaf " : "")}Candlehearth Coffee";
        }
    }
}
