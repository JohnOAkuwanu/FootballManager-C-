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
    public partial class Squad : Form
    {
        public static string PlayerNamePublic;
        private static double AverageAbility;
        private static double SumAverageAbility = 0;
        private static int playercount = 0;
        public static double TotalTeamAvgAbility;


        public Squad()
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

        private void Squad_Load(object sender, EventArgs e)
        {

          
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            GetAverageAbility();
            double TeamAverageAbility = SumAverageAbility / playercount;
            TotalTeamAvgAbility = Math.Round(TeamAverageAbility, 0, MidpointRounding.AwayFromZero);
            txtTeamAbility.Text = TotalTeamAvgAbility.ToString();
         
            DataTable generalTable = new DataTable();
            generalTable.Columns.Add("Name");
            generalTable.Columns.Add("Match Position");
            generalTable.Columns.Add("Position");
            generalTable.Columns.Add("Nation");
            generalTable.Columns.Add("Age");
            generalTable.Columns.Add("Happiness");
            generalTable.Columns.Add("Condition");

            foreach (var player in clubPlayers)
            {
                generalTable.Rows.Add(new object[] { player.FirstName, player.MatchPosition, player.Positions, player.Nationality, player.Age, player.Happiness, player.Condition });
            }
            squadDataView.DataSource = generalTable;

            DataTable MatchStatsTable = new DataTable();
            MatchStatsTable.Columns.Add("Name");
            MatchStatsTable.Columns.Add("Goals");
            MatchStatsTable.Columns.Add("Assists");
            MatchStatsTable.Columns.Add("Yellow Cards");
            MatchStatsTable.Columns.Add("Red Cards");
            MatchStatsTable.Columns.Add("Clean Sheets");
            MatchStatsTable.Columns.Add("Form");

            foreach (var player in clubPlayers)
            {
                MatchStatsTable.Rows.Add(new object[] { player.FirstName, player.Goals, player.Assists, player.YelCards, player.RedCards, player.CleanSheets, player.Form });
            }
            MatchStatsView.DataSource = MatchStatsTable;

            DataTable contractsTable = new DataTable();
            contractsTable.Columns.Add("Name");
            contractsTable.Columns.Add("Age");
            contractsTable.Columns.Add("Value");
            contractsTable.Columns.Add("Wages");

            foreach (var player in clubPlayers)
            {
                contractsTable.Rows.Add(new object[] { player.FirstName, player.Age, player.MarketValue, player.ContractValue });
            }
            contractsView.DataSource = contractsTable;

            DataTable attStatsTable = new DataTable();
            attStatsTable.Columns.Add("Name");
            attStatsTable.Columns.Add("Finishing");
            attStatsTable.Columns.Add("Dribbling");
            attStatsTable.Columns.Add("Crossing");
            attStatsTable.Columns.Add("Free Kick");
            attStatsTable.Columns.Add("Heading");
            attStatsTable.Columns.Add("Long Shot");
            attStatsTable.Columns.Add("Movement");
            attStatsTable.Columns.Add("Passing");
            foreach (var player in clubPlayers)
            {
                attStatsTable.Rows.Add(new object[] { player.FirstName, player.Finishing, player.Dribbling, player.Crossing, player.FreeKick, player.Heading, player.LongShot, player.Movement, player.Passing });
            }
            attackStatsView.DataSource = attStatsTable;

            DataTable defStatsTable = new DataTable();
            defStatsTable.Columns.Add("Name");
            defStatsTable.Columns.Add("Positioning");
            defStatsTable.Columns.Add("Heading");
            defStatsTable.Columns.Add("Marking");
            defStatsTable.Columns.Add("Strength");
            defStatsTable.Columns.Add("Tackling");

            foreach (var player in clubPlayers)
            {
                defStatsTable.Rows.Add(new object[] { player.FirstName, player.DefPos, player.Heading, player.Marking, player.Strength, player.Tackling });
            }
            defStatsView.DataSource = defStatsTable;
        }

        private void ButMenuTraining_Click_1(object sender, EventArgs e)
        {
            Training TeamTraining = new Training();
            TeamTraining.Show(); this.Hide();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewPlayer PlayerDialog = new ViewPlayer();
            ViewPlayer PlayerDialogText = new ViewPlayer();
            string TxtName = PlayerDialog.TxtPlayerName.Text;
            int columnIndex = MatchStatsView.CurrentCell.ColumnIndex;
            int rowIndex = MatchStatsView.CurrentCell.RowIndex;
            //var i = TransferGeneralList.CurrentRow.Index;
            //TxtName = TransferGeneralList[columnIndex].(i).value;
            //form2 f = new form2(text1.Text);
            //PlayerDialogText.ShowDialog();
            string data = (string)MatchStatsView[0, rowIndex].Value;
            //Aimed to get the name of the cell of the selected player

            //PlayerDialogText.TxtPlayerName.Text += data;
            PlayerNamePublic = data;
            PlayerDialog.Show();
            //This is aimed to open a dialog which shows the player, who was selected, full details and information
        }

        private void defStatsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewPlayer PlayerDialog = new ViewPlayer();
            ViewPlayer PlayerDialogText = new ViewPlayer();
            string TxtName = PlayerDialog.TxtPlayerName.Text;
            int columnIndex = defStatsView.CurrentCell.ColumnIndex;
            int rowIndex = defStatsView.CurrentCell.RowIndex;
            //var i = TransferGeneralList.CurrentRow.Index;
            //TxtName = TransferGeneralList[columnIndex].(i).value;
            //form2 f = new form2(text1.Text);
            //PlayerDialogText.ShowDialog();
            string data = (string)defStatsView[0, rowIndex].Value;
            //Aimed to get the name of the cell of the selected player

            //PlayerDialogText.TxtPlayerName.Text += data;
            PlayerNamePublic = data;
            PlayerDialog.Show();
            //This is aimed to open a dialog which shows the player, who was selected, full details and information
        }

        private void contractsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void squadDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewPlayer PlayerDialog = new ViewPlayer();
            ViewPlayer PlayerDialogText = new ViewPlayer();
            string TxtName = PlayerDialog.TxtPlayerName.Text;
            int columnIndex = squadDataView.CurrentCell.ColumnIndex;
            int rowIndex = squadDataView.CurrentCell.RowIndex;
            //var i = TransferGeneralList.CurrentRow.Index;
            //TxtName = TransferGeneralList[columnIndex].(i).value;
            //form2 f = new form2(text1.Text);
            //PlayerDialogText.ShowDialog();
            string data = (string)squadDataView[0, rowIndex].Value;
            //Aimed to get the name of the cell of the selected player

            //PlayerDialogText.TxtPlayerName.Text += data;
            PlayerNamePublic = data;
            PlayerDialog.Show();
            //This is aimed to open a dialog which shows the player, who was selected, full details and information
        }

        private void attackStatsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewPlayer PlayerDialog = new ViewPlayer();
            ViewPlayer PlayerDialogText = new ViewPlayer();
            string TxtName = PlayerDialog.TxtPlayerName.Text;
            int columnIndex = attackStatsView.CurrentCell.ColumnIndex;
            int rowIndex = attackStatsView.CurrentCell.RowIndex;
            //var i = TransferGeneralList.CurrentRow.Index;
            //TxtName = TransferGeneralList[columnIndex].(i).value;
            //form2 f = new form2(text1.Text);
            //PlayerDialogText.ShowDialog();
            string data = (string)attackStatsView[0, rowIndex].Value;
            //Aimed to get the name of the cell of the selected player

            //PlayerDialogText.TxtPlayerName.Text += data;
            PlayerNamePublic = data;
            PlayerDialog.Show();
            //This is aimed to open a dialog which shows the player, who was selected, full details and information
        }

        private void defStatsView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ViewPlayer PlayerDialog = new ViewPlayer();
            ViewPlayer PlayerDialogText = new ViewPlayer();

            string TxtName = PlayerDialog.TxtPlayerName.Text;
            int columnIndex = defStatsView.CurrentCell.ColumnIndex;
            int rowIndex = defStatsView.CurrentCell.RowIndex;
            //var i = TransferGeneralList.CurrentRow.Index;
            //TxtName = TransferGeneralList[columnIndex].(i).value;
            //form2 f = new form2(text1.Text);
            //PlayerDialogText.ShowDialog();
            string data = (string)defStatsView[0, rowIndex].Value;
            //Aimed to get the name of the cell of the selected player

            //PlayerDialogText.TxtPlayerName.Text += data;
            PlayerNamePublic = data;
            PlayerDialog.Show();
            //This is aimed to open a dialog which shows the player, who was selected, full details and information
        }
        private void GetAverageAbility()
        {
        
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            double TeamTotalAbility;


            foreach (var player in clubPlayers)
            {
                playercount = playercount + 1;
            
                string plyrname = player.FirstName;

                if (player.Positions.Contains("AM R") || player.Positions.Contains("AM L") || player.Positions.Contains("AM C"))
                {
                    int totalAM = player.Vision + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Crossing + player.Acceleration;
                    double avgability = (totalAM + 3.5) / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                    
                    AverageAbility = playerability;
                }
                if (player.Positions.Contains("ST") || player.Positions.Contains("F C"))
                {
                    int totalST = player.Strength + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Heading + player.Acceleration;
                    double avgability = totalST / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                
                    AverageAbility = playerability;

                }
                if (player.Positions.Contains("M C") || player.Positions.Contains("M R") || player.Positions.Contains("M L") || player.Positions.Contains("DM"))
                {
                    int totalM = player.WorkRate + player.Vision + player.Tackling + player.Strength + player.Passing + player.Marking + player.Finishing + player.Dribbling + player.Crossing;
                    double avgability = totalM / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                  
                    AverageAbility = playerability;

                }
                if (player.Positions.Contains("D C") || player.Positions.Contains("D R") || player.Positions.Contains("D L"))
                {
                    int totalD = player.WorkRate + player.Tackling + player.Strength + player.Passing + player.Pace + player.Marking + player.Heading + player.DefPos;
                    double avgability = totalD / 8;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
               
                    AverageAbility = playerability;
                }
                if (player.Positions.Contains("G"))
                {
                    int totalGK = player.Reflexes + player.Passing + player.OneVsOne + player.Handling + player.CommandArea + player.AerialAbility;
                    double avgability = totalGK / 6;
                    double playerability = Math.Round(avgability * 5, 0, MidpointRounding.AwayFromZero);
                  
                    AverageAbility = playerability;
                }

                SumAverageAbility = SumAverageAbility + AverageAbility;              
            }
        }
        private void AvgAbility()
        {         
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            foreach (var player in clubPlayers)
            {

                if (player.Positions.Contains("AM R") || player.Positions.Contains("AM L") || player.Positions.Contains("AM C"))
                {
                    int totalAM = player.Vision + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Crossing + player.Acceleration;
                    double avgability = (totalAM + 3.5) / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                }
                if (player.Positions.Contains("ST") || player.Positions.Contains("F C"))
                {
                    int totalST = player.Strength + player.Passing + player.Pace + player.Movement + player.LongShot + player.Finishing + player.Dribbling + player.Heading + player.Acceleration;
                    double avgability = totalST / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                }
                if (player.Positions.Contains("M C") || player.Positions.Contains("M R") || player.Positions.Contains("M L") || player.Positions.Contains("DM"))
                {
                    int totalM = player.WorkRate + player.Vision + player.Tackling + player.Strength + player.Passing + player.Marking + player.Finishing + player.Dribbling + player.Crossing;
                    double avgability = totalM / 9;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);
                }
                if (player.Positions.Contains("D C") || player.Positions.Contains("D R") || player.Positions.Contains("D L"))
                {
                    int totalD = player.WorkRate + player.Tackling + player.Strength + player.Passing + player.Pace + player.Marking + player.Heading + player.DefPos;
                    double avgability = totalD / 8;
                    double playerability = Math.Round(avgability * 6, 0, MidpointRounding.AwayFromZero);

                }
                if (player.Positions.Contains("G"))
                {
                    int totalGK = player.Reflexes + player.Passing + player.OneVsOne + player.Handling + player.CommandArea + player.AerialAbility;
                    double avgability = totalGK / 6;
                    double playerability = Math.Round(avgability * 5, 0, MidpointRounding.AwayFromZero);
                }
            }
        }
    }
}
