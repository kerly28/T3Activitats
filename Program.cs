using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
          
            Player player1 = new Player("Adriana", 23);
            Player player2 = new Player("Anna", 23);
            Player player3 = new Player("Paula", 22);
            //numero de jugadors
            Player[] teamPlayers = new Player[] { player1, player2, player3 };
            //nom del equip
            Team team = new Team("The mermaids", teamPlayers);
            //mostrar equip
            Console.WriteLine("Team: " + team.GetTeamName());
            Console.WriteLine("Players:");
            //mostrar jugadors (nom i edat)
            foreach (var player in team.GetPlayers())
            {
                Console.WriteLine($"Name: {player.GetName()}, Age: {player.GetAge()}");
            }
        }
    }
}
