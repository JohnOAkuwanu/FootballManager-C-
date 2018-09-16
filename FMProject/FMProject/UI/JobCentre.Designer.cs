namespace FMProject
{
    partial class JobCentre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobCentre));
            this.ButApply = new System.Windows.Forms.Button();
            this.ButAddClubShortlist = new System.Windows.Forms.Button();
            this.ButClubShortlist = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButMenuHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButMenuTraining = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTeam = new System.Windows.Forms.ToolStripButton();
            this.ButMenuClubInfo = new System.Windows.Forms.ToolStripButton();
            this.ButMenuComp = new System.Windows.Forms.ToolStripButton();
            this.ButMenuTransfer = new System.Windows.Forms.ToolStripButton();
            this.ButMenuManagerProfile = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButApply
            // 
            this.ButApply.Location = new System.Drawing.Point(113, 12);
            this.ButApply.Name = "ButApply";
            this.ButApply.Size = new System.Drawing.Size(81, 43);
            this.ButApply.TabIndex = 0;
            this.ButApply.Text = "Apply for Job";
            this.ButApply.UseVisualStyleBackColor = true;
            // 
            // ButAddClubShortlist
            // 
            this.ButAddClubShortlist.Location = new System.Drawing.Point(200, 12);
            this.ButAddClubShortlist.Name = "ButAddClubShortlist";
            this.ButAddClubShortlist.Size = new System.Drawing.Size(71, 43);
            this.ButAddClubShortlist.TabIndex = 1;
            this.ButAddClubShortlist.Text = "Add Club to Shortlist";
            this.ButAddClubShortlist.UseVisualStyleBackColor = true;
            this.ButAddClubShortlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButClubShortlist
            // 
            this.ButClubShortlist.Location = new System.Drawing.Point(277, 12);
            this.ButClubShortlist.Name = "ButClubShortlist";
            this.ButClubShortlist.Size = new System.Drawing.Size(72, 43);
            this.ButClubShortlist.TabIndex = 2;
            this.ButClubShortlist.Text = "Club Shortlist";
            this.ButClubShortlist.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(110, 345);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(113, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 263);
            this.tabControl1.TabIndex = 81;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(246, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Financial Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 233);
            this.dataGridView2.TabIndex = 82;
            // 
            // JobCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 345);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ButClubShortlist);
            this.Controls.Add(this.ButAddClubShortlist);
            this.Controls.Add(this.ButApply);
            this.Name = "JobCentre";
            this.Text = "JobCentre";
            this.Load += new System.EventHandler(this.JobCentre_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButApply;
        private System.Windows.Forms.Button ButAddClubShortlist;
        private System.Windows.Forms.Button ButClubShortlist;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButMenuHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButMenuTraining;
        private System.Windows.Forms.ToolStripButton ButMenuTeam;
        private System.Windows.Forms.ToolStripButton ButMenuClubInfo;
        private System.Windows.Forms.ToolStripButton ButMenuComp;
        private System.Windows.Forms.ToolStripButton ButMenuTransfer;
        private System.Windows.Forms.ToolStripButton ButMenuManagerProfile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}