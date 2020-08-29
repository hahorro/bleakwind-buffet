/*
 * Author: Hans Ahorro
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Warrior Water
    /// </summary>
    public class WarriorWater
    {
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;

        public bool Ice { get => ice; set => ice = value; }
        public Size Size { get => size; set => size = value; }
        public bool Lemon { get => lemon; set => lemon = value; }
        public double Price { get; }
        public uint Calories { get; }
        public List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!ice) list.Add("Hold ice");
                if (lemon) list.Add("Add lemon");

                return list;
            }
        }

        public WarriorWater()
        {
        }

        public override string ToString()
        {
            return $"{size} Warrior Water";
        }
    }
}
