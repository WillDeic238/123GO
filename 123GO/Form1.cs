using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace _123GO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        { //change the color of the button
            StartGame.Visible = false;
            //change the message in the output label
            Countdown.ForeColor = Color.White;
            Countdown.Text = "Game Starts In . . . 3";
            SoundPlayer player = new SoundPlayer(Properties.Resources.ShortDing);
            player.Play();    
            Refresh();
            Thread.Sleep(1000);
            
            Countdown.Text = "Game Starts In . . . 2";

            player.Play();

            Refresh();
            Thread.Sleep(1000);


            Countdown.Text = "Game Starts In . . . 1";

            player.Play();


            Refresh();
            Thread.Sleep(1000);

            Countdown.Text = "GO!!!!!";
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.LongDing);
            player3.Play();
            this.BackColor = Color.Green;

   

        }

        private void Countdown_Click(object sender, EventArgs e)
        {

        }
    }
}
