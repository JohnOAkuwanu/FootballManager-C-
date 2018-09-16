namespace FMProject
{
    partial class TransferMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferMarket));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabGeneral = new System.Windows.Forms.TabPage();
            this.TransferGeneralList = new System.Windows.Forms.DataGridView();
            this.TabMatchStats = new System.Windows.Forms.TabPage();
            this.TabContracts = new System.Windows.Forms.TabPage();
            this.TabAttackAttributes = new System.Windows.Forms.TabPage();
            this.TabDefAttributes = new System.Windows.Forms.TabPage();
            this.ButFilter = new System.Windows.Forms.Button();
            this.ButShortlist = new System.Windows.Forms.Button();
            this.ButInterestedPlayers = new System.Windows.Forms.Button();
            this.ButScouted = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTransfer = new System.Windows.Forms.TextBox();
            this.TxtWage = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButMenuHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButMenuTraining = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTeam = new System.Windows.Forms.ToolStripButton();
            this.ButMenuClubInfo = new System.Windows.Forms.ToolStripButton();
            this.ButMenuComp = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTransfer = new System.Windows.Forms.ToolStripButton();
            this.ButMenuManagerProfile = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferGeneralList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabGeneral);
            this.tabControl1.Controls.Add(this.TabMatchStats);
            this.tabControl1.Controls.Add(this.TabContracts);
            this.tabControl1.Controls.Add(this.TabAttackAttributes);
            this.tabControl1.Controls.Add(this.TabDefAttributes);
            this.tabControl1.Location = new System.Drawing.Point(108, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 331);
            this.tabControl1.TabIndex = 62;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.TransferGeneralList);
            this.TabGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeneral.Size = new System.Drawing.Size(453, 305);
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.Text = "General";
            this.TabGeneral.UseVisualStyleBackColor = true;
            this.TabGeneral.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TransferGeneralList
            // 
            this.TransferGeneralList.AllowUserToAddRows = false;
            this.TransferGeneralList.AllowUserToDeleteRows = false;
            this.TransferGeneralList.AllowUserToOrderColumns = true;
            this.TransferGeneralList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransferGeneralList.Location = new System.Drawing.Point(0, -1);
            this.TransferGeneralList.Name = "TransferGeneralList";
            this.TransferGeneralList.ReadOnly = true;
            this.TransferGeneralList.Size = new System.Drawing.Size(453, 306);
            this.TransferGeneralList.TabIndex = 0;
            this.TransferGeneralList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransferGeneralList_CellClick);
            this.TransferGeneralList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransferGeneralList_CellContentClick);
            // 
            // TabMatchStats
            // 
            this.TabMatchStats.Location = new System.Drawing.Point(4, 22);
            this.TabMatchStats.Name = "TabMatchStats";
            this.TabMatchStats.Padding = new System.Windows.Forms.Padding(3);
            this.TabMatchStats.Size = new System.Drawing.Size(453, 305);
            this.TabMatchStats.TabIndex = 1;
            this.TabMatchStats.Text = "Match Stats";
            this.TabMatchStats.UseVisualStyleBackColor = true;
            // 
            // TabContracts
            // 
            this.TabContracts.Location = new System.Drawing.Point(4, 22);
            this.TabContracts.Name = "TabContracts";
            this.TabContracts.Size = new System.Drawing.Size(453, 305);
            this.TabContracts.TabIndex = 2;
            this.TabContracts.Text = "Contracts";
            this.TabContracts.UseVisualStyleBackColor = true;
            // 
            // TabAttackAttributes
            // 
            this.TabAttackAttributes.Location = new System.Drawing.Point(4, 22);
            this.TabAttackAttributes.Name = "TabAttackAttributes";
            this.TabAttackAttributes.Size = new System.Drawing.Size(453, 305);
            this.TabAttackAttributes.TabIndex = 4;
            this.TabAttackAttributes.Text = "Attacking Attributes";
            this.TabAttackAttributes.UseVisualStyleBackColor = true;
            // 
            // TabDefAttributes
            // 
            this.TabDefAttributes.Location = new System.Drawing.Point(4, 22);
            this.TabDefAttributes.Name = "TabDefAttributes";
            this.TabDefAttributes.Size = new System.Drawing.Size(453, 305);
            this.TabDefAttributes.TabIndex = 5;
            this.TabDefAttributes.Text = "Defensive Attributes";
            this.TabDefAttributes.UseVisualStyleBackColor = true;
            // 
            // ButFilter
            // 
            this.ButFilter.Location = new System.Drawing.Point(575, 92);
            this.ButFilter.Name = "ButFilter";
            this.ButFilter.Size = new System.Drawing.Size(80, 48);
            this.ButFilter.TabIndex = 66;
            this.ButFilter.Text = "Filter Players";
            this.ButFilter.UseVisualStyleBackColor = true;
            this.ButFilter.Click += new System.EventHandler(this.ButFilter_Click);
            // 
            // ButShortlist
            // 
            this.ButShortlist.Location = new System.Drawing.Point(575, 254);
            this.ButShortlist.Name = "ButShortlist";
            this.ButShortlist.Size = new System.Drawing.Size(80, 48);
            this.ButShortlist.TabIndex = 65;
            this.ButShortlist.Text = "Shortlist";
            this.ButShortlist.UseVisualStyleBackColor = true;
            // 
            // ButInterestedPlayers
            // 
            this.ButInterestedPlayers.Location = new System.Drawing.Point(575, 200);
            this.ButInterestedPlayers.Name = "ButInterestedPlayers";
            this.ButInterestedPlayers.Size = new System.Drawing.Size(80, 48);
            this.ButInterestedPlayers.TabIndex = 64;
            this.ButInterestedPlayers.Text = "Interested Players";
            this.ButInterestedPlayers.UseVisualStyleBackColor = true;
            // 
            // ButScouted
            // 
            this.ButScouted.Location = new System.Drawing.Point(575, 146);
            this.ButScouted.Name = "ButScouted";
            this.ButScouted.Size = new System.Drawing.Size(80, 48);
            this.ButScouted.TabIndex = 63;
            this.ButScouted.Text = "Scouted Players";
            this.ButScouted.UseVisualStyleBackColor = true;
            this.ButScouted.Click += new System.EventHandler(this.ButScouted_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Transfer Budget:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Wage Budget:";
            // 
            // TxtTransfer
            // 
            this.TxtTransfer.Location = new System.Drawing.Point(374, 8);
            this.TxtTransfer.Name = "TxtTransfer";
            this.TxtTransfer.ReadOnly = true;
            this.TxtTransfer.Size = new System.Drawing.Size(32, 20);
            this.TxtTransfer.TabIndex = 69;
            // 
            // TxtWage
            // 
            this.TxtWage.Location = new System.Drawing.Point(374, 32);
            this.TxtWage.Name = "TxtWage";
            this.TxtWage.ReadOnly = true;
            this.TxtWage.Size = new System.Drawing.Size(32, 20);
            this.TxtWage.TabIndex = 70;
            this.TxtWage.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.toolStrip1.Size = new System.Drawing.Size(110, 408);
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
            this.ButMenuTraining.Click += new System.EventHandler(this.ButMenuTraining_Click);
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
            // TransferMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 408);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TxtWage);
            this.Controls.Add(this.TxtTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButFilter);
            this.Controls.Add(this.ButShortlist);
            this.Controls.Add(this.ButInterestedPlayers);
            this.Controls.Add(this.ButScouted);
            this.Name = "TransferMarket";
            this.Text = "TransferMarket";
            this.Load += new System.EventHandler(this.TransferMarket_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransferGeneralList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGeneral;
        private System.Windows.Forms.TabPage TabMatchStats;
        private System.Windows.Forms.TabPage TabContracts;
        private System.Windows.Forms.TabPage TabAttackAttributes;
        private System.Windows.Forms.TabPage TabDefAttributes;
        private System.Windows.Forms.Button ButFilter;
        private System.Windows.Forms.Button ButShortlist;
        private System.Windows.Forms.Button ButInterestedPlayers;
        private System.Windows.Forms.Button ButScouted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTransfer;
        private System.Windows.Forms.TextBox TxtWage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButMenuHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButMenuTraining;
        private System.Windows.Forms.ToolStripButton ButMenuTeam;
        private System.Windows.Forms.ToolStripButton ButMenuClubInfo;
        private System.Windows.Forms.ToolStripButton ButMenuComp;
        private System.Windows.Forms.ToolStripButton ButMenuTransfer;
        private System.Windows.Forms.ToolStripButton ButMenuManagerProfile;
        private System.Windows.Forms.DataGridView TransferGeneralList;
    }
}