using FMProject.Data;
using FMProject.Domain;
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

namespace FMProject.UI
{
    public partial class WageNegotiations : Form
    {
        public WageNegotiations()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;
        private double teamwagevaluation;
        private decimal teamWageBudget;

        private void WageNegotiations_Load(object sender, EventArgs e)
        {
            var allPlayers = controller.GameObjects.Players;
            var PlayersDatabase = allPlayers.PlayerAttributes.Where(x => x.AssignedClub == txtName.Text);

            txtName.Text = ViewPlayer.PlyrName;
            txtClub.Text = ViewPlayer.ClubName;

            var team = controller.GameObjects.GetCurrentTeam();

            foreach (var player in PlayersDatabase)
            {
                txtCurrentWage.Text = player.ContractValue.ToString();
            }

            decimal wages = team.WageBudget;
            teamWageBudget = Math.Round(wages, 2, MidpointRounding.AwayFromZero);
            txtWageBudget.Text = teamWageBudget.ToString();            
        }

        private void butOfferWage_Click(object sender, EventArgs e)
        {
            var clubname = controller.GameObjects.ManagerEntity.AssignedClub;
            var allPlayers = controller.GameObjects.Players;
            var Player = allPlayers.PlayerAttributes.Where(x => x.AssignedClub == txtName.Text);
            string playerskilllevel = ViewPlayer.PlayerSkill;
            string playerclubvalue = ViewPlayer.PlayerValue;
            int playervalue;
            int skillvalue;
            long WageBudget;
            long YourValue;
            bool AcceptedOffer;

            Int32.TryParse(txtCurrentWage.Text, out playervalue);
            Int64.TryParse(txtYourValue.Text, out YourValue);
            Int64.TryParse(txtWageBudget.Text, out WageBudget);
            Int32.TryParse(playerskilllevel, out skillvalue);


            if (skillvalue < Squad.TotalTeamAvgAbility)
            {
                double teamval = playervalue + Math.Pow(0.95 * skillvalue, 1.5);
                teamwagevaluation = Math.Round(teamval, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                double teamval = playervalue + Math.Pow(1.95 * skillvalue, 4);
                teamwagevaluation = Math.Round(teamval, 2, MidpointRounding.AwayFromZero);
            }
            if (WageBudget > YourValue)
            {
                if (YourValue >= teamwagevaluation)
                {
                    AcceptedOffer = true;
                }
                else
                {
                    AcceptedOffer = false;
                }
            }
            else
            {
                AcceptedOffer = false;
            }

            if (AcceptedOffer == true)
            {
                MessageBox.Show("Offer Accepted");
                XmlDocument doc = new XmlDocument();
                XmlTextReader xmlread = new XmlTextReader("D:\\documents\\documentsdocumentsFMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                //doc.Load(xmlread);
                XmlNodeList nodes = doc.SelectNodes("players/player");
                foreach (var club in Player)
                {
                    club.AssignedClub = clubname;
                }
                XDocument xdoc = XDocument.Load(xmlread);
                string plyrname = txtName.Text;
                var clubnode = xdoc.Descendants("player").FirstOrDefault(cd => cd.Element("Name").Value == plyrname);
                clubnode.SetElementValue("Club", clubname);
                xmlread.Close();
                xdoc.Save("D:\\documents\\documentsdocumentsFMProject\\FMProject\\Data\\CurrentGameData\\CurrentPlayers.xml");
                this.Hide();
                Squad team = new Squad();
                team.Show();
            }
            else
            {
                MessageBox.Show("Offer Rejected");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPlayer player = new ViewPlayer();
            player.Show();
        }
    }
}
