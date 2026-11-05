using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project8_2.tamagotchi
{
    

    public partial class Form1 : Form
    {
         Cat cat;
        static Timer tamagochiTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            cat = new Cat();
            tamagochiTimer.Interval = 6000;
            tamagochiTimer.Tick += Tick;
            tamagochiTimer.Start();
            progresBar();
        }
        
        private void progresBar() 
        {
            this.Hunger.Value = cat.getHunger();
            this.Energy.Value = cat.getEnergy();
            this.Happy.Value = cat.getHappines();

        }
        private void Tick(object sender, EventArgs e)
        {
            cat.increaseHunger(5);
            cat.decreaseHappines(5);
            cat.decreaseEnergy(5);
            progresBar();
            if (cat.getEnergy() == 0 || cat.getHunger() == 100 || cat.getHappines() == 0)
            {
                this.pictureBox1.Image = global::Project8_2.tamagotchi.Properties.Resources.angrycat;
                tamagochiTimer.Enabled = false;

                DialogResult dr = MessageBox.Show("Ваш кіт з'їв вас.", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                {
                    Application.Exit();
                }
                return;
            }
            else if (cat.getHappines() >= 90)
            {
                this.pictureBox1.Image = global::Project8_2.tamagotchi.Properties.Resources.happycat;
                MessageBox.Show("Ваш кіт щасливий!", "   :)))))   ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cat.getHunger() >= 80 || cat.getHappines() <= 30 || cat.getEnergy() <= 20)
            {
                this.pictureBox1.Image = global::Project8_2.tamagotchi.Properties.Resources.sadcat;
                MessageBox.Show("Ваш кіт сумний...", "   :(((((((   ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                this.pictureBox1.Image = global::Project8_2.tamagotchi.Properties.Resources.normalcat;
            }
            


        }

        

        private void buttonEat_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::Project8_2.tamagotchi.Properties.Resources.eatcat;
            cat.increaseEnergy(10);
            cat.increaseHappines(10);
            cat.decreaseHunger(20);
            progresBar();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::Project8_2.tamagotchi.Properties.Resources.playcat;
            cat.increaseHappines(20);
            cat.increaseHunger(10);
            cat.decreaseEnergy(10);
            progresBar();
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::Project8_2.tamagotchi.Properties.Resources.sleepcat;
            cat.increaseEnergy(10);
            cat.increaseHunger(10);
            cat.decreaseHappines(20);
            progresBar();
        }

    }
    
   
}
