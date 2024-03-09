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

namespace УП3_приложение
{
    public partial class AvtorizFm : Form
    {
        public AvtorizFm()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void InputBt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "SELECT Роль FROM Пользователи Where Логин ='" + LogTb.Text.Trim() + "'and Пароль ='" + PassTb.Text.Trim() + "'";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                switch (dtbl.Rows[0]["Роль"] as string)
                {
                    case "Администратор":
                        {
                            this.Hide();
                            AdministratorFm af = new AdministratorFm();
                            af.Show();
                            break;
                        }
                    case "Сотрудник":
                        {
                            this.Hide();
                            SotrudnikFm sf = new SotrudnikFm();
                            sf.Show();
                            break;
                        }
                    case "Абонент":
                        {
                            this.Hide();
                            PhoneUserFm uf = new PhoneUserFm();
                            uf.Show();
                            break;
                        }
                }

                sqlcon.Close();
            }
            else
            {
                MessageBox.Show("Неверно введены логин или пароль", "Информирование об операции", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
