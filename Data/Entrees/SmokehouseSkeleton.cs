/*
 * Author: Hans Ahorro
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Smokehouse Skeleton.
    /// </summary>
    /// <remarks>
    /// Comes with sausage links, eggs, hashbrowns, and pancakes.
    /// </remarks>
    public class SmokehouseSkeleton
    {
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// Whether the entree has sausage links or not.
        /// </summary>
        public bool SausageLink { get => sausageLink; set => sausageLink = value; }

        /// <summary>
        /// Whether the entree has eggs or not.
        /// </summary>
        public bool Egg { get => egg; set => egg = value; }

        /// <summary>
        /// Whether the entree has hash browns or not.
        /// </summary>
        public bool HashBrowns { get => hashBrowns; set => hashBrowns = value; }

        /// <summary>
        /// Whether the entree has pancakes or not.
        /// </summary>
        public bool Pancake { get => pancake; set => pancake = value; }

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
                if (!sausageLink) list.Add("Hold sausage");
                if (!egg) list.Add("Hold eggs");
                if (!hashBrowns) list.Add("Hold hash browns");
                if (!pancake) list.Add("Hold pancakes");

                return list;
            }
        }

        /// <summary>
        /// Constructs a new Smokehouse Skeleton.
        /// </summary>
        public SmokehouseSkeleton()
        {
            Price = 5.62;
            Calories = 602;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
