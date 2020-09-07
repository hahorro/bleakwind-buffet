/*
 * Author: Hans Ahorro
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Sailor Soda.
    /// </summary>
    /// <remarks>
    /// The initial size of the drink is small and
    /// comes in several flavors with or without ice.
    /// </remarks>
    public class SailorSoda
    {
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; set => ice = value; }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// The flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor { get => flavor; set => flavor = value; }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: return 1.42;
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
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: return 117;
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
                if (!ice) list.Add("Hold ice");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Sailor Soda.
        /// </summary>
        public SailorSoda()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size} {flavor} Sailor Soda";
        }
    }
}
