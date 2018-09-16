namespace FMProject
{
    partial class Squad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Squad));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabGeneral = new System.Windows.Forms.TabPage();
            this.squadDataView = new System.Windows.Forms.DataGridView();
            this.TabMatchStats = new System.Windows.Forms.TabPage();
            this.MatchStatsView = new System.Windows.Forms.DataGridView();
            this.TabContract = new System.Windows.Forms.TabPage();
            this.contractsView = new System.Windows.Forms.DataGridView();
            this.TabAttAttributes = new System.Windows.Forms.TabPage();
            this.attackStatsView = new System.Windows.Forms.DataGridView();
            this.TabDefAttributes = new System.Windows.Forms.TabPage();
            this.defStatsView = new System.Windows.Forms.DataGridView();
            this.ButFormation = new System.Windows.Forms.Button();
            this.ButYouth = new System.Windows.Forms.Button();
            this.ButReserves = new System.Windows.Forms.Button();
            this.ButGamePlan = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButMenuHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButMenuTraining = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTeam = new System.Windows.Forms.ToolStripButton();
            this.ButMenuClubInfo = new System.Windows.Forms.ToolStripButton();
            this.ButMenuComp = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTransfer = new System.Windows.Forms.ToolStripButton();
            this.ButMenuManagerProfile = new System.Windows.Forms.ToolStripButton();
            this.txtTeamAbility = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadDataView)).BeginInit();
            this.TabMatchStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchStatsView)).BeginInit();
            this.TabContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsView)).BeginInit();
            this.TabAttAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackStatsView)).BeginInit();
            this.TabDefAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defStatsView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabGeneral);
            this.tabControl1.Controls.Add(this.TabMatchStats);
            this.tabControl1.Controls.Add(this.TabContract);
            this.tabControl1.Controls.Add(this.TabAttAttributes);
            this.tabControl1.Controls.Add(this.TabDefAttributes);
            this.tabControl1.Location = new System.Drawing.Point(108, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.squadDataView);
            this.TabGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeneral.Size = new System.Drawing.Size(453, 305);
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.Text = "General";
            this.TabGeneral.UseVisualStyleBackColor = true;
            // 
            // squadDataView
            // 
            this.squadDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.squadDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.squadDataView.Location = new System.Drawing.Point(-3, 0);
            this.squadDataView.Name = "squadDataView";
            this.squadDataView.ReadOnly = true;
            this.squadDataView.Size = new System.Drawing.Size(453, 299);
            this.squadDataView.TabIndex = 0;
            this.squadDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.squadDataView_CellClick);
            // 
            // TabMatchStats
            // 
            this.TabMatchStats.Controls.Add(this.MatchStatsView);
            this.TabMatchStats.Location = new System.Drawing.Point(4, 22);
            this.TabMatchStats.Name = "TabMatchStats";
            this.TabMatchStats.Padding = new System.Windows.Forms.Padding(3);
            this.TabMatchStats.Size = new System.Drawing.Size(453, 305);
            this.TabMatchStats.TabIndex = 1;
            this.TabMatchStats.Text = "Match Stats";
            this.TabMatchStats.UseVisualStyleBackColor = true;
            // 
            // MatchStatsView
            // 
            this.MatchStatsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MatchStatsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchStatsView.Location = new System.Drawing.Point(1, 0);
            this.MatchStatsView.Name = "MatchStatsView";
            this.MatchStatsView.ReadOnly = true;
            this.MatchStatsView.Size = new System.Drawing.Size(452, 305);
            this.MatchStatsView.TabIndex = 0;
            this.MatchStatsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TabContract
            // 
            this.TabContract.Controls.Add(this.contractsView);
            this.TabContract.Location = new System.Drawing.Point(4, 22);
            this.TabContract.Name = "TabContract";
            this.TabContract.Size = new System.Drawing.Size(453, 305);
            this.TabContract.TabIndex = 2;
            this.TabContract.Text = "Contracts";
            this.TabContract.UseVisualStyleBackColor = true;
            // 
            // contractsView
            // 
            this.contractsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.contractsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsView.Location = new System.Drawing.Point(3, 0);
            this.contractsView.Name = "contractsView";
            this.contractsView.ReadOnly = true;
            this.contractsView.Size = new System.Drawing.Size(452, 305);
            this.contractsView.TabIndex = 81;
            this.contractsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractsView_CellContentClick);
            // 
            // TabAttAttributes
            // 
            this.TabAttAttributes.Controls.Add(this.attackStatsView);
            this.TabAttAttributes.Location = new System.Drawing.Point(4, 22);
            this.TabAttAttributes.Name = "TabAttAttributes";
            this.TabAttAttributes.Size = new System.Drawing.Size(453, 305);
            this.TabAttAttributes.TabIndex = 4;
            this.TabAttAttributes.Text = "Attacking Attributes";
            this.TabAttAttributes.UseVisualStyleBackColor = true;
            // 
            // attackStatsView
            // 
            this.attackStatsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.attackStatsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attackStatsView.Location = new System.Drawing.Point(1, -1);
            this.attackStatsView.Name = "attackStatsView";
            this.attackStatsView.ReadOnly = true;
            this.attackStatsView.Size = new System.Drawing.Size(452, 305);
            this.attackStatsView.TabIndex = 81;
            this.attackStatsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attackStatsView_CellClick);
            // 
            // TabDefAttributes
            // 
            this.TabDefAttributes.Controls.Add(this.defStatsView);
            this.TabDefAttributes.Location = new System.Drawing.Point(4, 22);
            this.TabDefAttributes.Name = "TabDefAttributes";
            this.TabDefAttributes.Size = new System.Drawing.Size(453, 305);
            this.TabDefAttributes.TabIndex = 5;
            this.TabDefAttributes.Text = "Defensive Attributes";
            this.TabDefAttributes.UseVisualStyleBackColor = true;
            // 
            // defStatsView
            // 
            this.defStatsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.defStatsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defStatsView.Location = new System.Drawing.Point(3, 0);
            this.defStatsView.Name = "defStatsView";
            this.defStatsView.ReadOnly = true;
            this.defStatsView.Size = new System.Drawing.Size(447, 302);
            this.defStatsView.TabIndex = 81;
            this.defStatsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defStatsView_CellClick_1);
            // 
            // ButFormation
            // 
            this.ButFormation.Location = new System.Drawing.Point(571, 112);
            this.ButFormation.Name = "ButFormation";
            this.ButFormation.Size = new System.Drawing.Size(80, 48);
            this.ButFormation.TabIndex = 61;
            this.ButFormation.Text = "Formation";
            this.ButFormation.UseVisualStyleBackColor = true;
            this.ButFormation.Click += new System.EventHandler(this.ButFormation_Click);
            // 
            // ButYouth
            // 
            this.ButYouth.Location = new System.Drawing.Point(571, 274);
            this.ButYouth.Name = "ButYouth";
            this.ButYouth.Size = new System.Drawing.Size(80, 48);
            this.ButYouth.TabIndex = 60;
            this.ButYouth.Text = "Youth Team";
            this.ButYouth.UseVisualStyleBackColor = true;
            // 
            // ButReserves
            // 
            this.ButReserves.Location = new System.Drawing.Point(571, 220);
            this.ButReserves.Name = "ButReserves";
            this.ButReserves.Size = new System.Drawing.Size(80, 48);
            this.ButReserves.TabIndex = 59;
            this.ButReserves.Text = "Reserve Team";
            this.ButReserves.UseVisualStyleBackColor = true;
            // 
            // ButGamePlan
            // 
            this.ButGamePlan.Location = new System.Drawing.Point(571, 166);
            this.ButGamePlan.Name = "ButGamePlan";
            this.ButGamePlan.Size = new System.Drawing.Size(80, 48);
            this.ButGamePlan.TabIndex = 58;
            this.ButGamePlan.Text = "Game Plan and Instructions";
            this.ButGamePlan.UseVisualStyleBackColor = true;
            this.ButGamePlan.Click += new System.EventHandler(this.ButGamePlan_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButMenuHome,
            this.toolStripSeparator1,
            this.ButMenuTraining,
            this.ButMenuTeam,
            this.ButMenuClubInfo,
            this.ButMenuComp,
            this.ButMenuTransfer,
            this.ButMenuManagerProfile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(110, 412);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 80;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButMenuHome
            // 
            this.ButMenuHome.AutoSize = false;
            this.ButMenuHome.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuHome.Image")));
            this.ButMenuHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuHome.Name = "ButMenuHome";
            this.ButMenuHome.Size = new System.Drawing.Size(107, 40);
            this.ButMenuHome.Text = "Home";
            this.ButMenuHome.Click += new System.EventHandler(this.ButMenuHome_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 10);
            // 
            // ButMenuTraining
            // 
            this.ButMenuTraining.AutoSize = false;
            this.ButMenuTraining.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuTraining.Image")));
            this.ButMenuTraining.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuTraining.Name = "ButMenuTraining";
            this.ButMenuTraining.Size = new System.Drawing.Size(107, 40);
            this.ButMenuTraining.Text = "Training";
            this.ButMenuTraining.Click += new System.EventHandler(this.ButMenuTraining_Click_1);
            // 
            // ButMenuTeam
            // 
            this.ButMenuTeam.AutoSize = false;
            this.ButMenuTeam.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuTeam.Image")));
            this.ButMenuTeam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuTeam.Name = "ButMenuTeam";
            this.ButMenuTeam.Size = new System.Drawing.Size(107, 40);
            this.ButMenuTeam.Text = "Team";
            this.ButMenuTeam.Click += new System.EventHandler(this.ButMenuTeam_Click_1);
            // 
            // ButMenuClubInfo
            // 
            this.ButMenuClubInfo.AutoSize = false;
            this.ButMenuClubInfo.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuClubInfo.Image")));
            this.ButMenuClubInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuClubInfo.Name = "ButMenuClubInfo";
            this.ButMenuClubInfo.Size = new System.Drawing.Size(107, 40);
            this.ButMenuClubInfo.Text = "Club Info";
            this.ButMenuClubInfo.Click += new System.EventHandler(this.ButMenuClubInfo_Click_1);
            // 
            // ButMenuComp
            // 
            this.ButMenuComp.AutoSize = false;
            this.ButMenuComp.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuComp.Image")));
            this.ButMenuComp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuComp.Name = "ButMenuComp";
            this.ButMenuComp.Size = new System.Drawing.Size(107, 40);
            this.ButMenuComp.Text = "Competitions";
            this.ButMenuComp.Click += new System.EventHandler(this.ButMenuComp_Click_1);
            // 
            // ButMenuTransfer
            // 
            this.ButMenuTransfer.AutoSize = false;
            this.ButMenuTransfer.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuTransfer.Image")));
            this.ButMenuTransfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuTransfer.Name = "ButMenuTransfer";
            this.ButMenuTransfer.Size = new System.Drawing.Size(107, 40);
            this.ButMenuTransfer.Text = "Transfer Market";
            this.ButMenuTransfer.Click += new System.EventHandler(this.ButMenuTransfer_Click_1);
            // 
            // ButMenuManagerProfile
            // 
            this.ButMenuManagerProfile.AutoSize = false;
            this.ButMenuManagerProfile.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuManagerProfile.Image")));
            this.ButMenuManagerProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuManagerProfile.Name = "ButMenuManagerProfile";
            this.ButMenuManagerProfile.Size = new System.Drawing.Size(107, 40);
            this.ButMenuManagerProfile.Text = "Manager Profile";
            this.ButMenuManagerProfile.Click += new System.EventHandler(this.ButMenuManagerProfile_Click_1);
            // 
            // txtTeamAbility
            // 
            this.txtTeamAbility.Location = new System.Drawing.Point(350, 12);
            this.txtTeamAbility.Name = "txtTeamAbility";
            this.txtTeamAbility.ReadOnly = true;
            this.txtTeamAbility.Size = new System.Drawing.Size(100, 20);
            this.txtTeamAbility.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Team\'s Average Ability";
            // 
            // Squad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamAbility);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ButFormation);
            this.Controls.Add(this.ButYouth);
            this.Controls.Add(this.ButReserves);
            this.Controls.Add(this.ButGamePlan);
            this.Controls.Add(this.tabControl1);
            this.Name = "Squad";
            this.Text = "Squad";
            this.Load += new System.EventHandler(this.Squad_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.squadDataView)).EndInit();
            this.TabMatchStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatchStatsView)).EndInit();
            this.TabContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractsView)).EndInit();
            this.TabAttAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attackStatsView)).EndInit();
            this.TabDefAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defStatsView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGeneral;
        private System.Windows.Forms.TabPage TabMatchStats;
        private System.Windows.Forms.TabPage TabContract;
        private System.Windows.Forms.TabPage TabAttAttributes;
        private System.Windows.Forms.TabPage TabDefAttributes;
        private System.Windows.Forms.Button ButFormation;
        private System.Windows.Forms.Button ButYouth;
        private System.Windows.Forms.Button ButReserves;
        private System.Windows.Forms.Button ButGamePlan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButMenuHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButMenuTraining;
        private System.Windows.Forms.ToolStripButton ButMenuTeam;
        private System.Windows.Forms.ToolStripButton ButMenuClubInfo;
        private System.Windows.Forms.ToolStripButton ButMenuComp;
        private System.Windows.Forms.ToolStripButton ButMenuTransfer;
        private System.Windows.Forms.ToolStripButton ButMenuManagerProfile;
        private System.Windows.Forms.DataGridView squadDataView;
        private System.Windows.Forms.DataGridView MatchStatsView;
        private System.Windows.Forms.DataGridView contractsView;
        private System.Windows.Forms.DataGridView attackStatsView;
        private System.Windows.Forms.DataGridView defStatsView;
        private System.Windows.Forms.TextBox txtTeamAbility;
        private System.Windows.Forms.Label label1;
    }
}