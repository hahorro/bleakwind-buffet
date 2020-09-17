/*
 * Author: Hans Ahorro
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent a Double Draugr
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Double Draugr.
    /// </summary>
    /// <remarks>
    /// Comes with buns, ketchup, mustard, pickles,
    /// cheese, tomatoes, lettuce, and mayo.
    /// </remarks>
    public class DoubleDraugr : Entree, IOrderItem
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

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Double Draugr.
        /// </summary>
        public DoubleDraugr()
        {
            Price = 7.32;
            Calories = 843;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
