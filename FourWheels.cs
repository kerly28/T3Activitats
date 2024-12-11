using System;

namespace T3Activitats
{
    public class FourWheels : Wheeled
    {
        public string Type { get; set; }
        public int Speed { get; set; }

        public FourWheels(string name, int wheels, string type, int speed) : base(name, wheels)
        {
            Type = type;
            Speed = speed;
        }
    }
}

