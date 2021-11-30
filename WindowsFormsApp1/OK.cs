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
    public partial class OK : Form
    {
        string Doljn = " ";
        public OK(string dj)
        {
            InitializeComponent();
            Ac.Text = dj;
            Doljn = dj;
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FCATBGV\PCC;Initial Catalog=VideoAr;Integrated Security=True");
            if (Sot.Checked)
            {
                da = new SqlDataAdapter("select * from dbo.View_Rabotnik", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Rabotnik");
                dataGridView1.DataSource = ds.Tables["Rabotnik"];
                con.Close();
            }
            if (Kl.Checked)
            {
                da = new SqlDataAdapter("select * from dbo.View_Client", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Client");
                dataGridView1.DataSource = ds.Tables["Client"];
                con.Close();
            }
        }

        private void OK_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            if (Sot.Checked)
            {
                if (Name.Text != "")
                {
                    cmd.CommandText = String.Format("update Rabotnik set Name_Rabotnik='{1}' where ID_Rabotnik='{0}'",
                                                                id.Text, Name.Text);
                    cmd.ExecuteNonQuery();
                }
                if (LastName.Text != "")
                {
                    cmd.CommandText = String.Format("update Rabotnik set Last_Name_Rabotnik='{1}' where ID_Rabotnik='{0}'",
                                                                id.Text, LastName.Text);
                    cmd.ExecuteNonQuery();
                }
                if (MidlleName.Text != "")
                {
                    cmd.CommandText = String.Format("update Rabotnik set Midlle_Name_Rabotnik='{1}' where ID_Rabotnik='{0}'",
                                                                id.Text, MidlleName.Text);
                    cmd.ExecuteNonQuery();
                }
                if (PNumber.Text != "")
                {
                    cmd.CommandText = String.Format("update Rabotnik set Nomber_Phone='{1}' where ID_Rabotnik='{0}'",
                                                                id.Text, PNumber.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Login.Text != "")
                {
                    cmd.CommandText = String.Format("update Rabotnik set Login='{1}' where ID_Rabotnik='{0}'",
                                                                id.Text, Login.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Password.Text != "")
                {
                    cmd.CommandText = String.Format("update Rabotnik set Password='{1}' where ID_Rabotnik='{0}'",
                                                                id.Text, Password.Text);
                    cmd.ExecuteNonQuery();
                }
                if (comboBox1.Text != "")
                {
                    int djn = 5;
                    switch (comboBox1.Text)
                    {
                        case "Администратор":
                            djn = 0;
                            break;
                        case "Кадровик":
                            djn = 1;
                            break;
                        case "Кассир":
                            djn = 2;
                            break;
                    }
                    cmd.CommandText = String.Format("update Rabotnik set Doljnost='{1}' where ID_Rabotnik='{0}'",
                                                                id.Text, djn);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                GetList();
            }
            if (Kl.Checked)
            {
                if (Name.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Name_Client='{1}' where ID_Client='{0}'",
                                                                id.Text, Name.Text);
                    cmd.ExecuteNonQuery();
                }
                if (LastName.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Last_Name_Client='{1}' where ID_Client='{0}'",
                                                                id.Text, LastName.Text);
                    cmd.ExecuteNonQuery();
                }
                if (MidlleName.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Midlle_Name_Client='{1}' where ID_Client='{0}'",
                                                                id.Text, MidlleName.Text);
                    cmd.ExecuteNonQuery();
                }
                if (PNumber.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Nomber_Phone='{1}' where ID_Client='{0}'",
                                                                id.Text, PNumber.Text);
                    cmd.ExecuteNonQuery();
                }
                if (SP.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Series='{1}' where ID_Client='{0}'",
                                                                id.Text, SP.Text);
                    cmd.ExecuteNonQuery();
                }
                if (NP.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Number_P='{1}' where ID_Client='{0}'",
                                                                id.Text, NP.Text);
                    cmd.ExecuteNonQuery();
                }
                if (dateTimePicker2.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Date='{1}' where ID_Client='{0}'",
                                                                id.Text, dateTimePicker2.Value.ToShortDateString());
                    cmd.ExecuteNonQuery();
                }
                if (Adres.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set Adres='{1}' where ID_Client='{0}'",
                                                                id.Text, Adres.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Vidan.Text != "")
                {
                    cmd.CommandText = String.Format("update Client set issued_by='{1}' where ID_Client='{0}'",
                                                                id.Text, Vidan.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                GetList();
                MessageBox.Show("Данные обновлены");
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (Sot.Checked)
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = String.Format("delete from Rabotnik where ID_Rabotnik='{0}'", id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();
            }
            if (Kl.Checked)
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = String.Format("delete from Client where ID_Client='{0}'", id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();
            }
            MessageBox.Show("Данные обновлены");
        }

        private void Sot_Click(object sender, EventArgs e)
        {
            LaP.Visible = true;
            Passport.Visible = false;
            GetList();
        }

        private void Kl_Click(object sender, EventArgs e)
        {
            LaP.Visible = false;
            Passport.Visible = true;
            GetList();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            OK.ActiveForm.Hide();
            Reg reg = new Reg(Doljn);
            reg.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            OK.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
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