/*
 * Author: Hans Ahorro
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Smokehouse Skeleton.
    /// </summary>
    /// <remarks>
    /// Comes with sausage links, eggs, hashbrowns, and pancakes.
    /// </remarks>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// An event fired when a property of this object changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Whether the entree has sausage links or not.
        /// </value>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
            }
        }

        /// <value>
        /// Whether the entree has eggs or not.
        /// </value>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }

        /// <value>
        /// Whether the entree has hash browns or not.
        /// </value>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
            }
        }

        /// <value>
        /// Whether the entree has pancakes or not.
        /// </value>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
            }
        }

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
