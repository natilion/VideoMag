
namespace WindowsFormsApp1
{
    partial class SkladAdd
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
            this.amount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Diss = new System.Windows.Forms.CheckBox();
            this.genre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name_proiz = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Number_V = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.release_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.media_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount.Location = new System.Drawing.Point(652, 230);
            this.amount.MaxLength = 7;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(251, 38);
            this.amount.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(433, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 34);
            this.label13.TabIndex = 58;
            this.label13.Text = "Количество";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Diss);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.genre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.name_proiz);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Number_V);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.release_year);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.media_type);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 310);
            this.panel1.TabIndex = 57;
            // 
            // Diss
            // 
            this.Diss.AutoSize = true;
            this.Diss.Font = new System.Drawing.Font("Bahnschrift", 16.2F);
            this.Diss.Location = new System.Drawing.Point(293, 234);
            this.Diss.Name = "Diss";
            this.Diss.Size = new System.Drawing.Size(134, 38);
            this.Diss.TabIndex = 60;
            this.Diss.Text = "Удален";
            this.Diss.UseVisualStyleBackColor = true;
            this.Diss.Visible = false;
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
            // name_proiz
            // 
            this.name_proiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_proiz.Location = new System.Drawing.Point(185, 185);
            this.name_proiz.MaxLength = 30;
            this.name_proiz.Name = "name_proiz";
            this.name_proiz.Size = new System.Drawing.Size(242, 38);
            this.name_proiz.TabIndex = 27;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(652, 26);
            this.Price.MaxLength = 7;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(251, 38);
            this.Price.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(433, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 34);
            this.label4.TabIndex = 55;
            this.label4.Text = "Стоимость";
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
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(185, 30);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(242, 38);
            this.name.TabIndex = 54;
            // 
            // release_year
            // 
            this.release_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.release_year.Location = new System.Drawing.Point(185, 79);
            this.release_year.MaxLength = 4;
            this.release_year.Name = "release_year";
            this.release_year.Size = new System.Drawing.Size(242, 38);
            this.release_year.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 53;
            this.label3.Text = "Название";
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
            // duration
            // 
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.Location = new System.Drawing.Point(185, 132);
            this.duration.MaxLength = 3;
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(242, 38);
            this.duration.TabIndex = 31;
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
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(102, 339);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(819, 51);
            this.bAdd.TabIndex = 58;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(12, 339);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(84, 51);
            this.Back.TabIndex = 59;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SkladAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 409);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.panel1);
            this.Name = "SkladAdd";
            this.Load += new System.EventHandler(this.SkladAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name_proiz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Number_V;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox release_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox media_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.CheckBox Diss;
    }
}