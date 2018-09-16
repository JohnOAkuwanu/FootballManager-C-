using FMProject.Data;
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


namespace FMProject
{
    public partial class AttributesForm : Form

    {
        public Action action { get; set; }
        XDocument doc2;

        private GameController controller;


        public AttributesForm()
        {
            InitializeComponent();
            this.controller = GameController.Instance;
        }
        private const int MinValue = 0;
        private const int MaxValue = 20;
        //This sets the maximum value of each attribute to 20 and the minimum value as 0
        private void AttributesForm_Load(object sender, EventArgs e)
        {
            ManagerCreation ManagerCreate = new ManagerCreation();
            ManagerCreate.Close();

            AttackCoaching.Value = controller.GameObjects.ManagerEntity.Attacking;
            DefCoaching.Value = controller.GameObjects.ManagerEntity.Defending;
            GoalkeepingCoaching.Value = controller.GameObjects.ManagerEntity.GoalKeeping;
            MentalCoaching.Value = controller.GameObjects.ManagerEntity.Mental;
            TacticalCoaching.Value = controller.GameObjects.ManagerEntity.Tactical;
            YouthDevelopment.Value = controller.GameObjects.ManagerEntity.YouthDev;
            TechnicalCoaching.Value = controller.GameObjects.ManagerEntity.Technical;
            FitnessCoaching.Value = controller.GameObjects.ManagerEntity.Fitness;
            Motivating.Value = controller.GameObjects.ManagerEntity.Motivating;
            DeterminationManager.Value = controller.GameObjects.ManagerEntity.Determination;
            PlayerKnowledge.Value = controller.GameObjects.ManagerEntity.PlayerKnowledge;
            LvlOfDiscipline.Value = controller.GameObjects.ManagerEntity.Discpline;
            Adaptablity.Value = controller.GameObjects.ManagerEntity.Adaptability;
            WorkRateManager.Value = controller.GameObjects.ManagerEntity.WorkRateManager;
            MediaHandling.Value = controller.GameObjects.ManagerEntity.MediaHandling;
            //This sets each progress bar to the equivalence of the value of the value pegged to the Manager's attribute value
            ValidateTaxCredit();


        }

        static void removeAllAttributes(XDocument doc)
        {
            foreach (var des in doc.Descendants())
                des.RemoveAttributes();
            //Aimed to remove all of descendants within an xml file
        }

        void CopyXmlDocument(string oldfile, string newfile)
        {
            XmlDocument document = new XmlDocument();
            document.Load("D:\\documents\\FMProject\\FMProject\\Data\\FixedGameData\\ManagerProfileOriginal.xml");

            // Modify XML file using XmlDocument here

            Console.WriteLine(document.OuterXml);
            if (File.Exists("D:\\documents\\FMProject\\FMProject\\Data\\CurrentGameData\\ManagerProfile.xml"))
                File.Delete("D:\\documents\\FMProject\\FMProject\\Data\\CurrentGameData\\ManagerProfile.xml");
            document.Save("D:\\documents\\FMProject\\FMProject\\Data\\CurrentGameData\\ManagerProfile.xml");
        }

        private void ButContinue_Click(object sender, EventArgs e)
        {       
            //var allTeams = DataManager.LoadAllTeams();
            //var manager = DataManager.LoadManager();
            //var managers = manager.ManagerAttributes.Where(man => man.Name != null);
                        
            string managername = controller.GameObjects.ManagerEntity.Name;
            string clubname = controller.GameObjects.ManagerEntity.AssignedClub;
            string PNation = controller.GameObjects.ManagerEntity.PrimaryNationality;
            string SNation = controller.GameObjects.ManagerEntity.SecondaryNationality;
            string PLang = controller.GameObjects.ManagerEntity.PrimaryLanguage;
            string SLang = controller.GameObjects.ManagerEntity.SecondaryLanguage;
            DateTime DOB = controller.GameObjects.ManagerEntity.DateOfBirth;
                              
            controller.GameObjects.ManagerEntity.Attacking = AttackCoaching.Value;
            controller.GameObjects.ManagerEntity.Defending = DefCoaching.Value;
            controller.GameObjects.ManagerEntity.GoalKeeping = GoalkeepingCoaching.Value;
            controller.GameObjects.ManagerEntity.Mental = MentalCoaching.Value;
            controller.GameObjects.ManagerEntity.Tactical = TacticalCoaching.Value;
            controller.GameObjects.ManagerEntity.YouthDev = YouthDevelopment.Value;
            controller.GameObjects.ManagerEntity.Technical = TechnicalCoaching.Value;
            controller.GameObjects.ManagerEntity.Fitness = FitnessCoaching.Value;
            controller.GameObjects.ManagerEntity.Motivating = Motivating.Value;
            controller.GameObjects.ManagerEntity.Determination = DeterminationManager.Value;
            controller.GameObjects.ManagerEntity.PlayerKnowledge = PlayerKnowledge.Value;
            controller.GameObjects.ManagerEntity.Discpline = LvlOfDiscipline.Value;
            controller.GameObjects.ManagerEntity.Adaptability = Adaptablity.Value;
            controller.GameObjects.ManagerEntity.WorkRateManager = WorkRateManager.Value;
            controller.GameObjects.ManagerEntity.MediaHandling = MediaHandling.Value;
            //This sets each of the Manager's attribute values to the progress bar associated with the attribute.

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();

            InGameHome HomeScreen = new InGameHome();
            HomeScreen.Show(); this.Hide();
            this.Hide();

        }

        private void ValidateTaxCredit()
        {
            if (TxtCredits.Text == "0")
            {
                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        ((Button)control).Enabled = false;
                        //If TaxCredits Textbox contains 0 then all of the buttons within the form is disabled
                    }
                }
            }
        }

        private void IncrementSkill(ProgressBar progressBar, Action action, Button incrementButton, Button decrementButton)
        {
            if (progressBar.Value >= MaxValue)
            {
                incrementButton.Enabled = false;
                return;
                //if the progress bar = 20 or more then any button containing a '+' sign is disabled
            }


            if (TxtCredits.Text == "0")
            {

                incrementButton.Enabled = false;
                return;
            }
            else
            {
                progressBar.Value += 1;
                action();
                controller.GameObjects.ManagerEntity.SkillCredits -= 1;
                TxtCredits.Text = controller.GameObjects.ManagerEntity.SkillCredits.ToString();
            }

            //This function allows a click on the '+' button to cause an increase in the associated progress bar value by 1


            decrementButton.Enabled = progressBar.Value > MinValue;
            //if the progress bar is greater than 0 then any button containing a '-' sign is enabled
            //ValidateTaxCredit();
        }

        private void DecrementSkill(ProgressBar progressBar, Action action, Button incrementButton, Button decrementButton)
        {
            if (progressBar.Value <= MinValue)
            //if the progress bar is less than or equal to 0 then any button containing a '-' sign is disabled

            {
                decrementButton.Enabled = false;
                return;
            }

            progressBar.Value -= 1;
            action();
            controller.GameObjects.ManagerEntity.SkillCredits += 1;
            TxtCredits.Text = controller.GameObjects.ManagerEntity.SkillCredits.ToString();
            //This function allows a click on the '+' button to cause an increase in the associated progress bar value by 1

            incrementButton.Enabled = progressBar.Value < MaxValue;
            //if the progress bar is less than 20 then any button containing a '+' sign is enabled

            //ValidateTaxCredit();
        }

        private void ButAddAttack_Click(object sender, EventArgs e)
        {
            Action action = () => AddAttack();

            //Action action = () => { controller.GameObjects.ManagerEntity.Attacking += 1; };

            IncrementSkill(AttackCoaching, action, ButAddAttack, ButSubtractAttack);

        }

        private void ButSubtractAttack_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractAttack();
            DecrementSkill(AttackCoaching, action, ButAddAttack, ButSubtractAttack);
        }

        private void ButAddDef_Click(object sender, EventArgs e)
        {
            Action action = () => AddDefending();
            IncrementSkill(DefCoaching, action, ButAddDef, ButSubtractDefence);
        }

        private void ButSubtractDefence_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractDefending();
            DecrementSkill(DefCoaching, action, ButAddDef, ButSubtractDefence);
        }

        private void ButAddGoalKeep_Click(object sender, EventArgs e)
        {
            Action action = () => AddGoalkeeping();
            IncrementSkill(GoalkeepingCoaching, action, ButAddGoalKeep, ButSubtractGoalKeep);
        }

        private void ButSubtractGoalKeep_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractGoalkeeping();
            DecrementSkill(GoalkeepingCoaching, action, ButAddGoalKeep, ButSubtractGoalKeep);
        }

        private void ButAddMental_Click(object sender, EventArgs e)
        {
            Action action = () => AddMental();
            IncrementSkill(MentalCoaching, action, ButAddMental, ButSubtractMental);
        }

        private void ButSubtractMental_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractMental();
            DecrementSkill(MentalCoaching, action, ButAddMental, ButSubtractMental);
        }

        private void ButAddTactical_Click(object sender, EventArgs e)
        {
            Action action = () => AddTactical();
            IncrementSkill(TacticalCoaching, action, ButAddTactical, ButSubtractTactical);
        }

        private void ButSubtractTactical_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractTactical();
            DecrementSkill(TacticalCoaching, action, ButAddTactical, ButSubtractTactical);
        }

        private void ButAddYouthDev_Click(object sender, EventArgs e)
        {
            Action action = () => AddYouth();
            IncrementSkill(YouthDevelopment, action, ButAddYouthDev, ButSubtractYouthDev);
        }

        private void ButSubtractYouthDev_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractYouth();
            DecrementSkill(YouthDevelopment, action, ButAddYouthDev, ButSubtractYouthDev);
        }

        private void ButAddTechnicalCoach_Click(object sender, EventArgs e)
        {
            Action action = () => AddTechnical();
            IncrementSkill(TechnicalCoaching, action, ButAddTechnicalCoach, ButSubtractTechnical);
        }

        private void ButSubtractTechnical_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractTechnical();
            DecrementSkill(TechnicalCoaching, action, ButAddTechnicalCoach, ButSubtractTechnical);
        }

        private void ButAddFitnessCoach_Click(object sender, EventArgs e)
        {
            Action action = () => AddFitness();
            IncrementSkill(FitnessCoaching, action, ButAddFitnessCoach, ButSubtractFitness);
        }

        private void ButSubtractFitness_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractFitness();
            DecrementSkill(FitnessCoaching, action, ButAddFitnessCoach, ButSubtractFitness);
        }

        private void ButAddMotivate_Click(object sender, EventArgs e)
        {
            Action action = () => AddMotivate();
            IncrementSkill(Motivating, action, ButAddMotivate, ButSubtractMotivate);
        }

        private void ButSubtractMotivate_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractMotivate();
            DecrementSkill(Motivating, action, ButAddMotivate, ButSubtractMotivate);
        }

        private void ButAddDetermination_Click(object sender, EventArgs e)
        {
            Action action = () => AddDetermination();
            IncrementSkill(DeterminationManager, action, ButAddDetermination, ButSubtractDetermination);
        }

        private void ButSubtractDetermination_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractDetermination();
            DecrementSkill(DeterminationManager, action, ButAddDetermination, ButSubtractDetermination);
        }

        private void ButAddPlayerKnowledge_Click(object sender, EventArgs e)
        {
            Action action = () => AddPlayerKnow();
            IncrementSkill(PlayerKnowledge, action, ButAddPlayerKnowledge, ButSubtractPlayerKnow);
        }

        private void ButSubtractPlayerKnow_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractPlayerKnow();
            DecrementSkill(PlayerKnowledge, action, ButAddPlayerKnowledge, ButSubtractPlayerKnow);
        }

        private void ButAddLvlOfDiscipline_Click(object sender, EventArgs e)
        {
            Action action = () => AddDiscipline();
            IncrementSkill(LvlOfDiscipline, action, ButAddLvlOfDiscipline, ButSubtractLvlOfDiscipline);
        }

        private void ButSubtractLvlOfDiscipline_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractDiscipline();
            DecrementSkill(LvlOfDiscipline, action, ButAddLvlOfDiscipline, ButSubtractLvlOfDiscipline);
        }

        private void ButAddAdaptability_Click(object sender, EventArgs e)
        {
            Action action = () => AddAdapt();
            IncrementSkill(Adaptablity, action, ButAddAdaptability, ButSubtractAdaptability);
        }

        private void ButSubtractAdaptability_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractAdapt();
            DecrementSkill(Adaptablity, action, ButAddAdaptability, ButSubtractAdaptability);
        }

        private void ButAddWorkRate_Click(object sender, EventArgs e)
        {
            Action action = () => AddWorkRateManager();
            IncrementSkill(WorkRateManager, action, ButAddWorkRate, ButSubtractWorkRate);
        }

        private void ButSubtractWorkRate_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractWorkRateManager();
            DecrementSkill(WorkRateManager, action, ButAddWorkRate, ButSubtractWorkRate);
        }

        private void ButAddMediaHandling_Click(object sender, EventArgs e)
        {
            Action action = () => AddMedia();
            DecrementSkill(MediaHandling, action, ButAddMediaHandling, ButSubtractMediaHandle);
        }

        private void ButSubtractMediaHandle_Click(object sender, EventArgs e)
        {
            Action action = () => SubtractMedia();
            IncrementSkill(MediaHandling, action, ButAddMediaHandling, ButSubtractMediaHandle);
        }

        private void AddAttack()
        {
            controller.GameObjects.ManagerEntity.Attacking += 1;
        }

        private void AddAdapt()
        {
            controller.GameObjects.ManagerEntity.Adaptability += 1;
        }

        private void AddDefending()
        {
            controller.GameObjects.ManagerEntity.Defending += 1;
        }

        private void AddDetermination()
        {
            controller.GameObjects.ManagerEntity.Determination += 1;
        }

        private void AddDiscipline()
        {
            controller.GameObjects.ManagerEntity.Discpline += 1;
        }

        private void AddFitness()
        {
            controller.GameObjects.ManagerEntity.Fitness += 1;
        }

        private void AddGoalkeeping()
        {
            controller.GameObjects.ManagerEntity.GoalKeeping += 1;
        }

        private void AddMedia()
        {
            controller.GameObjects.ManagerEntity.MediaHandling += 1;
        }

        private void AddMental()
        {
            controller.GameObjects.ManagerEntity.Mental += 1;
        }

        private void AddMotivate()
        {
            controller.GameObjects.ManagerEntity.Motivating += 1;
        }

        private void AddPlayerKnow()
        {
            controller.GameObjects.ManagerEntity.PlayerKnowledge += 1;
        }

        private void AddTactical()
        {
            controller.GameObjects.ManagerEntity.Tactical += 1;
        }

        private void AddTechnical()
        {
            controller.GameObjects.ManagerEntity.Technical += 1;
        }

        private void AddWorkRateManager()
        {
            controller.GameObjects.ManagerEntity.WorkRateManager += 1;
        }

        private void AddYouth()
        {
            controller.GameObjects.ManagerEntity.YouthDev += 1;
        }

        private void SubtractAttack()
        {
            controller.GameObjects.ManagerEntity.Attacking -= 1;
        }

        private void SubtractAdapt()
        {
            controller.GameObjects.ManagerEntity.Adaptability -= 1;
        }

        private void SubtractDefending()
        {
            controller.GameObjects.ManagerEntity.Defending -= 1;
        }

        private void SubtractDetermination()
        {
            controller.GameObjects.ManagerEntity.Determination -= 1;
        }

        private void SubtractDiscipline()
        {
            controller.GameObjects.ManagerEntity.Discpline -= 1;
        }

        private void SubtractFitness()
        {
            controller.GameObjects.ManagerEntity.Fitness -= 1;
        }

        private void SubtractGoalkeeping()
        {
            controller.GameObjects.ManagerEntity.GoalKeeping -= 1;
        }

        private void SubtractMedia()
        {
            controller.GameObjects.ManagerEntity.MediaHandling -= 1;
        }

        private void SubtractMental()
        {
            controller.GameObjects.ManagerEntity.Mental -= 1;
        }

        private void SubtractMotivate()
        {
            controller.GameObjects.ManagerEntity.Motivating -= 1;
        }

        private void SubtractPlayerKnow()
        {
            controller.GameObjects.ManagerEntity.PlayerKnowledge -= 1;
        }

        private void SubtractTactical()
        {
            controller.GameObjects.ManagerEntity.Tactical -= 1;
        }

        private void SubtractTechnical()
        {
            controller.GameObjects.ManagerEntity.Technical -= 1;
        }

        private void SubtractWorkRateManager()
        {
            controller.GameObjects.ManagerEntity.WorkRateManager -= 1;
        }

        private void SubtractYouth()
        {
            controller.GameObjects.ManagerEntity.YouthDev -= 1;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fileName = saveFileDialog1.FileName;
            var xml = GameController.Instance.GetGameDataAsXmlString();
            File.WriteAllText(fileName, xml);
        }
    }
}
