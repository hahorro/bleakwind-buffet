/*
 * Author: Hans Ahorro
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Warrior Water.
    /// </summary>
    /// Comes with or without ice and a lemon slice.
    /// </remarks>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;

        /// <summary>
        /// An event fired when a property of this object changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Whether the drink has ice or not.
        /// </value>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <value>
        /// Whether the drink has a lemon slice or not.
        /// </value>
        public bool Lemon
        { 
            get => lemon;
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        }

        /// <value>
        /// The size of the drink.
        /// </value>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        public override double Price { get; }

        /// <value>
        /// The calories of the drink.
        /// </value>
        public override uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink.
        /// </summary>
        /// <value>
        /// List of special instructions.
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!ice) list.Add("Hold ice");
                if (lemon) list.Add("Add lemon");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Warrior Water.
        /// </summary>
        public WarriorWater()
        {
            Price = 0;
            Calories = 0;
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size} Warrior Water";
        }
    }
}
