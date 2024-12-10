using System;

namespace T3Activitats
{
    // Class Player
    public class Player
    {
        private string Name;
        private int Age;

        public string GetName() { return this.Name; }
        public int GetAge() { return this.Age; }
        public string SetName(string Name) { return this.Name = Name; }
        public int SetAge(int Age) { return this.Age = Age; }

        public Player(string name, int age)
        {
           this.Name=name;
           this.Age=age;
        }
    }
 
}
