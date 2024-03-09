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
    public partial class ContraktAddFm : Form
    {
        public ContraktAddFm()
        {
            InitializeComponent();
            AbonentCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddBt_Click(object sender, EventArgs e)
        {
            // проверка на заполнение данных
            if ((AbonentCb.Text == "" || MesTb.Text == "" || YearTb.Text == "" || TownTb.Text == "" || MejTb.Text == "" || PriceTb.Text == "" || SummaTb.Text == "" || ObshTb.Text == ""))
            {
                AbonentCb.BackColor = (AbonentCb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                MesTb.BackColor = (MesTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                YearTb.BackColor = (YearTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                TownTb.BackColor = (TownTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                MejTb.BackColor = (MejTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                PriceTb.BackColor = (PriceTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                SummaTb.BackColor = (SummaTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                ObshTb.BackColor = (ObshTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);

                MessageBox.Show("Заполнены не все данные!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else // в случае удачи
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand($"INSERT INTO Ведомость_абоненской_платы (Код_абонета, Месяц, Год, Количество_минут_на_город," +
                    $"Количество_минут_на_межгород, Стоимость, Сумма_льготы, Общая_стоимость) " +
                $"VALUES (@abon, @mes, @year, @town, @mej, @price, @summa, @obsh)", sqlcon);

                
                command.Parameters.AddWithValue("@abon", AbonentCb.SelectedValue);
                command.Parameters.AddWithValue("@mes", MesTb.Text);
                command.Parameters.AddWithValue("@year", YearTb.Text);
                command.Parameters.AddWithValue("@town", TownTb.Text);
                command.Parameters.AddWithValue("@mej", MejTb.Text);
                command.Parameters.AddWithValue("@price", PriceTb.Text);
                command.Parameters.AddWithValue("@summa", SummaTb.Text);
                command.Parameters.AddWithValue("@obsh", ObshTb.Text);

                command.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Данные успешно добалены!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void ContraktAddFm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneСonnectionDBDataSet.Абоненты". При необходимости она может быть перемещена или удалена.
            this.абонентыTableAdapter.Fill(this.telephoneСonnectionDBDataSet.Абоненты);

        }

        private void MesTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void YearTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void TownTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void MejTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void SummaTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void ObshTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
