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
    public partial class Lectures : Form
    {
        public Lectures()
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

        private void label2_Click(object sender, EventArgs e)
        {

            forms.contact contactform = new contact();

            contactform.Show();
            this.Hide();

        }

        private void btn_contactus_Click(object sender, EventArgs e)
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

        private void btn_about_Click(object sender, EventArgs e)
        {

            forms.about aboutform = new about();
            aboutform.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {

            forms.about aboutform = new about();
            aboutform.Show();
            this.Hide();
        }

        private void btn_lectureplayer_Click(object sender, EventArgs e)
        {
            offlineplayer playerform = new offlineplayer();
            playerform.Show();
            this.Hide();
        }
        
    }
}
