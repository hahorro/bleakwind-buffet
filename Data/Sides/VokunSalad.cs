/*
 * Author: Hans Ahorro
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent a Vokun Salad
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents a Vokun Salad.
    /// </summary>
    /// <remarks>
    /// The initial size of the side is small.
    /// </remarks>
    public class VokunSalad
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
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: return 0.93;
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
                    default: return 41;
                }
            }
        }

        /// <summary>
        /// Special instructions attached to the side.
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Constructs a new Vokun Salad.
        /// </summary>
        public VokunSalad()
        {
        }

        /// <summary>
        /// Returns a string representing the side.
        /// </summary>
        /// <returns>The string representing the side.</returns>
        public override string ToString()
        {
            return $"{size} Vokun Salad";
        }
    }
}
