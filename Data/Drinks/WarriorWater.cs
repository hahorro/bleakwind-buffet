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
    /// Represents a Warrior Water.
    /// </summary>
    /// The initial size of the drink is small and
    /// comes with or without ice and a lemon slice.
    /// </remarks>
    public class WarriorWater
    {
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;

        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; set => ice = value; }

        /// <summary>
        /// Whether the drink has a lemon slice or not.
        /// </summary>
        public bool Lemon { get => lemon; set => lemon = value; }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// The amount of calories in the drink.
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// Special instructions attached to the drink.
        /// </summary>
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

        /// <summary>
        /// Constructs a new Warrior Water.
        /// </summary>
        public WarriorWater()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size} Warrior Water";
        }
    }
}
