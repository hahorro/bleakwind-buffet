/*
 * Author: Hans Ahorro
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent a Garden Orc Omelette
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        public bool Broccoli { get => broccoli; set => broccoli = value; }
        public bool Mushrooms { get => mushrooms; set => mushrooms = value; }
        public bool Tomato { get => tomato; set => tomato = value; }
        public bool Cheddar { get => cheddar; set => cheddar = value; }
        public double Price { get; }
        public uint Calories { get; }
        public List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();
                if (!broccoli) list.Add("Hold broccoli");
                if (!mushrooms) list.Add("Hold mushrooms");
                if (!tomato) list.Add("Hold tomato");
                if (!cheddar) list.Add("Hold cheddar");

                return list;
            }
        }

        public GardenOrcOmelette()
        {
            Price = 4.57;
            Calories = 404;
        }

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
