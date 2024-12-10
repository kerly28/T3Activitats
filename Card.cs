using System;

namespace T3Activitats
{
    public class Card
    {
        private int Number;
        private string Suit;

        // Getters
        public int GetNumber() { return Number; }
        public string GetSuit() { return Suit; }

        // Setters
        public void SetNumber(int number)
        {
            if (number < 1 || number > 13)
                throw new ArgumentException("The number must be between 1 and 13");
            Number = number;
        }

        public void SetSuit(string suit)
        {
            if (string.IsNullOrEmpty(suit)) 
                throw new ArgumentException("The suit must have a value; it cannot be empty");
            Suit = suit;
        }

        // Constructor
        public Card(int number, string suit)
        {
            SetNumber(number);
            SetSuit(suit);
        }
    }
}
