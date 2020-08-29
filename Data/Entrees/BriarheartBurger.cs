/*
 * Author: Hans Ahorro
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a Briarheart Burger
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        public bool Bun { get => bun; set => bun = value; }
        public bool Ketchup { get => ketchup; set => ketchup = value; }
        public bool Mustard { get => mustard; set => mustard = value; }
        public bool Pickle { get => pickle; set => pickle = value; }
        public bool Cheese { get => cheese; set => cheese = value; }
        public double Price { get; }
        public uint Calories { get; }
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

        public BriarheartBurger()
        {
            Price = 6.32;
            Calories = 743;
        }

        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
