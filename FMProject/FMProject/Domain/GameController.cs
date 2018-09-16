using System;
using System.Collections.Generic;
using System.Linq;
using FMProject.Data.FixedGameData;
using FMProject.Data;
using System.Data;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace FMProject.Domain
{
    public sealed class GameController
    {
        private static readonly Lazy<GameController> lazy = new Lazy<GameController>(() => new GameController());
        //The Lazy Method allows me to access the constructor only when being used. Lazy is the only access to the constructor 'private gamecontroller'. This is only when the constructor is being used
        public static GameController Instance { get { return lazy.Value; } }

        public  GameComponents GameObjects { get; private set;}

        public static string SavedGameFile { get; set; }

        public static bool SavedGame { get; set; }

        private GameController()
        {
            if (SavedGame)            
                this.LoadSavedGame();            
            else            
                this.NewGameDataGeneration();                     
        }

        public static List<string> ListCountries()
        {
            return DataManager.ListCountries();
        }

        public static List<string> ListLanguages()
        {
            return DataManager.ListLanguages();          
        }

        public List<string> ListClubs()
        {
            return this.LoadAllTeams().Select(x => x.ClubName).ToList();
        }

        public List<BPLTeams> LoadAllTeams()
        {
            if (SavedGame)
               return this.GameObjects.Teams;

            return DataManager.LoadAllTeams();
        }

        public Manager LoadManager()
        {
            if (SavedGame)            
                return this.GameObjects.ManagerEntity;            
                       
            return DataManager.LoadManager().ManagerAttributes.First();                      
        }

        private void LoadSavedGame()
        {            
            XmlSerializer serializerman = new XmlSerializer(typeof(GameComponents));
            //XDocument doc = XDocument.Load(SavedGameFile);
            using (var stream = File.OpenRead(SavedGameFile))
            {
                this.GameObjects = (GameComponents)(serializerman.Deserialize(stream));
            }
            //var ManDocs = doc.Descendants("GameComponents").Select(d => new XDocument(new XElement("managerEntity", d)));
            //foreach (var newDoc in ManDocs)
            //{
            //    using (StringReader reader = new StringReader(newDoc.ToString()))
            //    {
            //        managerData = (Manager)(serializerman.Deserialize(reader));
            //    }
            //}
        }

        private void NewGameDataGeneration()
        {
            this.GameObjects = new Domain.GameComponents();
            GameObjects.Teams = DataManager.LoadAllTeams();
            GameObjects.Players = DataManager.LoadPlayers();
            //This is to input all of the team names from an XML file into a list of strings
            GameObjects.Fixtures = CreateFixtures();
            //This is for the function createfixtures to populate the set of fixtures into the var named within fixture class
            GameObjects.ManagerEntity = GenericManager();
            //this is when a generic profile is generated with no skills if the user doesn't load a game file
        }

        public static Manager GenericManager()
        {
            DateTime Today = DateTime.Today;
            var manager = new Manager
            {
                DateOfBirth = Today.AddYears(21),
                Name = "Generic Player",
            };

            return manager;
            // This populates the Manager's characteristics with generic data
        }

        public Player GenericPlayer()
        {            
            var rn = new Random();
         
            var player = new Player
            {
                FirstName = string.Concat(NameGenerator.GenRandomFirstName(), " ", NameGenerator.GenRandomLastName()),
                AssignedClub = this.GameObjects.ManagerEntity.AssignedClub,
                Age = rn.Next(16, 35),
                Positions = NameGenerator.GenRandomPosition(),
                Acceleration = rn.Next(0, 20),
                Crossing = rn.Next(0, 20),
                DefPos = rn.Next(0, 20),
                Dribbling = rn.Next(0, 20),
                Finishing = rn.Next(0, 20),
                Heading = rn.Next(0, 20),
                Leadership = rn.Next(0, 20),
                LongShot = rn.Next(0, 20),
                Movement = rn.Next(0, 20),
                Marking = rn.Next(0, 20),
                Pace = rn.Next(0, 20),
                Passing = rn.Next(0, 20),
                Stamina = rn.Next(0, 20),
                Strength = rn.Next(0, 20),
                Tackling = rn.Next(0, 20),
                Vision = rn.Next(0, 20),
                WorkRate = rn.Next(0, 20),
            };

            return player;
            // This populates the Player's characteristics with generic data
        }

        public Player YouthPlayer()
        {            
            var rn = new Random();
          
            var player = new Player
            {
                FirstName = string.Concat(NameGenerator.GenRandomFirstName(), " ", NameGenerator.GenRandomLastName()),
                AssignedClub = this.GameObjects.ManagerEntity.AssignedClub,
                Age = rn.Next(14, 19),
                Positions = NameGenerator.GenRandomPosition(),
                Acceleration = rn.Next(0, 20),
                Crossing = rn.Next(0, 20),
                DefPos = rn.Next(0, 20),
                Dribbling = rn.Next(0, 20),
                Finishing = rn.Next(0, 20),
                Heading = rn.Next(0, 20),
                Leadership = rn.Next(0, 20),
                LongShot = rn.Next(0, 20),
                Movement = rn.Next(0, 20),
                Marking = rn.Next(0, 20),
                Pace = rn.Next(0, 20),
                Passing = rn.Next(0, 20),
                Stamina = rn.Next(0, 20),
                Strength = rn.Next(0, 20),
                Tackling = rn.Next(0, 20),
                Vision = rn.Next(0, 20),
                WorkRate = rn.Next(0, 20),
            };

            return player;
            // This populates the Player's characteristics with generic data
        }

        public Player GenericGoalKeeperPlayer()
        {            
            var rn = new Random();
        
            var player = new Player
            {
                FirstName = string.Concat(NameGenerator.GenRandomFirstName(), " ", NameGenerator.GenRandomLastName()),
                AssignedClub = this.GameObjects.ManagerEntity.AssignedClub,
                Age = rn.Next(16, 40),
                Positions = "GK",
                AerialAbility = rn.Next(0, 20),
                Acceleration = rn.Next(0, 20),
                CommandArea = rn.Next(0, 20),
                DefPos = rn.Next(0, 20),
                Handling = rn.Next(0, 20),
                OneVsOne = rn.Next(0, 20),
                Heading = rn.Next(0, 20),
                Reflexes = rn.Next(0, 20),
                Leadership = rn.Next(0, 20),
                Pace = rn.Next(0, 20),
                Passing = rn.Next(0, 20),
                Stamina = rn.Next(0, 20),
            };

            return player;
            // This populates the Player's characteristics with generic data
        }


        private List<List<Fixture>> CreateFixtures()
        {
            //This is a set of declarations made to make it easier to access classes within my domain
            var teamNames = GameObjects.Teams.Select(team => team.ClubName).ToList();
            var teamDict = GameObjects.Teams.ToDictionary(v => v.ClubName, v => v);
            var fixtures = FixtureGenerator.CreateFixtures(teamNames, true);
            var fullFixtures = new List<List<Fixture>>();

            //These are a series of assignments 
            //This is when every round (containing a collection of pre generated fixtures) within the list of fixtures
            //This is when every fixture within the round
            //This is when the Home and Away team, club names are called and displayed on the fixture

            foreach (var round in fixtures)
            {
                var fullRound = new List<Fixture>();
                foreach (var fixture in round)
                {
                    var fullFixture = new Fixture
                    {
                        HomeTeam = teamDict[fixture.Item1],
                        AwayTeam = teamDict[fixture.Item2]
                    };
                    fullRound.Add(fullFixture);
                }
                fullFixtures.Add(fullRound);
            }

            return fullFixtures;
        }

        public DataTable GetCurrentFixturesAsDataTable()
        {
            var data = this.GameObjects.Fixtures[this.GameObjects.Round];
            //This is when a function generates a series of fixtures where the round dictates the set of fixtures
            DataTable table = new DataTable();
            table.Columns.Add("Home");
            table.Columns.Add("Versus");
            table.Columns.Add("Away");
            table.Columns.Add("Home Points");
            table.Columns.Add("Away Points");

            foreach (var fixture in data)
            {
                table.Rows.Add(new object[] {
                    fixture.HomeTeam.ClubName,
                    "vs",
                    fixture.AwayTeam.ClubName,
                    fixture.HomePoints,
                    fixture.AwayPoints,
                });
            }

            return table;
            //This is when the object each fixture is populated with team names based on the index number
            //This is when every fixture within the round
            //After each fixture is populated with team names a table which is displayed to returned
        }
           
        public void StartUpFunction()
        {               
            var clubnamevar = this.GameObjects.ManagerEntity.AssignedClub;            
            var clubPlayers = this.GameObjects.Players.PlayerAttributes.Where(x => x.AssignedClub == clubnamevar);
            var gkPlayers = this.GameObjects.Players.PlayerAttributes.Where(x => x.AssignedClub == clubnamevar && x.Positions.Contains("G"));            
            var currentTeam = this.GameObjects.Teams.First(team => team.ClubName == clubnamevar);

            var totalWages = clubPlayers.Sum(p => p.ContractValue);
                       
            currentTeam.WageCost = totalWages;
            currentTeam.TransferBudget = (currentTeam.ClubWealth - totalWages) / 24;
            currentTeam.WageBudget = (currentTeam.ClubWealth - currentTeam.TransferBudget - totalWages) / 15;

            // Note: could implement gk regen
            // Note: could implement less than 30 players regens            
        }

        public string GetGameDataAsXmlString()
        {
            return DataManager.SerialiseToXml(this.GameObjects);
        }      
    }
}
