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
    public class BriarheartBurger : Entree, IOrderItem
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
