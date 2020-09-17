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
    public abstract class Side : IOrderItem
    {
        /// <value>
        /// The size of the side.
        /// </value>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the side.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        public abstract double Price { get; }

        /// <value>
        /// The calories of the side.
        /// </value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
        public abstract List<string> SpecialInstructions { get; }
    }
}
