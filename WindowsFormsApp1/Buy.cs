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
    public partial class Buy : Form
    {
        int rid;
        int tid;
        public Buy(int id, int t_id)
        {
            InitializeComponent();
            rid = id;
            tid = t_id;
        }

        public string url = "http://localhost:8080/api/clients";

        public async void GetList()
        {
            string respuesta = await Web.GetHttp(url);
            List<Clientt> lst = JsonConvert.DeserializeObject<List<Clientt>>(respuesta.Replace(@"\", ""));
            dataGridView1.DataSource = lst;
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void bBuy_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    Chek chek = new Chek()
                    {
                        date = dateTimePicker1.Value.ToShortDateString(),
                        Rabotnik_ID = Convert.ToInt32(rid),
                        Client_ID = Convert.ToInt32(cell.Value),
                        Tovar_ID = Convert.ToInt32(tid)
                    };

                    var r = JsonConvert.SerializeObject(chek);
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = client.PostAsJsonAsync("/api/chek", chek).Result;
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
