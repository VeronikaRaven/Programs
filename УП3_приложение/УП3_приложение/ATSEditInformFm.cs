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
    public partial class ATSEditInformFm : Form
    {
        public ATSEditInformFm()
        {
            InitializeComponent();
            VidCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ATSEditInformFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT АТС.Код_АТС, АТС.Название_АТС, Вид_АТС.Название AS Вид, АТС.Адрес, АТС.Город, АТС.Количество_абонентов " +
                "FROM АТС INNER JOIN Вид_АТС ON АТС.Код_вид = Вид_АТС.Код_вид", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "АТС");
            ATSDGV.DataSource = ds.Tables[0];

            this.ATSDGV.Columns["Код_АТС"].Visible = false;

            sqlcon.Close();
        }

        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            ATSDGV.AllowUserToResizeColumns = false;
            ATSDGV.AllowUserToResizeRows = false;
            ATSDGV.MultiSelect = false;
            // убираем левый столбец
            ATSDGV.RowHeadersVisible = false;
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            SqlCommand command = new SqlCommand("UPDATE АТС SET Название_АТС = @name, Код_вид = @vid, Адрес = @adress, Город = @town, Количество_абонентов = @num " +
            $"FROM АТС WHERE Код_АТС = {ATSDGV.Rows[ATSDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            command.Parameters.AddWithValue("@name", NameTb.Text);
            command.Parameters.AddWithValue("@vid", VidCb.SelectedValue);
            command.Parameters.AddWithValue("@adress", AdressTb.Text);
            command.Parameters.AddWithValue("@town", TownTb.Text);
            command.Parameters.AddWithValue("@num", NumbUserTb.Text);

            command.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Данные изменены", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void ATSDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlcon.Open(); // открываем соединение

            SqlCommand sqlCommand = new SqlCommand("SELECT АТС.Код_АТС, АТС.Название_АТС, Вид_АТС.Название AS Вид, АТС.Адрес, АТС.Город, АТС.Количество_абонентов " +
            $"FROM АТС INNER JOIN Вид_АТС ON АТС.Код_вид = Вид_АТС.Код_вид WHERE Код_АТС = {ATSDGV.Rows[ATSDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            NameTb.Text = reader[1].ToString(); //2
            VidCb.Text = reader[2].ToString(); //3
            AdressTb.Text = reader[3].ToString(); //4
            TownTb.Text = reader[4].ToString(); //5
            NumbUserTb.Text = reader[5].ToString(); //6

            sqlcon.Close();
        }

        private void ATSEditInformFm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneСonnectionDBDataSet.Вид_АТС". При необходимости она может быть перемещена или удалена.
            this.вид_АТСTableAdapter.Fill(this.telephoneСonnectionDBDataSet.Вид_АТС);

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
