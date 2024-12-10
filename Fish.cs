using System;

namespace T3Activitats
{
    public class Fish : Animal
    {
        private string WaterType;
        public string GetWaterType() { return WaterType; }
        public void SetWaterType(string waterType) { this.WaterType = waterType; }

        // Constructor 
        public Fish(string name, string waterType) : base(name, 0)
        {
            SetWaterType(waterType);
        }
    }
}