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
    public abstract class Drink
    {
        /// <summary>
        /// The size of the drink.
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <remarks>
        /// In US dollars.
        /// </remarks>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
