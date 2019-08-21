using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunRussianRoullete
{
    // coding for main form
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        gameclass  objrollete = new gameclass();
        Random gunlandspin = new Random();

        //coding for load button
        private void Loadbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image =GunRussianRoullete.Properties.Resources.load;



            Spinbtn.Enabled = true;
            Loadbtn.Enabled = false;
        }

        //This is codu
        private void spinbtn_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = GunRussianRoullete.Properties.Resources.spin1;

            objrollete.spingun = gunlandspin.Next(1, 6);

            Shootbtn.Enabled = true;
            Spinbtn.Enabled = false;
        }
        
        //coding for shoot button
        private void shootbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GunRussianRoullete.Properties.Resources.shoot;
            System.IO.Stream str = GunRussianRoullete.Properties.Resources.shoot1;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();


            if (objrollete.chabspin > 0 && objrollete.spingun == 1)
            {


                MessageBox.Show("You Loose");

                Loadbtn.Enabled = false;
                Shootbtn.Enabled = false;
                Spinbtn.Enabled = false;
                SAbtn.Enabled = false;



            }
            else if (objrollete.chabspin > 0 && objrollete.spingun != 1)
            {
                objrollete.chabspin = objrollete.chabspin - 1;
                if (objrollete.spingun == 6)
                {
                    objrollete.spingun = 1;
                }
                else
                {
                    objrollete.spingun++;
                }

                MessageBox.Show("Saved missed");

            }
        }
        //coding for a shoot away button
        private void SAbtn_Click(object sender, EventArgs e)
        {
            int scr = objrollete.AwaybulleteMissed();
            // coding for image 
            System.IO.Stream str = GunRussianRoullete.Properties.Resources.shoot1;
            //coding for sound
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            // coding for  a shoot and message
            if (scr == 10)
            {
                MessageBox.Show("you win score=100");
                Loadbtn.Enabled = false;
                Shootbtn.Enabled = false;
                Spinbtn.Enabled = false;
                SAbtn.Enabled = false;

            }
            if (scr == 5)
            {
                MessageBox.Show("you win score =10");
                Loadbtn.Enabled = false;
                Shootbtn.Enabled = false;
                Spinbtn.Enabled = false;
                SAbtn.Enabled = false;
            }
            if (scr == 0)
            {

                MessageBox.Show("missed");


            }
            if (objrollete.chabspin == 0)
            {

                MessageBox.Show("losser");
                Loadbtn.Enabled = false;
                Shootbtn.Enabled = false;
                Spinbtn.Enabled = false;
                SAbtn.Enabled = false;


            }
        }

        private void Playagainbtn_Click(object sender, EventArgs e)
        {
            (new Game()).Show();
            this.Hide();
        }
    }
}
