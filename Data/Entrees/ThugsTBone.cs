/*
 * Author: Hans Ahorro
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a Thugs T-Bone
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents a Thugs T-Bone
    /// </summary>
    public class ThugsTBone
    {
        public double Price { get; }
        public uint Calories { get; }
        public List<string> SpecialInstructions { get => new List<string>(); }

        public ThugsTBone()
        {
            Price = 6.44;
            Calories = 982;
        }

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
