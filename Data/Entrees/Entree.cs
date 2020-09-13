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
    public abstract class Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <remarks>
        /// In US dollars.
        /// </remarks>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
