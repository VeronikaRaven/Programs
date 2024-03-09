using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows;
using System.Data.SqlClient;
using System.Diagnostics;

namespace УП3_приложение
{
    public partial class AdministratorFm : Form
    {
        public AdministratorFm()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void AddInfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInfUserFm af = new AddInfUserFm();
            af.Show();
        }
        private void EditInfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditInfFm uf = new EditInfFm();

            uf.Show();
        }
        private void DeleteInfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            SqlCommand command = new SqlCommand($"DELETE FROM Пользователи WHERE Код = {UserDGV.Rows[UserDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon); //TableName - имя таблицы, из которой удаляете запись

            command.ExecuteNonQuery();

            sqlcon.Close();
            try  // при успешном удалении
            {
                DeleteInfToolStripMenuItem.Enabled = true;

                MessageBox.Show("Данные успешно удалены!", "Информация об операции удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch // в случае неудачного удаления
            {
                DeleteInfToolStripMenuItem.Enabled = false;

                MessageBox.Show("Неверно выбрана строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdministratorFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT Код, Фамилия + ' ' + Имя + ' ' + Отчество AS ФИО, Логин, Пароль, Роль " +
            "FROM Пользователи", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "Пользователи");
            UserDGV.DataSource = ds.Tables[0];

            this.UserDGV.Columns["Код"].Visible = false;

            sqlcon.Close();
        }

        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            UserDGV.AllowUserToResizeColumns = false;
            UserDGV.AllowUserToResizeRows = false;
            UserDGV.MultiSelect = false;
            // убираем левый столбец
            UserDGV.RowHeadersVisible = false;
        }
    }
}
