using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DBMOfflinePlayer.forms
{
    public partial class offlineplayer : Form
    {
        public offlineplayer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            btn_pause.Enabled = true;
            btn_play.Enabled = false;
            btn_startover.Enabled = true;


            System.Threading.Thread.Sleep(100);

            utility.ReadandDrawFromFileCall(ref imageBoxplayer, ref lblCurrentTime,this);
            btn_play.Enabled = true;
        }

        private void offlineplayer_Load(object sender, EventArgs e)
        {
            lblTotalTime.Text = utility.getTotalVideoDuration().ToString();
           
            btn_pause.Enabled = true;
            btn_play.Enabled = false;
            btn_startover.Enabled = true;


            System.Threading.Thread.Sleep(100);

            utility.ReadandDrawFromFileCall(ref imageBoxplayer, ref lblCurrentTime, this);
            btn_play.Enabled = true;
        }
       


        private void button2_Click(object sender, EventArgs e)
        {
            btn_play.Enabled = false;
            btn_pause.Enabled = true;
           

            System.Threading.Thread.Sleep(100);

            utility.startover(ref imageBoxplayer);
            btn_play.Enabled = true;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            btn_play.Enabled = false;
            if(btn_pause.Text.ToLower() == "pause")
            {
                if(utility.thread1.ThreadState == System.Threading.ThreadState.Running)
                {

                }
                btn_pause.Text = "Resume";
                utility.pausevideo();
            }
            else if(btn_pause.Text.ToLower() == "resume")
            {
                btn_pause.Text = "Pause";
                utility.startpausedvideo(ref imageBoxplayer);
            }

        }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            forms.Lectures lecturesform = new Lectures();
            lecturesform.Show();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int i = trackBar1.Value;
            float fraction = ((float)(i)) / ((float)(trackBar1.Maximum));
            Console.WriteLine(fraction);
            double totaltime = utility.getTotalVideoDuration();
            double currentTime = totaltime * fraction;
            Console.WriteLine(currentTime);
            utility.ReadandDrawFromFileOnSpecificTimeCall(ref imageBoxplayer,ref lblCurrentTime, this,currentTime,ref trackBar1);
        }
    }
}
