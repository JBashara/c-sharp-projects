﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatMaster_JustinBashara
{
    public partial class Form : System.Windows.Forms.Form
    {
        IReporter[] masters;
        int count = 0;
        
        public Form()
        {
            InitializeComponent();
            masters = new IReporter[20];
        }

        private void HatMaster_Click(object sender, EventArgs e)
        {
            HatMaster master = new HatMaster(NameBox.Text, (int)ClotheAmt.Value);
            if (NameBox.Text == "")
            {
                MessageBox.Show("Enter a name.");
            }
            else if (ClotheAmt.Value == 0)
            {
                MessageBox.Show("Enter a value above zero.");
            }
            

            if (count < 20 && NameBox.Text != "" && ClotheAmt.Value != 0)
            {
                masters[count] = master;
                count++;
            }
            else
            {
                MessageBox.Show("No more room.");
            }

            NameBox.ResetText();
            ClotheAmt.ResetText();
            
        }

        private void PantsMasterButton_Click(object sender, EventArgs e)
        {
            PantsMaster master = new PantsMaster(NameBox.Text, (int)ClotheAmt.Value);
            if (NameBox.Text == "")
            {
                MessageBox.Show("Enter a name.");
            }
            else if (ClotheAmt.Value == 0)
            {
                MessageBox.Show("Enter a value above zero.");
            }


            if (count < 20 && NameBox.Text != "" && ClotheAmt.Value != 0)
            {
                masters[count] = master;
                count++;
            }
            else
            {
                MessageBox.Show("No more room.");
            }

            NameBox.ResetText();
            ClotheAmt.ResetText();

        }

        private void RingMasterButton_Click(object sender, EventArgs e)
        {
            RingMaster master = new RingMaster(NameBox.Text, (int)ClotheAmt.Value);
            if (NameBox.Text == "")
            {
                MessageBox.Show("Enter a name.");
            }
            else if (ClotheAmt.Value == 0)
            {
                MessageBox.Show("Enter a value above zero.");
            }


            if (count < 20 && NameBox.Text != "" && ClotheAmt.Value != 0)
            {
                masters[count] = master;
                count++;
            }
            else
            {
                MessageBox.Show("No more room.");
            }

            NameBox.ResetText();
            ClotheAmt.ResetText();
        }

        private void PersonButton_Click(object sender, EventArgs e)
        {
            Person master = new Person(NameBox.Text);
            if (NameBox.Text == "")
            {
                MessageBox.Show("Enter a name.");
            }
            else if (ClotheAmt.Value == 0)
            {
                MessageBox.Show("Enter a value above zero.");
            }


            if (count < 20 && NameBox.Text != "" && ClotheAmt.Value != 0)
            {
                masters[count] = master;
                count++;
            }
            else
            {
                MessageBox.Show("No more room.");
            }

            NameBox.ResetText();
            ClotheAmt.ResetText();
        }

        private void RollCall_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < masters.Length && masters[i] != null; i++)
            {
                MessageBox.Show(masters[i].Report());
            }

            NameBox.ResetText();
            ClotheAmt.ResetText();
        }
    }
}
