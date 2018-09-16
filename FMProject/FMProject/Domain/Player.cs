using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FMProject.Data.FixedGameData
{
    [Serializable]
    public class Player
    {
        [System.Xml.Serialization.XmlElement("Nation")]
        public string Nationality { get; set; }

        [System.Xml.Serialization.XmlElement("Age")]
        public int Age { get; set; }

        [System.Xml.Serialization.XmlElement("Name")]
        public string FirstName { get; set; }

        [System.Xml.Serialization.XmlElement("Position")]
        public string Positions { get; set; }

        //public System.DateTime DateOfBirth { get; set;}
        //public bool TransferListed { get; set;}
        [System.Xml.Serialization.XmlElement("MarketValue")]
        public string MarketValue { get; set; }

        [System.Xml.Serialization.XmlElement("Wage")]
        public int ContractValue { get; set; }

        [System.Xml.Serialization.XmlElement("Happiness")]
        public string Happiness { get; set; }

        [System.Xml.Serialization.XmlElement("Passing")]
        public int Passing { get; set; }

        [System.Xml.Serialization.XmlElement("Crossing")]
        public int Crossing { get; set; }

        [System.Xml.Serialization.XmlElement("Finishing")]
        public int Finishing { get; set; }

        [System.Xml.Serialization.XmlElement("LongShots")]
        public int LongShot { get; set; }

        [System.Xml.Serialization.XmlElement("Dribbling")]
        public int Dribbling { get; set; }

        [System.Xml.Serialization.XmlElement("Movement")]
        public int Movement { get; set; }

        [System.Xml.Serialization.XmlElement("Vision")]
        public int Vision { get; set; }

        [System.Xml.Serialization.XmlElement("Strength")]
        public int Strength { get; set; }

        [System.Xml.Serialization.XmlElement("Pace")]
        public int Pace { get; set; }

        [System.Xml.Serialization.XmlElement("Acceleration")]
        public int Acceleration { get; set; }

        [System.Xml.Serialization.XmlElement("Stamina")]
        public int Stamina { get; set; }

        [System.Xml.Serialization.XmlElement("Heading")]
        public int Heading { get; set; }

        [System.Xml.Serialization.XmlElement("Tackling")]
        public int Tackling { get; set; }

        [System.Xml.Serialization.XmlElement("Anticiptation")]
        public int Anticiptation { get; set; }

        [System.Xml.Serialization.XmlElement("Marking")]
        public int Marking { get; set; }

        [System.Xml.Serialization.XmlElement("Positioning")]
        public int DefPos { get; set; }

        [System.Xml.Serialization.XmlElement("WorkRate")]
        public int WorkRate { get; set; }

        [System.Xml.Serialization.XmlElement("Leadership")]
        public int Leadership { get; set; }

        [XmlElement("Club")]
        public string AssignedClub { get; set; }

        [System.Xml.Serialization.XmlElement("OnevOne")]
        public int OneVsOne { get; set; }

        [System.Xml.Serialization.XmlElement("FreeKick")]
        public string FreeKick { get; set; }

        [System.Xml.Serialization.XmlElement("Handling")]
        public int Handling { get; set; }

        [System.Xml.Serialization.XmlElement("CommandArea")]
        public int CommandArea { get; set; }

        [System.Xml.Serialization.XmlElement("Reflexes")]
        public int Reflexes { get; set; }

        [System.Xml.Serialization.XmlElement("AerialAbility")]
        public int AerialAbility { get; set; }

        [System.Xml.Serialization.XmlElement("Condition")]
        public string Condition { get; set; }

        [XmlElement("MatchPosition")]
        public string MatchPosition { get; set; }

        [XmlElement("ClubStatus")]
        public string ClubStatus { get; set; }

        [XmlElement("TransferStatus")]
        public string TransferStatus { get; set; }

        [XmlElement("MainClub")]
        public string MainClub { get; set; }

        public int Goals = 0;
        public int Assists = 0;
        public int CleanSheets = 0;
        public int YelCards = 0;
        public int RedCards = 0;
        public int Form = 0;
        //These are a series of declarations about the individual's players attribute and characteristics
    }

    [System.Xml.Serialization.XmlRoot("players")]
    [Serializable]
    public class Players
    {
        [XmlElement("player")]
        public Player[] PlayerAttributes { get; set; }
        //aimed to get all of the teams under the root 'participtants' data within a class called BPLTeams
    }
}
