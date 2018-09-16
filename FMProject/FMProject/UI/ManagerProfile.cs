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

namespace FMProject
{
    public partial class ManagerProfile : Form
    {
        public ManagerProfile()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;

        private void ManagerProfile_Load(object sender, EventArgs e)
        {
            var manager = controller.GameObjects.ManagerEntity;
           
                txtManName.Text = manager.Name;
                txtManPoints.Text = manager.ManagerPoints.ToString();
                txtClubsManaged.Text = manager.NoOfClubsManaged.ToString();
                txtConcededGoals.Text = manager.GoalsAgainst.ToString();
                txtCupWins.Text = manager.CupsWins.ToString();
                txtDraws.Text = manager.Draws.ToString();
                txtGamesPlayed.Text = manager.GamesPlayed.ToString();
                txtGamesWon.Text = manager.Wins.ToString();
                txtGoalsScored.Text = manager.GoalsFor.ToString();
                txtLeagueTitles.Text = manager.LeagueTitles.ToString();
                txtLosses.Text = manager.Losses.ToString();
                txtPromotions.Text = manager.Promotions.ToString();
                txtSeasonPlayed.Text = manager.SeasonsPlayed.ToString();
                double winpercent = Math.Round(manager.Wins / manager.GamesPlayed, 1, MidpointRounding.AwayFromZero);
                txtWinPercentage.Text = winpercent.ToString();
            
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
InGameHome fhome = new InGameHome();
            fhome.Show(); this.Hide();
        }

        private void ButMenuTeam_Click_1(object sender, EventArgs e)
        {
Squad SquadPage = new Squad();
            SquadPage.Show(); this.Hide();
        }

        private void ButMenuClubInfo_Click_1(object sender, EventArgs e)
        {
ClubFinances ClubInfo = new ClubFinances();
            ClubInfo.Show(); this.Hide();
        }

        private void ButMenuComp_Click_1(object sender, EventArgs e)
        {
            Competitions CompPage = new FMProject.Competitions();
            CompPage.Show(); this.Hide();
        }

        private void ButMenuTransfer_Click_1(object sender, EventArgs e)
        {
            TransferMarket TransferPage = new TransferMarket();
            TransferPage.Show(); this.Hide();
        }

        private void ButMenuManagerProfile_Click_1(object sender, EventArgs e)
        {
            ManagerProfile ManProf = new FMProject.ManagerProfile();
            ManProf.Show(); this.Hide();
        }

        private void ButJobCentre_Click(object sender, EventArgs e)
        {
            JobCentre jobs = new JobCentre();
            jobs.Show();
            this.Hide();
        }

        private void ButStaff_Click(object sender, EventArgs e)
        {
            StaffScreen Staff = new FMProject.StaffScreen();
            Staff.Show();
            this.Hide();
        }
    }
}
