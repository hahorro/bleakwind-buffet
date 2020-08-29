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
    /// Represents Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        private Size size = Size.Small;

        public Size Size { get => size; set => size = value; }
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
        public List<string> SpecialInstructions { get => new List<string>(); }

        public DragonbornWaffleFries()
        {
        }

        public override string ToString()
        {
            return $"{size} Dragonborn Waffle Fries";
        }
    }
}
