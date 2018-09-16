//using FMProject.Data.FixedGameData;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Xml.Serialization;
//using System.Xml;
//using FMProject.Domain;

//namespace FMProject.Data
//{
//    public static class DataManager
//    {
//        public static List<TeamBasic> LoadBPLTeamData()
//        {
//            string path = "D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\FixedGameData\\BPLLeagueDataNew.xml";

//            XmlSerializer serializer = new XmlSerializer(typeof(BPLLeagueData));
//            using (var reader = new StreamReader(path))
//            {
//                var leagueData = (BPLLeagueData)serializer.Deserialize(reader);
//                return leagueData.Participants
//                    .Select(p => new Domain.TeamBasic
//                    {
//                        ClubName = p.ClubName,
//                        Draws = p.Draws,

//                    })
//                    .ToList();
//            }

//        }

//        //public static Players SavePlayers()
//        //{
//        //    string path = "D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml";

//        //    XmlSerializer serializer = new XmlSerializer(typeof(Players));
//        //    using (StreamWriter sw = new StreamWriter(path))
//        //    {
//        //       serializer.Serialize(sw, path);
//        //    }
//        //}


//        public static void WriteToXmlFile<Players>(string fileName, Players objectToWrite, bool append = false) where Players : new()
//        {
//            TextWriter writer = null;
//            try
//            {
//                var serializer = new XmlSerializer(typeof(Players));
//                writer = new StreamWriter(fileName, append);
//                serializer.Serialize(writer, objectToWrite);
//            }
//            finally
//            {
//                if (writer != null)
//                    writer.Close();
//            }
//        }

//        public static Players LoadPlayers()
//        {
//            string path = "D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml";
//            //string path = "D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\FixedGameData\\NewBPLPlayers.xml";


//            XmlSerializer serializer = new XmlSerializer(typeof(Players));
//            using (var reader = new StreamReader(path))
//            {

//                var players = (Players)serializer.Deserialize(reader);
//                return players;
//            }
//        }

//        public static string SerialiseToXml<T>(T objectToSerialise)
//        {
//            var serialiser = new XmlSerializer(typeof(T));
//            var result = string.Empty;

//            using (var stringWriter = new StringWriter())
//            {
//                using (var writer = XmlWriter.Create(stringWriter))
//                {
//                    serialiser.Serialize(writer, objectToSerialise);
//                    result = stringWriter.ToString();
//                }
//            }

//            return result;
//        }
//    }
//}