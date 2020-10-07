/*
 * Author: Hans Ahorro
 * Class name: MarkathMilk.cs
 * Purpose: Class used to represent a Markarth Milk
 */

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Markarth Milk.
    /// </summary>
    /// <remarks>
    /// Comes with or without ice.
    /// </remarks>
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        private bool ice = false;
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
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: return 1.05;
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
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: return 56;
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

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Markarth Milk.
        /// </summary>
        public MarkarthMilk()
        {
        }

        /// <summary>
        /// Returns a string representing the drink.
        /// </summary>
        /// <returns>The string representing the drink.</returns>
        public override string ToString()
        {
            return $"{size} Markarth Milk";
        }
    }
}
