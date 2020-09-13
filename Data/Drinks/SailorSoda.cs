/*
 * Author: Hans Ahorro
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Sailor Soda.
    /// </summary>
    /// <remarks>
    /// Comes in several flavors with or without ice.
    /// </remarks>
    public class SailorSoda : Drink, IOrderItem
    {
        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// The flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: return 1.42;
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: return 117;
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!Ice) list.Add("Hold ice");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Sailor Soda.
        /// </summary>
        public SailorSoda()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
