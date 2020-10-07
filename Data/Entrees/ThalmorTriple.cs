/*
 * Author: Hans Ahorro
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent a Thalmor Triple
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Thalmor Triple.
    /// </summary>
    /// <remarks>
    /// Comes with buns, ketchup, mustard, pickles,
    /// cheese, tomatoes, lettuce, mayo, bacon, and eggs.
    /// </remarks>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

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

        /// <value>
        /// Whether the entree has tomatoes or not.
        /// </value>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <value>
        /// Whether the entree has lettuce or not.
        /// </value>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <value>
        /// Whether the entree has mayo or not.
        /// </value>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <value>
        /// Whether the entree has bacon or not.
        /// </value>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
            }
        }

        /// <value>
        /// Whether the entree has eggs or not.
        /// </value>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
                if (!tomato) list.Add("Hold tomato");
                if (!lettuce) list.Add("Hold lettuce");
                if (!mayo) list.Add("Hold mayo");
                if (!bacon) list.Add("Hold bacon");
                if (!egg) list.Add("Hold egg");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Thalmor Triple.
        /// </summary>
        public ThalmorTriple()
        {
            Price = 8.32;
            Calories = 943;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
