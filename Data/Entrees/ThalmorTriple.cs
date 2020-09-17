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
        /// <value>
        /// Whether the entree has buns or not.
        /// </value>
        public bool Bun { get; set; } = true;

        /// <value>
        /// Whether the entree has ketchup or not.
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// Whether the entree has mustard or not.
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// Whether the entree has pickles or not.
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// Whether the entree has cheese or not.
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <value>
        /// Whether the entree has tomatoes or not.
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Whether the entree has lettuce or not.
        /// </value>
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// Whether the entree has mayo or not.
        /// </value>
        public bool Mayo { get; set; } = true;

        /// <value>
        /// Whether the entree has bacon or not.
        /// </value>
        public bool Bacon { get; set; } = true;

        /// <value>
        /// Whether the entree has eggs or not.
        /// </value>
        public bool Egg { get; set; } = true;

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
