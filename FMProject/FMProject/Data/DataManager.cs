using FMProject.Data.FixedGameData;
using FMProject.Domain;
using System.IO;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace FMProject.Data
{
    public static class DataManager
    {
        public static List<string> ListCountries()
        {
            XDocument obj = XDocument.Load("D:\\Comp Sci 1st Year\\Self-FM Project\\FMProject\\FMProject\\Data\\FixedGameData\\CountriesList.xml");
            return obj.Descendants("country").Select(x => x.Attribute("countryName").Value).ToList();
        }

        public static List<string> ListLanguages()
        {
            XDocument LangObj = XDocument.Load("D:\\Comp Sci 1st Year\\Self-FM Project\\FMProject\\FMProject\\Data\\FixedGameData\\LanguagesList.xml");
            return LangObj.Descendants("language").Select(x => x.Attribute("languageName").Value).ToList();
        }

        public static List<BPLTeams> LoadAllTeams()
        {
            string path = "D:\\Comp Sci 1st Year\\Self-FM Project\\FMProject\\FMProject\\Data\\FixedGameData\\BPLLeagueDataNew.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(BPLLeagueData));
            using (var reader = new StreamReader(path))
            {
                var leagueData = (BPLLeagueData)serializer.Deserialize(reader);
                return leagueData.Participants.ToList();
            }
        }

        public static Managers LoadManager()
        {
            string path = "D:\\Comp Sci 1st Year\\Self-FM Project\\FMProject\\FMProject\\Data\\CurrentGameData\\ManagerProfile.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Managers));
            using (var reader = new StreamReader(path))
            {
                var ManagerData = (Managers)serializer.Deserialize(reader);
                return ManagerData;
            }
        }            
              
        public static string SerialiseToXml<T>(T objectToSerialise)
        {
            var serialiser = new XmlSerializer(typeof(T));
            var result = string.Empty;

            using (var stringWriter = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    serialiser.Serialize(writer, objectToSerialise);
                    result = stringWriter.ToString();
                }
            }

            return result;
        }
    }
}