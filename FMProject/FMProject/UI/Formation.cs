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
    public partial class Formation : Form
    {
        public string PlayerFormationName1 { get; set; }
        public string PlayerFormationName2 { get; set; }
        public string PlayerFormationName3 { get; set; }
        public string PlayerFormationName4 { get; set; }
        public string PlayerFormationName5 { get; set; }
        public string PlayerFormationName6 { get; set; }
        public string PlayerFormationName7 { get; set; }
        public string PlayerFormationName8 { get; set; }
        public string PlayerFormationName9 { get; set; }
        public string PlayerFormationName10 { get; set; }
        public string PlayerFormationNameGK { get; set; }
        public string PlayerFormationNameSubs { get; set; }
        public List<string> PlayerNamesDL = new List<string>();
        public List<string> PlayerNamesDC = new List<string>();
        public List<string> PlayerNamesDC1 = new List<string>();
        public List<string> PlayerNamesDC2 = new List<string>();
        public List<string> PlayerNamesDC3 = new List<string>();
        public List<string> PlayerNamesDR = new List<string>();
        public List<string> PlayerNamesDR1 = new List<string>();
        public List<string> PlayerNamesWBL = new List<string>();
        public List<string> PlayerNamesWBR = new List<string>();
        public List<string> PlayerNamesDMC = new List<string>();
        public List<string> PlayerNamesDMC1 = new List<string>();
        public List<string> PlayerNamesDMC2 = new List<string>();
        public List<string> PlayerNamesMC = new List<string>();
        public List<string> PlayerNamesMC1 = new List<string>();
        public List<string> PlayerNamesMC2 = new List<string>();
        public List<string> PlayerNamesMC3 = new List<string>();
        public List<string> PlayerNamesMC4 = new List<string>();
        public List<string> PlayerNamesMC5 = new List<string>();
        public List<string> PlayerNamesML = new List<string>();
        public List<string> PlayerNamesML1 = new List<string>();
        public List<string> PlayerNamesML2 = new List<string>();
        public List<string> PlayerNamesML3 = new List<string>();
        public List<string> PlayerNamesML4 = new List<string>();
        public List<string> PlayerNamesML5 = new List<string>();
        public List<string> PlayerNamesMR = new List<string>();
        public List<string> PlayerNamesMR1 = new List<string>();
        public List<string> PlayerNamesAMR = new List<string>();
        public List<string> PlayerNamesAMR1 = new List<string>();
        public List<string> PlayerNamesAML = new List<string>();
        public List<string> PlayerNamesAML1 = new List<string>();
        public List<string> PlayerNamesAML2 = new List<string>();
        public List<string> PlayerNamesAMC = new List<string>();
        public List<string> PlayerNamesST = new List<string>();
        public List<string> PlayerNamesST1 = new List<string>();
        public List<string> PlayerNamesST2 = new List<string>();
        public List<string> PlayerNamesST3 = new List<string>();
        public List<string> PlayerNamesST4 = new List<string>();
        public List<string> PlayerNamesGK = new List<string>();
        public List<string> PlayerNamesSubs1 = new List<string>();
        public List<string> PlayerNamesSubs2 = new List<string>();
        public List<string> PlayerNamesSubs3 = new List<string>();
        public List<string> PlayerNamesSubs4 = new List<string>();
        public List<string> PlayerNamesSubs5 = new List<string>();
        public List<string> PlayerNamesSubs6 = new List<string>();
        public List<string> PlayerNamesSubs7 = new List<string>();

        private List<string> listPositions = new List<string>();


        public Formation()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;

        private void Formation_Load(object sender, EventArgs e)
        {
            ComboBoxPopulator();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("WBL");
            listPositions.Items.Add("WBR");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");

            ComboBoxPopulator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("ML");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MR");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");

            ComboBoxPopulator();
        }

        private void but442Def_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("DMC");
            listPositions.Items.Add("DMC");
            listPositions.Items.Add("ML");
            listPositions.Items.Add("MR");
            listPositions.Items.Add("STC");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DR";
            FormationIndex5.Text = "DMC";
            FormationIndex6.Text = "DMC";
            FormationIndex7.Text = "ML";
            FormationIndex8.Text = "MR";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but442Att_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("AML");
            listPositions.Items.Add("AMR");
            listPositions.Items.Add("STC");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DR";
            FormationIndex5.Text = "MC";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "AML";
            FormationIndex8.Text = "AMR";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but451_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("ML");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MR");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DR";
            FormationIndex5.Text = "ML";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "MC";
            FormationIndex8.Text = "MC";
            FormationIndex9.Text = "MR";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but4231_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("AML");
            listPositions.Items.Add("AMC");
            listPositions.Items.Add("AMR");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DR";
            FormationIndex5.Text = "MC";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "AML";
            FormationIndex8.Text = "AMC";
            FormationIndex9.Text = "AMR";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but4231Def_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("DMC");
            listPositions.Items.Add("DMC");
            listPositions.Items.Add("AML");
            listPositions.Items.Add("AMC");
            listPositions.Items.Add("AMR");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DR";
            FormationIndex5.Text = "DMC";
            FormationIndex6.Text = "DMC";
            FormationIndex7.Text = "AML";
            FormationIndex8.Text = "AMC";
            FormationIndex9.Text = "AMR";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but541_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("ML");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MR");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DC";
            FormationIndex5.Text = "DR";
            FormationIndex6.Text = "ML";
            FormationIndex7.Text = "MC";
            FormationIndex8.Text = "MC";
            FormationIndex9.Text = "MR";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but541Def_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("DMC");
            listPositions.Items.Add("DMC");
            listPositions.Items.Add("ML");
            listPositions.Items.Add("MR");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DC";
            FormationIndex5.Text = "DR";
            FormationIndex6.Text = "DMC";
            FormationIndex7.Text = "DMC";
            FormationIndex8.Text = "ML";
            FormationIndex9.Text = "MR";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but541Att_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("AML");
            listPositions.Items.Add("AMR");
            listPositions.Items.Add("ST");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DC";
            FormationIndex5.Text = "DR";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "MC";
            FormationIndex8.Text = "AML";
            FormationIndex9.Text = "AMR";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but352_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("ML");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MR");
            listPositions.Items.Add("STC");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DC";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "ML";
            FormationIndex5.Text = "MC";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "MC";
            FormationIndex8.Text = "MR";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but352Att_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("AML");
            listPositions.Items.Add("AMR");
            listPositions.Items.Add("STC");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DC";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "MC";
            FormationIndex5.Text = "MC";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "AML";
            FormationIndex8.Text = "AMR";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but532_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("ML");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MR");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DC";
            FormationIndex5.Text = "DR";
            FormationIndex6.Text = "ML";
            FormationIndex7.Text = "MC";
            FormationIndex8.Text = "MR";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but532Att_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("AML");
            listPositions.Items.Add("AMR");
            listPositions.Items.Add("STC");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DC";
            FormationIndex5.Text = "DR";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "AML";
            FormationIndex8.Text = "AMR";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but424_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DR";
            FormationIndex5.Text = "MC";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "ST";
            FormationIndex8.Text = "ST";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();
        }

        private void but433_Click(object sender, EventArgs e)
        {
            listPositions.Items.Clear();
            listPositions.Items.Add("GK");
            listPositions.Items.Add("DL");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DC");
            listPositions.Items.Add("DR");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("MC");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");
            listPositions.Items.Add("ST");

            FormationIndex1.Text = "DL";
            FormationIndex2.Text = "DC";
            FormationIndex3.Text = "DC";
            FormationIndex4.Text = "DR";
            FormationIndex5.Text = "MC";
            FormationIndex6.Text = "MC";
            FormationIndex7.Text = "MC";
            FormationIndex8.Text = "ST";
            FormationIndex9.Text = "ST";
            FormationIndex10.Text = "ST";

            ComboBoxPopulator();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void LABEL1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxPopulator()
        {

            if (FormationIndex1.Text == "DL")
            {
                PlayerNamesDL.Clear();              
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => x.Positions.Contains("D L") || x.Positions.Contains("D RL"));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName1 = player.FirstName;
                    PlayerNamesDL.Add(PlayerFormationName1);
                }

                ListDL.DataSource = PlayerNamesDL;
            }
            if (FormationIndex1.Text == "DC")
            {
                PlayerNamesDC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D C") || x.Positions.Contains("D RC") || x.Positions.Contains("D LC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName1 = player.FirstName;
                    PlayerNamesDC.Add(PlayerFormationName1);
                }

                ListDL.DataSource = PlayerNamesDC;
            }

            if (FormationIndex2.Text == "DC")
            {
                PlayerNamesDC.Clear();                               
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D C") || x.Positions.Contains("D RC") || x.Positions.Contains("D LC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName2 = player.FirstName;
                    PlayerNamesDC1.Add(PlayerFormationName2);
                }

                ListDC.DataSource = PlayerNamesDC1;
                ListDC.Items.Remove(ListDL.SelectedText);
            }

            if (FormationIndex3.Text == "DC")
            {
                PlayerNamesDC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D C") || x.Positions.Contains("D RC") || x.Positions.Contains("D LC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName3 = player.FirstName;
                    PlayerNamesDC2.Add(PlayerFormationName3);
                }

                ListDC2.DataSource = PlayerNamesDC2;
            }
            if (FormationIndex4.Text == "DR")
            {
                PlayerNamesDR.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D R") || x.Positions.Contains("D RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName4 = player.FirstName;
                    PlayerNamesDR.Add(PlayerFormationName4);
                }

                ListDR.DataSource = PlayerNamesDR;
            }
            if (FormationIndex4.Text == "WBL")
            {
                PlayerNamesWBL.Clear();                
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D/WB/AM L") || x.Positions.Contains("D/WB/M L") || x.Positions.Contains("D/WB L") || x.Positions.Contains("WB L") || x.Positions.Contains("WB/AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName4 = player.FirstName;
                    PlayerNamesWBL.Add(PlayerFormationName4);
                }

                ListDR.DataSource = PlayerNamesWBL;
            }
            if (FormationIndex4.Text == "ML")
            {
                PlayerNamesML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M L") || x.Positions.Contains("M L") || x.Positions.Contains("AM L") || x.Positions.Contains("M RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName4 = player.FirstName;
                    PlayerNamesML.Add(PlayerFormationName4);
                }

                ListDR.DataSource = PlayerNamesML;
            }
            if (FormationIndex4.Text == "DC")
            {
                PlayerNamesDC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D/WB/AM L") || x.Positions.Contains("D/WB/M L") || x.Positions.Contains("D/WB L") || x.Positions.Contains("WB L") || x.Positions.Contains("WB/AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName4 = player.FirstName;
                    PlayerNamesDC3.Add(PlayerFormationName4);
                }

                ListDR.DataSource = PlayerNamesDC3;
            }
            if (FormationIndex4.Text == "MC")
            {
                PlayerNamesMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M C") || x.Positions.Contains("M LC") || x.Positions.Contains("M RC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName4 = player.FirstName;
                    PlayerNamesMC.Add(PlayerFormationName4);
                }

                ListDR.DataSource = PlayerNamesMC;
            }
            if (FormationIndex5.Text == "WBR")
            {
                PlayerNamesWBR.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D/WB/AM R") || x.Positions.Contains("D/WB/M R") || x.Positions.Contains("D/WB R") || x.Positions.Contains("WB R") || x.Positions.Contains("WB/AM R")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName5 = player.FirstName;
                    PlayerNamesWBR.Add(PlayerFormationName5);
                }

                ListML.DataSource = PlayerNamesWBR;
            }
            if (FormationIndex5.Text == "DR")
            {
                PlayerNamesDR.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("D R") || x.Positions.Contains("D RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName5 = player.FirstName;
                    PlayerNamesDR1.Add(PlayerFormationName5);
                }

                ListML.DataSource = PlayerNamesDR1;
            }
            if (FormationIndex5.Text == "DMC")
            {
                PlayerNamesDMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("DM")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName5 = player.FirstName;
                    PlayerNamesDMC.Add(PlayerFormationName5);
                }

                ListML.DataSource = PlayerNamesDMC;
            }
            if (FormationIndex5.Text == "ML")
            {
                PlayerNamesML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M L") || x.Positions.Contains("M RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName5 = player.FirstName;
                    PlayerNamesML1.Add(PlayerFormationName5);
                }

                ListML.DataSource = PlayerNamesML1;
            }
            if (FormationIndex5.Text == "MC")
            {
                PlayerNamesMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M C") || x.Positions.Contains("M LC") || x.Positions.Contains("M RC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName5 = player.FirstName;
                    PlayerNamesMC1.Add(PlayerFormationName5);
                }

                ListML.DataSource = PlayerNamesMC1;
            }
            if (FormationIndex6.Text == "MC")
            {
                PlayerNamesMC2.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M C") || x.Positions.Contains("M LC") || x.Positions.Contains("M RC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName6 = player.FirstName;
                    PlayerNamesMC2.Add(PlayerFormationName6);
                }

                ListMC.DataSource = PlayerNamesMC2;
            }
            if (FormationIndex6.Text == "DMC")
            {
                PlayerNamesDMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("DM")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName6 = player.FirstName;
                    PlayerNamesDMC1.Add(PlayerFormationName6);
                }

                ListMC.DataSource = PlayerNamesDMC1;
            }
            if (FormationIndex6.Text == "ML")
            {
                PlayerNamesML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M L") || x.Positions.Contains("M RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName6 = player.FirstName;
                    PlayerNamesML2.Add(PlayerFormationName6);
                }

                ListMC.DataSource = PlayerNamesML2;
            }
            if (FormationIndex7.Text == "MC")
            {
                PlayerNamesMC3.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M C") || x.Positions.Contains("M LC") || x.Positions.Contains("M RC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName7 = player.FirstName;
                    PlayerNamesMC3.Add(PlayerFormationName7);
                }

                ListMC2.DataSource = PlayerNamesMC3;
            }
            if (FormationIndex7.Text == "DMC")
            {
                PlayerNamesDMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("DM")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName7 = player.FirstName;
                    PlayerNamesDMC2.Add(PlayerFormationName7);
                }

                ListMC2.DataSource = PlayerNamesDMC2;
            }
            if (FormationIndex7.Text == "ML")
            {
                PlayerNamesML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M L") || x.Positions.Contains("M RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName7 = player.FirstName;
                    PlayerNamesML3.Add(PlayerFormationName7);
                }

                ListMC2.DataSource = PlayerNamesML3;
            }
            if (FormationIndex7.Text == "AML")
            {
                PlayerNamesAML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM L") || x.Positions.Contains("AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName7 = player.FirstName;
                    PlayerNamesAML.Add(PlayerFormationName7);
                }

                ListMC2.DataSource = PlayerNamesAML;
            }
            if (FormationIndex7.Text == "ST")
            {
                PlayerNamesST.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("ST") || x.Positions.Contains("F C")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName7 = player.FirstName;
                    PlayerNamesST.Add(PlayerFormationName7);
                }

                ListMC2.DataSource = PlayerNamesST;
            }
            if (FormationIndex8.Text == "ST")
            {
                PlayerNamesST.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("ST") || x.Positions.Contains("F C")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName8 = player.FirstName;
                    PlayerNamesST1.Add(PlayerFormationName8);
                }

                ListMR.DataSource = PlayerNamesST1;
            }
            if (FormationIndex8.Text == "MC")
            {
                PlayerNamesMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M C") || x.Positions.Contains("M LC") || x.Positions.Contains("M RC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName8 = player.FirstName;
                    PlayerNamesMC4.Add(PlayerFormationName8);
                }

                ListMR.DataSource = PlayerNamesMC4;
            }
            if (FormationIndex8.Text == "AML")
            {
                PlayerNamesAML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM L") || x.Positions.Contains("AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName8 = player.FirstName;
                    PlayerNamesAML1.Add(PlayerFormationName8);
                }

                ListMR.DataSource = PlayerNamesAML1;
            }
            if (FormationIndex8.Text == "AMR")
            {
                PlayerNamesAMR.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM R") || x.Positions.Contains("AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName8 = player.FirstName;
                    PlayerNamesAMR.Add(PlayerFormationName8);
                }

                ListMR.DataSource = PlayerNamesAMR;
            }
            if (FormationIndex8.Text == "MR")
            {
                PlayerNamesMR.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM R") || x.Positions.Contains("AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName8 = player.FirstName;
                    PlayerNamesMR.Add(PlayerFormationName8);
                }

                ListMR.DataSource = PlayerNamesMR;
            }
            if (FormationIndex8.Text == "AMC")
            {
                PlayerNamesAMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM C") || x.Positions.Contains("AM RC") || x.Positions.Contains("AM LC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName8 = player.FirstName;
                    PlayerNamesAMC.Add(PlayerFormationName8);
                }

                ListMR.DataSource = PlayerNamesAMC;
            }
            if (FormationIndex8.Text == "ML")
            {
                PlayerNamesML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M R") || x.Positions.Contains("M RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName8 = player.FirstName;
                    PlayerNamesML4.Add(PlayerFormationName8);
                }

                ListMR.DataSource = PlayerNamesML4;
            }
            if (FormationIndex9.Text == "MR")
            {
                PlayerNamesMR.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM R") || x.Positions.Contains("AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName9 = player.FirstName;
                    PlayerNamesMR1.Add(PlayerFormationName9);
                }

                ListMR.DataSource = PlayerNamesMR1;
            }
            if (FormationIndex9.Text == "ST")
            {
                PlayerNamesST.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("ST") || x.Positions.Contains("F C")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName9 = player.FirstName;
                    PlayerNamesST2.Add(PlayerFormationName9);
                }

                ListSTC.DataSource = PlayerNamesST2;
            }
            if (FormationIndex9.Text == "MC")
            {
                PlayerNamesMC.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M C") || x.Positions.Contains("M LC") || x.Positions.Contains("M RC")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName9 = player.FirstName;
                    PlayerNamesMC5.Add(PlayerFormationName9);
                }

                ListSTC.DataSource = PlayerNamesMC5;
            }
            if (FormationIndex9.Text == "AML")
            {
                PlayerNamesAML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM L") || x.Positions.Contains("AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName9 = player.FirstName;
                    PlayerNamesAML2.Add(PlayerFormationName9);
                }

                ListSTC.DataSource = PlayerNamesAML2;
            }
            if (FormationIndex9.Text == "AMR")
            {
                PlayerNamesAMR.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("AM R") || x.Positions.Contains("AM RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName9 = player.FirstName;
                    PlayerNamesAMR1.Add(PlayerFormationName9);
                }

                ListSTC.DataSource = PlayerNamesAMR1;
            }
            if (FormationIndex9.Text == "ML")
            {
                PlayerNamesML.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("M R") || x.Positions.Contains("M RL")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName9 = player.FirstName;
                    PlayerNamesML5.Add(PlayerFormationName9);
                }

                ListSTC.DataSource = PlayerNamesML5;
            }
            if (FormationIndex10.Text == "ST")
            {
                PlayerNamesST.Clear();
                
                
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("ST") || x.Positions.Contains("F C")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationName10 = player.FirstName;
                    PlayerNamesST3.Add(PlayerFormationName10);
                }

                ListSTC2.DataSource = PlayerNamesST3;
                //var bonusnames = new List<string>();
                //bonusnames.AddRange(playernames);
                //ListSTC2.DataSource = bonusnames;
                //ListSTC2.DataSource = clubPlayers.ToList();
            }
            if (LabelGK.Text == "GK")
            {               
                var clubPlayers = controller.GameObjects.GetCurrentPlayers().Where(x => (x.Positions.Contains("GK")));
                foreach (var player in clubPlayers)
                {
                    PlayerFormationNameGK = player.FirstName;
                    PlayerNamesGK.Add(PlayerFormationNameGK);
                }

                ListGK.DataSource = PlayerNamesGK;
            }
                 
            var Subs = controller.GameObjects.GetCurrentPlayers();
            foreach (var player in Subs)
            {
                PlayerFormationNameSubs = player.FirstName;
                PlayerNamesSubs1.Add(PlayerFormationNameSubs);
                PlayerNamesSubs2.Add(PlayerFormationNameSubs);
                PlayerNamesSubs3.Add(PlayerFormationNameSubs);
                PlayerNamesSubs4.Add(PlayerFormationNameSubs);
                PlayerNamesSubs5.Add(PlayerFormationNameSubs);
                PlayerNamesSubs6.Add(PlayerFormationNameSubs);
                PlayerNamesSubs7.Add(PlayerFormationNameSubs);
            }

            ListSub1.DataSource = PlayerNamesSubs1;
            ListSub2.DataSource = PlayerNamesSubs2;
            ListSub3.DataSource = PlayerNamesSubs3;
            ListSub4.DataSource = PlayerNamesSubs4;
            ListSub5.DataSource = PlayerNamesSubs5;
            ListSub6.DataSource = PlayerNamesSubs6;
            ListSub7.DataSource = PlayerNamesSubs7;

        }

        private void ButSetFormation_Click(object sender, EventArgs e)
        {            
            var clubPlayers = controller.GameObjects.GetCurrentPlayers();
            var PlayerGK = clubPlayers.Where(x => x.FirstName == ListGK.Text);
            var Player1 = clubPlayers.Where(x => x.FirstName == ListDL.Text);
            var Player2 = clubPlayers.Where(x => x.FirstName == ListDC.Text);
            var Player3 = clubPlayers.Where(x => x.FirstName == ListDC2.Text);
            var Player4 = clubPlayers.Where(x => x.FirstName == ListDR.Text);
            var Player5 = clubPlayers.Where(x => x.FirstName == ListML.Text);
            var Player6 = clubPlayers.Where(x => x.FirstName == ListMC.Text);
            var Player7 = clubPlayers.Where(x => x.FirstName == ListMC2.Text);
            var Player8 = clubPlayers.Where(x => x.FirstName == ListMR.Text);
            var Player9 = clubPlayers.Where(x => x.FirstName == ListSTC.Text);
            var Player10 = clubPlayers.Where(x => x.FirstName == ListSTC2.Text);

            string[] allTextInputs = { ListGK.Text, ListDL.Text, ListDC.Text, ListDC2.Text, ListDR.Text, ListML.Text, ListMC.Text, ListMC2.Text, ListSTC.Text, ListSTC2.Text };

            if (allTextInputs.Length != allTextInputs.Distinct().Count())
            {
                MessageBox.Show("Contains duplicates");
            }
            else
            {                   
                foreach (var player in PlayerGK)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                  
                }

                foreach (var player in Player1)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                  
                }
                foreach (var player in Player2)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                 
                }
                foreach (var player in Player3)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                  
                }
                foreach (var player in Player4)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                 
                }
                foreach (var player in Player5)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                 
                }
                foreach (var player in Player6)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                   
                }
                foreach (var player in Player7)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                    
                }
                foreach (var player in Player8)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                 
                }
                foreach (var player in Player9)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                  
                }
                foreach (var player in Player10)
                {
                    player.MatchPosition = LabelGK.Text;
                    string plyrname = ListGK.Text;                  
                }
                this.Hide();
                Squad TeamSheets = new Squad();
                TeamSheets.Show();
            }
        }
        private void ListSTC2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
