namespace FMProject.UI
{
    partial class NegotiationsScreen
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Club = new System.Windows.Forms.Label();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butOffer = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.txtYourValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransferBudget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Club
            // 
            this.Club.AutoSize = true;
            this.Club.Location = new System.Drawing.Point(170, 15);
            this.Club.Name = "Club";
            this.Club.Size = new System.Drawing.Size(31, 13);
            this.Club.TabIndex = 3;
            this.Club.Text = "Club:";
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(207, 12);
            this.txtClub.Name = "txtClub";
            this.txtClub.ReadOnly = true;
            this.txtClub.Size = new System.Drawing.Size(100, 20);
            this.txtClub.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Market Value:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // butOffer
            // 
            this.butOffer.Location = new System.Drawing.Point(228, 147);
            this.butOffer.Name = "butOffer";
            this.butOffer.Size = new System.Drawing.Size(75, 23);
            this.butOffer.TabIndex = 6;
            this.butOffer.Text = "Offer";
            this.butOffer.UseVisualStyleBackColor = true;
            this.butOffer.Click += new System.EventHandler(this.butOffer_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(228, 176);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // txtYourValue
            // 
            this.txtYourValue.Location = new System.Drawing.Point(122, 150);
            this.txtYourValue.Name = "txtYourValue";
            this.txtYourValue.Size = new System.Drawing.Size(100, 20);
            this.txtYourValue.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type in Value:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "£0",
            "£100k",
            "£250k",
            "£500k",
            "£750k",
            "£1m",
            "£2.5m",
            "£5m",
            "£7.5m",
            "£10m",
            "£15m",
            "£20m",
            "£25m",
            "£50m",
            "£75m",
            "£100m",
            "£250m"});
            this.comboBox1.Location = new System.Drawing.Point(122, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Auto Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Transfer Budget:";
            // 
            // txtTransferBudget
            // 
            this.txtTransferBudget.Location = new System.Drawing.Point(122, 53);
            this.txtTransferBudget.Name = "txtTransferBudget";
            this.txtTransferBudget.ReadOnly = true;
            this.txtTransferBudget.Size = new System.Drawing.Size(100, 20);
            this.txtTransferBudget.TabIndex = 12;
            // 
            // NegotiationsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 303);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTransferBudget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYourValue);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOffer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Club);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "NegotiationsScreen";
            this.Text = "Negotiations";
            this.Load += new System.EventHandler(this.NegotiationsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Club;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butOffer;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox txtYourValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransferBudget;
    }
}