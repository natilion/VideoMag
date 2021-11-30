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

namespace WindowsFormsApp1
{
    public partial class Office : Form
    {
        public Office(string dj)
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FCATBGV\PCC;Initial Catalog=VideoAr;Integrated Security=True");
            da = new SqlDataAdapter("select * from View_Office", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Office");
            dataGridView1.DataSource = ds.Tables["Office"];
            con.Close();
        }

        private void Office_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("insert into Office(type, Nomber_Phone, Adres) values('1', '{0}', '{1}')", PNumber.Text, Adres.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            MessageBox.Show("Офис добавлен");
        }

        private void Up_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            if (PNumber.Text != "")
            {
                cmd.CommandText = String.Format("update Office set Nomber_Phone='{1}' where ID_Office='{0}'",
                                                            id.Text, PNumber.Text);
                cmd.ExecuteNonQuery();
            }
            if (Adres.Text != "")
            {
                cmd.CommandText = String.Format("update Office set Adres='{1}' where ID_Office='{0}'",
                                                            id.Text, Adres.Text);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            GetList();
            MessageBox.Show("Данные обновлены");
        }

        private void Del_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("delete from Office where ID_Office='{0}'", id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            MessageBox.Show("Офис удалён");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Office.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Office.ActiveForm.Hide();
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
    }
}
