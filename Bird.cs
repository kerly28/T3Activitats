using System;

namespace T3Activitats
{
    public class Bird : Animal
    {
        private int Wings;

        public int GetWings() { return Wings; }
        public void SetWings(int wings) { this.Wings = wings; }

        // Constructor 
        public Bird(string name, int wings) : base(name, 0)  
        {
            SetWings(wings);
        }
    }
}
