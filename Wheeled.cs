using System;

namespace T3Activitats
{
    public class Wheeled : Vehicle1
    {
        public int Wheels { get; set; }

        public Wheeled(string name, int wheels) : base(name)
        {
            Wheels = wheels;
        }
    }
}

