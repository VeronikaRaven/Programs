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
    public partial class ATSAddInformFm : Form
    {
        public ATSAddInformFm()
        {
            InitializeComponent();
            VidCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ATSAddInformFm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneСonnectionDBDataSet.АТС". При необходимости она может быть перемещена или удалена.
            this.аТСTableAdapter.Fill(this.telephoneСonnectionDBDataSet.АТС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneСonnectionDBDataSet.Вид_АТС". При необходимости она может быть перемещена или удалена.
            this.вид_АТСTableAdapter.Fill(this.telephoneСonnectionDBDataSet.Вид_АТС);

        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            // проверка на заполнение данных
            if ((NameTb.Text == "" || VidCb.Text == "" || AdressTb.Text == "" || TownTb.Text == "" || NumbUserTb.Text == ""))
            {
                NameTb.BackColor = (NameTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                VidCb.BackColor = (VidCb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                AdressTb.BackColor = (AdressTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                TownTb.BackColor = (TownTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);
                NumbUserTb.BackColor = (NumbUserTb.Text == "") ? Color.LightCoral : Color.FromKnownColor(KnownColor.Window);

                MessageBox.Show("Заполнены не все данные!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else // в случае удачи
            {
                sqlcon.Open();

                //string commText = "SELECT Код_вид, Название from Вид_АТС";
                //SqlCommand comm = new SqlCommand(commText, sqlcon);
                //DataTable table = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter(comm);
                //adapter.Fill(table);
                //VidCb.DataSource = table;
                //VidCb.DisplayMember = "Название"; //отображающееся в комбобоксе значение
                //VidCb.ValueMember = "Код_вид"; //фактическое значение в комбобоксе

                SqlCommand command = new SqlCommand($"INSERT INTO АТС (Название_АТС, Код_вид, Адрес, Город, Количество_абонентов) " +
                $"VALUES (@name, @vid, @adress, @town, @num)", sqlcon);

                command.Parameters.AddWithValue("@name", NameTb.Text);
                command.Parameters.AddWithValue("@vid", VidCb.SelectedValue);
                command.Parameters.AddWithValue("@adress", AdressTb.Text);
                command.Parameters.AddWithValue("@town", TownTb.Text);
                command.Parameters.AddWithValue("@num", NumbUserTb.Text);

                command.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Данные успешно добалены!", "Информация об операции добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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

        private void TownTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NumbUserTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
