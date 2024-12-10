using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            // Mamifer
            Mammal mammal = new Mammal("Os Polar", "Suau");  
            mammal.SetAge(5);  
            //Peix
            Fish fish = new Fish("Peix Pallaso", "Aigua salada"); 
            fish.SetAge(2);  
            //Ocell
            Bird bird = new Bird("Periquito", 2);  
            bird.SetAge(3);  

            // Mostrar informació sobre cada animal
            //Mamifer
            Console.WriteLine("Mammal: \n Name: " + mammal.GetName() +
                              " \n Age: " + mammal.GetAge() +
                              " \n Coat Type: " + mammal.GetHairType());  
            Console.WriteLine("----------------------------");
            //Peix
            Console.WriteLine("Fish:\n Name: " + fish.GetName() +
                              " \n Age: " + fish.GetAge() +
                              " \n Water Type: " + fish.GetWaterType());  // Mostrem les dades del peix
            Console.WriteLine("----------------------------");
            //Ocell
            Console.WriteLine("Bird:\n Name: " + bird.GetName() +
                              "\n Age: " + bird.GetAge() +
                              "\n Wings: " + bird.GetWings());  // Mostrem les dades de l'ocell
        }
    }
}