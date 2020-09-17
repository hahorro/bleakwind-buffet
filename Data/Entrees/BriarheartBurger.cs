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
