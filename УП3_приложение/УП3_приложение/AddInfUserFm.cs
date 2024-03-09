using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace УП3_приложение
{
    public partial class AddInfUserFm : Form
    {
        public AddInfUserFm()
        {
            InitializeComponent();
            RoleCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void AddBt_Click(object sender, EventArgs e)
        {
            // проверка на заполнение данных
            if ((SurnameTb.Text == "" || FathernameTb.Text == "" || NameTb.Text == "" || LoginTb.Text == "" || PasswordTb.Text == "" || RoleCb.Text == ""))
            {
                SurnameTb.BackColor = (SurnameTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                NameTb.BackColor = (NameTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                FathernameTb.BackColor = (NameTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                LoginTb.BackColor = (LoginTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                PasswordTb.BackColor = (PasswordTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                RoleCb.BackColor = (RoleCb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);

                MessageBox.Show("Заполнены не все данные!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else // в случае удачи
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand($"INSERT INTO Пользователи (Фамилия, Имя, Отчество, Логин, Пароль, Роль)" +
                $"VALUES (@surname, @name, @fathername, @login, @password, @role)", sqlcon);

                command.Parameters.AddWithValue("@surname", SurnameTb.Text);
                command.Parameters.AddWithValue("@name", NameTb.Text);
                command.Parameters.AddWithValue("@fathername", FathernameTb.Text);
                command.Parameters.AddWithValue("@login", LoginTb.Text);
                command.Parameters.AddWithValue("@password", PasswordTb.Text);
                command.Parameters.AddWithValue("@role", RoleCb.Text);

                command.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Данные успешно добалены!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
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
