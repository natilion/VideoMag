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
using Newtonsoft.Json;
using System.Net.Http;

namespace WindowsFormsApp1
{
    public partial class TChek : Form
    {
        public TChek()
        {
            InitializeComponent();
        }

        public static string url = "http://localhost:8080/api/cheks";

        public class Chek
        {
            public int ID { get; set; }
            public string Сотрудник { get; set; }
            public string Покупатель { get; set; }
            public string Товар { get; set; }
        }

        async void GetList()
        {
            string respuesta = await Web.GetHttp(url);
            List<Chek> lst = JsonConvert.DeserializeObject<List<Chek>>(respuesta.Replace(@"\", ""));
            dataGridView1.DataSource = lst;
        }

        private void TChek_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = client.DeleteAsync(String.Format("/api/chek/{0}", cell.Value.ToString())).Result;
                GetList();
            }
            MessageBox.Show("Данные удалены");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}