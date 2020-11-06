namespace ZombieMakerJustinBashara
{
    partial class ZombieNameLabel
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
            this.groupBoxZombie = new System.Windows.Forms.GroupBox();
            this.CurrentZombieText = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ZombieGroanText = new System.Windows.Forms.TextBox();
            this.ZombieNameText = new System.Windows.Forms.TextBox();
            this.ZombieGroanLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CurrentZombieButton = new System.Windows.Forms.Button();
            this.groupBoxZombie.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxZombie
            // 
            this.groupBoxZombie.Controls.Add(this.CurrentZombieButton);
            this.groupBoxZombie.Controls.Add(this.CurrentZombieText);
            this.groupBoxZombie.Controls.Add(this.LoadButton);
            this.groupBoxZombie.Controls.Add(this.SaveButton);
            this.groupBoxZombie.Controls.Add(this.ZombieGroanText);
            this.groupBoxZombie.Controls.Add(this.ZombieNameText);
            this.groupBoxZombie.Controls.Add(this.ZombieGroanLabel);
            this.groupBoxZombie.Controls.Add(this.label1);
            this.groupBoxZombie.Location = new System.Drawing.Point(41, 35);
            this.groupBoxZombie.Name = "groupBoxZombie";
            this.groupBoxZombie.Size = new System.Drawing.Size(269, 269);
            this.groupBoxZombie.TabIndex = 0;
            this.groupBoxZombie.TabStop = false;
            this.groupBoxZombie.Text = "Create a Zombie";
            // 
            // CurrentZombieText
            // 
            this.CurrentZombieText.Location = new System.Drawing.Point(36, 228);
            this.CurrentZombieText.Name = "CurrentZombieText";
            this.CurrentZombieText.Size = new System.Drawing.Size(195, 20);
            this.CurrentZombieText.TabIndex = 6;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(156, 132);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(36, 132);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ZombieGroanText
            // 
            this.ZombieGroanText.Location = new System.Drawing.Point(90, 80);
            this.ZombieGroanText.Name = "ZombieGroanText";
            this.ZombieGroanText.Size = new System.Drawing.Size(173, 20);
            this.ZombieGroanText.TabIndex = 3;
            // 
            // ZombieNameText
            // 
            this.ZombieNameText.Location = new System.Drawing.Point(90, 39);
            this.ZombieNameText.Name = "ZombieNameText";
            this.ZombieNameText.Size = new System.Drawing.Size(173, 20);
            this.ZombieNameText.TabIndex = 2;
            // 
            // ZombieGroanLabel
            // 
            this.ZombieGroanLabel.AutoSize = true;
            this.ZombieGroanLabel.Location = new System.Drawing.Point(7, 83);
            this.ZombieGroanLabel.Name = "ZombieGroanLabel";
            this.ZombieGroanLabel.Size = new System.Drawing.Size(77, 13);
            this.ZombieGroanLabel.TabIndex = 1;
            this.ZombieGroanLabel.Text = "Zombie Groan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zombie Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CurrentZombieButton
            // 
            this.CurrentZombieButton.Location = new System.Drawing.Point(81, 181);
            this.CurrentZombieButton.Name = "CurrentZombieButton";
            this.CurrentZombieButton.Size = new System.Drawing.Size(100, 23);
            this.CurrentZombieButton.TabIndex = 7;
            this.CurrentZombieButton.Text = "Current Zombie";
            this.CurrentZombieButton.UseVisualStyleBackColor = true;
            this.CurrentZombieButton.Click += new System.EventHandler(this.CurrentZombieButton_Click);
            // 
            // ZombieNameLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxZombie);
            this.Name = "ZombieNameLabel";
            this.Text = "Form1";
            this.groupBoxZombie.ResumeLayout(false);
            this.groupBoxZombie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZombie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentZombieText;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox ZombieGroanText;
        private System.Windows.Forms.TextBox ZombieNameText;
        private System.Windows.Forms.Label ZombieGroanLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CurrentZombieButton;
    }
}

