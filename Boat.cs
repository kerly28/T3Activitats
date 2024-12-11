using System;

namespace T3Activitats
{
    public class Boat : Vehicle1
    {
        public string Type { get; set; }

        public Boat(string name, string type) : base(name)
        {
            Type = type;
        }
    }
}

