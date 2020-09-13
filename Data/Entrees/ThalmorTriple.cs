/*
 * Author: Hans Ahorro
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent a Thalmor Triple
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Thalmor Triple.
    /// </summary>
    /// <remarks>
    /// Comes with buns, ketchup, mustard, pickles,
    /// cheese, tomatoes, lettuce, mayo, bacon, and eggs.
    /// </remarks>
    public class ThalmorTriple : Entree, IOrderItem
    {
        /// <summary>
        /// Whether the entree has buns or not.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Whether the entree has ketchup or not.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Whether the entree has mustard or not.
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Whether the entree has pickles or not.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Whether the entree has cheese or not.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Whether the entree has tomatoes or not.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Whether the entree has lettuce or not.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Whether the entree has mayo or not.
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Whether the entree has bacon or not.
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Whether the entree has eggs or not.
        /// </summary>
        public bool Egg { get; set; } = true;

        public override double Price { get; }

        public override uint Calories { get; }

        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!Bun) list.Add("Hold bun");
                if (!Ketchup) list.Add("Hold ketchup");
                if (!Mustard) list.Add("Hold mustard");
                if (!Pickle) list.Add("Hold pickle");
                if (!Cheese) list.Add("Hold cheese");
                if (!Tomato) list.Add("Hold tomato");
                if (!Lettuce) list.Add("Hold lettuce");
                if (!Mayo) list.Add("Hold mayo");
                if (!Bacon) list.Add("Hold bacon");
                if (!Egg) list.Add("Hold egg");

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
