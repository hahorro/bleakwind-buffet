/*
 * Author: Hans Ahorro
 * Class name: Drink.cs
 * Purpose: Abstract class used to represent a drink
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks.
    /// </summary>
    /// <remarks>
    /// The initial size of the drink is small.
    /// </remarks>
    public abstract class Drink : IOrderItem
    {
        /// <value>
        /// The size of the drink.
        /// </value>
        public abstract Size Size { get; set; }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        public abstract double Price { get; }

        /// <value>
        /// The calories of the drink.
        /// </value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
        public abstract List<string> SpecialInstructions { get; }
    }
}
