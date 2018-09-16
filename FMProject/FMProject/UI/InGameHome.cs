using FMProject.Data;
using FMProject.Domain;
using FMProject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FMProject
{
    public partial class InGameHome : Form
    {
        public InGameHome()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;
        public static string GameFileName;

        private void InGameHome_Load(object sender, EventArgs e)
        {
            AttributesForm SkillsForm = new AttributesForm();
            SkillsForm.Close();            
            TxtAbility.Text = this.controller.GameObjects.CurrentTeamAvgTotalAbility().ToString();
            var manager = this.controller.GameObjects.ManagerEntity;
            var team = this.controller.GameObjects.GetCurrentTeam();

            FixtureView.DataSource = controller.GetCurrentFixturesAsDataTable();
           
            TxtTeamName.Text = manager.AssignedClub;
            TxtManagerName.Text = manager.Name;            

            TxtDay.Text = controller.GameObjects.GameWeek.ToString();            
            TxtLeaguePos.Text = team.LeaguePos.ToString();

            //XmlDataDocument xmlDatadoc = new XmlDataDocument();
            //xmlDatadoc.DataSet.ReadXml("D:\\documents\\FMProject\\FMProject\\Data\\CurrentGameData\\AmendableLeagueData.xml");
            //DataSet ds = new DataSet("PremierLeagueLeagueTable");
            //ds = xmlDatadoc.DataSet;
            LeagueView.DataSource = controller.GameObjects.Teams;// ds.Tables[1];

            var Winner = this.LeagueView.Rows[0];
            Winner.DefaultCellStyle.BackColor = Color.Gold;

            foreach (DataGridViewRow i in LeagueView.Rows)
                if (i == this.LeagueView.Rows[1] || i == this.LeagueView.Rows[2] || i == this.LeagueView.Rows[3])
                {
                    i.DefaultCellStyle.BackColor = Color.Green;
                }

            foreach (DataGridViewRow j in LeagueView.Rows)
                if (j == this.LeagueView.Rows[4] || j == this.LeagueView.Rows[5])
                {
                    j.DefaultCellStyle.BackColor = Color.LightGreen;
                }

            foreach (DataGridViewRow i in LeagueView.Rows)
                if (i == this.LeagueView.Rows[17] || i == this.LeagueView.Rows[18] || i == this.LeagueView.Rows[19])
                {
                    i.DefaultCellStyle.BackColor = Color.Red;
                }


            controller.StartUpFunction();
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtManagerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.OpenFile());
                if ((sr != null))
                {
                    //data d1 = sr.ReadToEnd;
                    sr.Close();
                }
            }
        }

        private void ButMenuTeam_Click_1(object sender, EventArgs e)
        {
            Squad SquadScreen = new FMProject.Squad();
            SquadScreen.Show(); this.Hide();
            this.Hide();
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

        private void ButContinue_Click(object sender, EventArgs e)
        {
            controller.GameObjects.Round += 1;
            controller.GameObjects.GameWeek += 1;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fileName = saveFileDialog1.FileName;
            var xml = GameController.Instance.GetGameDataAsXmlString();
            File.WriteAllText(fileName, xml);
        }
    }
}