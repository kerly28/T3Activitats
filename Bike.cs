using System;

namespace T3Activitats
{
    public class Bike
    {
        private string Type;
        private string Color;
        private int Speed;

        // Getters
        public string GetType() { return Type; }
        public string GetColor() { return Color; }
        public int GetSpeed() { return Speed; }

        // Setters
        public void SetColor(string color) { this.Color = color; }
        public void SetType(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                throw new ArgumentException("Type cannot be null or empty");
            }
            this.Type = type;
        }

        public void SetSpeed(int speed) { this.Speed = speed; }

        // Constructor
        public Bike(string type, string color, int speed)
        {
            SetType(type);
            SetColor(color);
            SetSpeed(speed);
        }
    }
}
