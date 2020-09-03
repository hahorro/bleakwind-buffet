/*
 * Author: Hans Ahorro
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
        private Size size = Size.Small;

        public bool Ice { get => ice; set => ice = value; }
        public bool Decaf { get => decaf; set => decaf = value; }
        public bool RoomForCream { get => roomForCream; set => roomForCream = value; }
        public Size Size { get => size; set => size = value; }
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: return 0.75;
                }
            }
        }
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: return 7;
                }
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (ice) list.Add("Add ice");
                if (roomForCream) list.Add("Add cream");

                return list;
            }
        }

        public CandlehearthCoffee()
        {
        }

        public override string ToString()
        {
            return $"{size} {(decaf ? "Decaf" : "")} Candlehearth Coffee";
        }
    }
}
