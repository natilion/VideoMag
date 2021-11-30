using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Reg : Form
    {
        string Doljn = " ";
        public Reg(string dj)
        {
            InitializeComponent();
            Ac.Text = dj;
            Doljn = dj;
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FCATBGV\PCC;Initial Catalog=VideoAr;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void Reg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videoArDataSet.Office". При необходимости она может быть перемещена или удалена.
            this.officeTableAdapter.Fill(this.videoArDataSet.Office);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (RBK.Checked)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = String.Format("insert into Client(Name_Client, Last_Name_Client, Midlle_Name_Client, Series, Number_P, Nomber_Phone, Date, Adres, issued_by, max_sum)" +
                                                    " values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '1000')",
                                                    Name.Text, LastName.Text, MidlleName.Text, SP.Text, NP.Text, PNumber.Text, dateTimePicker2.Value.ToShortDateString(), Adres.Text, Vidan.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Клиент зарегистрирован");
                    Bde();
                }
                else
                {
                    int Dolj = 5;
                    if (RBAdmin.Checked) { Dolj = 0; }
                    if (RBKad.Checked) { Dolj = 1; }
                    if (RBKas.Checked) { Dolj = 2; }

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = String.Format("insert into Rabotnik(Name_Rabotnik, Last_Name_Rabotnik, Midlle_Name_Rabotnik, Doljnost, Nomber_Phone, Login, Password, Office_ID)" +
                                                    " values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                                                    Name.Text, LastName.Text, MidlleName.Text, Dolj, PNumber.Text, Login.Text, Password.Text, comboBox2.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Работник зарегистрирован");
                    Bde();
                }
            }
            catch { MessageBox.Show("Правильно введите данные"); }
        }

        public void Bde()
        {
            Reg.ActiveForm.Hide();
            OK ok = new OK(Doljn);
            ok.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Bde();
        }

        private void Kl_Click(object sender, EventArgs e)
        {
            LaP.Visible = false;
            Passport.Visible = true;
            label12.Visible = false;
            comboBox2.Visible = false;
        }

        private void J_Click(object sender, EventArgs e)
        {
            LaP.Visible = true;
            Passport.Visible = false;
            label12.Visible = true;
            comboBox2.Visible = true;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Reg.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void PNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char number = e.KeyChar;

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}