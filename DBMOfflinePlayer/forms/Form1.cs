using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMOfflinePlayer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBMOfflinePlayer.forms.offlineplayer a = new forms.offlineplayer();
            a.Show();
            this.Hide();
        }

        private void btn_authenticate_Click(object sender, EventArgs e)
        {
            forms.AuthenticationForm authform = new forms.AuthenticationForm();
            authform.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            utility.dbfile = "C:/Users/Dc/Desktop/MyDatabase.sqlite";
            if (!File.Exists(utility.dbfile))
            {
                utility.createdatabase();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_contactus_Click(object sender, EventArgs e)
        {

            forms.contact contactform = new forms.contact();

            contactform.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            forms.contact contactform = new forms.contact();

            contactform.Show();
            this.Hide();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {

            forms.about aboutform = new forms.about();
            aboutform.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            forms.about aboutform = new forms.about();
            aboutform.Show();
            this.Hide();
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {

            forms.Lectures lectureform = new forms.Lectures();
            lectureform.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

            forms.Lectures lectureform = new forms.Lectures();
            lectureform.Show();
            this.Hide();
        }
    }
}
