using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сборник_игр.Sudoku
{
    public partial class GameF : Form
    {
        SudokGE S;

        private Communicator C;
        public GameF()
        {
            InitializeComponent();

            S = new SudokGE();

            Application.DoEvents();

            S.GenerateGame();

            S.RequestRepaint += new SudokGE.SudokuEvent2(S_RequestRepaint);

            C = new Communicator();

            C.StatusChange += new Communicator.MethodDelegate(C_StatusChange);
        }
        void C_StatusChange()
        {
            this.Text = C.Status;
        }

        void S_RequestRepaint()
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            S.Draw(e.Graphics, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                S.SetLocation(e.Location);

                pictureBox1.Invalidate();
            }
        }

        private void GameFm_KeyDown(object sender, KeyEventArgs e)
        {
            S.KeyPress((char)e.KeyValue);

            if ((int)e.KeyValue == 27) S.Deselect();

            if ((int)e.KeyValue == 46) S.DeleteCurrentSquare();

            pictureBox1.Invalidate();
        }

        private void GameFm_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            S.GenerateGame();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";

            DialogResult R = openFileDialog1.ShowDialog();

            if (R != DialogResult.OK) return;

            bool result = S.LoadFile(openFileDialog1.FileName);

            if (!result)
            {
                Application.DoEvents();

                MessageBox.Show("Ошибка, игра не может быть открыта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult R = saveFileDialog1.ShowDialog();

            if (R != DialogResult.OK) return;

            bool result = S.SaveFile(saveFileDialog1.FileName);

            if (!result)
            {
                Application.DoEvents();

                MessageBox.Show("Ошибка сохранения игры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectGameF sf = new SelectGameF();
            this.Hide();
            sf.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(S.GetGameString());
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool result = S.SetGameString(Clipboard.GetText());

            if (!result)
            {
                Application.DoEvents();

                MessageBox.Show("Буфер обмена не сожержит игры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void solveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (S.checkSolvable(SudokGE.SolveMethods8.All) == false)
            {
                Application.DoEvents();

                MessageBox.Show("Головоломка не решена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                S.SolvePuzzle(SudokGE.SolveMethods8.All);

                pictureBox1.Invalidate();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            S.SolveStep(SudokGE.SolveMethods8.All);

            pictureBox1.Invalidate();
        }

        private void checkSolvabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (S.isSolved()) return;

            int error_count = S.ComputeErrors();

            if (error_count == 0)
            {
                S.RenderMessage("Все отлично, молодец!", "Нажмите любую клавишу для продолжения", false);

                pictureBox1.Invalidate();

                Application.DoEvents();

            }
            else
            {
                Application.DoEvents();

                S.ShowErrors = true;

                pictureBox1.Invalidate();
            }
        }

        private void checkSolutionsCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (S.isSolved()) return;

            SudokGE.SolutionStepList L = S.ComputePossibleSteps(SudokGE.SolveMethods8.All);

            S.RenderMessage(L.Count().ToString() + " возможные недочеты!", "Нажмите любую кнопку для продолжения", false);
        }
    }
}
