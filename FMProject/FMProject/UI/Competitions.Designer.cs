namespace FMProject
{
    partial class Competitions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Competitions));
            this.DataGridLeagueDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ButPlayerStatistics = new System.Windows.Forms.Button();
            this.ButTeamStatistics = new System.Windows.Forms.Button();
            this.ButCups = new System.Windows.Forms.Button();
            this.ButChangeCountry = new System.Windows.Forms.Button();
            this.ButNextLeague = new System.Windows.Forms.Button();
            this.ButPrevLeague = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButMenuHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButMenuTraining = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTeam = new System.Windows.Forms.ToolStripButton();
            this.ButMenuClubInfo = new System.Windows.Forms.ToolStripButton();
            this.ButMenuComp = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTransfer = new System.Windows.Forms.ToolStripButton();
            this.ButMenuManagerProfile = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeagueDisplay)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridLeagueDisplay
            // 
            this.DataGridLeagueDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLeagueDisplay.Location = new System.Drawing.Point(117, 65);
            this.DataGridLeagueDisplay.Name = "DataGridLeagueDisplay";
            this.DataGridLeagueDisplay.Size = new System.Drawing.Size(379, 259);
            this.DataGridLeagueDisplay.TabIndex = 48;
            this.DataGridLeagueDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridLeagueDisplay_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "The Selected Country\'s League is inputted";
            // 
            // ButPlayerStatistics
            // 
            this.ButPlayerStatistics.Location = new System.Drawing.Point(502, 167);
            this.ButPlayerStatistics.Name = "ButPlayerStatistics";
            this.ButPlayerStatistics.Size = new System.Drawing.Size(80, 48);
            this.ButPlayerStatistics.TabIndex = 50;
            this.ButPlayerStatistics.Text = "Player Stats";
            this.ButPlayerStatistics.UseVisualStyleBackColor = true;
            this.ButPlayerStatistics.Click += new System.EventHandler(this.ButPlayerStatistics_Click_1);
            // 
            // ButTeamStatistics
            // 
            this.ButTeamStatistics.Location = new System.Drawing.Point(502, 221);
            this.ButTeamStatistics.Name = "ButTeamStatistics";
            this.ButTeamStatistics.Size = new System.Drawing.Size(80, 48);
            this.ButTeamStatistics.TabIndex = 51;
            this.ButTeamStatistics.Text = "Team Stats";
            this.ButTeamStatistics.UseVisualStyleBackColor = true;
            this.ButTeamStatistics.Click += new System.EventHandler(this.ButTeamStatistics_Click);
            // 
            // ButCups
            // 
            this.ButCups.Location = new System.Drawing.Point(502, 275);
            this.ButCups.Name = "ButCups";
            this.ButCups.Size = new System.Drawing.Size(80, 48);
            this.ButCups.TabIndex = 52;
            this.ButCups.Text = "Club Competitions";
            this.ButCups.UseVisualStyleBackColor = true;
            this.ButCups.Click += new System.EventHandler(this.ButCups_Click);
            // 
            // ButChangeCountry
            // 
            this.ButChangeCountry.Location = new System.Drawing.Point(502, 113);
            this.ButChangeCountry.Name = "ButChangeCountry";
            this.ButChangeCountry.Size = new System.Drawing.Size(80, 48);
            this.ButChangeCountry.TabIndex = 53;
            this.ButChangeCountry.Text = "Change Country";
            this.ButChangeCountry.UseVisualStyleBackColor = true;
            this.ButChangeCountry.Click += new System.EventHandler(this.ButChangeCountry_Click);
            // 
            // ButNextLeague
            // 
            this.ButNextLeague.Location = new System.Drawing.Point(322, 338);
            this.ButNextLeague.Name = "ButNextLeague";
            this.ButNextLeague.Size = new System.Drawing.Size(100, 22);
            this.ButNextLeague.TabIndex = 54;
            this.ButNextLeague.Text = "Next League";
            this.ButNextLeague.UseVisualStyleBackColor = true;
            // 
            // ButPrevLeague
            // 
            this.ButPrevLeague.Location = new System.Drawing.Point(185, 338);
            this.ButPrevLeague.Name = "ButPrevLeague";
            this.ButPrevLeague.Size = new System.Drawing.Size(100, 22);
            this.ButPrevLeague.TabIndex = 55;
            this.ButPrevLeague.Text = "Previous League";
            this.ButPrevLeague.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(110, 370);
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
            this.ButMenuHome.Click += new System.EventHandler(this.ButMenuHome_Click);
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
            this.ButMenuTeam.Click += new System.EventHandler(this.ButMenuTeam_Click);
            // 
            // ButMenuClubInfo
            // 
            this.ButMenuClubInfo.AutoSize = false;
            this.ButMenuClubInfo.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuClubInfo.Image")));
            this.ButMenuClubInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuClubInfo.Name = "ButMenuClubInfo";
            this.ButMenuClubInfo.Size = new System.Drawing.Size(107, 40);
            this.ButMenuClubInfo.Text = "Club Info";
            this.ButMenuClubInfo.Click += new System.EventHandler(this.ButMenuClubInfo_Click);
            // 
            // ButMenuComp
            // 
            this.ButMenuComp.AutoSize = false;
            this.ButMenuComp.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuComp.Image")));
            this.ButMenuComp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuComp.Name = "ButMenuComp";
            this.ButMenuComp.Size = new System.Drawing.Size(107, 40);
            this.ButMenuComp.Text = "Competitions";
            this.ButMenuComp.Click += new System.EventHandler(this.ButMenuComp_Click);
            // 
            // ButMenuTransfer
            // 
            this.ButMenuTransfer.AutoSize = false;
            this.ButMenuTransfer.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuTransfer.Image")));
            this.ButMenuTransfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuTransfer.Name = "ButMenuTransfer";
            this.ButMenuTransfer.Size = new System.Drawing.Size(107, 40);
            this.ButMenuTransfer.Text = "Transfer Market";
            this.ButMenuTransfer.Click += new System.EventHandler(this.ButMenuTransfer_Click);
            // 
            // ButMenuManagerProfile
            // 
            this.ButMenuManagerProfile.AutoSize = false;
            this.ButMenuManagerProfile.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuManagerProfile.Image")));
            this.ButMenuManagerProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuManagerProfile.Name = "ButMenuManagerProfile";
            this.ButMenuManagerProfile.Size = new System.Drawing.Size(107, 40);
            this.ButMenuManagerProfile.Text = "Manager Profile";
            this.ButMenuManagerProfile.Click += new System.EventHandler(this.ButMenuManagerProfile_Click);
            // 
            // Competitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ButPrevLeague);
            this.Controls.Add(this.ButNextLeague);
            this.Controls.Add(this.ButChangeCountry);
            this.Controls.Add(this.ButCups);
            this.Controls.Add(this.ButTeamStatistics);
            this.Controls.Add(this.ButPlayerStatistics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridLeagueDisplay);
            this.Name = "Competitions";
            this.Text = "Competitions";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeagueDisplay)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridLeagueDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButPlayerStatistics;
        private System.Windows.Forms.Button ButTeamStatistics;
        private System.Windows.Forms.Button ButCups;
        private System.Windows.Forms.Button ButChangeCountry;
        private System.Windows.Forms.Button ButNextLeague;
        private System.Windows.Forms.Button ButPrevLeague;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButMenuHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButMenuTraining;
        private System.Windows.Forms.ToolStripButton ButMenuTeam;
        private System.Windows.Forms.ToolStripButton ButMenuClubInfo;
        private System.Windows.Forms.ToolStripButton ButMenuComp;
        private System.Windows.Forms.ToolStripButton ButMenuTransfer;
        private System.Windows.Forms.ToolStripButton ButMenuManagerProfile;
    }
}