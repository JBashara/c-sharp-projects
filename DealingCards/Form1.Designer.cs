namespace DealingCards
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
            this.HandBox = new System.Windows.Forms.ListBox();
            this.Hand = new System.Windows.Forms.GroupBox();
            this.Deck = new System.Windows.Forms.GroupBox();
            this.DeckBox = new System.Windows.Forms.ListBox();
            this.DrawCard = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.Hand.SuspendLayout();
            this.Deck.SuspendLayout();
            this.SuspendLayout();
            // 
            // HandBox
            // 
            this.HandBox.FormattingEnabled = true;
            this.HandBox.Location = new System.Drawing.Point(6, 19);
            this.HandBox.Name = "HandBox";
            this.HandBox.Size = new System.Drawing.Size(188, 355);
            this.HandBox.TabIndex = 0;
            // 
            // Hand
            // 
            this.Hand.Controls.Add(this.HandBox);
            this.Hand.Location = new System.Drawing.Point(27, 50);
            this.Hand.Name = "Hand";
            this.Hand.Size = new System.Drawing.Size(200, 390);
            this.Hand.TabIndex = 1;
            this.Hand.TabStop = false;
            this.Hand.Text = "Hand";
            // 
            // Deck
            // 
            this.Deck.Controls.Add(this.DeckBox);
            this.Deck.Location = new System.Drawing.Point(391, 50);
            this.Deck.Name = "Deck";
            this.Deck.Size = new System.Drawing.Size(200, 387);
            this.Deck.TabIndex = 2;
            this.Deck.TabStop = false;
            this.Deck.Text = "Deck";
            // 
            // DeckBox
            // 
            this.DeckBox.FormattingEnabled = true;
            this.DeckBox.Location = new System.Drawing.Point(6, 19);
            this.DeckBox.Name = "DeckBox";
            this.DeckBox.Size = new System.Drawing.Size(188, 355);
            this.DeckBox.TabIndex = 0;
            // 
            // DrawCard
            // 
            this.DrawCard.Location = new System.Drawing.Point(233, 150);
            this.DrawCard.Name = "DrawCard";
            this.DrawCard.Size = new System.Drawing.Size(152, 23);
            this.DrawCard.TabIndex = 3;
            this.DrawCard.Text = "Draw a Random Card";
            this.DrawCard.UseVisualStyleBackColor = true;
            this.DrawCard.Click += new System.EventHandler(this.DrawCard_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(233, 204);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(152, 23);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Sort Hand";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 452);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DrawCard);
            this.Controls.Add(this.Deck);
            this.Controls.Add(this.Hand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Hand.ResumeLayout(false);
            this.Deck.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HandBox;
        private System.Windows.Forms.GroupBox Hand;
        private System.Windows.Forms.GroupBox Deck;
        private System.Windows.Forms.ListBox DeckBox;
        private System.Windows.Forms.Button DrawCard;
        private System.Windows.Forms.Button SortButton;
    }
}

