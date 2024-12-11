using System;

namespace T3Activitats
{
    class Program
    {
        public static void Main()
        {
            Turtle turtle = new Turtle("Michelangelo", 100, 15, "freshwater");
            Wolf wolf = new Wolf("Taylor", 7, "gray", "Bella");
            Iguana iguana = new Iguana("Pascal", 5, "green", 1);

            Console.WriteLine("---------------------");
            Console.WriteLine($"Turtle: {turtle.Name}\nAge: {turtle.Age}\nShell Size: {turtle.SizeShell}\nType of Water: {turtle.TypeWater}");
            turtle.Sound();

            Console.WriteLine("---------------------");
            Console.WriteLine($"Wolf: {wolf.Name}\nAge: {wolf.Age}\nColour Type: {wolf.ColourType}\nToday's Food: {wolf.TodayFood}");
            wolf.Sound();

            Console.WriteLine("---------------------");
            Console.WriteLine($"Iguana: {iguana.Name}\nAge: {iguana.Age}\nColour: {iguana.Colour}\nTail Length: {iguana.Tail}");
            iguana.Eat();
        }


    }
}