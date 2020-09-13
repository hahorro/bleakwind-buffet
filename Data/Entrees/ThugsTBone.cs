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
    public class ThugsTBone : Entree, IOrderItem
    {
        public override double Price { get; }

        public override uint Calories { get; }

        public override List<string> SpecialInstructions { get => new List<string>(); }

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
