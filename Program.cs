using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            // Bike 1
           
                Bike bike1 = new Bike("Mountain", "Red", 20); 
                Console.WriteLine("Bike 1:\n -Type = " + bike1.GetType() + "\n -Color = " + bike1.GetColor() + "\n -Speed = " + bike1.GetSpeed());
                Console.WriteLine("-------------------------------------------------");

            // Bike 2
            try
            {
                Bike bike2 = new Bike("", "Blue", 15); 
                Console.WriteLine("Bike 2: \n -Type = " + bike2.GetType() + " \n -Color = " + bike2.GetColor() + "\n -Speed = " + bike2.GetSpeed());
                Console.WriteLine("-------------------------------------------------");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error en Bike 2: " + ex.Message);
                Console.WriteLine("-------------------------------------------------");
            }

            //Bike 3
           
                Bike bike3 = new Bike("Road", "Green", -5); 
                Console.WriteLine("Bike 3: \n -Type = " + bike3.GetType() + "\n -Color = " + bike3.GetColor() + "\n -Speed = " + bike3.GetSpeed());
                Console.WriteLine("-------------------------------------------------");       
        }
    }
}
