/*
 * Author: Hans Ahorro
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent a Thalmor Triple
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Thalmor Triple
    /// </summary>
    public class ThalmorTriple
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

        public bool Bun { get => bun; set => bun = value; }
        public bool Ketchup { get => ketchup; set => ketchup = value; }
        public bool Mustard { get => mustard; set => mustard = value; }
        public bool Pickle { get => pickle; set => pickle = value; }
        public bool Cheese { get => cheese; set => cheese = value; }
        public bool Tomato { get => tomato; set => tomato = value; }
        public bool Lettuce { get => lettuce; set => lettuce = value; }
        public bool Mayo { get => mayo; set => mayo = value; }
        public bool Bacon { get => bacon; set => bacon = value; }
        public bool Egg { get => egg; set => egg = value; }
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
                if (!tomato) list.Add("Hold tomato");
                if (!lettuce) list.Add("Hold lettuce");
                if (!mayo) list.Add("Hold mayo");
                if (!bacon) list.Add("Hold bacon");
                if (!egg) list.Add("Hold egg");

                return list;
            }
        }

        public ThalmorTriple()
        {
            Price = 8.32;
            Calories = 943;
        }

        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
