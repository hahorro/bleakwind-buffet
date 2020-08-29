using System;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace DataExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = new MarkarthMilk() { Size = Size.Large, Ice = true };

            // Print price and calorie information along with ToString
            Console.WriteLine($"{thing.Price.ToString()}, { thing.Calories}");
            Console.WriteLine(thing.ToString());

            foreach(string s in thing.SpecialInstructions)
            {
                Console.WriteLine(s);
            }
        }
    }
}
