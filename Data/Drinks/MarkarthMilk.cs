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
    /// Represents a Markarth Milk.
    /// </summary>
    /// <remarks>
    /// Comes with or without ice.
    /// </remarks>
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = false;

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: return 1.05;
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: return 56;
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (Ice) list.Add("Add ice");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Markarth Milk.
        /// </summary>
        public MarkarthMilk()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
