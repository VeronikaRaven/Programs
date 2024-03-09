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
    public partial class UserPhoneEditFm : Form
    {
        public UserPhoneEditFm()
        {
            InitializeComponent();
            VidCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MejTownCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LgotaCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void UserPhoneEditFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter data = new SqlDataAdapter("SELECT Абоненты.Код_абонента, Абоненты.Фамилия + ' ' + Абоненты.Имя + ' ' + Абоненты.Отчество AS ФИО, Вид_телефона.Название AS Вид_телефона , Абоненты.Номер_телефона, Абоненты.Межгород, Абоненты.Льгота, Абоненты.Адрес " +
            "FROM Абоненты INNER JOIN Вид_телефона ON Абоненты.Код_вид_телефона = Вид_телефона.Код_вид_телефона", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb1 = new SqlCommandBuilder(data);
            DataSet ds1 = new DataSet();

            // заполняем таблицу
            data.Fill(ds1, "Абоненты");
            UserPhoneDGV.DataSource = ds1.Tables[0];

            this.UserPhoneDGV.Columns["Код_абонента"].Visible = false;

            sqlcon.Close();
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            SqlCommand command = new SqlCommand("UPDATE Абоненты SET  Фамилия = @sur, Имя = @name, Отчество = @fath, Код_вид_телефона = @vid, Номер_телефона = @num, Межгород = @mej, Льгота = @lgota, Адрес = @adres " +
            $"FROM Абоненты WHERE Код_абонента = {UserPhoneDGV.Rows[UserPhoneDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

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
            MessageBox.Show("Данные изменены", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void UserPhoneEditFm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneСonnectionDBDataSet.Вид_телефона". При необходимости она может быть перемещена или удалена.
            this.вид_телефонаTableAdapter.Fill(this.telephoneСonnectionDBDataSet.Вид_телефона);

        }

        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            UserPhoneDGV.AllowUserToResizeColumns = false;
            UserPhoneDGV.AllowUserToResizeRows = false;
            UserPhoneDGV.MultiSelect = false;
            // убираем левый столбец
            UserPhoneDGV.RowHeadersVisible = false;
        }

        private void UserPhoneDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlcon.Open(); // открываем соединение

            SqlCommand sqlCommand = new SqlCommand("SELECT Абоненты.Код_абонента, Абоненты.Фамилия, Абоненты.Имя, Абоненты.Отчество, Вид_телефона.Название, Абоненты.Номер_телефона, Абоненты.Межгород, Абоненты.Льгота, Абоненты.Адрес " +
            $"FROM Абоненты INNER JOIN Вид_телефона ON Абоненты.Код_вид_телефона = Вид_телефона.Код_вид_телефона WHERE Код_абонента = {UserPhoneDGV.Rows[UserPhoneDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            SurnameTb.Text = reader[1].ToString(); //2
            NameTb.Text = reader[2].ToString(); //3
            FathernameTb.Text = reader[3].ToString(); //2
            VidCb.Text = reader[4].ToString(); //3
            NumberTb.Text = reader[5].ToString(); //4
            MejTownCb.Text = reader[6].ToString(); //5
            LgotaCb.Text = reader[7].ToString(); //6
            AdresTb.Text = reader[8].ToString(); //6

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
