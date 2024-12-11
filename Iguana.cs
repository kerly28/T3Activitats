using System;

namespace T3Activitats
{
    public class Iguana:Animal
    {
        //Getters and Setters
        public string Colour { get; set; }
        public int Tail { get; set; }
        //Constructor
        public Iguana(string name, int age, string colour, int tail)
            : base("Pascal", 0)
        {
            this.Colour = colour;
            this.Tail = tail;
        }
        //Methods
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating some insects ñam ñam");
        }
    }
}
