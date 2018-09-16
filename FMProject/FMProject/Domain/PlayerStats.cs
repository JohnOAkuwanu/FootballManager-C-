using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMProject.Domain
{
   public  class PlayerStats
    {
        public int Goals;
        public int Assists;
        public int CleanSheets;
        public int YelCards;
        public int RedCards;
        public int Form;
        //This is a link to the players and their Player stats. This will be represented in the Player Statistics. This is only in game stats and they are volatile. This is created to communicate between screens
    }
}
