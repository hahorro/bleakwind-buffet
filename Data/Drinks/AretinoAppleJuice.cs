/*
 * Author: Hans Ahorro
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent an Aretino Apple Juice
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an Aretino Apple Juice.
    /// </summary>
    /// <remarks>
    /// The initial size of the drink is small and
    /// comes with or without ice.
    /// </remarks>
    public class AretinoAppleJuice
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
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: return 0.62;
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
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: return 44;
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
        /// Constructs a new Aretino Apple Juice.
        /// </summary>
        public AretinoAppleJuice()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size} Aretino Apple Juice";
        }
    }
}
