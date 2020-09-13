/*
 * Author: Hans Ahorro
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Philly Poacher.
    /// </summary>
    /// <remarks>
    /// Comes with sirloin, onions, and roll.
    /// </remarks>
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <summary>
        /// Whether the entree has sirloin or not.
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Whether the entree has onions or not.
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Whether the entree has a roll or not.
        /// </summary>
        public bool Roll { get; set; } = true;

        public override double Price { get; }

        public override uint Calories { get; }

        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!Sirloin) list.Add("Hold sirloin");
                if (!Onion) list.Add("Hold onions");
                if (!Roll) list.Add("Hold roll");

                return list;
            }
        }

        /// <summary>
        /// Construct a new Philly Poacher.
        /// </summary>
        public PhillyPoacher()
        {
            Price = 7.23;
            Calories = 784;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
