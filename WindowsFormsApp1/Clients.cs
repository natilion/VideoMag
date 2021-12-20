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
    public partial class Clients : Form
    {
        string Doljn = " ";
        public Clients(string dj)
        {
            InitializeComponent();
            Ac.Text = dj;
            Doljn = dj;
        }

        public static string url = "http://localhost:8080/api/clients";

        async void GetList()
        {
            string respuesta = await Web.GetHttp(url);
            List<Clientt> lst = JsonConvert.DeserializeObject<List<Clientt>>(respuesta.Replace(@"\", ""));
            dataGridView1.DataSource = lst;
        }

        private void bReg_Click(object sender, EventArgs e)
        {
            ClientAdd clientAdd = new ClientAdd(0);
            clientAdd.Show();
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                ClientAdd clientAdd = new ClientAdd(Convert.ToInt32(cell.Value));
                clientAdd.Show();
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            Clients.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = client.DeleteAsync(String.Format("/api/client/{0}", cell.Value.ToString())).Result;
                GetList();
            }
            MessageBox.Show("Данные удалены");
        }

        private void Clients_Activated(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
