using FMProject.Data;
using FMProject.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FMProject.UI
{
    public partial class NegotiationsScreen : Form
    {
        private double teamvaluation;
        public NegotiationsScreen()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == ("£0"))
            {
                txtYourValue.Text = "0";
            }
            if (comboBox1.SelectedValue == "£100k")
            {
                txtYourValue.Text = "1000000";
            }
            if (comboBox1.SelectedValue == "£250k")
            {
                txtYourValue.Text = "250000";
            }
            if (comboBox1.SelectedValue == "£500k")
            {
                txtYourValue.Text = "500000";
            }
            if (comboBox1.SelectedValue == "£750k")
            {
                txtYourValue.Text = "750000";
            }
            if (comboBox1.SelectedValue == "£1m")
            {
                txtYourValue.Text = "1000000";
            }
            if (comboBox1.SelectedValue == "£2.5m")
            {
                txtYourValue.Text = "2500000";
            }
            if (comboBox1.SelectedValue == "£5m")
            {
                txtYourValue.Text = "5000000";
            }
            if (comboBox1.SelectedValue == "£7.5m")
            {
                txtYourValue.Text = "7500000";
            }
            if (comboBox1.SelectedValue == "£10m")
            {
                txtYourValue.Text = "10000000";
            }
            if (comboBox1.SelectedValue == "£15m")
            {
                txtYourValue.Text = "15000000";
            }
            if (comboBox1.SelectedValue == "£20m")
            {
                txtYourValue.Text = "20000000";
            }
            if (comboBox1.SelectedValue == "£25m")
            {
                txtYourValue.Text = "25000000";
            }
            if (comboBox1.Text.Contains("£50m"))
            {
                txtYourValue.Text = "50000000";
            }
            if (comboBox1.SelectedValue == "£75m")
            {
                txtYourValue.Text = "75000000";
            }
            if (comboBox1.SelectedValue == "£100m")
            {
                txtYourValue.Text = "100000000";
            }
            if (comboBox1.SelectedValue == "£250m")
            {
                txtYourValue.Text = "250000000";
            }
        }

        private void butOffer_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue == ("£0"))
            {
                txtYourValue.Text = "0";
            }
            if (comboBox1.SelectedValue == "£100k")
            {
                txtYourValue.Text = "1000000";
            }
            if (comboBox1.SelectedValue == "£250k")
            {
                txtYourValue.Text = "250000";
            }
            if (comboBox1.SelectedValue == "£500k")
            {
                txtYourValue.Text = "500000";
            }
            if (comboBox1.SelectedValue == "£750k")
            {
                txtYourValue.Text = "750000";
            }
            if (comboBox1.SelectedValue == "£1m")
            {
                txtYourValue.Text = "1000000";
            }
            if (comboBox1.SelectedValue == "£2.5m")
            {
                txtYourValue.Text = "2500000";
            }
            if (comboBox1.SelectedValue == "£5m")
            {
                txtYourValue.Text = "5000000";
            }
            if (comboBox1.SelectedValue == "£7.5m")
            {
                txtYourValue.Text = "7500000";
            }
            if (comboBox1.SelectedValue == "£10m")
            {
                txtYourValue.Text = "10000000";
            }
            if (comboBox1.SelectedValue == "£15m")
            {
                txtYourValue.Text = "15000000";
            }
            if (comboBox1.SelectedValue == "£20m")
            {
                txtYourValue.Text = "20000000";
            }
            if (comboBox1.SelectedValue == "£25m")
            {
                txtYourValue.Text = "25000000";
            }
            if (comboBox1.Text.Contains("£50m"))
            {
                txtYourValue.Text = "50000000";
            }
            if (comboBox1.SelectedValue == "£75m")
            {
                txtYourValue.Text = "75000000";
            }
            if (comboBox1.SelectedValue == "£100m")
            {
                txtYourValue.Text = "100000000";
            }
            if (comboBox1.SelectedValue == "£250m")
            {
                txtYourValue.Text = "250000000";
            }
            var clubname = controller.GameObjects.ManagerEntity.AssignedClub;
            var allPlayers = controller.GameObjects.Players;
            var Player = allPlayers.PlayerAttributes.Where(x => x.AssignedClub == txtName.Text);
            string playerskilllevel = ViewPlayer.PlayerSkill;
            string playerclubvalue = ViewPlayer.PlayerValue;
            int playervalue;
            int skillvalue;
            long TransferBudget;
            long YourValue;
            bool AcceptedOffer;

            Int32.TryParse(playerclubvalue, out playervalue);
            Int32.TryParse(playerskilllevel, out skillvalue);
            Int64.TryParse(txtYourValue.Text, out YourValue);
            Int64.TryParse(txtTransferBudget.Text, out TransferBudget);

            if (skillvalue < Squad.TotalTeamAvgAbility)
            {
                double teamval = playervalue + Math.Pow(0.95 * skillvalue, 4.5);
                teamvaluation = Math.Round(teamval, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                double teamval = playervalue + Math.Pow(2.05 * skillvalue, 5.5);
                teamvaluation = Math.Round(teamval, 2, MidpointRounding.AwayFromZero);
            }
            if (TransferBudget > YourValue)
            {
                if (YourValue >= teamvaluation)
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
                WageNegotiations WageContract = new WageNegotiations();
                WageContract.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Offer Rejected");
            }
        }

        private void NegotiationsScreen_Load(object sender, EventArgs e)
        {
            txtName.Text = ViewPlayer.PlyrName;
            txtClub.Text = ViewPlayer.ClubName;
            textBox1.Text = ViewPlayer.PlayerValue;            
            var team = controller.GameObjects.GetCurrentTeam();

        
                txtTransferBudget.Text = team.TransferBudget.ToString();
            
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Squad team = new FMProject.Squad();
            team.Show();
        }
    }
}
