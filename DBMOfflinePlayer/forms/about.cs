using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMOfflinePlayer.forms
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_contactus_Click(object sender, EventArgs e)
        {
            forms.contact contactform = new contact();

            contactform.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            forms.contact contactform = new contact();

            contactform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {

            forms.Lectures lectureform = new Lectures();
            lectureform.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

            forms.Lectures lectureform = new Lectures();
            lectureform.Show();
            this.Hide();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {

        }
    }
}
