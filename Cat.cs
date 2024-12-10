using System;

namespace T3Activitats
{
    public class Cat
    {
        private string Name;
        private int Age;
        private string Breed;
        private string FavoriteFood;

        // Getters
        public string GetName() { return Name; }
        public int GetAge() { return Age; }
        public string GetBreed() { return Breed; }
        public string GetFavoriteFood () { return FavoriteFood; }
        //Setters
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            Name = name;
        }
        public void SetAge(int age) { this.Age = age; }
        public void SetBreed(string breed) { this.Breed = breed; }
        public void SetFavoriteFood(string favoriteFood) { this.FavoriteFood = favoriteFood; }

        // Accions

        public void Meow()
        {
            Console.WriteLine($"{Name} says: Miaw miaw miaw miaaaaw, miaw miaw miaw miaw miaaaw");
        }
        public void Play()
        {
            Console.WriteLine($"{Name} is playing with a box");
        }
        public void Wash()
        {
            Console.WriteLine($"{Name} is showering with her tongue");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating ñam ñam " + FavoriteFood);
        }
        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting a ant");
            Console.WriteLine("  \\  / \n ( o )\n  | |  \n / \\ \n");
        }

        //Constructor
        public Cat(string name, int age, string breed, string favoriteFood)
        {
            SetName(name);
            SetAge(age);
            SetBreed(breed);
            SetFavoriteFood(favoriteFood);
        }

    }
}
