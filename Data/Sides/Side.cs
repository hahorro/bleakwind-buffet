/*
 * Author: Hans Ahorro
 * Class name: Side.cs
 * Purpose: Abstract class used to represent a side
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides.
    /// </summary>
    /// <remarks>
    /// The initial size of the side is small.
    /// </remarks>
    public abstract class Side
    {
        /// <summary>
        /// The size of the drink.
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the side.
        /// </summary>
        /// <remarks>
        /// In US dollars.
        /// </remarks>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
