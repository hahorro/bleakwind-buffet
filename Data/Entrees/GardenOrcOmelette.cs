/*
 * Author: Hans Ahorro
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent a Garden Orc Omelette
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Garden Orc Omelette.
    /// </summary>
    /// <remarks>
    /// Comes with broccoli, mushrooms, tomatoes, and cheddar.
    /// </remarks>
    public class GardenOrcOmelette
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// Whether the entree has broccoli or not.
        /// </summary>
        public bool Broccoli { get => broccoli; set => broccoli = value; }

        /// <summary>
        /// Whether the entree has mushrooms or not.
        /// </summary>
        public bool Mushrooms { get => mushrooms; set => mushrooms = value; }

        /// <summary>
        /// Whether the entree has tomatoes or not.
        /// </summary>
        public bool Tomato { get => tomato; set => tomato = value; }

        /// <summary>
        /// Whether the entree has cheddar or not.
        /// </summary>
        public bool Cheddar { get => cheddar; set => cheddar = value; }

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
