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
    public partial class Competitions : Form
    {
        public Competitions()
        {
            InitializeComponent();
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

        private void ButPlayerStatistics_Click(object sender, EventArgs e)
        {
            PlayerStatistics PlayerStatPage = new PlayerStatistics();
            PlayerStatPage.Show(); this.Hide();
        }

        private void ButTeamStatistics_Click(object sender, EventArgs e)
        {
            TeamStatistics TeamStatsScreen = new FMProject.TeamStatistics();
            TeamStatsScreen.Show(); this.Hide();
        }

        private void ButMenuTraining_Click_1(object sender, EventArgs e)
        {
            Training TeamTraining = new Training();
            TeamTraining.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuHome_Click(object sender, EventArgs e)
        {
            InGameHome fHome = new FMProject.InGameHome();
            fHome.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuTeam_Click(object sender, EventArgs e)
        {
            Squad SquadScreen = new FMProject.Squad();
            SquadScreen.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuClubInfo_Click(object sender, EventArgs e)
        {
            ClubFinances clubData = new ClubFinances();
            clubData.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuComp_Click(object sender, EventArgs e)
        {
            Competitions Cups = new FMProject.Competitions();
            Cups.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuTransfer_Click(object sender, EventArgs e)
        {
            TransferMarket transferMarket = new FMProject.TransferMarket();
            transferMarket.Show(); this.Hide();
            this.Hide();
        }

        private void ButMenuManagerProfile_Click(object sender, EventArgs e)
        {
            ManagerProfile manProf = new FMProject.ManagerProfile();
            manProf.Show(); this.Hide();
            this.Hide();
        }

        private void ButChangeCountry_Click(object sender, EventArgs e)
        {
            CountryDialog cunch = new UI.CountryDialog();
            cunch.Show();
            this.Hide();
        }

        private void ButPlayerStatistics_Click_1(object sender, EventArgs e)
        {
            PlayerStatistics PlyrStats = new FMProject.PlayerStatistics();
            PlyrStats.Show();
            this.Hide();
        }

        private void ButCups_Click(object sender, EventArgs e)
        {

        }

        private void DataGridLeagueDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
