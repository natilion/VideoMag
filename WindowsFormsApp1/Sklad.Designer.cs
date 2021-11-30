
namespace WindowsFormsApp1
{
    partial class Sklad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Ac = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.duration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.release_year = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name_proiz = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cost_per_day = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bBuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.media_type = new System.Windows.Forms.ComboBox();
            this.Number_V = new System.Windows.Forms.ComboBox();
            this.bArenda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.ComboBox();
            this.bTChek = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Склад";
            // 
            // Ac
            // 
            this.Ac.AutoSize = true;
            this.Ac.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.Ac.ForeColor = System.Drawing.Color.Black;
            this.Ac.Location = new System.Drawing.Point(980, 16);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(324, 51);
            this.Ac.TabIndex = 7;
            this.Ac.Text = "Администратор";
            // 
            // bLogOut
            // 
            this.bLogOut.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bLogOut.Location = new System.Drawing.Point(792, 16);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(182, 51);
            this.bLogOut.TabIndex = 6;
            this.bLogOut.Text = "Выйти";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.LogOut);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(309, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(85, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 36);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Склад";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.bSk_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(235, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 36);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Покупка";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // duration
            // 
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.Location = new System.Drawing.Point(185, 132);
            this.duration.MaxLength = 3;
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(242, 38);
            this.duration.TabIndex = 31;
            this.duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 34);
            this.label6.TabIndex = 30;
            this.label6.Text = "Время (мин)";
            // 
            // release_year
            // 
            this.release_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.release_year.Location = new System.Drawing.Point(185, 79);
            this.release_year.MaxLength = 4;
            this.release_year.Name = "release_year";
            this.release_year.Size = new System.Drawing.Size(242, 38);
            this.release_year.TabIndex = 29;
            this.release_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 68);
            this.label7.TabIndex = 28;
            this.label7.Text = "Название \r\nпроизводителя";
            // 
            // name_proiz
            // 
            this.name_proiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_proiz.Location = new System.Drawing.Point(185, 185);
            this.name_proiz.MaxLength = 30;
            this.name_proiz.Name = "name_proiz";
            this.name_proiz.Size = new System.Drawing.Size(242, 38);
            this.name_proiz.TabIndex = 27;
            this.name_proiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 34);
            this.label8.TabIndex = 26;
            this.label8.Text = "Год выпуска";
            // 
            // cost_per_day
            // 
            this.cost_per_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_per_day.Location = new System.Drawing.Point(157, 262);
            this.cost_per_day.MaxLength = 7;
            this.cost_per_day.Name = "cost_per_day";
            this.cost_per_day.Size = new System.Drawing.Size(242, 38);
            this.cost_per_day.TabIndex = 25;
            this.cost_per_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 68);
            this.label5.TabIndex = 24;
            this.label5.Text = "Стоимость \r\nпроката в сутки";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(157, 207);
            this.Price.MaxLength = 7;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(242, 38);
            this.Price.TabIndex = 23;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 34);
            this.label4.TabIndex = 22;
            this.label4.Text = "Стоимость";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(157, 152);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(242, 38);
            this.name.TabIndex = 21;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "Название";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(433, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 34);
            this.label9.TabIndex = 36;
            this.label9.Text = "Номер выпуска";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(433, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 34);
            this.label10.TabIndex = 34;
            this.label10.Text = "Тип носителя";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(433, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 34);
            this.label11.TabIndex = 32;
            this.label11.Text = "Жанр";
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(12, 361);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(182, 51);
            this.bAdd.TabIndex = 38;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // bUp
            // 
            this.bUp.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bUp.Location = new System.Drawing.Point(200, 361);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(182, 51);
            this.bUp.TabIndex = 39;
            this.bUp.Text = "Обновить";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.Up_Click);
            // 
            // bDel
            // 
            this.bDel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bDel.Location = new System.Drawing.Point(388, 361);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(182, 51);
            this.bDel.TabIndex = 40;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.Del_Click);
            // 
            // bBuy
            // 
            this.bBuy.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bBuy.Location = new System.Drawing.Point(1122, 361);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(182, 51);
            this.bBuy.TabIndex = 41;
            this.bBuy.Text = "Купить";
            this.bBuy.UseVisualStyleBackColor = true;
            this.bBuy.Visible = false;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 243);
            this.dataGridView1.TabIndex = 42;
            // 
            // media_type
            // 
            this.media_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.media_type.FormattingEnabled = true;
            this.media_type.Items.AddRange(new object[] {
            "CD-диск",
            "DVD-диск",
            "VHS-кассета"});
            this.media_type.Location = new System.Drawing.Point(652, 130);
            this.media_type.Name = "media_type";
            this.media_type.Size = new System.Drawing.Size(251, 39);
            this.media_type.TabIndex = 43;
            // 
            // Number_V
            // 
            this.Number_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_V.FormattingEnabled = true;
            this.Number_V.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.Number_V.Location = new System.Drawing.Point(652, 185);
            this.Number_V.Name = "Number_V";
            this.Number_V.Size = new System.Drawing.Size(251, 39);
            this.Number_V.TabIndex = 44;
            // 
            // bArenda
            // 
            this.bArenda.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bArenda.Location = new System.Drawing.Point(934, 361);
            this.bArenda.Name = "bArenda";
            this.bArenda.Size = new System.Drawing.Size(182, 51);
            this.bArenda.TabIndex = 46;
            this.bArenda.Text = "Аренда";
            this.bArenda.UseVisualStyleBackColor = true;
            this.bArenda.Visible = false;
            this.bArenda.Click += new System.EventHandler(this.Aren_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.genre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.name_proiz);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Number_V);
            this.panel1.Controls.Add(this.release_year);
            this.panel1.Controls.Add(this.media_type);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(405, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 255);
            this.panel1.TabIndex = 47;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount.Location = new System.Drawing.Point(185, 31);
            this.amount.MaxLength = 7;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(242, 38);
            this.amount.TabIndex = 52;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(4, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 34);
            this.label13.TabIndex = 51;
            this.label13.Text = "Количество";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.FormattingEnabled = true;
            this.genre.Items.AddRange(new object[] {
            "художественные фильмы",
            "музыкальные композиции",
            "документальные фильмы",
            "развлекательные программы",
            "мультфильмы"});
            this.genre.Location = new System.Drawing.Point(652, 78);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(251, 39);
            this.genre.TabIndex = 45;
            // 
            // bTChek
            // 
            this.bTChek.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bTChek.Location = new System.Drawing.Point(746, 361);
            this.bTChek.Name = "bTChek";
            this.bTChek.Size = new System.Drawing.Size(182, 51);
            this.bTChek.TabIndex = 48;
            this.bTChek.Text = "Таблица чеков";
            this.bTChek.UseVisualStyleBackColor = true;
            this.bTChek.Visible = false;
            this.bTChek.Click += new System.EventHandler(this.toTCheck);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(157, 108);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(242, 38);
            this.id.TabIndex = 50;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 34);
            this.label12.TabIndex = 49;
            this.label12.Text = "id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1114, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 51;
            this.dateTimePicker1.Visible = false;
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bTChek);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bArenda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bBuy);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.cost_per_day);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ac);
            this.Controls.Add(this.bLogOut);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "Sklad";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Sklad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ac;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox release_year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_proiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cost_per_day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bBuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox media_type;
        private System.Windows.Forms.ComboBox Number_V;
        private System.Windows.Forms.Button bArenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bTChek;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}