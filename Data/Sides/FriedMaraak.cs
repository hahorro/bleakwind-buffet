/*
 * Author: Hans Ahorro
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a Fried Miraak
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents a Fried Miraak.
    /// </summary>
    /// <remarks>
    /// The initial size of the side is small.
    /// </remarks>
    public class FriedMiraak
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: return 1.78;
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: return 151;
                }
            }
        }

        /// <summary>
        /// Special instructions attached to the side.
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Constructs a new Fried Miraak.
        /// </summary>
        public FriedMiraak()
        {
        }

        /// <summary>
        /// Returns a string representing the side.
        /// </summary>
        /// <returns>The string representing the side.</returns>
        public override string ToString()
        {
            return $"{size} Fried Miraak";
        }
    }
}
