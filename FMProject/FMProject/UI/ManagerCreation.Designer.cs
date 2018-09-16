namespace FMProject
{
    partial class ManagerCreation
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
            this.ListNationalityPrimary = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListNationalitySecondary = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListLanguageSecondary = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListLanguagePrimary = new System.Windows.Forms.ComboBox();
            this.ButContinue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ClubList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListNationalityPrimary
            // 
            this.ListNationalityPrimary.FormattingEnabled = true;
            this.ListNationalityPrimary.Location = new System.Drawing.Point(41, 150);
            this.ListNationalityPrimary.Name = "ListNationalityPrimary";
            this.ListNationalityPrimary.Size = new System.Drawing.Size(227, 21);
            this.ListNationalityPrimary.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nationality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secondary Nationality";
            // 
            // ListNationalitySecondary
            // 
            this.ListNationalitySecondary.FormattingEnabled = true;
            this.ListNationalitySecondary.Location = new System.Drawing.Point(41, 199);
            this.ListNationalitySecondary.Name = "ListNationalitySecondary";
            this.ListNationalitySecondary.Size = new System.Drawing.Size(227, 21);
            this.ListNationalitySecondary.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(300, 202);
            this.monthCalendar1.MaxDate = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Secondary Language";
            // 
            // ListLanguageSecondary
            // 
            this.ListLanguageSecondary.FormattingEnabled = true;
            this.ListLanguageSecondary.Location = new System.Drawing.Point(42, 294);
            this.ListLanguageSecondary.Name = "ListLanguageSecondary";
            this.ListLanguageSecondary.Size = new System.Drawing.Size(227, 21);
            this.ListLanguageSecondary.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Primary Language";
            // 
            // ListLanguagePrimary
            // 
            this.ListLanguagePrimary.FormattingEnabled = true;
            this.ListLanguagePrimary.Location = new System.Drawing.Point(41, 246);
            this.ListLanguagePrimary.Name = "ListLanguagePrimary";
            this.ListLanguagePrimary.Size = new System.Drawing.Size(227, 21);
            this.ListLanguagePrimary.TabIndex = 10;
            // 
            // ButContinue
            // 
            this.ButContinue.Location = new System.Drawing.Point(41, 9);
            this.ButContinue.Name = "ButContinue";
            this.ButContinue.Size = new System.Drawing.Size(227, 79);
            this.ButContinue.TabIndex = 14;
            this.ButContinue.Text = "Continue";
            this.ButContinue.UseVisualStyleBackColor = true;
            this.ButContinue.Click += new System.EventHandler(this.ButContinue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Choose Club";
            // 
            // ClubList
            // 
            this.ClubList.FormattingEnabled = true;
            this.ClubList.Location = new System.Drawing.Point(42, 343);
            this.ClubList.Name = "ClubList";
            this.ClubList.Size = new System.Drawing.Size(228, 21);
            this.ClubList.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Name:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(41, 108);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(229, 20);
            this.TxtUsername.TabIndex = 18;
            // 
            // ManagerCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 374);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClubList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButContinue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListLanguageSecondary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListLanguagePrimary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListNationalitySecondary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListNationalityPrimary);
            this.Name = "ManagerCreation";
            this.Text = "ManagerCreation";
            this.Load += new System.EventHandler(this.ManagerCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListNationalityPrimary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ListNationalitySecondary;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ListLanguageSecondary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ListLanguagePrimary;
        private System.Windows.Forms.Button ButContinue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ClubList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUsername;
    }
}