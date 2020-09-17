/*
 * Author: Hans Ahorro
 * Class name: IOrderItem.cs
 * Purpose: Interface used to represent an orderable item
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface representing an orderable item.
    /// </summary>
    public interface IOrderItem
    {
        /// <value>
        /// The price of the item.
        /// </value>
        double Price { get; }

        /// <value>
        /// The calories of the item.
        /// </value>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the item.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
        List<string> SpecialInstructions { get; }
    }
}
