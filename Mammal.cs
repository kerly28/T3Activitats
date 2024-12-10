using System;

namespace T3Activitats
{
    public class Mammal : Animal
    {
        private string HairType;
        public string GetHairType() { return HairType; }
        public void SetHairType(string hairType) { this.HairType = hairType; }

        // Constructor 
        public Mammal(string name, string hairType) : base(name, 0)
        {
            SetHairType(hairType);
        }
    }
}