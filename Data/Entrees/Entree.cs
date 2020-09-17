/*
 * Author: Hans Ahorro
 * Class name: Entree.cs
 * Purpose: Abstract class used to represent an entree
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees.
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        public abstract double Price { get; }

        /// <value>
        /// The calories of the entree.
        /// </value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
        public abstract List<string> SpecialInstructions { get; }
    }
}
