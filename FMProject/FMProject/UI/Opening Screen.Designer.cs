namespace FMProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButNewGame = new System.Windows.Forms.Button();
            this.ButSettings = new System.Windows.Forms.Button();
            this.ButHelp = new System.Windows.Forms.Button();
            this.ButLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButNewGame
            // 
            this.ButNewGame.Location = new System.Drawing.Point(12, 27);
            this.ButNewGame.Name = "ButNewGame";
            this.ButNewGame.Size = new System.Drawing.Size(136, 46);
            this.ButNewGame.TabIndex = 0;
            this.ButNewGame.Text = "Start A New Game";
            this.ButNewGame.UseVisualStyleBackColor = true;
            this.ButNewGame.Click += new System.EventHandler(this.ButNewGame_Click);
            // 
            // ButSettings
            // 
            this.ButSettings.Location = new System.Drawing.Point(12, 183);
            this.ButSettings.Name = "ButSettings";
            this.ButSettings.Size = new System.Drawing.Size(136, 46);
            this.ButSettings.TabIndex = 1;
            this.ButSettings.Text = "Settings";
            this.ButSettings.UseVisualStyleBackColor = true;
            // 
            // ButHelp
            // 
            this.ButHelp.Location = new System.Drawing.Point(12, 131);
            this.ButHelp.Name = "ButHelp";
            this.ButHelp.Size = new System.Drawing.Size(136, 46);
            this.ButHelp.TabIndex = 2;
            this.ButHelp.Text = "Help";
            this.ButHelp.UseVisualStyleBackColor = true;
            // 
            // ButLoad
            // 
            this.ButLoad.Location = new System.Drawing.Point(12, 79);
            this.ButLoad.Name = "ButLoad";
            this.ButLoad.Size = new System.Drawing.Size(136, 46);
            this.ButLoad.TabIndex = 3;
            this.ButLoad.Text = "Load Game";
            this.ButLoad.UseVisualStyleBackColor = true;
            this.ButLoad.Click += new System.EventHandler(this.ButLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 353);
            this.Controls.Add(this.ButLoad);
            this.Controls.Add(this.ButHelp);
            this.Controls.Add(this.ButSettings);
            this.Controls.Add(this.ButNewGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Opening Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButNewGame;
        private System.Windows.Forms.Button ButSettings;
        private System.Windows.Forms.Button ButHelp;
        private System.Windows.Forms.Button ButLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

