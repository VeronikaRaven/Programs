using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Сборник_игр.Dino;
using Сборник_игр.Sudoku;
using Сборник_игр.Tag;

namespace Сборник_игр
{
    public partial class SelectGameF : Form
    {
        public SelectGameF()
        {
            InitializeComponent();
        }

        public void DinoPb_Click(object sender, EventArgs e)
        {
            PlayDinoFm pd = new PlayDinoFm();
            pd.Show();
        }

        private void SudokuPb_Click(object sender, EventArgs e)
        {
            GameF g = new GameF();
            this.Hide();
            g.Show();
        }

        private void TagPb_Click(object sender, EventArgs e)
        {
            TagFm t = new TagFm();
            t.Show();
        }
    }
}
