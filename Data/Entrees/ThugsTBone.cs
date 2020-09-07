/*
 * Author: Hans Ahorro
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a Thugs T-Bone
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Thugs T-Bone.
    /// </summary>
    public class ThugsTBone
    {
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
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Constructs a new Thus T-Bone.
        /// </summary>
        public ThugsTBone()
        {
            Price = 6.44;
            Calories = 982;
        }

        /// <summary>
        /// Returns a string representing the entree.
        /// </summary>
        /// <returns>The string representing the entree.</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
