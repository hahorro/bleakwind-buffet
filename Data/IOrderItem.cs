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
        /// <summary>
        /// The price of the item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of the item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the item.
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
