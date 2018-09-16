using FMProject.Data;
using FMProject.Domain;
using FMProject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FMProject
{
    public partial class PlayerTraining : Form
    {

        public List<string> PlayerNames1 = new List<string>();
        public List<string> PlayerNames2 = new List<string>();
        public List<string> PlayerNames3 = new List<string>();
        public List<string> PlayerNames4 = new List<string>();
        public string PlayerFormationName1 { get; set; }
        public string PlayerFormationName2 { get; set; }
        public string PlayerFormationName3 { get; set; }
        public string PlayerFormationName4 { get; set; }

        public PlayerTraining()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

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

        private void ButMenuTraining_Click_1(object sender, EventArgs e)
        {
            Training TeamTraining = new Training();
            TeamTraining.Show(); this.Hide();
        }

        private void ButMenuHome_Click_1(object sender, EventArgs e)
        {
            InGameHome fHome = new FMProject.InGameHome();
            fHome.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuClubInfo_Click_1(object sender, EventArgs e)
        {
            ClubFinances clubData = new ClubFinances();
            clubData.Show(); this.Hide();
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

        private void ButShoot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButSetPlayerTraining_Click(object sender, EventArgs e)
        {
            if (ButShoot.Checked = true)
            {
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                XDocument xdoc = XDocument.Load(xmlread);
                //var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Club").Value == controller.GameObjects.managerEntity.AssignedClub);
                //clubnode.SetElementValue("Club", clubname);

                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 3 || round == 6 || round == 9 || round == 12 || round == 15 || round == 18 || round == 21 || round == 24 || round == 27 || round == 30 || round == 33 || round == 36 || round == 39)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.Finishing += 1;
                        player.LongShot += 1;
                        xmlread.Close();
                        xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                    }
                }
            }

            if (ButControl.Checked = true)
            {
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                XDocument xdoc = XDocument.Load(xmlread);
                //var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Club").Value == controller.GameObjects.managerEntity.AssignedClub);
                //clubnode.SetElementValue("Club", clubname);

                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 3 || round == 6 || round == 9 || round == 12 || round == 15 || round == 18 || round == 21 || round == 24 || round == 27 || round == 30 || round == 33 || round == 36 || round == 39)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.Movement += 1;
                        player.Dribbling += 1;
                        xmlread.Close();
                        xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                    }
                }
            }
            if (ButCross.Checked = true)
            {
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                XDocument xdoc = XDocument.Load(xmlread);
                //var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Club").Value == controller.GameObjects.managerEntity.AssignedClub);
                //clubnode.SetElementValue("Club", clubname);

                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 3 || round == 6 || round == 9 || round == 12 || round == 15 || round == 18 || round == 21 || round == 24 || round == 27 || round == 30 || round == 33 || round == 36 || round == 39)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.Crossing += 1;
                        player.Vision += 1;
                        xmlread.Close();
                        xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                    }
                }
            }
            if (ButDefending.Checked = true)
            {
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                XDocument xdoc = XDocument.Load(xmlread);
                //var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Club").Value == controller.GameObjects.managerEntity.AssignedClub);
                //clubnode.SetElementValue("Club", clubname);

                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 3 || round == 6 || round == 9 || round == 12 || round == 15 || round == 18 || round == 21 || round == 24 || round == 27 || round == 30 || round == 33 || round == 36 || round == 39)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.Tackling += 1;
                        player.Marking += 1;
                        player.Heading += 1;
                        xmlread.Close();
                        xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                    }
                }
            }
            if (ButFitness.Checked = true)
            {
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                XDocument xdoc = XDocument.Load(xmlread);
                //var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Club").Value == controller.GameObjects.managerEntity.AssignedClub);
                //clubnode.SetElementValue("Club", clubname);

                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 3 || round == 6 || round == 9 || round == 12 || round == 15 || round == 18 || round == 21 || round == 24 || round == 27 || round == 30 || round == 33 || round == 36 || round == 39)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.Strength += 1;
                        player.Stamina += 1;
                        xmlread.Close();
                        xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                    }
                }
            }
            if (ButPlaymaking.Checked = true)
            {
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                XDocument xdoc = XDocument.Load(xmlread);
                //var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Club").Value == controller.GameObjects.managerEntity.AssignedClub);
                //clubnode.SetElementValue("Club", clubname);

                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 3 || round == 6 || round == 9 || round == 12 || round == 15 || round == 18 || round == 21 || round == 24 || round == 27 || round == 30 || round == 33 || round == 36 || round == 39)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.Passing += 1;
                        player.Vision += 1;
                        xmlread.Close();
                        xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                    }
                }
            }
            if (ButMental.Checked = true)
            {
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                XDocument xdoc = XDocument.Load(xmlread);
                //var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Club").Value == controller.GameObjects.managerEntity.AssignedClub);
                //clubnode.SetElementValue("Club", clubname);

                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 3 || round == 6 || round == 9 || round == 12 || round == 15 || round == 18 || round == 21 || round == 24 || round == 27 || round == 30 || round == 33 || round == 36 || round == 39)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.WorkRate += 1;
                        player.Leadership += 1;
                        xmlread.Close();
                        xdoc.Save("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                    }
                }
            }
            if (ButSetPiece.Checked = true)
            {               
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.FirstName == comboBox1.Text || x.FirstName == comboBox3.Text || x.FirstName == comboBox4.Text);
                int round = controller.GameObjects.Round;
                if (round == 4 || round == 8 || round == 12 || round == 16 || round == 20 || round == 24 || round == 28 || round == 32 || round == 36 || round == 40)
                {
                    foreach (var player in clubPlayers)
                    {
                        player.FreeKick += 2;                       
                    }
                }
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlayerTraining_Load(object sender, EventArgs e)
        {
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            foreach (var p in clubPlayers)
            {
                PlayerFormationName1 = p.FirstName;
                PlayerFormationName2 = p.FirstName;
                PlayerFormationName3 = p.FirstName;
                PlayerFormationName4 = p.FirstName;

                PlayerNames1.Add(PlayerFormationName1);
                PlayerNames2.Add(PlayerFormationName2);
                PlayerNames3.Add(PlayerFormationName3);
                PlayerNames4.Add(PlayerFormationName4);
            }
            comboBox1.DataSource = PlayerNames1;
            comboBox3.DataSource = PlayerNames2;
            comboBox4.DataSource = PlayerNames3;
            comboBox7.DataSource = PlayerNames4;
        }
    }
}
