using FMProject.Data.FixedGameData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FMProject.Domain
{
    public class GameComponents
    {
        public GameComponents()
        {
            this.Teams = new List<BPLTeams>();            
            this.Fixtures = new List<List<Fixture>>();
        }

        public List<Player> GetCurrentPlayers()
        {
            return this.Players.PlayerAttributes
                .Where(p => p.AssignedClub == this.ManagerEntity.AssignedClub).ToList();
        }

        public BPLTeams GetCurrentTeam()
        {
            return this.Teams.First(t => t.ClubName == this.ManagerEntity.AssignedClub);
        }

        public double CurrentTeamAvgTotalAbility()
        {         
            var clubPlayers = this.GetCurrentPlayers();
            var playerability = 0.0;
            var SumAverageAbility = 0.0;

            foreach (var player in clubPlayers)
            {
                // Note: this is probably buggy. Players with multiple positions might not be worked out correctly
                if (player.Positions.Contains("AM R") || player.Positions.Contains("AM L") || player.Positions.Contains("AM C"))
                {
                    int totalAM = player.Vision + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Crossing + player.Acceleration;
                    double avgability = (totalAM + 3.5) / 9;
                    playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                }
                if (player.Positions.Contains("ST") || player.Positions.Contains("F C"))
                {
                    int totalST = player.Strength + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Heading + player.Acceleration;
                    double avgability = totalST / 9;
                    playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                }
                if (player.Positions.Contains("M C") || player.Positions.Contains("M R") || player.Positions.Contains("M L") || player.Positions.Contains("DM"))
                {
                    int totalM = player.WorkRate + player.Vision + player.Tackling + player.Strength + player.Passing + player.Marking + player.Finishing + player.Dribbling + player.Crossing;
                    double avgability = totalM / 9;
                    playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                }
                if (player.Positions.Contains("D C") || player.Positions.Contains("D R") || player.Positions.Contains("D L"))
                {
                    int totalD = player.WorkRate + player.Tackling + player.Strength + player.Passing + player.Pace + player.Marking + player.Heading + player.DefPos;
                    double avgability = totalD / 8;
                    playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                }
                if (player.Positions.Contains("G"))
                {
                    int totalGK = player.Reflexes + player.Passing + player.OneVsOne + player.Handling + player.CommandArea + player.AerialAbility;
                    double avgability = totalGK / 6;
                    playerability = Math.Round(avgability * 5, 0, MidpointRounding.AwayFromZero);
                }

                SumAverageAbility += playerability;
            }

            double TeamAverageAbility = SumAverageAbility / clubPlayers.Count();
            return Math.Round(TeamAverageAbility, 0, MidpointRounding.AwayFromZero);
        }

        public List<BPLTeams> Teams { get; set; }
        public Players Players { get; set; }
        public Manager ManagerEntity { get; set; }
        public int Round { get; set; }
        public List<List<Fixture>> Fixtures { get; set; }
        public int GameWeek { get; set; }
    }
}
//This is a set of declarations linking classes within the Domain. This makes it more accessible and clearer to access classes from the User Interface
        //This is a set of declarations linking classes within the Domain. This makes it more accessible and clearer to access classes from the User Interface