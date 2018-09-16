using System;
using System.Xml.Serialization;

namespace FMProject.Domain
{
    [Serializable]
    public class Manager
    {
        //[XmlElement("DOB")]
        public DateTime DateOfBirth;

        [XmlElement("Club")]
        public string AssignedClub { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("secondarynationality")]
        public string SecondaryNationality { get; set; }

        [XmlIgnore]
        public bool? Valid
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(SecondaryNationality))
                {
                    return bool.Parse(SecondaryNationality);
                }

                return null;
            }
        }

        [XmlElement("primarynationality")]
        public string PrimaryNationality { get; set; }
        [XmlIgnore]
        public bool? Valid1
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(PrimaryNationality))
                {
                    return bool.Parse(PrimaryNationality);
                }
                return null;

            }
        }

        [XmlElement("primarylang")]
        public string PrimaryLanguage { get; set; }

        [XmlIgnore]
        public bool? Valid2
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(PrimaryLanguage))
                {
                    return bool.Parse(PrimaryLanguage);
                }
                return null;

            }
        }

        [XmlElement("secondarylang")]
        public string SecondaryLanguage { get; set; }
        [XmlIgnore]
        public bool? Valid3
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(SecondaryLanguage))
                {
                    return bool.Parse(SecondaryLanguage);
                }
                return null;

            }
        }

        [XmlElement("Attacking")]
        public int Attacking { get; set; }

        [XmlElement("Defending")]
        public int Defending { get; set; }

        [XmlElement("Goalkeeping")]
        public int GoalKeeping { get; set; }

        [XmlElement("Mental")]
        public int Mental { get; set; }

        [XmlElement("Tactical")]
        public int Tactical { get; set; }

        [XmlElement("Youthdev")]
        public int YouthDev { get; set; }

        [XmlElement("Technical")]
        public int Technical { get; set; }

        [XmlElement("Fitness")]
        public int Fitness { get; set; }

        [XmlElement("Motivating")]
        public int Motivating { get; set; }

        [XmlElement("Determination")]
        public int Determination { get; set; }

        [XmlElement("Playerknowledge")]
        public int PlayerKnowledge { get; set; }

        [XmlElement("Discipline")]
        public int Discpline { get; set; }

        [XmlElement("Adaptability")]
        public int Adaptability { get; set; }

        [XmlElement("Workratemanager")]
        public int WorkRateManager { get; set; }

        [XmlElement("Mediahandling")]
        public int MediaHandling { get; set; }

        [XmlElement("Managerpoints")]
        public int ManagerPoints { get; set; }

        [XmlElement("Leaguetitles")]
        public int LeagueTitles { get; set; }

        [XmlElement("Seasonsplayed")]
        public int SeasonsPlayed { get; set; }

        [XmlElement("Clubsmanaged")]
        public int NoOfClubsManaged { get; set; }

        [XmlElement("CupWins")]
        public int CupsWins { get; set; }

        [XmlElement("GamesPlayed")]
        public double GamesPlayed { get; set; }

        [XmlElement("Wins")]
        public double Wins { get; set; }

        [XmlElement("Draws")]
        public int Draws { get; set; }

        [XmlElement("Losses")]
        public int Losses { get; set; }

        [XmlElement("GoalsFor")]
        public int GoalsFor { get; set; }

        [XmlElement("GoalsAgainst")]
        public int GoalsAgainst { get; set; }

        [XmlElement("Promotions")]
        public int Promotions { get; set; }

        [XmlElement("SkillCredits")]
        public int SkillCredits { get; set; }

    }

    [System.Xml.Serialization.XmlRoot("ManagerData")]
    [Serializable]
    public class Managers
    {
        [XmlElement("Manager")]
        public Manager[] ManagerAttributes { get; set; }
        //aimed to get all of the teams under the root 'participtants' data within a class called BPLTeams
    }
}


