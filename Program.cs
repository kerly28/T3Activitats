using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Lamp lamp1 = new Lamp(true, "Red");
                Lamp lamp2 = new Lamp(false, ""); 
                Lamp lamp3 = new Lamp(true, "Green");

                // Missatges

                Console.WriteLine("Lamp 1: IsOn = " + lamp1.GetIsOn() + ", Color = " + lamp1.GetColor());
                Console.WriteLine("Lamp 2: IsOn = " + lamp2.GetIsOn() + ", Color = " + lamp2.GetColor());
                Console.WriteLine("Lamp 3: IsOn = " + lamp3.GetIsOn() + ", Color = " + lamp3.GetColor());
            }
            catch (ArgumentException ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
