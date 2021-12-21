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
using Newtonsoft.Json;
using System.Net.Http;

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

        public static string url = "http://localhost:8080/api/rabotniks";

        async void GetList()
        {
            string respuesta = await Web.GetHttp(url);
            List<Rabotnik> lst = JsonConvert.DeserializeObject<List<Rabotnik>>(respuesta.Replace(@"\", ""));
            dataGridView1.DataSource = lst;
        }

        private void OK_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            OK.ActiveForm.Hide();
            Reg reg = new Reg(Doljn, 0);
            reg.Show();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                OK.ActiveForm.Hide();
                Reg reg= new Reg(Doljn, Convert.ToInt32(cell.Value));
                reg.Show();
            }
        }

        private async void Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                string respuesta = await Web.GetHttp("http://localhost:8080/api/rabotnik/" + cell.Value.ToString());
                List<Rabotnikk> lst = JsonConvert.DeserializeObject<List<Rabotnikk>>(respuesta.Replace(@"\", ""));
                lst[0].Dismissed = true;
                var r = JsonConvert.SerializeObject(lst);
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = client.PutAsJsonAsync(String.Format("/api/rabotnik/{0}", cell.Value.ToString()), lst).Result;
            }

            //foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            //{
            //    HttpClient client = new HttpClient();
            //    client.BaseAddress = new Uri(url);
            //    HttpResponseMessage response = client.DeleteAsync(String.Format("/api/rabotnik/{0}", cell.Value.ToString())).Result;
            //    GetList();
            //}
            MessageBox.Show("Данные удалены");
        }

        private void Sot_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void Kl_Click(object sender, EventArgs e)
        {
            GetList();
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