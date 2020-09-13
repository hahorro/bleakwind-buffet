/*
 * Author: Hans Ahorro
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents Mad Otar Grits.
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: return 1.22;
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: return 105;
                }
            }
        }

        public override List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Constructs a new Mad Otar Grits.
        /// </summary>
        public MadOtarGrits()
        {
        }

        /// <summary>
        /// Returns a string representing the side.
        /// </summary>
        /// <returns>The string representing the side.</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
