/*
 * Author: Hans Ahorro
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents Dragonborn Waffle Fries.
    /// </summary>
    /// <remarks>
    /// The initial size of the side is small.
    /// </remarks>
    public class DragonbornWaffleFries
    {
        private Size size = Size.Small;

        /// <summary>
        /// The size of the side.
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// The price of the side.
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: return 0.42;
                }
            }
        }

        /// <summary>
        /// The amount of calories in the side.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: return 77;
                }
            }
        }

        /// <summary>
        /// Special instructions attached to the side.
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Constructs a new Dragonborn Waffle Fries.
        /// </summary>
        public DragonbornWaffleFries()
        {
        }

        /// <summary>
        /// Returns a string representing the side.
        /// </summary>
        /// <returns>The string representing the side.</returns>
        public override string ToString()
        {
            return $"{size} Dragonborn Waffle Fries";
        }
    }
}
