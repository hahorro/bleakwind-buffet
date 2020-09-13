/*
 * Author: Hans Ahorro
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents Dragonborn Waffle Fries.
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: return 0.42;
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: return 77;
                }
            }
        }

        public override List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Constructs a new Dragonborn Waffle Fries.
        /// </summary>
        public DragonbornWaffleFries()
        {
        }

        /// <summary>
        /// Returns a string representing the side.
        /// </summary>
        /// <returns>The string representing the side.</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
