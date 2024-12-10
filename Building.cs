using System;

namespace T3Activitats
{
    public class Building
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Floors { get; set; }
        public double Area { get; set; } 
        public string Type { get; set; }

        // Constructor
        public Building(string name, string location, int floors, double area, string type)
        {
            Name = name;
            Location = location;
            Floors = floors;
            Area = area;
            Type = type;
        }
    }
}
