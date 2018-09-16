using FMProject.Data;
using FMProject.Domain;
using FMProject.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FMProject
{
    public partial class TransferMarket : Form
    {
        public static string PlayerNameActivate;
        public TransferMarket()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;

        private void TransferMarket_Load(object sender, EventArgs e)
        {            
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();

            DataTable generalTable = new DataTable();
            generalTable.Columns.Add("Name");
            generalTable.Columns.Add("Position");
            generalTable.Columns.Add("Club");
            generalTable.Columns.Add("MarketValue");
            
            foreach (var player in clubPlayers)
            {
                generalTable.Rows.Add(new object[] { player.FirstName, player.Positions, player.AssignedClub, player.MarketValue });
            }
            TransferGeneralList.DataSource = generalTable;            
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButFilter_Click(object sender, EventArgs e)
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

            ClubFinances ClubFinance = new ClubFinances();
            ClubFinance.Show(); this.Hide();
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

        private void TransferGeneralList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewPlayer PlayerDialog = new ViewPlayer();
            ViewPlayer PlayerDialogText = new ViewPlayer();
            string TxtName = PlayerDialog.TxtPlayerName.Text;
            int columnIndex = TransferGeneralList.CurrentCell.ColumnIndex;
            int rowIndex = TransferGeneralList.CurrentCell.RowIndex;
            //var i = TransferGeneralList.CurrentRow.Index;
            //TxtName = TransferGeneralList[columnIndex].(i).value;
            //form2 f = new form2(text1.Text);
            //PlayerDialogText.ShowDialog();
            string data = (string)TransferGeneralList[columnIndex, rowIndex].Value;
            //Aimed to get the name of the cell of the selected player

            //PlayerDialogText.TxtPlayerName.Text += data;
            PlayerNameActivate = data;
            PlayerDialog.Show();
            //This is aimed to open a dialog which shows the player, who was selected, full details and information
        }

        private void TransferGeneralList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ViewPlayer PlayerDialog = new ViewPlayer();
            //ViewPlayer PlayerDialogText = new ViewPlayer();
            //string TxtName = PlayerDialog.TxtPlayerName.Text;
            //int columnIndex = TransferGeneralList.CurrentCell.ColumnIndex;
            //int rowIndex = TransferGeneralList.CurrentCell.RowIndex;
            ////var i = TransferGeneralList.CurrentRow.Index;
            ////TxtName = TransferGeneralList[columnIndex].(i).value;
            ////form2 f = new form2(text1.Text);
            ////PlayerDialogText.ShowDialog();
            //string data = (string)TransferGeneralList[columnIndex, rowIndex].Value;
            ////Aimed to get the name of the cell of the selected player

            ////PlayerDialogText.TxtPlayerName.Text += data;
            //PlayerNameActivate = data;
            //PlayerDialog.Show();
            //This is aimed to open a dialog which shows the player, who was selected, full details and information
        }
    }
}