using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Web
    {
        public static string hhostt = "http://localhost:8080/";
        public static async Task<string> GetHttp(string link)
        {
            string url = link;
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        public static string hash = "nat";

        public static string Hash(string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return password.ToString();
        }

        public static string UnHash(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return password.ToString();
        }
    }

    public class Positionn
    {
        public int ID { get; set; }
        public string Должность { get; set; }
    }

    public class Positionnn
    {
        public int ID_Position { get; set; }
        public string Name_Position { get; set; }
    }

    public class Tovar
    {
        public int ID { get; set; }
        public string Название { get; set; }
        public int Цена { get; set; }
        public int Год_выхода { get; set; }
        public int Номер_выпуска { get; set; }
        public string Жанр { get; set; }
        public int Продолжительность { get; set; }
        public string Название_производителя { get; set; }
        public string Тип_носителя { get; set; }
        public int Количество { get; set; }
        public bool Удалено { get; set; }
    }

    public class Tovarr
    {
        public int ID_Tovara { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int release_year { get; set; }
        public int Number_V { get; set; }
        public string genre { get; set; }
        public int duration { get; set; }
        public string name_proiz { get; set; }
        public string media_type { get; set; }
        public int amount { get; set; }
        public bool delete { get; set; }
    }

    public class Client
    {
        public int ID { get; set; }
        public string ФИО { get; set; }
        public string Телефон { get; set; }
    }

    public class Clientt
    {
        public int ID_Client { get; set; }
        public string Name_Client { get; set; }
        public string Last_Name_Client { get; set; }
        public string Nomber_Phone { get; set; }
    }

    public class Chek
    {
        public int ID_Chek { get; set; }
        public string date { get; set; }
        public int Rabotnik_ID { get; set; }
        public int Client_ID { get; set; }
        public int Tovar_ID { get; set; }
    }

    public class Chekk
    {
        public int ID { get; set; }
        public string Дата { get; set; }
        public int Сотрудник { get; set; }
        public int Покупатель { get; set; }
        public int Товар { get; set; }
    }

    public class Rabotnik
    {
        public int ID { get; set; }
        public string ФИО { get; set; }
        public string Паспортные_данные { get; set; }
        public string Номер_телефона { get; set; }
        public string Должность { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public bool Уволен { get; set; }
    }

    public class Rabotnikk
    {
        public int ID_Rabotnik { get; set; }
        public string Name_Rabotnik { get; set; }
        public string Last_Name_Rabotnik { get; set; }
        public string Midlle_Name_Rabotnik { get; set; }
        public int Series { get; set; }
        public int Nomber_P { get; set; }
        public string Nomber_Phone { get; set; }
        public int Position_FK { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Dismissed { get; set; }
    }

    public class Buhgal
    {
        public int ID { get; set; }
        public string Дата { get; set; }
        public int Выплата { get; set; }
        public string Сотрудник { get; set; }
    }

    public class Buhgall
    {
        public int ID_Buxgalteriya { get; set; }
        public string date { get; set; }
        public int Salary { get; set; }
        public int Rabotnik_ID { get; set; }
    }
}