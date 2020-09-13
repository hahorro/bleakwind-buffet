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
