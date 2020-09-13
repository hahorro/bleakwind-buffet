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
    public class VokunSalad : Side, IOrderItem
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: return 0.93;
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
                    default: return 41;
                }
            }
        }

        public override List<string> SpecialInstructions { get => new List<string>(); }

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
            return $"{Size} Vokun Salad";
        }
    }
}
