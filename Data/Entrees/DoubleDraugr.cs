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
    public class DoubleDraugr
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        /// <summary>
        /// Whether the entree has buns or not.
        /// </summary>
        public bool Bun { get => bun; set => bun = value; }

        /// <summary>
        /// Whether the entree has ketchup or not.
        /// </summary>
        public bool Ketchup { get => ketchup; set => ketchup = value; }

        /// <summary>
        /// Whether the entree has mustard or not.
        /// </summary>
        public bool Mustard { get => mustard; set => mustard = value; }

        /// <summary>
        /// Whether the entree has pickles or not.
        /// </summary>
        public bool Pickle { get => pickle; set => pickle = value; }

        /// <summary>
        /// Whether the entree has cheese or not.
        /// </summary>
        public bool Cheese { get => cheese; set => cheese = value; }

        /// <summary>
        /// Whether the entree has tomatoes or not.
        /// </summary>
        public bool Tomato { get => tomato; set => tomato = value; }

        /// <summary>
        /// Whether the entree has lettuce or not.
        /// </summary>
        public bool Lettuce { get => lettuce; set => lettuce = value; }

        /// <summary>
        /// Whether the entree has mayo or not.
        /// </summary>
        public bool Mayo { get => mayo; set => mayo = value; }

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
                if (!bun) list.Add("Hold bun");
                if (!ketchup) list.Add("Hold ketchup");
                if (!mustard) list.Add("Hold mustard");
                if (!pickle) list.Add("Hold pickle");
                if (!cheese) list.Add("Hold cheese");
                if (!tomato) list.Add("Hold tomato");
                if (!lettuce) list.Add("Hold lettuce");
                if (!mayo) list.Add("Hold mayo");

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
