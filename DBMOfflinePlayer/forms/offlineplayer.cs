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
            utility.ReadandDrawFromFileCall(ref imageBoxplayer);
        }

        private void offlineplayer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
