/*
 * Author: Hans Ahorro
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Philly Poacher.
    /// </summary>
    /// <remarks>
    /// Comes with sirloin, onions, and roll.
    /// </remarks>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// An event fired when a property of this object changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Whether the entree has sirloin or not.
        /// </value>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
            }
        }

        /// <value>
        /// Whether the entree has onions or not.
        /// </value>
        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
            }
        }

        /// <value>
        /// Whether the entree has a roll or not.
        /// </value>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
            }
        }

        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        public override double Price { get; }

        /// <value>
        /// The calories of the entree.
        /// </value>
        public override uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
        public override List<string> SpecialInstructions
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
