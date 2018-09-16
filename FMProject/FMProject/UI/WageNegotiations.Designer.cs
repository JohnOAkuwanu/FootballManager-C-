namespace FMProject.UI
{
    partial class WageNegotiations
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtWageBudget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYourValue = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOfferWage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentWage = new System.Windows.Forms.TextBox();
            this.Club = new System.Windows.Forms.Label();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Wage Budget:";
            // 
            // txtWageBudget
            // 
            this.txtWageBudget.Location = new System.Drawing.Point(117, 49);
            this.txtWageBudget.Name = "txtWageBudget";
            this.txtWageBudget.ReadOnly = true;
            this.txtWageBudget.Size = new System.Drawing.Size(100, 20);
            this.txtWageBudget.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Type in Value:";
            // 
            // txtYourValue
            // 
            this.txtYourValue.Location = new System.Drawing.Point(117, 146);
            this.txtYourValue.Name = "txtYourValue";
            this.txtYourValue.Size = new System.Drawing.Size(100, 20);
            this.txtYourValue.TabIndex = 22;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(223, 172);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 21;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOfferWage
            // 
            this.butOfferWage.Location = new System.Drawing.Point(223, 143);
            this.butOfferWage.Name = "butOfferWage";
            this.butOfferWage.Size = new System.Drawing.Size(75, 23);
            this.butOfferWage.TabIndex = 20;
            this.butOfferWage.Text = "Offer";
            this.butOfferWage.UseVisualStyleBackColor = true;
            this.butOfferWage.Click += new System.EventHandler(this.butOfferWage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contract Value:";
            // 
            // txtCurrentWage
            // 
            this.txtCurrentWage.Location = new System.Drawing.Point(118, 102);
            this.txtCurrentWage.Name = "txtCurrentWage";
            this.txtCurrentWage.ReadOnly = true;
            this.txtCurrentWage.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentWage.TabIndex = 18;
            // 
            // Club
            // 
            this.Club.AutoSize = true;
            this.Club.Location = new System.Drawing.Point(165, 11);
            this.Club.Name = "Club";
            this.Club.Size = new System.Drawing.Size(31, 13);
            this.Club.TabIndex = 17;
            this.Club.Text = "Club:";
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(202, 8);
            this.txtClub.Name = "txtClub";
            this.txtClub.ReadOnly = true;
            this.txtClub.Size = new System.Drawing.Size(100, 20);
            this.txtClub.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 8);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 14;
            // 
            // WageNegotiations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 252);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWageBudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYourValue);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOfferWage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentWage);
            this.Controls.Add(this.Club);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "WageNegotiations";
            this.Text = "WageNegotiations";
            this.Load += new System.EventHandler(this.WageNegotiations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWageBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYourValue;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOfferWage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentWage;
        private System.Windows.Forms.Label Club;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}