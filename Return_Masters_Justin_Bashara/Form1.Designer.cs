namespace HatMaster_JustinBashara
{
    partial class Form
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.ClothesQty = new System.Windows.Forms.Label();
            this.ClotheAmt = new System.Windows.Forms.NumericUpDown();
            this.HatMasterButton = new System.Windows.Forms.Button();
            this.RollCallButton = new System.Windows.Forms.Button();
            this.PantsMasterButton = new System.Windows.Forms.Button();
            this.RingMasterButton = new System.Windows.Forms.Button();
            this.PersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClotheAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(138, 56);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(213, 20);
            this.NameBox.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(41, 56);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(38, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name:";
            // 
            // ClothesQty
            // 
            this.ClothesQty.AutoSize = true;
            this.ClothesQty.Location = new System.Drawing.Point(44, 97);
            this.ClothesQty.Name = "ClothesQty";
            this.ClothesQty.Size = new System.Drawing.Size(67, 13);
            this.ClothesQty.TabIndex = 2;
            this.ClothesQty.Text = "Clothing Qty:";
            // 
            // ClotheAmt
            // 
            this.ClotheAmt.Location = new System.Drawing.Point(138, 90);
            this.ClotheAmt.Name = "ClotheAmt";
            this.ClotheAmt.Size = new System.Drawing.Size(120, 20);
            this.ClotheAmt.TabIndex = 3;
            // 
            // HatMasterButton
            // 
            this.HatMasterButton.Location = new System.Drawing.Point(107, 148);
            this.HatMasterButton.Name = "HatMasterButton";
            this.HatMasterButton.Size = new System.Drawing.Size(166, 23);
            this.HatMasterButton.TabIndex = 4;
            this.HatMasterButton.Text = "Create New Hat Master";
            this.HatMasterButton.UseVisualStyleBackColor = true;
            this.HatMasterButton.Click += new System.EventHandler(this.HatMaster_Click);
            // 
            // RollCallButton
            // 
            this.RollCallButton.Location = new System.Drawing.Point(134, 281);
            this.RollCallButton.Name = "RollCallButton";
            this.RollCallButton.Size = new System.Drawing.Size(124, 23);
            this.RollCallButton.TabIndex = 5;
            this.RollCallButton.Text = "Roll Call";
            this.RollCallButton.UseVisualStyleBackColor = true;
            this.RollCallButton.Click += new System.EventHandler(this.RollCall_Click);
            // 
            // PantsMasterButton
            // 
            this.PantsMasterButton.Location = new System.Drawing.Point(107, 177);
            this.PantsMasterButton.Name = "PantsMasterButton";
            this.PantsMasterButton.Size = new System.Drawing.Size(166, 23);
            this.PantsMasterButton.TabIndex = 6;
            this.PantsMasterButton.Text = "Create New Pants Master";
            this.PantsMasterButton.UseVisualStyleBackColor = true;
            this.PantsMasterButton.Click += new System.EventHandler(this.PantsMasterButton_Click);
            // 
            // RingMasterButton
            // 
            this.RingMasterButton.Location = new System.Drawing.Point(107, 206);
            this.RingMasterButton.Name = "RingMasterButton";
            this.RingMasterButton.Size = new System.Drawing.Size(166, 23);
            this.RingMasterButton.TabIndex = 7;
            this.RingMasterButton.Text = "Create New Ring Master";
            this.RingMasterButton.UseVisualStyleBackColor = true;
            this.RingMasterButton.Click += new System.EventHandler(this.RingMasterButton_Click);
            // 
            // PersonButton
            // 
            this.PersonButton.Location = new System.Drawing.Point(107, 235);
            this.PersonButton.Name = "PersonButton";
            this.PersonButton.Size = new System.Drawing.Size(166, 23);
            this.PersonButton.TabIndex = 8;
            this.PersonButton.Text = "Create New Person";
            this.PersonButton.UseVisualStyleBackColor = true;
            this.PersonButton.Click += new System.EventHandler(this.PersonButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 336);
            this.Controls.Add(this.PersonButton);
            this.Controls.Add(this.RingMasterButton);
            this.Controls.Add(this.PantsMasterButton);
            this.Controls.Add(this.RollCallButton);
            this.Controls.Add(this.HatMasterButton);
            this.Controls.Add(this.ClotheAmt);
            this.Controls.Add(this.ClothesQty);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.NameBox);
            //this.Name = "Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ClotheAmt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label ClothesQty;
        private System.Windows.Forms.NumericUpDown ClotheAmt;
        private System.Windows.Forms.Button HatMasterButton;
        private System.Windows.Forms.Button RollCallButton;
        private System.Windows.Forms.Button PantsMasterButton;
        private System.Windows.Forms.Button RingMasterButton;
        private System.Windows.Forms.Button PersonButton;
    }
}

