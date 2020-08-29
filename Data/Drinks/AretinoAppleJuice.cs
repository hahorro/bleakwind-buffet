/*
 * Author: Hans Ahorro
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent an Aretino Apple Juice
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
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
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: return 0.62;
                }
            }
        }
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: return 44;
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

        public AretinoAppleJuice()
        {
        }

        public override string ToString()
        {
            return $"{size} Aretino Apple Juice";
        }
    }
}
