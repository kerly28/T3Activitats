using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            Card card = new Card(1, "Hearts");
            Card card1 = new Card(3, "Clover");
            Card card2 = new Card(5, "Diamonds");
            Card card3 = new Card(7, "Spades");
            
            //Mostrar cartes
          
            Console.WriteLine("\n Card 1: " + card.GetNumber() + " of " + card.GetSuit());
            Console.WriteLine("\n Card 2: " + card1.GetNumber() + " of " + card1.GetSuit());
            Console.WriteLine("\n Card 3: " + card2.GetNumber() + " of " + card2.GetSuit());
            Console.WriteLine("\n Card 4: " + card3.GetNumber() + " of " + card3.GetSuit());

        }
    }
}