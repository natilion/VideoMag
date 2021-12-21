using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }

        public string url = "http://localhost:8080/api/positions";

        async void GetList()
        {
            string respuesta = await Web.GetHttp(url);
            List<Positionn> lst = JsonConvert.DeserializeObject<List<Positionn>>(respuesta.Replace(@"\", ""));
            dataGridView1.DataSource = lst;
        }

        private void Position_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Positionnn positionnn = new Positionnn() { Name_Position = name.Text };
            var r = JsonConvert.SerializeObject(positionnn);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = client.PostAsJsonAsync("/api/position", positionnn).Result;
            GetList();
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                Positionnn positionnn = new Positionnn() { Name_Position = name.Text };
                var r = JsonConvert.SerializeObject(positionnn);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = client.PutAsJsonAsync(String.Format("/api/position/{0}", cell.Value.ToString()) , positionnn).Result;
                GetList();
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            Position.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}