/*
 * Author: Hans Ahorro
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a Briarheart Burger
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Briarheart Burger.
    /// </summary>
    /// <remarks>
    /// Comes with buns, ketchup, mustard, pickles, and cheese.
    /// </remarks>
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// An event fired when a property of this object changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Whether the entree has buns or not.
        /// </value>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }

        /// <value>
        /// Whether the entree has ketchup or not.
        /// </value>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        /// <value>
        /// Whether the entree has mustard or not.
        /// </value>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <value>
        /// Whether the entree has pickles or not.
        /// </value>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }

        /// <value>
        /// Whether the entree has cheese or not.
        /// </value>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                if (!bun) list.Add("Hold bun");
                if (!ketchup) list.Add("Hold ketchup");
                if (!mustard) list.Add("Hold mustard");
                if (!pickle) list.Add("Hold pickle");
                if (!cheese) list.Add("Hold cheese");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Briarheart Burger.
        /// </summary>
        public BriarheartBurger()
        {
            Price = 6.32;
            Calories = 743;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
