/*
 * Author: Hans Ahorro
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        public bool SausageLink { get => sausageLink; set => sausageLink = value; }
        public bool Egg { get => egg; set => egg = value; }
        public bool HashBrowns { get => hashBrowns; set => hashBrowns = value; }
        public bool Pancake { get => pancake; set => pancake = value; }
        public double Price { get; }
        public uint Calories { get; }
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

        public SmokehouseSkeleton()
        {
            Price = 5.62;
            Calories = 602;
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
