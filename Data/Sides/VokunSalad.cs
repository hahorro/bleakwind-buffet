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
    /// Represents a Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        private Size size = Size.Small;

        public Size Size { get => size; set => size = value; }
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
        public List<string> SpecialInstructions { get => new List<string>(); }

        public VokunSalad()
        {
        }

        public override string ToString()
        {
            return $"{size} Vokun Salad";
        }
    }
}
