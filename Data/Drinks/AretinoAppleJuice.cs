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
    /// Represents an Aretino Apple Juice.
    /// </summary>
    /// <remarks>
    /// Comes with or without ice.
    /// </remarks>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <value>
        /// Whether the drink has ice or not.
        /// </value>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: return 0.62;
                }
            }
        }

        /// <value>
        /// The calories of the drink.
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: return 44;
                }
            }
        }

        /// <summary>
        /// Special instructions to prepare the drink.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
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
        /// Constructs a new Aretino Apple Juice.
        /// </summary>
        public AretinoAppleJuice()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
