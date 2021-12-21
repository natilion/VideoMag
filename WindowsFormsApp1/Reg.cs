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
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Reg : Form
    {
        int ID;
        string Doljn = " ";
        public Reg(string dj, int id)
        {
            InitializeComponent();
            Ac.Text = dj;
            Doljn = dj;
            ID = id;
        }

        public static string url = "http://localhost:8080/api/rabotniks";
        private async void Reg_Load(object sender, EventArgs e)
        {
            string respuesta = await Web.GetHttp("http://localhost:8080/api/positions");
            List <Positionn> lst = JsonConvert.DeserializeObject<List<Positionn>>(respuesta.Replace(@"\", ""));
            comboBox1.Items.Insert(0, "");
            foreach (Positionn positionn in lst)
            {
                comboBox1.Items.Insert(positionn.ID, positionn.Должность.ToString());
            }

            if (ID == 0)
                bReg.Text = "Подтвердить регистрацию";
            else
            {
                bReg.Text = "Обновить";
                string respuesta2 = await Web.GetHttp("http://localhost:8080/api/rabotnik/" + ID);
                List<Rabotnikk> list = JsonConvert.DeserializeObject<List<Rabotnikk>>(respuesta2.Replace(@"\", ""));
                Name.Text = list[0].Name_Rabotnik;
                LastName.Text = list[0].Last_Name_Rabotnik;
                MidlleName.Text = list[0].Midlle_Name_Rabotnik;
                PNumber.Text = list[0].Nomber_Phone;
                SP.Text = list[0].Series.ToString();
                NP.Text = list[0].Nomber_P.ToString();
                Login.Text = list[0].Login;
                Password.Text = Web.UnHash(list[0].Password);
                comboBox1.SelectedIndex = list[0].Position_FK;
                if (list[0].Dismissed == true)
                    Diss.Checked = true;
                else
                    Diss.Checked = false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bool t;
            if (Diss.Checked == true)
                t = true;
            else
                t = false;

            try
            {
                Rabotnikk rabotnikk = new Rabotnikk()
                {
                    Name_Rabotnik = Name.Text,
                    Last_Name_Rabotnik = LastName.Text,
                    Midlle_Name_Rabotnik = MidlleName.Text,
                    Series = Convert.ToInt32(SP.Text),
                    Nomber_P = Convert.ToInt32(NP.Text),
                    Nomber_Phone = PNumber.Text,
                    Position_FK = comboBox1.SelectedIndex,
                    Login = Login.Text,
                    Password = Web.Hash(Password.Text),
                    Dismissed = t
                };
                var r = JsonConvert.SerializeObject(rabotnikk);
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                if (ID == 0)
                { HttpResponseMessage response = client.PostAsJsonAsync("/api/rabotnik", rabotnikk).Result;}
                else
                { HttpResponseMessage response = client.PutAsJsonAsync(String.Format("/api/rabotnik/{0}", ID.ToString()), rabotnikk).Result; }
                Bde();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Bde()
        {
            Reg.ActiveForm.Hide();
            OK ok = new OK(Doljn);
            ok.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Bde();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Reg.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void PNumber_KeyPress(object sender, KeyPressEventArgs e)
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