using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Buh : Form
    {
        string Doljn = " ";
        public Buh(string dj)
        {
            InitializeComponent();
            Ac.Text = dj;
            Doljn = dj;
        }

        public static string url = "http://localhost:8080/api/buxgalteriyas";

        async void GetList()
        {
            string respuesta2 = await Web.GetHttp("http://localhost:8080/api/rabotniks");
            List<Rabotnik> lst2 = JsonConvert.DeserializeObject<List<Rabotnik>>(respuesta2.Replace(@"\", ""));
            dataGridView2.DataSource = lst2;

            string respuesta = await Web.GetHttp(url);
            List<Buhgal> lst = JsonConvert.DeserializeObject<List<Buhgal>>(respuesta.Replace(@"\", ""));
            dataGridView1.DataSource = lst;
        }

        private void bReg_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridView2.SelectedCells)
                {
                    Buhgall gueyw = new Buhgall()
                    {
                        date = dateTimePicker1.Value.ToShortDateString(),
                        Salary = Convert.ToInt32(Salaryy.Text),
                        Rabotnik_ID = Convert.ToInt32(cell.Value)
                    };

                    var r = JsonConvert.SerializeObject(gueyw);
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(url);

                    HttpResponseMessage response = client.PostAsJsonAsync("/api/buxgalteriya", gueyw).Result;
                }
                GetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Buh_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    foreach (DataGridViewCell cell2 in dataGridView2.SelectedCells)
                    {
                        Buhgall gueyw = new Buhgall()
                        {
                            date = dateTimePicker1.Value.ToShortDateString(),
                            Salary = Convert.ToInt32(Salaryy.Text),
                            Rabotnik_ID = Convert.ToInt32(cell2.Value)
                        };

                        var r = JsonConvert.SerializeObject(gueyw);
                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri(url);
                        HttpResponseMessage response = client.PutAsJsonAsync(String.Format("/api/buxgalteriya/{0}", cell.Value.ToString()), gueyw).Result;
                    }
                }
                GetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = client.DeleteAsync(String.Format("/api/buxgalteriya/{0}", cell.Value.ToString())).Result;
                GetList();
            }
            MessageBox.Show("Данные удалены");
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Buh.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Salaryy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
