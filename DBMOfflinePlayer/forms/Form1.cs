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
            if (!File.Exists("C:/Users/Dc/Desktop/MyDatabase.sqlite"))
            {
                utility.createdatabase();
            }
        }
    }
}
