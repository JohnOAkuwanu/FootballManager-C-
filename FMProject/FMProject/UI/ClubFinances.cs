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
    public partial class ClubFinances : Form
    {
        public ClubFinances()
        {
            InitializeComponent();
        }

        private void ButMenuHome_Click(object sender, EventArgs e)
        {
            InGameHome fhome = new InGameHome();
            fhome.Show(); this.Hide();
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
    }
}
