/*
 * Author: Hans Ahorro
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Philly Poacher
    /// </summary>
    public class PhillyPoacher
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        public bool Sirloin { get => sirloin; set => sirloin = value; }
        public bool Onion { get => onion; set => onion = value; }
        public bool Roll { get => roll; set => roll = value; }
        public double Price { get; }
        public uint Calories { get; }
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

        public PhillyPoacher()
        {
            Price = 7.23;
            Calories = 784;
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
