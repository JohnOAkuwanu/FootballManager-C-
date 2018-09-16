using FMProject.Data;
using FMProject.Domain;
using FMProject.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FMProject
{
    public partial class Training : Form
    {
        public Training()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;

        private void ButMenuHome_Click(object sender, EventArgs e)
        {
            InGameHome fhome = new InGameHome();
            fhome.Show(); this.Hide();
        }

        private void ButMenuClubInfo_Click(object sender, EventArgs e)
        {
            ClubFinances ClubInfo = new ClubFinances();
            ClubInfo.Show(); this.Hide();
        }

        private void ButMenuTraining_Click(object sender, EventArgs e)
        {
            Training TeamTraining = new Training();
            TeamTraining.Show(); this.Hide();
        }

        private void ButMenuTeam_Click(object sender, EventArgs e)
        {
            Squad SquadPage = new Squad();
            SquadPage.Show(); this.Hide();
        }

        private void ButMenuComp_Click(object sender, EventArgs e)
        {
            Competitions CompPage = new FMProject.Competitions();
            CompPage.Show(); this.Hide();
        }

        private void ButMenuTransfer_Click(object sender, EventArgs e)
        {
            TransferMarket TransferPage = new TransferMarket();
            TransferPage.Show(); this.Hide();
        }

        private void ButMenuManagerProfile_Click(object sender, EventArgs e)
        {
            ManagerProfile ManProf = new FMProject.ManagerProfile();
            ManProf.Show(); this.Hide();
        }

        private void ButScouted_Click(object sender, EventArgs e)
        {
        }
        private void ButFormation_Click(object sender, EventArgs e)
        {
            Formation Tactics = new Formation();
            Tactics.Show(); this.Hide();
        }

        private void ButGamePlan_Click(object sender, EventArgs e)
        {
            GamePlan GamePlanScreen = new FMProject.GamePlan();
            GamePlanScreen.Show(); this.Hide();
        }

        private void ButMenuClubInfo_Click_1(object sender, EventArgs e)
        {
            ClubFinances clubData = new ClubFinances();
            clubData.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuHome_Click_1(object sender, EventArgs e)
        {
            InGameHome fHome = new FMProject.InGameHome();
            fHome.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuTeam_Click_1(object sender, EventArgs e)
        {
            Squad SquadScreen = new FMProject.Squad();
            SquadScreen.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuComp_Click_1(object sender, EventArgs e)
        {
            Competitions Cups = new FMProject.Competitions();
            Cups.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuTransfer_Click_1(object sender, EventArgs e)
        {
            TransferMarket transferMarket = new FMProject.TransferMarket();
            transferMarket.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuManagerProfile_Click_1(object sender, EventArgs e)
        {
            ManagerProfile manProf = new FMProject.ManagerProfile();
            manProf.Show(); this.Hide();
            this.Hide();
        }

        private void TeamShootTraining_Click(object sender, EventArgs e)
        {
            if (TeamPlayMakeTraining.Enabled == false)
            {
                TeamPlayMakeTraining.Enabled = true;
            }
            else
            {
                TeamPlayMakeTraining.Enabled = false;
            }


            if (ButTeamPossessTrain.Enabled == false)
            {
                ButTeamPossessTrain.Enabled = true;
            }
            else
            {
                ButTeamPossessTrain.Enabled = false;
            }
            if (ButTeamDefendTraining.Enabled == false)
            {
                ButTeamDefendTraining.Enabled = true;
            }
            else
            {
                ButTeamDefendTraining.Enabled = false;
            }
            if (ButTeamFitnessTraining.Enabled == false)
            {
                ButTeamFitnessTraining.Enabled = true;
            }
            else
            {
                ButTeamFitnessTraining.Enabled = false;
            }
            if (ButCounterAttackingTraining.Enabled == false)
            {
                ButCounterAttackingTraining.Enabled = true;
            }
            else
            {
                ButCounterAttackingTraining.Enabled = false;
            }
                      
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.Finishing += 1;
                    player.Dribbling += 1;
                    player.LongShot += 1;
                    player.Heading += 1;                   
                }
            }
        }

        private void Training_Load(object sender, EventArgs e)
        {

        }

        private void TeamPlayMakeTraining_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
            XDocument xdoc = XDocument.Load(xmlread);

            if (TeamShootTraining.Enabled == false)
            { TeamShootTraining.Enabled = true; }
            else
            { TeamShootTraining.Enabled = false; }

            if (ButTeamPossessTrain.Enabled == false)
            {
                ButTeamPossessTrain.Enabled = true;
            }
            else
            {
                ButTeamPossessTrain.Enabled = false;
            }
            if (ButTeamDefendTraining.Enabled == false)
            {
                ButTeamDefendTraining.Enabled = true;
            }
            else
            {
                ButTeamDefendTraining.Enabled = false;
            }
            if (ButTeamFitnessTraining.Enabled == false)
            {
                ButTeamFitnessTraining.Enabled = true;
            }
            else
            {
                ButTeamFitnessTraining.Enabled = false;
            }
            if (ButCounterAttackingTraining.Enabled == false)
            {
                ButCounterAttackingTraining.Enabled = true;
            }
            else
            {
                ButCounterAttackingTraining.Enabled = false;
            }

            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.Passing += 1;
                    player.Vision += 1;
                    player.Movement += 1;
                    player.Crossing += 1;
                    xmlread.Close();
                    xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                }
            }
        }

        private void ButTeamPossessTrain_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
            XDocument xdoc = XDocument.Load(xmlread);

            if (TeamPlayMakeTraining.Enabled == false)
            { TeamPlayMakeTraining.Enabled = true; }
            else
            { TeamPlayMakeTraining.Enabled = false; }

            if (TeamShootTraining.Enabled == false)
            {
                TeamShootTraining.Enabled = true;
            }
            else
            {
                TeamShootTraining.Enabled = false;
            }
            if (ButTeamDefendTraining.Enabled == false)
            {
                ButTeamDefendTraining.Enabled = true;
            }
            else
            {
                ButTeamDefendTraining.Enabled = false;
            }
            if (ButTeamFitnessTraining.Enabled == false)
            {
                ButTeamFitnessTraining.Enabled = true;
            }
            else
            {
                ButTeamFitnessTraining.Enabled = false;
            }
            if (ButCounterAttackingTraining.Enabled == false)
            {
                ButCounterAttackingTraining.Enabled = true;
            }
            else
            {
                ButCounterAttackingTraining.Enabled = false;
            }

            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.Strength += 1;
                    player.Movement += 1;
                    player.Passing += 1;
                    player.DefPos += 1;                    
                }
            }
        }

        private void ButCounterAttackingTraining_Click(object sender, EventArgs e)
        {           

            if (TeamPlayMakeTraining.Enabled == false)
            { TeamPlayMakeTraining.Enabled = true; }
            else
            { TeamPlayMakeTraining.Enabled = false; }

            if (TeamShootTraining.Enabled == false)
            {
                TeamShootTraining.Enabled = true;
            }
            else
            {
                TeamShootTraining.Enabled = false;
            }
            if (ButTeamDefendTraining.Enabled == false)
            {
                ButTeamDefendTraining.Enabled = true;
            }
            else
            {
                ButTeamDefendTraining.Enabled = false;
            }
            if (ButTeamFitnessTraining.Enabled == false)
            {
                ButTeamFitnessTraining.Enabled = true;
            }
            else
            {
                ButTeamFitnessTraining.Enabled = false;
            }
            if (ButTeamPossessTrain.Enabled == false)
            {
                ButTeamPossessTrain.Enabled = true;
            }
            else
            {
                ButTeamPossessTrain.Enabled = false;
            }
                      
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.Dribbling += 1;
                    player.Pace += 1;
                    player.Vision += 1;
                    player.Acceleration += 1;
                    player.DefPos += 1;                 
                }
            }
        }

        private void ButTeamDefendTraining_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
            XDocument xdoc = XDocument.Load(xmlread);

            if (TeamPlayMakeTraining.Enabled == false)
            { TeamPlayMakeTraining.Enabled = true; }
            else
            { TeamPlayMakeTraining.Enabled = false; }

            if (TeamShootTraining.Enabled == false)
            {
                TeamShootTraining.Enabled = true;
            }
            else
            {
                TeamShootTraining.Enabled = false;
            }
            if (ButCounterAttackingTraining.Enabled == false)
            {
                ButCounterAttackingTraining.Enabled = true;
            }
            else
            {
                ButCounterAttackingTraining.Enabled = false;
            }
            if (ButTeamFitnessTraining.Enabled == false)
            {
                ButTeamFitnessTraining.Enabled = true;
            }
            else
            {
                ButTeamFitnessTraining.Enabled = false;
            }
            if (ButTeamPossessTrain.Enabled == false)
            {
                ButTeamPossessTrain.Enabled = true;
            }
            else
            {
                ButTeamPossessTrain.Enabled = false;
            }

            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.Tackling += 1;
                    player.Heading += 1;
                    player.DefPos += 1;
                    player.Anticiptation += 1;
                    player.Marking += 1;
                    xmlread.Close();
                    xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                }
            }
        }

        private void ButTeamFitnessTraining_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
            XDocument xdoc = XDocument.Load(xmlread);
            TeamShootTraining.Enabled = false;
            TeamPlayMakeTraining.Enabled = false;
            ButTeamPossessTrain.Enabled = false;
            ButTeamDefendTraining.Enabled = false;
            ButCounterAttackingTraining.Enabled = false;
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.Stamina += 1;
                    player.Strength += 1;
                    player.Acceleration += 1;
                    player.Pace += 1;                  
                }
            }
        }

        private void ButGoalkeepingTraining_Click(object sender, EventArgs e)
        {           
            ButGoalSweeperTrain.Enabled = false;

            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.Reflexes += 1;
                    player.Handling += 1;
                    player.AerialAbility += 1;
                    player.OneVsOne += 1;                 
                }
            }
        }

        private void ButGoalSweeperTrain_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
            XDocument xdoc = XDocument.Load(xmlread);
            ButGoalkeepingTraining.Enabled = false;
           
            var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.Positions.Contains("GK"));
            int round = controller.GameObjects.Round;
            if (round == 5 || round == 10 || round == 15 || round == 20 || round == 25 || round == 30 || round == 35 || round == 40)
            {
                foreach (var player in clubPlayers)
                {
                    player.OneVsOne += 1;
                    player.Pace += 1;
                    player.Acceleration += 1;
                    player.Reflexes += 1;
                    xmlread.Close();
                    xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                }
            }
        }
    }
}