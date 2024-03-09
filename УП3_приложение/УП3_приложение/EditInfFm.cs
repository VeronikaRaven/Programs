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
using System.Text.RegularExpressions;

namespace УП3_приложение
{
    public partial class EditInfFm : Form
    {
        public EditInfFm()
        {
            InitializeComponent();
            RoleCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void EditBt_Click(object sender, EventArgs e) ///
        {
            sqlcon.Open();

            SqlCommand command = new SqlCommand("UPDATE Пользователи SET Фамилия = @surname, Имя = @name, Отчество = @fathername, Логин = @login, Пароль = @password, Роль = @role " +
            $"FROM Пользователи WHERE Код = {UserDGV.Rows[UserDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            //command.Parameters.AddWithValue("@id", IdTb.Text);
            command.Parameters.AddWithValue("@surname", SurnameTb.Text);
            command.Parameters.AddWithValue("@name", NameTb.Text);
            command.Parameters.AddWithValue("@fathername", FathernameTb.Text);
            command.Parameters.AddWithValue("@login", LoginTb.Text);
            command.Parameters.AddWithValue("@password", PasswordTb.Text);
            command.Parameters.AddWithValue("@role", RoleCb.Text);

            command.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Данные изменены", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void EditInfFm_Activated(object sender, EventArgs e)
        {
            Limitation();
            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT Код, Фамилия, Имя, Отчество, Логин, Пароль, Роль " +
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

        private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlcon.Open(); // открываем соединение

            SqlCommand sqlCommand = new SqlCommand("SELECT Код, Фамилия, Имя, Отчество, Логин, Пароль, Роль " +
            $"FROM Пользователи WHERE Код = {UserDGV.Rows[UserDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            SurnameTb.Text = reader[1].ToString(); //1
            NameTb.Text = reader[2].ToString(); //2
            FathernameTb.Text = reader[3].ToString(); //3
            LoginTb.Text = reader[4].ToString(); //4
            PasswordTb.Text = reader[5].ToString(); //5
            RoleCb.Text = reader[6].ToString(); //6

            sqlcon.Close();
        }

        private void SurnameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void FathernameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
