/*
 * Author: Hans Ahorro
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent a Garden Orc Omelette
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Garden Orc Omelette.
    /// </summary>
    /// <remarks>
    /// Comes with broccoli, mushrooms, tomatoes, and cheddar.
    /// </remarks>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// An event fired when a property of this object changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Whether the entree has broccoli or not.
        /// </value>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
            }
        }

        /// <value>
        /// Whether the entree has mushrooms or not.
        /// </value>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
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
        /// Whether the entree has cheddar or not.
        /// </value>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                if (!broccoli) list.Add("Hold broccoli");
                if (!mushrooms) list.Add("Hold mushrooms");
                if (!tomato) list.Add("Hold tomato");
                if (!cheddar) list.Add("Hold cheddar");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Garden Orc Omelette.
        /// </summary>
        public GardenOrcOmelette()
        {
            Price = 4.57;
            Calories = 404;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
