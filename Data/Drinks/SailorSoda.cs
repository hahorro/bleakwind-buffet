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
    /// Represents a Sailor Soda
    /// </summary>
    public class SailorSoda
    {
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

        public bool Ice { get => ice; set => ice = value; }
        public Size Size { get => size; set => size = value; }
        public SodaFlavor Flavor { get => flavor; set => flavor = value; }
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
        public List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!ice) list.Add("Hold ice");

                return list;
            }
        }

        public SailorSoda()
        {
        }

        public override string ToString()
        {
            return $"{size} {flavor} Sailor Soda";
        }
    }
}
