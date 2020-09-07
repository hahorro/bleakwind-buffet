/*
 * Author: Hans Ahorro
 * Class name: MarkathMilk.cs
 * Purpose: Class used to represent a Markarth Milk
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Markarth Milk.
    /// </summary>
    /// <remarks>
    /// The initial size of the drink is small and
    /// comes with or without ice.
    /// </remarks>
    public class MarkarthMilk
    {
        private bool ice = false;
        private Size size = Size.Small;

        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; set => ice = value; }

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
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: return 1.05;
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
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: return 56;
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

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Markarth Milk.
        /// </summary>
        public MarkarthMilk()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size} Markarth Milk";
        }
    }
}
