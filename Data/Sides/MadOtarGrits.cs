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
    /// Represents Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        private Size size = Size.Small;

        public Size Size { get => size; set => size = value; }
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: return 1.22;
                }
            }
        }
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: return 105;
                }
            }
        }
        public List<string> SpecialInstructions { get => new List<string>(); }

        public MadOtarGrits()
        {
        }

        public override string ToString()
        {
            return $"{size} Mad Otar Grits";
        }
    }
}
