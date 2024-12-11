using System;
using System.Xml.Linq;

namespace T3Activitats
{
    public class Wolf : Animal
    {
        public string ColourType { get; set; }
        public string TodayFood { get; set; }

        public Wolf(string name, int age, string colourType, string todayFood)
            : base("Taylor", 0)
        {
            this.ColourType = colourType;
            this.TodayFood = todayFood;
        }

        public void Sound()
        {
            Console.WriteLine($"{Name} saaays Auuuu Baby, I'm preying on you tonight\r\nHunt you down eat you alive\r\nJust like animals");
        }
    }
}
