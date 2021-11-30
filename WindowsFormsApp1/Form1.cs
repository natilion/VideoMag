using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FCATBGV\PCC;Initial Catalog=VideoAr;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        int rid;
        string Doljn = " ";

        private void toSk(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Sklad sklad = new Sklad(Doljn, rid);
            sklad.Show();
        }

        private void toOK(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            OK oK = new OK(Doljn);
            oK.Show();
        }

        private void toOF(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Office office = new Office(Doljn);
            office.Show();
        }

        private void Log(object sender, EventArgs e)
        {
            string Password = "";
            int id;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            try
            {
                cmd.CommandText = String.Format("select Login from Rabotnik where Login = '{0}'", login.Text);
                if (cmd.ExecuteScalar() != null)
                {
                    cmd.CommandText = String.Format("select Password from Rabotnik where Login = '{0}'", login.Text);
                    Password = cmd.ExecuteScalar().ToString();
                    if (Password != password.Text)
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                    else
                    {
                        cmd.CommandText = String.Format("select Doljnost from Rabotnik where Login = '{0}'", login.Text);
                        id = Convert.ToInt32(cmd.ExecuteScalar());
                        switch (id)
                        {
                            case 0:
                                Ac.Text = "Администратор";
                                Doljn = Ac.Text;
                                bSk.Visible = true;
                                bOK.Visible = true;
                                bOf.Visible = true;
                                bLogOut.Visible = true;
                                break;
                            case 1:
                                Ac.Text = "Кадровик";
                                Doljn = Ac.Text;
                                bOK.Visible = true;
                                bLogOut.Visible = true;
                                break;
                            case 2:
                                Ac.Text = "Кассир";
                                Doljn = Ac.Text;
                                bSk.Visible = true;
                                bLogOut.Visible = true;
                                break;
                        }
                        cmd.CommandText = String.Format("select ID_Rabotnik from Rabotnik where Login = '{0}' AND Password = '{1}'", login.Text, password.Text);
                        rid = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                    MessageBox.Show("Успешная авторизация");
                }
                else
                    MessageBox.Show("Неверный логин");
            }
            finally { con.Close(); }
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Ac.Text = "";
            login.Text = "";
            password.Text = "";
            bSk.Visible = false;
            bOK.Visible = false;
            bOf.Visible = false;
            bLogOut.Visible = false;
        }
    }
}