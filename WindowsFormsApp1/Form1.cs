using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rid;
        string Doljn = "";
        public static string url = "http://localhost:8080/api/rabotniks";
        public List<Rabotnik> lst;

        private async void Form1_Load(object sender, EventArgs e)
        {
            string respuesta = await Web.GetHttp(url);
            lst = JsonConvert.DeserializeObject<List<Rabotnik>>(respuesta.Replace(@"\", ""));
        }

        private void Log(object sender, EventArgs e)
        {
            foreach (Rabotnik rabotnik in lst)
            {
                if (login.Text == rabotnik.Логин)
                {
                    if (password.Text == rabotnik.Пароль)
                    {
                        if (rabotnik.Уволен == true)
                            MessageBox.Show("Вы уволены");
                        else
                            MessageBox.Show("Успешная авторизация");
                        rid = rabotnik.ID;
                        Doljn = rabotnik.Должность;
                        break;
                    }
                    else
                        MessageBox.Show("Неверный пароль");
                }
                else
                    MessageBox.Show("Неверный логин");
            }

            switch (Doljn)
            {
                case "Админ":
                    Ac.Text = "Администратор";
                    Doljn = Ac.Text;
                    bSk.Visible = true;
                    bOK.Visible = true;
                    bPos.Visible = true;
                    bLogOut.Visible = true;
                    bCli.Visible = true;
                    bBuh.Visible = true;
                    break;
                case "Кадровик":
                    Ac.Text = "Кадровик";
                    Doljn = Ac.Text;
                    bOK.Visible = true;
                    bLogOut.Visible = true;
                    break;
                case "Кассир":
                    Ac.Text = "Кассир";
                    Doljn = Ac.Text;
                    bSk.Visible = true;
                    bCli.Visible = true;
                    bLogOut.Visible = true;
                    break;
                case "Бухгалтер":
                    Ac.Text = "Бухгалтер";
                    Doljn = Ac.Text;
                    bBuh.Visible = true;
                    bLogOut.Visible = true;
                    break;
            }
        }

        private void toSk(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Sklad sklad = new Sklad(Doljn, rid);
            sklad.Show();
        }

        private void toOK(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            OK oK = new OK(Doljn);
            oK.Show();
        }

        private void toPos(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Position position = new Position();
            position.Show();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Ac.Text = "";
            login.Text = "";
            password.Text = "";
            bSk.Visible = false;
            bOK.Visible = false;
            bPos.Visible = false;
            bLogOut.Visible = false;
            bCli.Visible = false;
            bBuh.Visible = false;
        }

        private void bCli_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Clients clients = new Clients(Doljn);
            clients.Show();
        }

        private void bBuh_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Buh buh = new Buh(Doljn);
            buh.Show();
        }
    }
}