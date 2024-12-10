using System;

namespace T3Activitats
{
    public class Team
    {
        private string TeamName;
        private Player[] Players; 

        public string GetTeamName() { return this.TeamName; }
        public Player[] GetPlayers() { return this.Players; }

        public void SetTeamName(string TeamName) { this.TeamName = TeamName; }
        public void SetPlayers(Player[] Players) { this.Players = Players; }

        public Team(string teamName, Player[] players)
        {
            this.TeamName = teamName;
            this.Players = players;
        }
    }
}
