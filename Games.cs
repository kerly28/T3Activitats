using System;

namespace T3Activitats
{
    public class Games
    {
        public string Type { get; set; }
        public int[] Players { get; set; }

        // Constructor de la clase Games
        public Games(string type, int[] players)
        {
            Type = type;
            Players = players;
        }
    }
}
