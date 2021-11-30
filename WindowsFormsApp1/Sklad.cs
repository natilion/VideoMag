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
    public partial class Sklad : Form
    {
        int rid;
        public Sklad(string dj, int id)
        {
            InitializeComponent();
            Ac.Text = dj;
            rid = id;
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FCATBGV\PCC;Initial Catalog=VideoAr;Integrated Security=True");
            da = new SqlDataAdapter("select * from dbo.View_Sklad", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Tovar");
            dataGridView1.DataSource = ds.Tables["Tovar"];
            con.Close();
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void LogOut(object sender, EventArgs e)
        {
            Sklad.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bBuy_Click(object sender, EventArgs e)
        {
            bTChek.Visible = true;
            bArenda.Visible = true;
            bBuy.Visible = true;

            bAdd.Visible = false;
            bUp.Visible = false;
            bDel.Visible = false;
            panel1.Visible = false;
        }

        private void bSk_Click(object sender, EventArgs e)
        {
            bTChek.Visible = false;
            bArenda.Visible = false;
            bBuy.Visible = false;

            bAdd.Visible = true;
            bUp.Visible = true;
            bDel.Visible = true;
            panel1.Visible = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("insert into Tovar(Name, Price, cost_per_day, release_year, Number_V, genre, duration, name_proiz, media_type, amount)" +
                                            " values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                                            name.Text, Price.Text, cost_per_day.Text, release_year.Text, Number_V.Text, genre.Text, duration.Text, name_proiz.Text, media_type.Text, amount.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            MessageBox.Show("Товар добавлен");
        }

        private void Up_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            if (name.Text != "") 
            {
                cmd.CommandText = String.Format("update Tovar set Name='{1}' where ID_Tovara='{0}'",
                                                            id.Text, name.Text);
                cmd.ExecuteNonQuery();
            }
            if (Price.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set Price='{1}' where ID_Tovara='{0}'",
                                                            id.Text, Price.Text);
                cmd.ExecuteNonQuery();
            }
            if (cost_per_day.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set cost_per_day='{1}' where ID_Tovara='{0}'",
                                                            id.Text, cost_per_day.Text);
                cmd.ExecuteNonQuery();
            }
            if (release_year.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set release_year='{1}' where ID_Tovara='{0}'",
                                                            id.Text, release_year.Text);
                cmd.ExecuteNonQuery();
            }
            if (Number_V.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set Number_V='{1}' where ID_Tovara='{0}'",
                                                            id.Text, Number_V.Text);
                cmd.ExecuteNonQuery();
            }
            if (genre.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set genre='{1}' where ID_Tovara='{0}'",
                                                            id.Text, genre.Text);
                cmd.ExecuteNonQuery();
            }
            if (duration.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set duration='{1}' where ID_Tovara='{0}'",
                                                            id.Text, duration.Text);
                cmd.ExecuteNonQuery();
            }
            if (name_proiz.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set name_proiz='{1}' where ID_Tovara='{0}'",
                                                            id.Text, name_proiz.Text);
                cmd.ExecuteNonQuery();
            }
            if (media_type.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set media_type='{1}' where ID_Tovara='{0}'",
                                                            id.Text, media_type.Text);
                cmd.ExecuteNonQuery();
            }
            if (amount.Text != "")
            {
                cmd.CommandText = String.Format("update Tovar set amount='{1}' where ID_Tovara='{0}'",
                                                            id.Text, amount.Text);
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
            cmd.CommandText = String.Format("delete from Tovar where ID_Tovara='{0}'", id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            MessageBox.Show("Данные удалены");
        }

        private void toTCheck(object sender, EventArgs e)
        {
            TChek chek = new TChek();
            chek.Show();
        }

        private void Aren_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                Arenda arenda = new Arenda(rid, id.Text.Length);
                arenda.Show();
            }
            else 
            {
                Arenda arenda = new Arenda(rid, -1);
                arenda.Show();
            }
        }

        private void bBuy_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("select amount from Tovar where ID_Tovara = '{0}'", id.Text);
            int col = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.CommandText = String.Format("select Price from Tovar where ID_Tovara = '{0}'", id.Text);
            int price = Convert.ToInt32(cmd.ExecuteScalar());
            if (col > 0)
            {
                cmd.CommandText = String.Format("insert into Chek(date_begin, type, Price, Rabotnik_ID, Tovar_ID)" +
                                                " values('{0}', 'Покупка', '{1}', '{2}', '{3}')",
                                                dateTimePicker1.Value.ToShortDateString(), price, rid, id.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = String.Format("update Tovar set amount='{1}' where ID_Tovara='{0}'",
                                                            id.Text, col-1);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Товар закончился");
            }
            con.Close();
            GetList();
            MessageBox.Show("Покупка совершена успешно");
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