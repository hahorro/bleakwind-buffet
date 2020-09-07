/*
 * Author: Hans Ahorro
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a Briarheart Burger
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Briarheart Burger.
    /// </summary>
    /// <remarks>
    /// Comes with buns, ketchup, mustard, pickles, and cheese.
    /// </remarks>
    public class BriarheartBurger
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

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

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Briarheart Burger.
        /// </summary>
        public BriarheartBurger()
        {
            Price = 6.32;
            Calories = 743;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
