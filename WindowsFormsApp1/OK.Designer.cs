
namespace WindowsFormsApp1
{
    partial class OK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sot = new System.Windows.Forms.RadioButton();
            this.Kl = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Ac = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            this.LaP = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MidlleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bReg = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Vidan = new System.Windows.Forms.TextBox();
            this.Passport = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.LaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Passport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sot);
            this.groupBox1.Controls.Add(this.Kl);
            this.groupBox1.Location = new System.Drawing.Point(309, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 51);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Sot
            // 
            this.Sot.AutoSize = true;
            this.Sot.Checked = true;
            this.Sot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sot.Location = new System.Drawing.Point(54, 9);
            this.Sot.Name = "Sot";
            this.Sot.Size = new System.Drawing.Size(193, 36);
            this.Sot.TabIndex = 3;
            this.Sot.TabStop = true;
            this.Sot.Text = "Сотрудники";
            this.Sot.UseVisualStyleBackColor = true;
            this.Sot.Click += new System.EventHandler(this.Sot_Click);
            // 
            // Kl
            // 
            this.Kl.AutoSize = true;
            this.Kl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kl.Location = new System.Drawing.Point(262, 9);
            this.Kl.Name = "Kl";
            this.Kl.Size = new System.Drawing.Size(152, 36);
            this.Kl.TabIndex = 2;
            this.Kl.Text = "Клиенты";
            this.Kl.UseVisualStyleBackColor = true;
            this.Kl.Click += new System.EventHandler(this.Kl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 51);
            this.label2.TabIndex = 12;
            this.label2.Text = "Отдел кадров";
            // 
            // Ac
            // 
            this.Ac.AutoSize = true;
            this.Ac.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.Ac.ForeColor = System.Drawing.Color.Black;
            this.Ac.Location = new System.Drawing.Point(980, 16);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(324, 51);
            this.Ac.TabIndex = 11;
            this.Ac.Text = "Администратор";
            // 
            // bLogOut
            // 
            this.bLogOut.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bLogOut.Location = new System.Drawing.Point(792, 16);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(182, 51);
            this.bLogOut.TabIndex = 10;
            this.bLogOut.Text = "Выйти";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.Back_Click);
            // 
            // LaP
            // 
            this.LaP.BackColor = System.Drawing.Color.Silver;
            this.LaP.Controls.Add(this.comboBox1);
            this.LaP.Controls.Add(this.Password);
            this.LaP.Controls.Add(this.Login);
            this.LaP.Controls.Add(this.label11);
            this.LaP.Controls.Add(this.label9);
            this.LaP.Controls.Add(this.label10);
            this.LaP.Location = new System.Drawing.Point(902, 150);
            this.LaP.Name = "LaP";
            this.LaP.Size = new System.Drawing.Size(418, 172);
            this.LaP.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Администратор",
            "Кадровик",
            "Кассир"});
            this.comboBox1.Location = new System.Drawing.Point(198, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 39);
            this.comboBox1.TabIndex = 45;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(123, 64);
            this.Password.MaxLength = 30;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(295, 38);
            this.Password.TabIndex = 23;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(123, 13);
            this.Login.MaxLength = 30;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(295, 38);
            this.Login.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 34);
            this.label11.TabIndex = 20;
            this.label11.Text = "Логин";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 34);
            this.label9.TabIndex = 44;
            this.label9.Text = "Должность";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 34);
            this.label10.TabIndex = 22;
            this.label10.Text = "Пароль";
            // 
            // PNumber
            // 
            this.PNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PNumber.Location = new System.Drawing.Point(1131, 106);
            this.PNumber.MaxLength = 11;
            this.PNumber.Name = "PNumber";
            this.PNumber.Size = new System.Drawing.Size(189, 38);
            this.PNumber.TabIndex = 38;
            this.PNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(896, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 34);
            this.label6.TabIndex = 37;
            this.label6.Text = "Номер телефона";
            // 
            // NP
            // 
            this.NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NP.Location = new System.Drawing.Point(233, 65);
            this.NP.MaxLength = 6;
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(240, 38);
            this.NP.TabIndex = 36;
            this.NP.WordWrap = false;
            this.NP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 34);
            this.label7.TabIndex = 35;
            this.label7.Text = "Номер паспорта";
            // 
            // SP
            // 
            this.SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SP.Location = new System.Drawing.Point(233, 7);
            this.SP.MaxLength = 4;
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(240, 38);
            this.SP.TabIndex = 34;
            this.SP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 34);
            this.label8.TabIndex = 33;
            this.label8.Text = "Серия паспорта";
            // 
            // MidlleName
            // 
            this.MidlleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MidlleName.Location = new System.Drawing.Point(154, 282);
            this.MidlleName.MaxLength = 30;
            this.MidlleName.Name = "MidlleName";
            this.MidlleName.Size = new System.Drawing.Size(242, 38);
            this.MidlleName.TabIndex = 32;
            this.MidlleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 34);
            this.label5.TabIndex = 31;
            this.label5.Text = "Отчество";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(154, 227);
            this.LastName.MaxLength = 30;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(242, 38);
            this.LastName.TabIndex = 30;
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 34);
            this.label4.TabIndex = 29;
            this.label4.Text = "Фамилия";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(154, 172);
            this.Name.MaxLength = 30;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(242, 38);
            this.Name.TabIndex = 28;
            this.Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Имя";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 243);
            this.dataGridView1.TabIndex = 43;
            // 
            // bReg
            // 
            this.bReg.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bReg.Location = new System.Drawing.Point(1119, 361);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(182, 51);
            this.bReg.TabIndex = 44;
            this.bReg.Text = "Регистрация";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(200, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 51);
            this.button4.TabIndex = 49;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Del_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 51);
            this.button3.TabIndex = 48;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Up_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(154, 114);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(242, 38);
            this.id.TabIndex = 51;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 34);
            this.label12.TabIndex = 50;
            this.label12.Text = "id";
            // 
            // Adres
            // 
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adres.Location = new System.Drawing.Point(143, 175);
            this.Adres.MaxLength = 150;
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(330, 38);
            this.Adres.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 34);
            this.label13.TabIndex = 20;
            this.label13.Text = "Дата";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(9, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 34);
            this.label14.TabIndex = 44;
            this.label14.Text = "Выдан";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(9, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 34);
            this.label15.TabIndex = 22;
            this.label15.Text = "Адрес";
            // 
            // Vidan
            // 
            this.Vidan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vidan.Location = new System.Drawing.Point(143, 231);
            this.Vidan.MaxLength = 150;
            this.Vidan.Name = "Vidan";
            this.Vidan.Size = new System.Drawing.Size(330, 38);
            this.Vidan.TabIndex = 45;
            // 
            // Passport
            // 
            this.Passport.BackColor = System.Drawing.Color.Silver;
            this.Passport.Controls.Add(this.dateTimePicker2);
            this.Passport.Controls.Add(this.label13);
            this.Passport.Controls.Add(this.Vidan);
            this.Passport.Controls.Add(this.label14);
            this.Passport.Controls.Add(this.label15);
            this.Passport.Controls.Add(this.Adres);
            this.Passport.Controls.Add(this.label8);
            this.Passport.Controls.Add(this.SP);
            this.Passport.Controls.Add(this.label7);
            this.Passport.Controls.Add(this.NP);
            this.Passport.Location = new System.Drawing.Point(414, 101);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(476, 275);
            this.Passport.TabIndex = 46;
            this.Passport.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 125);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 30);
            this.dateTimePicker2.TabIndex = 51;
            // 
            // OK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bReg);
            this.Controls.Add(this.LaP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MidlleName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ac);
            this.Controls.Add(this.bLogOut);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name.Name = "OK";
            this.ShowIcon = false;
            this.Text = "OK";
            this.Load += new System.EventHandler(this.OK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LaP.ResumeLayout(false);
            this.LaP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Passport.ResumeLayout(false);
            this.Passport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Sot;
        private System.Windows.Forms.RadioButton Kl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ac;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Panel LaP;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MidlleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Vidan;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel Passport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}