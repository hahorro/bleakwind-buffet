/*
 * Author: Hans Ahorro
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Warrior Water.
    /// </summary>
    /// Comes with or without ice and a lemon slice.
    /// </remarks>
    public class WarriorWater : Drink, IOrderItem
    {
        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Whether the drink has a lemon slice or not.
        /// </summary>
        public bool Lemon { get; set; } = false;

        public override double Price { get; }

        public override uint Calories { get; }

        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!Ice) list.Add("Hold ice");
                if (Lemon) list.Add("Add lemon");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Warrior Water.
        /// </summary>
        public WarriorWater()
        {
            Price = 0;
            Calories = 0;
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
