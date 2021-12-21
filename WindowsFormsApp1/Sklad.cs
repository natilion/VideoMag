using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

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

        public static string url = "http://localhost:8080/api/tovars";
        private static SynchronizationContext synchronizationContext = new SynchronizationContext();

        public async void GetList()
        {
            string respuesta = await Web.GetHttp(url);
            List<Tovarr> lst = JsonConvert.DeserializeObject<List<Tovarr>>(respuesta.Replace(@"\", ""));
            dataGridView1.DataSource = lst;
            //comboBox2.Items.AddRange(lst.AddRange[0]);
            comboBox2.Items.Insert(0, "");
            foreach (Tovarr tovarr in lst)
            {
                comboBox2.Items.Insert(tovarr.ID_Tovara, tovarr.Name.ToString());
            }
        }

        private void Sklad_Activated(object sender, EventArgs e)
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
            bBuy.Visible = true;
            bAdd.Visible = false;
            bUp.Visible = false;
            bDel.Visible = false;
        }

        private void bSk_Click(object sender, EventArgs e)
        {
            bTChek.Visible = false;
            bBuy.Visible = false;

            bAdd.Visible = true;
            bUp.Visible = true;
            bDel.Visible = true;
        }
        
        private void Add_Click(object sender, EventArgs e)
        {
            SkladAdd skladAdd = new SkladAdd(0);
            skladAdd.Show();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                SkladAdd skladAdd = new SkladAdd(Convert.ToInt32(cell.Value));
                skladAdd.Show();
            }
        }

        private async void Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                string respuesta = await Web.GetHttp("http://localhost:8080/api/tovar/" + cell.Value.ToString());
                List<Tovarr> lst = JsonConvert.DeserializeObject<List<Tovarr>>(respuesta.Replace(@"\", ""));
                lst[0].delete = true;
                var r = JsonConvert.SerializeObject(lst);
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = client.PutAsJsonAsync(String.Format("/api/tovar/{0}", cell.Value.ToString()), lst).Result;
            }
            //foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            //{
            //    HttpClient client = new HttpClient();
            //    client.BaseAddress = new Uri(url);
            //    HttpResponseMessage response = client.DeleteAsync(String.Format("/api/tovar/{0}", cell.Value.ToString())).Result;
            //    GetList();
            //}
            MessageBox.Show("Данные удалены");
        }

        private void toTCheck(object sender, EventArgs e)
        {
            TChek chek = new TChek();
            chek.Show();
        }

        private async void bBuy_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                string respuesta = await Web.GetHttp("http://localhost:8080/api/tovar/" + cell.Value.ToString());
                List<Tovarr> lst = JsonConvert.DeserializeObject<List<Tovarr>>(respuesta.Replace(@"\", ""));
                if (lst[0].amount == 0)
                    MessageBox.Show("Товыра " + lst[0].Name + " нет в наличии");
                else
                {
                    Buy buy = new Buy(rid, Convert.ToInt32(cell.Value));
                    buy.Show();
                }
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.SelectedIndex.ToString());
        }
    }
}