using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сборник_игр
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayBt_Click(object sender, EventArgs e)
        {
            SelectGameF s = new SelectGameF();
            this.Hide();
            s.Show();
        }

        private void HowPlayBt_Click(object sender, EventArgs e)
        {

        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
