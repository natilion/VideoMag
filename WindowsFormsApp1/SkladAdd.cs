using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SkladAdd : Form
    {
        int ID;
        public SkladAdd(int id)
        {
            InitializeComponent();
            ID = id;
        }

        public string url = "http://localhost:8080/api/tovars";

        private void bAdd_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (Diss.Checked == true)
                t = true;
            else
                t = false;
            try
            {
                Tovarr tovarr = new Tovarr()
                {
                    Name = name.Text,
                    Price = Convert.ToInt32(Price.Text),
                    release_year = Convert.ToInt32(release_year.Text),
                    Number_V = Convert.ToInt32(Number_V.Text),
                    genre = genre.Text,
                    duration = Convert.ToInt32(duration.Text),
                    name_proiz = name_proiz.Text,
                    media_type = media_type.Text,
                    amount = Convert.ToInt32(amount.Text),
                    delete = t
                };
                var r = JsonConvert.SerializeObject(tovarr);
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);

                if (ID == 0)
                { HttpResponseMessage response = client.PostAsJsonAsync("/api/tovar", tovarr).Result; }
                else
                { HttpResponseMessage response = client.PutAsJsonAsync(String.Format("/api/tovar/{0}", ID.ToString()), tovarr).Result; }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void SkladAdd_Load(object sender, EventArgs e)
        {
            if (ID == 0)
                bAdd.Text = "Добавить";
            else
            {
                bAdd.Text = "Обновить";
                Diss.Visible = true;
                string respuesta = await Web.GetHttp("http://localhost:8080/api/tovar/" + ID);
                List<Tovarr> lst = JsonConvert.DeserializeObject<List<Tovarr>>(respuesta.Replace(@"\", ""));
                name.Text = lst[0].Name;
                Price.Text = lst[0].Price.ToString();
                release_year.Text = lst[0].release_year.ToString();
                Number_V.Text = lst[0].Number_V.ToString();
                genre.Text = lst[0].genre;
                duration.Text = lst[0].duration.ToString();
                name_proiz.Text = lst[0].name_proiz;
                media_type.Text = lst[0].media_type;
                amount.Text = lst[0].amount.ToString();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}