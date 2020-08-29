/*
 * Author: Hans Ahorro
 * Class name: MarkathMilk.cs
 * Purpose: Class used to represent a Markarth Milk
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        private bool ice = false;
        private Size size = Size.Small;

        public bool Ice { get => ice; set => ice = value; }
        public Size Size { get => size; set => size = value; }
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: return 1.05;
                }
            }
        }
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: return 56;
                }
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (ice) list.Add("Add ice");

                return list;
            }
        }

        public MarkarthMilk()
        {
        }

        public override string ToString()
        {
            return $"{size} Markarth Milk";
        }
    }
}
