using System;

namespace T3Activitats
{
    public class Objects
    {
        private string Name;

        //Getters
        public string GetName() { return Name; }
        //Setters
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("You have to mention what kind object is");
            }
        }
        //Constructor
        public Objects(string name)
            {
            SetName(name);
            }

    }
}
