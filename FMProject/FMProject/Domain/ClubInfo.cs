using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMProject.Domain
{
   public class ClubInfo
    {
        public string Nation;
        public string ClubName;
        public string StadiumName;
        public int StadiumCapacity;
        public string PredictedLeaguePos;
        public string FinancialStatus;
        public double TransferBudget;
        public double WageBudget;
        public double ScoutBudget;
        public double WageCost;
        public int TotalSponsors;
        public long ClubWealth;
        //These are all of the components of a club which will be displayed on the club info screen. The sponsorship money and transfer budget will will be in use for the Transfer Market
    }
}
