
namespace WindowsFormsApp1
{
    partial class Reg
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.Ac = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MidlleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBK = new System.Windows.Forms.RadioButton();
            this.RBKas = new System.Windows.Forms.RadioButton();
            this.RBKad = new System.Windows.Forms.RadioButton();
            this.RBAdmin = new System.Windows.Forms.RadioButton();
            this.LaP = new System.Windows.Forms.Panel();
            this.bReg = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoArDataSet = new WindowsFormsApp1.VideoArDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.Vidan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.NP = new System.Windows.Forms.TextBox();
            this.officeTableAdapter = new WindowsFormsApp1.VideoArDataSetTableAdapters.OfficeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.LaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoArDataSet)).BeginInit();
            this.Passport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Регистрация";
            // 
            // Ac
            // 
            this.Ac.AutoSize = true;
            this.Ac.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.Ac.ForeColor = System.Drawing.Color.Black;
            this.Ac.Location = new System.Drawing.Point(980, 16);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(324, 51);
            this.Ac.TabIndex = 4;
            this.Ac.Text = "Администратор";
            // 
            // bLogOut
            // 
            this.bLogOut.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bLogOut.Location = new System.Drawing.Point(792, 16);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(182, 51);
            this.bLogOut.TabIndex = 3;
            this.bLogOut.Text = "Выйти";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(151, 172);
            this.Name.MaxLength = 30;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(316, 38);
            this.Name.TabIndex = 9;
            this.Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(151, 227);
            this.LastName.MaxLength = 30;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(316, 38);
            this.LastName.TabIndex = 11;
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Фамилия";
            // 
            // MidlleName
            // 
            this.MidlleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MidlleName.Location = new System.Drawing.Point(151, 282);
            this.MidlleName.MaxLength = 30;
            this.MidlleName.Name = "MidlleName";
            this.MidlleName.Size = new System.Drawing.Size(316, 38);
            this.MidlleName.TabIndex = 13;
            this.MidlleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Отчество";
            // 
            // PNumber
            // 
            this.PNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PNumber.Location = new System.Drawing.Point(250, 337);
            this.PNumber.MaxLength = 11;
            this.PNumber.Name = "PNumber";
            this.PNumber.Size = new System.Drawing.Size(217, 38);
            this.PNumber.TabIndex = 19;
            this.PNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 34);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер телефона";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(238, 74);
            this.Password.MaxLength = 30;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(235, 38);
            this.Password.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 34);
            this.label10.TabIndex = 22;
            this.label10.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(238, 19);
            this.Login.MaxLength = 30;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(235, 38);
            this.Login.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 21);
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
            this.label9.Location = new System.Drawing.Point(1096, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 34);
            this.label9.TabIndex = 24;
            this.label9.Text = "Должность";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.RBK);
            this.groupBox1.Controls.Add(this.RBKas);
            this.groupBox1.Controls.Add(this.RBKad);
            this.groupBox1.Controls.Add(this.RBAdmin);
            this.groupBox1.Location = new System.Drawing.Point(955, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 241);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // RBK
            // 
            this.RBK.AutoSize = true;
            this.RBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBK.Location = new System.Drawing.Point(6, 184);
            this.RBK.Name = "RBK";
            this.RBK.Size = new System.Drawing.Size(132, 36);
            this.RBK.TabIndex = 3;
            this.RBK.TabStop = true;
            this.RBK.Text = "Клиент";
            this.RBK.UseVisualStyleBackColor = true;
            this.RBK.Click += new System.EventHandler(this.Kl_Click);
            // 
            // RBKas
            // 
            this.RBKas.AutoSize = true;
            this.RBKas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBKas.Location = new System.Drawing.Point(6, 129);
            this.RBKas.Name = "RBKas";
            this.RBKas.Size = new System.Drawing.Size(131, 36);
            this.RBKas.TabIndex = 2;
            this.RBKas.TabStop = true;
            this.RBKas.Text = "Кассир";
            this.RBKas.UseVisualStyleBackColor = true;
            this.RBKas.Click += new System.EventHandler(this.J_Click);
            // 
            // RBKad
            // 
            this.RBKad.AutoSize = true;
            this.RBKad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBKad.Location = new System.Drawing.Point(6, 68);
            this.RBKad.Name = "RBKad";
            this.RBKad.Size = new System.Drawing.Size(164, 36);
            this.RBKad.TabIndex = 1;
            this.RBKad.TabStop = true;
            this.RBKad.Text = "Кадровик";
            this.RBKad.UseVisualStyleBackColor = true;
            this.RBKad.Click += new System.EventHandler(this.J_Click);
            // 
            // RBAdmin
            // 
            this.RBAdmin.AutoSize = true;
            this.RBAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBAdmin.Location = new System.Drawing.Point(6, 13);
            this.RBAdmin.Name = "RBAdmin";
            this.RBAdmin.Size = new System.Drawing.Size(243, 36);
            this.RBAdmin.TabIndex = 0;
            this.RBAdmin.TabStop = true;
            this.RBAdmin.Text = "Администратор";
            this.RBAdmin.UseVisualStyleBackColor = true;
            this.RBAdmin.Click += new System.EventHandler(this.J_Click);
            // 
            // LaP
            // 
            this.LaP.BackColor = System.Drawing.Color.Silver;
            this.LaP.Controls.Add(this.Password);
            this.LaP.Controls.Add(this.Login);
            this.LaP.Controls.Add(this.label11);
            this.LaP.Controls.Add(this.label10);
            this.LaP.Location = new System.Drawing.Point(473, 381);
            this.LaP.Name = "LaP";
            this.LaP.Size = new System.Drawing.Size(476, 133);
            this.LaP.TabIndex = 26;
            this.LaP.Visible = false;
            // 
            // bReg
            // 
            this.bReg.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bReg.Location = new System.Drawing.Point(151, 591);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(974, 51);
            this.bReg.TabIndex = 27;
            this.bReg.Text = "Подтвердить регистрацию";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.Add_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(12, 591);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(84, 51);
            this.Back.TabIndex = 28;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.officeBindingSource;
            this.comboBox2.DisplayMember = "Adres";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 397);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(316, 39);
            this.comboBox2.TabIndex = 56;
            this.comboBox2.ValueMember = "ID_Office";
            this.comboBox2.Visible = false;
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataMember = "Office";
            this.officeBindingSource.DataSource = this.videoArDataSet;
            // 
            // videoArDataSet
            // 
            this.videoArDataSet.DataSetName = "VideoArDataSet";
            this.videoArDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 34);
            this.label12.TabIndex = 55;
            this.label12.Text = "Офис";
            this.label12.Visible = false;
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
            this.Passport.Controls.Add(this.label16);
            this.Passport.Controls.Add(this.SP);
            this.Passport.Controls.Add(this.label17);
            this.Passport.Controls.Add(this.NP);
            this.Passport.Location = new System.Drawing.Point(473, 106);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(476, 275);
            this.Passport.TabIndex = 57;
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
            // Vidan
            // 
            this.Vidan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vidan.Location = new System.Drawing.Point(143, 231);
            this.Vidan.MaxLength = 150;
            this.Vidan.Name = "Vidan";
            this.Vidan.Size = new System.Drawing.Size(330, 38);
            this.Vidan.TabIndex = 45;
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
            // Adres
            // 
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adres.Location = new System.Drawing.Point(143, 175);
            this.Adres.MaxLength = 150;
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(330, 38);
            this.Adres.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 34);
            this.label16.TabIndex = 33;
            this.label16.Text = "Серия паспорта";
            // 
            // SP
            // 
            this.SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SP.Location = new System.Drawing.Point(233, 7);
            this.SP.MaxLength = 4;
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(240, 38);
            this.SP.TabIndex = 34;
            this.SP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PNumber_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 34);
            this.label17.TabIndex = 35;
            this.label17.Text = "Номер паспорта";
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
            this.NP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PNumber_KeyPress);
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.bReg);
            this.Controls.Add(this.LaP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MidlleName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ac);
            this.Controls.Add(this.bLogOut);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Load += new System.EventHandler(this.Reg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LaP.ResumeLayout(false);
            this.LaP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoArDataSet)).EndInit();
            this.Passport.ResumeLayout(false);
            this.Passport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ac;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MidlleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBK;
        private System.Windows.Forms.RadioButton RBKas;
        private System.Windows.Forms.RadioButton RBKad;
        private System.Windows.Forms.RadioButton RBAdmin;
        private System.Windows.Forms.Panel LaP;
        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel Passport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Vidan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox SP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox NP;
        private VideoArDataSet videoArDataSet;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private VideoArDataSetTableAdapters.OfficeTableAdapter officeTableAdapter;
    }
}