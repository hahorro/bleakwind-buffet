/*
 * Author: Hans Ahorro
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee
 */

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Candlehearth Coffee.
    /// </summary>
    /// <remarks>
    /// Comes with or without ice, caffeinated/decaf,
    /// and allows for cream to be added.
    /// </remarks>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
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
        /// Whether the drink is caffeinated or not.
        /// </value>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <value>
        /// Whether the drink has room for cream or not.
        /// </value>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
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
        public override double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: return 0.75;
                }
            }
        }

        /// <value>
        /// The calories of the drink.
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: return 7;
                }
            }
        }

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
                if (ice) list.Add("Add ice");
                if (roomForCream) list.Add("Add cream");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Candlehearth Coffee.
        /// </summary>
        public CandlehearthCoffee()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size}{(decaf ? " Decaf" : "")} Candlehearth Coffee";
        }
    }
}
