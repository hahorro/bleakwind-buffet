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
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <value>
        /// Whether the entree has broccoli or not.
        /// </value>
        public bool Broccoli { get; set; } = true;

        /// <value>
        /// Whether the entree has mushrooms or not.
        /// </value>
        public bool Mushrooms { get; set; } = true;

        /// <value>
        /// Whether the entree has tomatoes or not.
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Whether the entree has cheddar or not.
        /// </value>
        public bool Cheddar { get; set; } = true;

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
                if (!Broccoli) list.Add("Hold broccoli");
                if (!Mushrooms) list.Add("Hold mushrooms");
                if (!Tomato) list.Add("Hold tomato");
                if (!Cheddar) list.Add("Hold cheddar");

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
