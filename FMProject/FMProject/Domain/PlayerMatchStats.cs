using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMProject.Domain
{
    public class PlayerMatchStats
    {
        public int MatchRating;
        public int Goals;
        public int Shots;
        public int OnTarget;
        public int PassesSuccess;
        public int Assists;
        public int Crosses;
        public int DribblesSuccess;
        public int Tackles;
        public int Clearances;
        public int Interceptions;
        public int Energy;
        //This is a link to the players and their in-game match player stats. This is only in-game match stats and they are volatile.

    }
}
