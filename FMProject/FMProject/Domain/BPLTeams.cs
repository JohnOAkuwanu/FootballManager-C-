using System;
using System.Xml.Serialization;

namespace FMProject.Domain
{
    [Serializable]
    public class BPLTeams
    {
        [System.Xml.Serialization.XmlElement("participantname")]
        public string ClubName { get; set; }

        [System.Xml.Serialization.XmlElement("league")]
        public string League { get; set; }

        [System.Xml.Serialization.XmlElement("rank")]
        public string LeaguePos { get; set; }

        [System.Xml.Serialization.XmlElement("played")]
        public int GamesPlayed { get; set; }

        [System.Xml.Serialization.XmlElement("wins")]
        public int Wins { get; set; }

        [System.Xml.Serialization.XmlElement("draws")]
        public int Draws { get; set; }

        [System.Xml.Serialization.XmlElement("losses")]
        public int Losses { get; set; }

        [System.Xml.Serialization.XmlElement("GF")]
        public int GF { get; set; }

        [System.Xml.Serialization.XmlElement("goalsagainst")]
        public int GoalsAgainst { get; set; }

        [System.Xml.Serialization.XmlElement("info")]
        public string LeaguePosInfo { get; set; }

        [System.Xml.Serialization.XmlElement("participantid")]
        public int ClubID { get; set; }

        [System.Xml.Serialization.XmlElement("clubwealth")]
        public decimal ClubWealth { get; set; }

        [System.Xml.Serialization.XmlElement("totalsponsors")]
        public decimal TotalSponsors { get; set; }

        [System.Xml.Serialization.XmlElement("transferbudget")]
        public decimal TransferBudget { get; set; }

        [System.Xml.Serialization.XmlElement("wagebudget")]
        public decimal WageBudget { get; set; }

        [System.Xml.Serialization.XmlElement("scoutingbudget")]
        public decimal ScoutingBudget { get; set; }

        [System.Xml.Serialization.XmlElement("WageCost")]
        public decimal WageCost { get; set; }
        //This aimed to serialized data from the xml file and assign it to a string or integer
    }

    [Serializable]
    [XmlRoot("BPLLegaueData")]
    public class BPLLeagueData
    {
        [XmlArray("participants")]
        [XmlArrayItem("participant", typeof(BPLTeams))]
        public BPLTeams[] Participants { get; set; }
        //aimed to get all of the teams under the root 'participtants' data within a class called BPLTeams
    }
}
