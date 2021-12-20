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
    public partial class ClientAdd : Form
    {
        int ID;
        public ClientAdd(int id)
        {
            InitializeComponent();
            ID = id;
        }

        public string url = "http://localhost:8080/api/clients";

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Clientt gueyw = new Clientt()
                {
                    Name_Client = Name.Text,
                    Last_Name_Client = LastName.Text,
                    Nomber_Phone = PNumber.Text
                };
                var r = JsonConvert.SerializeObject(gueyw);
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);

                if (ID == 0)
                { HttpResponseMessage response = client.PostAsJsonAsync("/api/client", gueyw).Result; }
                else
                { HttpResponseMessage response = client.PutAsJsonAsync(String.Format("/api/client/{0}", ID.ToString()), gueyw).Result; }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void ClientAdd_Load(object sender, EventArgs e)
        {
            if (ID == 0)
                bAdd.Text = "Добавить";
            else
            {
                bAdd.Text = "Обновить";
                string respuesta = await Web.GetHttp("http://localhost:8080/api/client/" + ID);
                List<Clientt> lst = JsonConvert.DeserializeObject<List<Clientt>>(respuesta.Replace(@"\", ""));
                Name.Text = lst[0].Name_Client;
                LastName.Text = lst[0].Last_Name_Client;
                PNumber.Text = lst[0].Nomber_Phone;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
