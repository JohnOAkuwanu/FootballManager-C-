namespace FMProject
{
    partial class PlayerStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerStatistics));
            this.ButMenuManagerProfile = new System.Windows.Forms.ToolStripButton();
            this.ButMenuComp = new System.Windows.Forms.ToolStripButton();
            this.ButMenuClubInfo = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTeam = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTraining = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButMenuHome = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButMenuTransfer = new System.Windows.Forms.ToolStripButton();
            this.ButPrevLeague = new System.Windows.Forms.Button();
            this.ButNextLeague = new System.Windows.Forms.Button();
            this.ButChangeCountry = new System.Windows.Forms.Button();
            this.ButCups = new System.Windows.Forms.Button();
            this.ButTeamStatistics = new System.Windows.Forms.Button();
            this.ButPlayerStatistics = new System.Windows.Forms.Button();
            this.TabGoals = new System.Windows.Forms.TabPage();
            this.TabAssists = new System.Windows.Forms.TabPage();
            this.TabCleanSheets = new System.Windows.Forms.TabPage();
            this.TabYelCards = new System.Windows.Forms.TabPage();
            this.TabRedCards = new System.Windows.Forms.TabPage();
            this.TabForm = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.goalsDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.TabGoals.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // ButMenuTraining
            // 
            this.ButMenuTraining.AutoSize = false;
            this.ButMenuTraining.Image = ((System.Drawing.Image)(resources.GetObject("ButMenuTraining.Image")));
            this.ButMenuTraining.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButMenuTraining.Name = "ButMenuTraining";
            this.ButMenuTraining.Size = new System.Drawing.Size(107, 40);
            this.ButMenuTraining.Text = "Training";
            this.ButMenuTraining.Click += new System.EventHandler(this.ButMenuTraining_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 10);
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
            this.toolStrip1.Size = new System.Drawing.Size(110, 348);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 88;
            this.toolStrip1.Text = "toolStrip1";
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
            // ButPrevLeague
            // 
            this.ButPrevLeague.Location = new System.Drawing.Point(182, 307);
            this.ButPrevLeague.Name = "ButPrevLeague";
            this.ButPrevLeague.Size = new System.Drawing.Size(100, 22);
            this.ButPrevLeague.TabIndex = 87;
            this.ButPrevLeague.Text = "Previous League";
            this.ButPrevLeague.UseVisualStyleBackColor = true;
            // 
            // ButNextLeague
            // 
            this.ButNextLeague.Location = new System.Drawing.Point(319, 307);
            this.ButNextLeague.Name = "ButNextLeague";
            this.ButNextLeague.Size = new System.Drawing.Size(100, 22);
            this.ButNextLeague.TabIndex = 86;
            this.ButNextLeague.Text = "Next League";
            this.ButNextLeague.UseVisualStyleBackColor = true;
            // 
            // ButChangeCountry
            // 
            this.ButChangeCountry.Location = new System.Drawing.Point(496, 91);
            this.ButChangeCountry.Name = "ButChangeCountry";
            this.ButChangeCountry.Size = new System.Drawing.Size(80, 48);
            this.ButChangeCountry.TabIndex = 85;
            this.ButChangeCountry.Text = "Change Country";
            this.ButChangeCountry.UseVisualStyleBackColor = true;
            this.ButChangeCountry.Click += new System.EventHandler(this.ButChangeCountry_Click);
            // 
            // ButCups
            // 
            this.ButCups.Location = new System.Drawing.Point(496, 253);
            this.ButCups.Name = "ButCups";
            this.ButCups.Size = new System.Drawing.Size(80, 48);
            this.ButCups.TabIndex = 84;
            this.ButCups.Text = "Club Competitions";
            this.ButCups.UseVisualStyleBackColor = true;
            this.ButCups.Click += new System.EventHandler(this.ButCups_Click);
            // 
            // ButTeamStatistics
            // 
            this.ButTeamStatistics.Location = new System.Drawing.Point(496, 199);
            this.ButTeamStatistics.Name = "ButTeamStatistics";
            this.ButTeamStatistics.Size = new System.Drawing.Size(80, 48);
            this.ButTeamStatistics.TabIndex = 83;
            this.ButTeamStatistics.Text = "Team Stats";
            this.ButTeamStatistics.UseVisualStyleBackColor = true;
            this.ButTeamStatistics.Click += new System.EventHandler(this.ButTeamStatistics_Click_1);
            // 
            // ButPlayerStatistics
            // 
            this.ButPlayerStatistics.Location = new System.Drawing.Point(496, 145);
            this.ButPlayerStatistics.Name = "ButPlayerStatistics";
            this.ButPlayerStatistics.Size = new System.Drawing.Size(80, 48);
            this.ButPlayerStatistics.TabIndex = 82;
            this.ButPlayerStatistics.Text = "Player Stats";
            this.ButPlayerStatistics.UseVisualStyleBackColor = true;
            this.ButPlayerStatistics.Click += new System.EventHandler(this.ButPlayerStatistics_Click_1);
            // 
            // TabGoals
            // 
            this.TabGoals.Controls.Add(this.goalsDataGridView);
            this.TabGoals.Location = new System.Drawing.Point(4, 22);
            this.TabGoals.Name = "TabGoals";
            this.TabGoals.Padding = new System.Windows.Forms.Padding(3);
            this.TabGoals.Size = new System.Drawing.Size(376, 254);
            this.TabGoals.TabIndex = 0;
            this.TabGoals.Text = "Goals";
            this.TabGoals.UseVisualStyleBackColor = true;
            // 
            // TabAssists
            // 
            this.TabAssists.Location = new System.Drawing.Point(4, 22);
            this.TabAssists.Name = "TabAssists";
            this.TabAssists.Padding = new System.Windows.Forms.Padding(3);
            this.TabAssists.Size = new System.Drawing.Size(376, 254);
            this.TabAssists.TabIndex = 1;
            this.TabAssists.Text = "Assists";
            this.TabAssists.UseVisualStyleBackColor = true;
            // 
            // TabCleanSheets
            // 
            this.TabCleanSheets.Location = new System.Drawing.Point(4, 22);
            this.TabCleanSheets.Name = "TabCleanSheets";
            this.TabCleanSheets.Size = new System.Drawing.Size(376, 254);
            this.TabCleanSheets.TabIndex = 3;
            this.TabCleanSheets.Text = "Clean Sheets";
            this.TabCleanSheets.UseVisualStyleBackColor = true;
            // 
            // TabYelCards
            // 
            this.TabYelCards.Location = new System.Drawing.Point(4, 22);
            this.TabYelCards.Name = "TabYelCards";
            this.TabYelCards.Size = new System.Drawing.Size(376, 254);
            this.TabYelCards.TabIndex = 5;
            this.TabYelCards.Text = "Yellow Cards";
            this.TabYelCards.UseVisualStyleBackColor = true;
            // 
            // TabRedCards
            // 
            this.TabRedCards.Location = new System.Drawing.Point(4, 22);
            this.TabRedCards.Name = "TabRedCards";
            this.TabRedCards.Size = new System.Drawing.Size(376, 254);
            this.TabRedCards.TabIndex = 6;
            this.TabRedCards.Text = "Red Cards";
            this.TabRedCards.UseVisualStyleBackColor = true;
            // 
            // TabForm
            // 
            this.TabForm.Location = new System.Drawing.Point(4, 22);
            this.TabForm.Name = "TabForm";
            this.TabForm.Size = new System.Drawing.Size(376, 254);
            this.TabForm.TabIndex = 7;
            this.TabForm.Text = "Recent Form";
            this.TabForm.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabGoals);
            this.tabControl1.Controls.Add(this.TabAssists);
            this.tabControl1.Controls.Add(this.TabCleanSheets);
            this.tabControl1.Controls.Add(this.TabYelCards);
            this.tabControl1.Controls.Add(this.TabRedCards);
            this.tabControl1.Controls.Add(this.TabForm);
            this.tabControl1.Location = new System.Drawing.Point(110, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 280);
            this.tabControl1.TabIndex = 81;
            // 
            // goalsDataGridView
            // 
            this.goalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goalsDataGridView.Location = new System.Drawing.Point(3, 4);
            this.goalsDataGridView.Name = "goalsDataGridView";
            this.goalsDataGridView.Size = new System.Drawing.Size(372, 249);
            this.goalsDataGridView.TabIndex = 0;
            // 
            // PlayerStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 348);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ButPrevLeague);
            this.Controls.Add(this.ButNextLeague);
            this.Controls.Add(this.ButChangeCountry);
            this.Controls.Add(this.ButCups);
            this.Controls.Add(this.ButTeamStatistics);
            this.Controls.Add(this.ButPlayerStatistics);
            this.Controls.Add(this.tabControl1);
            this.Name = "PlayerStatistics";
            this.Text = "PlayerStatistics";
            this.Load += new System.EventHandler(this.PlayerStatistics_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabGoals.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton ButMenuManagerProfile;
        private System.Windows.Forms.ToolStripButton ButMenuComp;
        private System.Windows.Forms.ToolStripButton ButMenuClubInfo;
        private System.Windows.Forms.ToolStripButton ButMenuTeam;
        private System.Windows.Forms.ToolStripButton ButMenuTraining;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButMenuHome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButMenuTransfer;
        private System.Windows.Forms.Button ButPrevLeague;
        private System.Windows.Forms.Button ButNextLeague;
        private System.Windows.Forms.Button ButChangeCountry;
        private System.Windows.Forms.Button ButCups;
        private System.Windows.Forms.Button ButTeamStatistics;
        private System.Windows.Forms.Button ButPlayerStatistics;
        private System.Windows.Forms.TabPage TabGoals;
        private System.Windows.Forms.TabPage TabAssists;
        private System.Windows.Forms.TabPage TabCleanSheets;
        private System.Windows.Forms.TabPage TabYelCards;
        private System.Windows.Forms.TabPage TabRedCards;
        private System.Windows.Forms.TabPage TabForm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView goalsDataGridView;
    }
}