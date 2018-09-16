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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace FMProject
{
    public partial class ManagerCreation : Form
    {
        public ManagerCreation()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }

        private GameController controller;

        private void ManagerCreation_Load(object sender, EventArgs e)
        {

            //XDocument obj = XDocument.Load("D:\\documents\\FMProject\\FMProject\\Data\\FixedGameData\\CountriesList.xml");
            //XDocument LangObj = XDocument.Load("D:\\documents\\FMProject\\FMProject\\Data\\FixedGameData\\LanguagesList.xml");
            //XDocument ClubObj = XDocument.Load("D:\\documents\\FMProject\\FMProject\\Data\\FixedGameData\\BPLLeagueDataNew.xml");
            ListNationalityPrimary.DataSource = GameController.ListCountries();
            ListNationalitySecondary.DataSource = GameController.ListCountries();
            ListLanguagePrimary.DataSource = GameController.ListLanguages();
            ListLanguageSecondary.DataSource = GameController.ListLanguages();
            // This populates 4 comboboxes with a list of languages and nations 
            //ClubList.DataSource = ClubObj.Descendants("participants").Select(x => x.Attribute("participantname").Value).ToList();
            //var NAME = XDocument.Load("D:\\documents\\documentsdocumentsVisual Studio Projects\\FMProject\\FMProject\\Data\\FixedGameData\\BPLLeagueDataNew.xml");
            //List<String> nameList = new List<String>();

            //if (NAME.Attribute("participantname") != null)
            //{
            //    nameList.Add(NAME.Attribute("participantname").Value);
            //}
            //ClubList.DataSource = nameList;

            //var output = new List<string>();
            //foreach (var element in controller.ListClubs())
            //{
            //    output.Add(element.Value.ToString());
            //}
            ClubList.DataSource = controller.ListClubs();
            //This creates a new list called output where each element which has an attribute called participtant name has its name added to a list           
        }

        private void ButContinue_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(controller.GameObjects.ManagerEntity.AssignedClub))
            {
                controller.GameObjects.ManagerEntity.AssignedClub = ClubList.Text;
            }

            if (ListNationalityPrimary.Text == "None" == false)
            {
                if (ListNationalitySecondary == ListNationalityPrimary == false)
                {
                    if (string.IsNullOrEmpty(controller.GameObjects.ManagerEntity.PrimaryNationality))
                    {
                        controller.GameObjects.ManagerEntity.PrimaryNationality = ListNationalityPrimary.Text;
                    }

                    if (string.IsNullOrEmpty(controller.GameObjects.ManagerEntity.SecondaryNationality))
                    {
                        controller.GameObjects.ManagerEntity.SecondaryNationality = ListNationalitySecondary.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Nationality and Do Not Choose The Same Nationality");
                }
            }
            if (ListLanguagePrimary.Text == "None" == false)
            {
                if (ListLanguageSecondary.Text == ListLanguagePrimary.Text == false)
                {
                    if (string.IsNullOrEmpty(controller.GameObjects.ManagerEntity.PrimaryLanguage))
                    {
                        controller.GameObjects.ManagerEntity.PrimaryLanguage = ListLanguagePrimary.Text;
                    }

                    if (string.IsNullOrEmpty(controller.GameObjects.ManagerEntity.SecondaryLanguage))
                    {
                        controller.GameObjects.ManagerEntity.SecondaryLanguage = ListLanguageSecondary.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Language and Do Not Choose The Same Language");
                }
            }

            if (string.IsNullOrEmpty(TxtUsername.Text) == false)
            {
                if (string.IsNullOrEmpty(controller.GameObjects.ManagerEntity.Name))
                {
                    controller.GameObjects.ManagerEntity.Name = TxtUsername.Text;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Name");
            }

            if (string.IsNullOrEmpty(TxtUsername.Text) == false)
            {
                if (ListLanguagePrimary.Text == ListLanguageSecondary.Text == false)
                {
                    if (ListNationalityPrimary.Text == ListNationalitySecondary.Text == false)
                    {
                        controller.GameObjects.ManagerEntity.Name = TxtUsername.Text;
                        controller.GameObjects.ManagerEntity.PrimaryLanguage = ListLanguagePrimary.Text;
                        controller.GameObjects.ManagerEntity.SecondaryLanguage = ListLanguageSecondary.Text;
                        controller.GameObjects.ManagerEntity.PrimaryNationality = ListNationalityPrimary.Text;
                        controller.GameObjects.ManagerEntity.SecondaryNationality = ListNationalitySecondary.Text;
                        this.Hide();
                        AttributesForm afForm = new AttributesForm();
                        afForm.Show(); this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Your First Name");
                    }
                }
            }
            // a series of conditions to make sure everything is filled in accordingly before we progress to the next stage of creating your manager profile

        }
    }
}


