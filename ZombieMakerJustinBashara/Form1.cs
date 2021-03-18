using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieMakerJustinBashara
{
    public partial class ZombieNameLabel : Form
    {
        Zombie currZombie = new Zombie();
        public ZombieNameLabel()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Zombie newZombie = new Zombie(ZombieNameText.Text, ZombieGroanText.Text);
            
            // Saving newZombie
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\justi\Documents\";
            saveFileDialog1.Filter = "Text files (*.zom)|*.zom|All files (*.*)|*.*";
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Zombie.saveTheFile(saveFileDialog1.FileName, newZombie);
            }

            currZombie = newZombie;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Zombie loadZombie = new Zombie();
            
            // Loading .zom file and assigning to currZombie variable.
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.zom)|*.zom|All files (*.*)|*.*";
            openFileDialog1.FileName = "default_file.zom";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
               currZombie = loadZombie.openTheFile(openFileDialog1.FileName);
            }
        }

        private void CurrentZombieButton_Click(object sender, EventArgs e)
        {
            // Displaying content of currZombie.
            CurrentZombieText.Text = currZombie.toString();
        }
    }
}
