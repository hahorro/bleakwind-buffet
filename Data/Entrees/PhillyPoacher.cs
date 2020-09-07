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
    public class PhillyPoacher
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// Whether the entree has sirloin or not.
        /// </summary>
        public bool Sirloin { get => sirloin; set => sirloin = value; }

        /// <summary>
        /// Whether the entree has onions or not.
        /// </summary>
        public bool Onion { get => onion; set => onion = value; }

        /// <summary>
        /// Whether the entree has a roll or not.
        /// </summary>
        public bool Roll { get => roll; set => roll = value; }

        /// <summary>
        /// The price of the entree.
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// The amount of calories in the entree.
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// Special instructions attached to the entree.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!sirloin) list.Add("Hold sirloin");
                if (!onion) list.Add("Hold onions");
                if (!roll) list.Add("Hold roll");

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
