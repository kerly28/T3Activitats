//using System;

//namespace T3Activitats
//{
//    public class Lamp
//    {
//        private bool IsOn;
//        private string Color;

//        // Getters
//        public bool GetIsOn() { return IsOn; }
//        public string GetColor() { return Color; }
//        //Setters
//        public void SetIsOn(bool isOn) { IsOn = isOn; }
//        public void SetColor(string color)

//        { if (string.IsNullOrEmpty(color))
//            {
//                throw new ArgumentException("Color cannot be null or empty");
//            }

//            Color = color; }
//        // Constructor
//        public Lamp (bool isOn, string color)
//        {
//            SetIsOn(isOn);
//            SetColor(color);
//        }
//    }
//}
using System;

namespace T3Activitats
{
    public class Lamp : Objects
    {
        private int Number;
        private string Suit;

        // Getter
        public int GetNumber() { return Number; }
        public string GetSuit() { return Suit; }

        // Setter
        public void SetNumber(int number)
        {
            if (number < 1 || number > 13)
            {
                throw new ArgumentException("The number must be between 1 and 13.");
            }
            Number = number;
        }

        public void SetSuit(string suit)
        {
            if (string.IsNullOrEmpty(suit))
            {
                throw new ArgumentException("The suit must have a value; it cannot be empty.");
            }
            Suit = suit;
        }

        // Constructor
        public Lamp(int number, string suit, string name) : base(name)
        {
            SetNumber(number);
            SetSuit(suit);
        }
    }
}
