using System;

namespace T3Activitats
{
    public class Turtle : Animal
    {
        public int SizeShell { get; set; }
        public string TypeWater { get; set; }

        public Turtle(string name, int age, int sizeShell, string typeWater)
            : base("Michelangelo", 0)
        {
            this.SizeShell = sizeShell;
            this.TypeWater = typeWater;
        }

    
        public void Sound()
        {
            Console.WriteLine($"{Name} says aAaaAaaA.");
        }
    }
}
