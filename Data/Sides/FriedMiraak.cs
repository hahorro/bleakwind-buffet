/*
 * Author: Hans Ahorro
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a Fried Miraak
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents a Fried Miraak.
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// The price of the side.
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: return 1.78;
                }
            }
        }

        /// <value>
        /// The calories of the side.
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: return 151;
                }
            }
        }

        /// <summary>
        /// Special instructions to prepare the side.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
        public override List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Constructs a new Fried Miraak.
        /// </summary>
        public FriedMiraak()
        {
        }

        /// <summary>
        /// Returns a string representing the side.
        /// </summary>
        /// <returns>The string representing the side.</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
