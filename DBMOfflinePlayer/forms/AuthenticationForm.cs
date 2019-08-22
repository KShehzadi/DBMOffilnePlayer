using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace DBMOfflinePlayer.forms
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.Enabled = false;
            if (utility.CheckForInternetConnection())
            {
                utility.authenticate(txt_username.Text, txt_password.Text);
                if (utility.authenticated == true)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Check for Internet Connectivity.");
            }
            btn_login.Enabled = true;
            
            
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboardform = new Dashboard();
            dashboardform.Show();
            this.Hide();
        }
    }
}
