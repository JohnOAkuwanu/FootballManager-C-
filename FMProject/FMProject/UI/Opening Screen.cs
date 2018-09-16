using FMProject.Domain;
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
using System.Xml.Linq;
using System.Xml.Serialization;


namespace FMProject
{

    public partial class Form1 : Form
    {
        delegate string data();
        private string GameFileName;
        DialogResult result;

        public Form1()
        {
            InitializeComponent();
        }


        private void ButNewGame_Click(object sender, EventArgs e)
        {
            ManagerCreation fCreate = new ManagerCreation();
            fCreate.Show(); this.Hide();
            this.Hide();
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();


            if (result != DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                GameController.SavedGame = true;
                GameController.SavedGameFile = openFileDialog1.FileName;

                InGameHome home = new InGameHome();
                home.Show();
                this.Hide();
            }           
        }
    }
}

