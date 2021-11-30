
namespace WindowsFormsApp1
{
    partial class Arenda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Aren = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Of = new System.Windows.Forms.RadioButton();
            this.Prin = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cost_per_day = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.Label();
            this.Sot = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoArDataSet = new WindowsFormsApp1.VideoArDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.officeTableAdapter = new WindowsFormsApp1.VideoArDataSetTableAdapters.OfficeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoArDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // Aren
            // 
            this.Aren.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Aren.Location = new System.Drawing.Point(279, 398);
            this.Aren.Name = "Aren";
            this.Aren.Size = new System.Drawing.Size(156, 67);
            this.Aren.TabIndex = 4;
            this.Aren.Text = "Одобрить аренду";
            this.Aren.UseVisualStyleBackColor = true;
            this.Aren.Click += new System.EventHandler(this.Aren_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 42);
            this.button3.TabIndex = 29;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "id клиента";
            // 
            // kid
            // 
            this.kid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kid.Location = new System.Drawing.Point(168, 349);
            this.kid.Name = "kid";
            this.kid.Size = new System.Drawing.Size(105, 38);
            this.kid.TabIndex = 31;
            this.kid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kid_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 34);
            this.label9.TabIndex = 42;
            this.label9.Text = "Итоговая цена: ";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(12, 431);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(72, 34);
            this.Price.TabIndex = 43;
            this.Price.Text = "0000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Of);
            this.groupBox1.Controls.Add(this.Prin);
            this.groupBox1.Location = new System.Drawing.Point(95, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 51);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // Of
            // 
            this.Of.AutoSize = true;
            this.Of.Checked = true;
            this.Of.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Of.Location = new System.Drawing.Point(6, 9);
            this.Of.Name = "Of";
            this.Of.Size = new System.Drawing.Size(177, 36);
            this.Of.TabIndex = 3;
            this.Of.TabStop = true;
            this.Of.Text = "Оформить";
            this.Of.UseVisualStyleBackColor = true;
            this.Of.CheckedChanged += new System.EventHandler(this.Of_CheckedChanged);
            this.Of.Click += new System.EventHandler(this.Of_Click);
            // 
            // Prin
            // 
            this.Prin.AutoSize = true;
            this.Prin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prin.Location = new System.Drawing.Point(193, 9);
            this.Prin.Name = "Prin";
            this.Prin.Size = new System.Drawing.Size(147, 36);
            this.Prin.TabIndex = 2;
            this.Prin.Text = "Принять";
            this.Prin.UseVisualStyleBackColor = true;
            this.Prin.CheckedChanged += new System.EventHandler(this.Prin_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cost_per_day);
            this.panel1.Controls.Add(this.TName);
            this.panel1.Controls.Add(this.Sot);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.days);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 279);
            this.panel1.TabIndex = 48;
            // 
            // cost_per_day
            // 
            this.cost_per_day.AutoSize = true;
            this.cost_per_day.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_per_day.ForeColor = System.Drawing.Color.Black;
            this.cost_per_day.Location = new System.Drawing.Point(187, 76);
            this.cost_per_day.Name = "cost_per_day";
            this.cost_per_day.Size = new System.Drawing.Size(32, 34);
            this.cost_per_day.TabIndex = 61;
            this.cost_per_day.Text = "С";
            // 
            // TName
            // 
            this.TName.AutoSize = true;
            this.TName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TName.ForeColor = System.Drawing.Color.Black;
            this.TName.Location = new System.Drawing.Point(187, 42);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(28, 34);
            this.TName.TabIndex = 60;
            this.TName.Text = "T";
            // 
            // Sot
            // 
            this.Sot.AutoSize = true;
            this.Sot.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sot.ForeColor = System.Drawing.Color.Black;
            this.Sot.Location = new System.Drawing.Point(187, 8);
            this.Sot.Name = "Sot";
            this.Sot.Size = new System.Drawing.Size(32, 34);
            this.Sot.TabIndex = 59;
            this.Sot.Text = "С";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.officeBindingSource;
            this.comboBox2.DisplayMember = "Adres";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 39);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "ID_Office";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 34);
            this.label5.TabIndex = 56;
            this.label5.Text = "Офис";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 34);
            this.label8.TabIndex = 55;
            this.label8.Text = "Цена сутки:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 34);
            this.label7.TabIndex = 54;
            this.label7.Text = "Товар:";
            // 
            // days
            // 
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.Location = new System.Drawing.Point(198, 150);
            this.days.MaxLength = 2;
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(105, 38);
            this.days.TabIndex = 53;
            this.days.Text = "1";
            this.days.TextChanged += new System.EventHandler(this.days_TextChanged);
            this.days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kid_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 34);
            this.label6.TabIndex = 52;
            this.label6.Text = "Кол-во суток:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(194, 194);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 30);
            this.dateTimePicker2.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 30);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 34);
            this.label4.TabIndex = 49;
            this.label4.Text = "Дата конца:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 34);
            this.label3.TabIndex = 48;
            this.label3.Text = "Дата начала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 47;
            this.label2.Text = "Сотрудник:";
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // Arenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Aren);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Arenda";
            this.Text = "Arenda";
            this.Load += new System.EventHandler(this.Arenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoArDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Of;
        private System.Windows.Forms.RadioButton Prin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aren;
        private VideoArDataSet videoArDataSet;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private VideoArDataSetTableAdapters.OfficeTableAdapter officeTableAdapter;
        private System.Windows.Forms.Label cost_per_day;
        private System.Windows.Forms.Label TName;
        private System.Windows.Forms.Label Sot;
    }
}