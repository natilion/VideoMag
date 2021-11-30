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
    public partial class Arenda : Form
    {
        int rid;
        int tid;
        public Arenda(int idSot, int idTov)
        {
            InitializeComponent();
            rid = idSot;
            tid = idTov;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FCATBGV\PCC;Initial Catalog=VideoAr;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            
            if (Of.Checked)
            {
                da = new SqlDataAdapter("select * from dbo.View_Client", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Client");
                dataGridView1.DataSource = ds.Tables["Client"];
                con.Close();
            }
            if (Prin.Checked)
            {
                da = new SqlDataAdapter("select * from dbo.View_Check", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Chek");
                dataGridView1.DataSource = ds.Tables["Chek"];
                con.Close();
            }
        }

        private void Arenda_Load(object sender, EventArgs e)
        {
            if (tid != -1)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "videoArDataSet.Office". При необходимости она может быть перемещена или удалена.
                this.officeTableAdapter.Fill(this.videoArDataSet.Office);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = String.Format("select Last_Name_Rabotnik from Rabotnik where ID_Rabotnik = '{0}'", rid);
                Sot.Text = cmd.ExecuteScalar().ToString();
                Sot.Text += " ";
                cmd.CommandText = String.Format("select Name_Rabotnik from Rabotnik where ID_Rabotnik = '{0}'", rid);
                Sot.Text += cmd.ExecuteScalar().ToString();

                cmd.CommandText = String.Format("select Name from Tovar where ID_Tovara = '{0}'", tid);
                TName.Text = cmd.ExecuteScalar().ToString();
                cmd.CommandText = String.Format("select cost_per_day from Tovar where ID_Tovara = '{0}'", tid);
                cost_per_day.Text = cmd.ExecuteScalar().ToString();
                Price.Text = cmd.ExecuteScalar().ToString();

                con.Close();
            }
            else 
            {
                Prin.Checked = true;
                h();
            }
            GetList();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Of_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label9.Visible = true;
            Price.Visible = true;
            label1.Text = "id клиента";
            Aren.Text = "Одобрить аренду";
            GetList();
        }

        private void Prin_CheckedChanged(object sender, EventArgs e)
        {
            h();
        }
        void h() 
        {
            panel1.Visible = false;
            label9.Visible = false;
            Price.Visible = false;
            label1.Text = "id чека";
            Aren.Text = "Принять товар";
            GetList();
        }

        private void days_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double day = Convert.ToDouble(days.Text);
                dateTimePicker2.Value = DateTime.Today.AddDays(day);

                Price.Text = (Convert.ToDouble(cost_per_day.Text) * day).ToString();
            }
            catch { }
        }

        private void Aren_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            if (Of.Checked)
            {
                cmd.CommandText = String.Format("select max_sum from Client where ID_Client = '{0}'", kid.Text);
                Double maxSum = Convert.ToInt32(cmd.ExecuteScalar());
                if ((maxSum - Convert.ToDouble(Price.Text)) < 0)
                {
                    MessageBox.Show("Вы не можете арендовать данный товар, цена выше разрешённого максимума");
                }
                else
                {
                    cmd.CommandText = String.Format("select amount from Tovar where ID_Tovara = '{0}'", tid);
                    int col = Convert.ToInt32(cmd.ExecuteScalar());
                    if (col > 0)
                    {
                        cmd.CommandText = String.Format("insert into Chek(date_begin, date_end, type, status, Price, Rabotnik_ID, Office_ID, Client_ID, Tovar_ID)" +
                                                        " values('{0}', '{1}', 'Аренда', 'В аренде', '{2}', '{3}', '{4}', '{5}', '{6}')",
                            dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), Price.Text, rid, comboBox2.SelectedValue.ToString(), kid.Text, tid);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = String.Format("update Tovar set amount='{1}' where ID_Tovara='{0}'",
                                                                    tid, col - 1);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = String.Format("update Client set max_sum='{1}' where ID_Client='{0}'",
                                                                    kid.Text, maxSum - Convert.ToDouble(Price.Text));
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Товар закончился");
                    }
                }
            }
            if (Prin.Checked)
            {
                cmd.CommandText = String.Format("update Chek set status='Сдан' where ID_Chek='{0}'", kid.Text);
                cmd.ExecuteNonQuery();

                cmd.CommandText = String.Format("select Price from Chek where ID_Chek='{0}'", kid.Text);
                Double Price = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = String.Format("select Client_ID from Chek where ID_Chek='{0}'", kid.Text);
                Double ClientId = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = String.Format("select max_sum from Client where ID_Client='{0}'", ClientId);
                Double maxSum = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = String.Format("update Client set max_sum='{1}' where ID_Client='{0}'", ClientId, maxSum + Price);
                cmd.ExecuteNonQuery();

                cmd.CommandText = String.Format("select Tovar_ID from Chek where ID_Chek='{0}'", kid.Text);
                Double TovarId = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = String.Format("select amount from Tovar where ID_Tovara = '{0}'", TovarId);
                int col = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = String.Format("update Tovar set amount='{1}' where ID_Tovara='{0}'", TovarId, col + 1);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            GetList();
        }

        private void kid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Of_Click(object sender, EventArgs e)
        {
            if (tid == -1) 
            { 
                MessageBox.Show("Вы не ввели id товара");
                Close();
            }
        }
    }
}