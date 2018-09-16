namespace FMProject
{
    partial class StaffScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffScreen));
            this.ButMutualTermination = new System.Windows.Forms.Button();
            this.ButScoutAssign = new System.Windows.Forms.Button();
            this.ButSackStaff = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabGeneral = new System.Windows.Forms.TabPage();
            this.TabContract = new System.Windows.Forms.TabPage();
            this.TabCoachAttributes = new System.Windows.Forms.TabPage();
            this.TabMentalAttributes = new System.Windows.Forms.TabPage();
            this.TabReputation = new System.Windows.Forms.TabPage();
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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButMutualTermination
            // 
            this.ButMutualTermination.Location = new System.Drawing.Point(575, 74);
            this.ButMutualTermination.Name = "ButMutualTermination";
            this.ButMutualTermination.Size = new System.Drawing.Size(80, 48);
            this.ButMutualTermination.TabIndex = 66;
            this.ButMutualTermination.Text = "Mutually Terminate Contract";
            this.ButMutualTermination.UseVisualStyleBackColor = true;
            // 
            // ButScoutAssign
            // 
            this.ButScoutAssign.Location = new System.Drawing.Point(575, 182);
            this.ButScoutAssign.Name = "ButScoutAssign";
            this.ButScoutAssign.Size = new System.Drawing.Size(80, 48);
            this.ButScoutAssign.TabIndex = 65;
            this.ButScoutAssign.Text = "Scout Assignments";
            this.ButScoutAssign.UseVisualStyleBackColor = true;
            // 
            // ButSackStaff
            // 
            this.ButSackStaff.Location = new System.Drawing.Point(575, 128);
            this.ButSackStaff.Name = "ButSackStaff";
            this.ButSackStaff.Size = new System.Drawing.Size(80, 48);
            this.ButSackStaff.TabIndex = 63;
            this.ButSackStaff.Text = "Sack";
            this.ButSackStaff.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabGeneral);
            this.tabControl1.Controls.Add(this.TabContract);
            this.tabControl1.Controls.Add(this.TabCoachAttributes);
            this.tabControl1.Controls.Add(this.TabMentalAttributes);
            this.tabControl1.Controls.Add(this.TabReputation);
            this.tabControl1.Location = new System.Drawing.Point(108, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 331);
            this.tabControl1.TabIndex = 62;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeneral.Size = new System.Drawing.Size(453, 305);
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.Text = "General";
            this.TabGeneral.UseVisualStyleBackColor = true;
            // 
            // TabContract
            // 
            this.TabContract.Location = new System.Drawing.Point(4, 22);
            this.TabContract.Name = "TabContract";
            this.TabContract.Size = new System.Drawing.Size(453, 305);
            this.TabContract.TabIndex = 2;
            this.TabContract.Text = "Contracts";
            this.TabContract.UseVisualStyleBackColor = true;
            // 
            // TabCoachAttributes
            // 
            this.TabCoachAttributes.Location = new System.Drawing.Point(4, 22);
            this.TabCoachAttributes.Name = "TabCoachAttributes";
            this.TabCoachAttributes.Size = new System.Drawing.Size(453, 305);
            this.TabCoachAttributes.TabIndex = 4;
            this.TabCoachAttributes.Text = "Coaching Attributes";
            this.TabCoachAttributes.UseVisualStyleBackColor = true;
            // 
            // TabMentalAttributes
            // 
            this.TabMentalAttributes.Location = new System.Drawing.Point(4, 22);
            this.TabMentalAttributes.Name = "TabMentalAttributes";
            this.TabMentalAttributes.Size = new System.Drawing.Size(453, 305);
            this.TabMentalAttributes.TabIndex = 5;
            this.TabMentalAttributes.Text = "Mental Attributes";
            this.TabMentalAttributes.UseVisualStyleBackColor = true;
            // 
            // TabReputation
            // 
            this.TabReputation.Location = new System.Drawing.Point(4, 22);
            this.TabReputation.Name = "TabReputation";
            this.TabReputation.Size = new System.Drawing.Size(453, 305);
            this.TabReputation.TabIndex = 6;
            this.TabReputation.Text = "Reputation & Rating";
            this.TabReputation.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(110, 397);
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
            // StaffScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 397);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ButMutualTermination);
            this.Controls.Add(this.ButScoutAssign);
            this.Controls.Add(this.ButSackStaff);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffScreen";
            this.Text = "StaffScreen";
            this.Load += new System.EventHandler(this.StaffScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButMutualTermination;
        private System.Windows.Forms.Button ButScoutAssign;
        private System.Windows.Forms.Button ButSackStaff;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGeneral;
        private System.Windows.Forms.TabPage TabContract;
        private System.Windows.Forms.TabPage TabCoachAttributes;
        private System.Windows.Forms.TabPage TabMentalAttributes;
        private System.Windows.Forms.TabPage TabReputation;
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