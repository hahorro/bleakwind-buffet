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
        /// <summary>
        /// Whether the entree has broccoli or not.
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Whether the entree has mushrooms or not.
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Whether the entree has tomatoes or not.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Whether the entree has cheddar or not.
        /// </summary>
        public bool Cheddar { get; set; } = true;

        public override double Price { get; }

        public override uint Calories { get; }

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
