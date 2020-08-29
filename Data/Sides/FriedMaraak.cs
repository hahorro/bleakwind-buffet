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
    /// Represents a Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        private Size size = Size.Small;

        public Size Size { get => size; set => size = value; }
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
        public List<string> SpecialInstructions { get => new List<string>(); }

        public FriedMiraak()
        {
        }

        public override string ToString()
        {
            return $"{size} Fried Miraak";
        }
    }
}
