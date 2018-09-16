using FMProject.Data;
using FMProject.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FMProject
{
    public partial class ViewPlayer : Form
    {
        public static string PlayerSkill;
        public static string PlayerValue;
        public static string PlyrName;
        public static string ClubName;
        public static string PlayerAvgAbility;
        public ViewPlayer()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewPlayer_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TransferMarket.PlayerNameActivate))
            {
                TxtPlayerName.Text = Squad.PlayerNamePublic;
                Squad.PlayerNamePublic = "";

            }
            else
            {
                TxtPlayerName.Text = TransferMarket.PlayerNameActivate;
                TransferMarket.PlayerNameActivate = "";
            }

            var allPlayers = controller.GameObjects.Players;
            var clubPlayers = allPlayers.PlayerAttributes.Where(x => x.FirstName == TxtPlayerName.Text);
            int value;
            
            foreach (var player in clubPlayers)
            {
                TxtAccelerate.Text = player.Acceleration.ToString();
                TxtAerial.Text = player.AerialAbility.ToString();
                TxtAnticiptation.Text = player.Anticiptation.ToString();
                TxtClubName.Text = player.AssignedClub;
                TxtCommandOfArea.Text = player.CommandArea.ToString();
                TxtCross.Text = player.Crossing.ToString();
                TxtDefPos.Text = player.DefPos.ToString();
                TxtDribbling.Text = player.Dribbling.ToString();
                TxtFinish.Text = player.Finishing.ToString();
                TxtHandle.Text = player.Handling.ToString();
                TxtHeading.Text = player.Heading.ToString();
                TxtLeader.Text = player.Leadership.ToString();
                TxtLongShot.Text = player.LongShot.ToString();
                TxtMarking.Text = player.Marking.ToString();
                TxtMovement.Text = player.Movement.ToString();
                TxtOnevOne.Text = player.OneVsOne.ToString();
                TxtPace.Text = player.Pace.ToString();
                TxtPassing.Text = player.Passing.ToString();
                TxtReflex.Text = player.Reflexes.ToString();
                TxtStamina.Text = player.Stamina.ToString();
                TxtStrength.Text = player.Strength.ToString();
                TxtTackle.Text = player.Tackling.ToString();
                TxtVision.Text = player.Vision.ToString();
                TxtWorkRate.Text = player.WorkRate.ToString();
                txtPositions.Text = player.Positions;
                txtMarketVal.Text = player.MarketValue;

                if (player.Positions.Contains("AM R") || player.Positions.Contains("AM L") || player.Positions.Contains("AM C"))
                {
                    int totalAM = player.Vision + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Crossing + player.Acceleration;
                    double avgability = (totalAM + 3.5) / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                    txtAvgSkill.Text = playerability.ToString();
                }
                if (player.Positions.Contains("ST") || player.Positions.Contains("F C"))
                {
                    int totalST = player.Strength + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Heading + player.Acceleration;
                    double avgability = totalST / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                    txtAvgSkill.Text = playerability.ToString();
                }
                if (player.Positions.Contains("M C") || player.Positions.Contains("M R") || player.Positions.Contains("M L") || player.Positions.Contains("DM"))
                {
                    int totalM = player.WorkRate + player.Vision + player.Tackling + player.Strength + player.Passing + player.Marking + player.Finishing + player.Dribbling + player.Crossing;
                    double avgability = totalM / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                    txtAvgSkill.Text = playerability.ToString();
                }
                if (player.Positions.Contains("D C") || player.Positions.Contains("D R") || player.Positions.Contains("D L"))
                {
                    int totalD = player.WorkRate + player.Tackling + player.Strength + player.Passing + player.Pace + player.Marking + player.Heading + player.DefPos;
                    double avgability = totalD / 8;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);

                    txtAvgSkill.Text = playerability.ToString();
                }
                if (player.Positions.Contains("G"))
                {
                    int totalGK = player.Reflexes + player.Passing + player.OneVsOne + player.Handling + player.CommandArea + player.AerialAbility;
                    double avgability = totalGK / 6;
                    double playerability = Math.Round(avgability * 5, 0, MidpointRounding.AwayFromZero);
                    txtAvgSkill.Text = playerability.ToString();
                }
            }


            //int total = player.WorkRate + player.Vision + player.Tackling + player.Strength + player.Stamina + player.Passing + player.Pace + player.Movement + player.Marking + player.LongShot + player.Heading + player.Finishing + player.Dribbling + player.Crossing + player.Acceleration;

            if (TxtClubName.Text == controller.GameObjects.ManagerEntity.AssignedClub)
            {
                butMakeOffer.Enabled = false;
                butScoutPlayer.Enabled = false;
            }

            foreach (Control c in this.Controls)
            {
                TextBox textbox = c as TextBox;
                {
                    if (textbox != null)
                        if (Int32.TryParse(textbox.Text, out value))
                            if (value < 10)
                                c.BackColor = Color.Red;
                }
            }

            foreach (Control c in this.Controls)
            {
                TextBox textbox = c as TextBox;
                {
                    if (textbox != null)
                        if (Int32.TryParse(textbox.Text, out value))
                            if (value > 15)
                                c.BackColor = Color.LightGreen;
                }
            }

            foreach (Control c in this.Controls)
            {
                TextBox textbox = c as TextBox;
                {
                    if (textbox != null)
                        if (Int32.TryParse(textbox.Text, out value))
                            if (value < 16 && value > 9)
                                c.BackColor = Color.LightGoldenrodYellow;
                }
            }
            //This is aimed to produce and display the attributes of the player which was selected by searching through the xml file to find the player whose name is equivalent to the name in the textbox
        }

        private void TxtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void butMakeOffer_Click(object sender, EventArgs e)
        {
            PlayerSkill = txtAvgSkill.Text;
            PlayerValue = txtMarketVal.Text;
            PlyrName = TxtPlayerName.Text;
            ClubName = TxtClubName.Text;
            PlayerAvgAbility = txtAvgSkill.Text;
            FMProject.UI.NegotiationsScreen MakeOffer = new UI.NegotiationsScreen();
            MakeOffer.Show();
        }
    }
}
