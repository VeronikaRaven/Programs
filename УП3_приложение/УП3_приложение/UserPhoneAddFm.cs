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
    public partial class UserPhoneAddFm : Form
    {
        public UserPhoneAddFm()
        {
            InitializeComponent();
            VidCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MejTownCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LgotaCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddBt_Click(object sender, EventArgs e)
        {
            // проверка на заполнение данных
            if ((SurnameTb.Text == "" || NameTb.Text == "" || FathernameTb.Text == "" || VidCb.Text == "" || NumberTb.Text == "" || MejTownCb.Text == "" || LgotaCb.Text == "" || AdresTb.Text == ""))
            {
                SurnameTb.BackColor = (SurnameTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                NameTb.BackColor = (NameTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                FathernameTb.BackColor = (FathernameTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                VidCb.BackColor = (VidCb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                NumberTb.BackColor = (NumberTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                MejTownCb.BackColor = (MejTownCb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                LgotaCb.BackColor = (LgotaCb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                AdresTb.BackColor = (AdresTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);

                MessageBox.Show("Заполнены не все данные!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else // в случае удачи
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand($"INSERT INTO Абоненты (Фамилия, Имя, Отчество, Код_вид_телефона, Номер_телефона, Межгород, Льгота, Адрес) " +
                $"VALUES (@sur, @name, @fath, @vid, @num, @mej, @lgota, @adres )", sqlcon);

                command.Parameters.AddWithValue("@sur", SurnameTb.Text);
                command.Parameters.AddWithValue("@name", NameTb.Text);
                command.Parameters.AddWithValue("@fath", FathernameTb.Text);
                command.Parameters.AddWithValue("@vid", VidCb.SelectedValue);
                command.Parameters.AddWithValue("@num", NumberTb.Text);
                command.Parameters.AddWithValue("@mej", MejTownCb.Text);
                command.Parameters.AddWithValue("@lgota", LgotaCb.Text);
                command.Parameters.AddWithValue("@adres", AdresTb.Text);

                command.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Данные успешно добалены!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void UserAddFm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneСonnectionDBDataSet.Вид_телефона". При необходимости она может быть перемещена или удалена.
            this.вид_телефонаTableAdapter.Fill(this.telephoneСonnectionDBDataSet.Вид_телефона);

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

        private void NumberTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
