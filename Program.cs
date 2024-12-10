using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            // gatito
            Cat myCat = new Cat("Luchy", 3, "Snowshoe", "Salmon");

            // Informacio Luchy
            Console.WriteLine("Cat Info:");
            Console.WriteLine("Name: " + myCat.GetName());
            Console.WriteLine("Age: " + myCat.GetAge());
            Console.WriteLine("Breed: " + myCat.GetBreed());
            Console.WriteLine("Favorite Food: " + myCat.GetFavoriteFood());

            // Accioons luchy
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nActions:");
            myCat.Meow();
            myCat.Play();
            myCat.Wash();
            myCat.Eat();
            myCat.Hunt();
        }
    }
}
