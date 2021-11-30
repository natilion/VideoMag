
namespace WindowsFormsApp1
{
    partial class Office
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Adres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.videoArDataSet = new WindowsFormsApp1.VideoArDataSet();
            this.rabotnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabotnikTableAdapter = new WindowsFormsApp1.VideoArDataSetTableAdapters.RabotnikTableAdapter();
            this.rabotnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoArDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Офисы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(980, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Администратор";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(792, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 422);
            this.dataGridView1.TabIndex = 46;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(478, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 51);
            this.button4.TabIndex = 45;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Del_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(290, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 51);
            this.button3.TabIndex = 44;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Up_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(102, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 51);
            this.button2.TabIndex = 43;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Add_Click);
            // 
            // Adres
            // 
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adres.Location = new System.Drawing.Point(431, 127);
            this.Adres.MaxLength = 30;
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(269, 38);
            this.Adres.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(330, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 34);
            this.label3.TabIndex = 47;
            this.label3.Text = "Адрес";
            // 
            // PNumber
            // 
            this.PNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PNumber.Location = new System.Drawing.Point(941, 127);
            this.PNumber.MaxLength = 11;
            this.PNumber.Name = "PNumber";
            this.PNumber.Size = new System.Drawing.Size(269, 38);
            this.PNumber.TabIndex = 50;
            this.PNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(706, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 34);
            this.label4.TabIndex = 49;
            this.label4.Text = "Номер телефона";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(55, 127);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(269, 38);
            this.id.TabIndex = 52;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 34);
            this.label5.TabIndex = 51;
            this.label5.Text = "id";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(12, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 51);
            this.button5.TabIndex = 55;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Back_Click);
            // 
            // videoArDataSet
            // 
            this.videoArDataSet.DataSetName = "VideoArDataSet";
            this.videoArDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rabotnikBindingSource
            // 
            this.rabotnikBindingSource.DataMember = "Rabotnik";
            this.rabotnikBindingSource.DataSource = this.videoArDataSet;
            // 
            // rabotnikTableAdapter
            // 
            this.rabotnikTableAdapter.ClearBeforeFill = true;
            // 
            // rabotnikBindingSource1
            // 
            this.rabotnikBindingSource1.DataMember = "Rabotnik";
            this.rabotnikBindingSource1.DataSource = this.videoArDataSet;
            // 
            // Office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "Office";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Office_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoArDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private VideoArDataSet videoArDataSet;
        private System.Windows.Forms.BindingSource rabotnikBindingSource;
        private VideoArDataSetTableAdapters.RabotnikTableAdapter rabotnikTableAdapter;
        private System.Windows.Forms.BindingSource rabotnikBindingSource1;
    }
}