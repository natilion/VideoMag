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
    public partial class TChek : Form
    {
        public TChek()
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
            da = new SqlDataAdapter("select * from Chek", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Chek");
            dataGridView1.DataSource = ds.Tables["Chek"];
            con.Close();
        }

        private void TChek_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = String.Format("delete from Chek where ID_Chek='{0}'", id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();
            }
            catch { MessageBox.Show("Ошибка"); }
            MessageBox.Show("Данные удалены");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
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