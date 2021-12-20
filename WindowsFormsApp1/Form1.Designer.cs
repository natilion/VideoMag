
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bLogOut = new System.Windows.Forms.Button();
            this.Ac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSk = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.bLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.bPos = new System.Windows.Forms.Button();
            this.bCli = new System.Windows.Forms.Button();
            this.bBuh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bLogOut.Location = new System.Drawing.Point(792, 16);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(182, 51);
            this.bLogOut.TabIndex = 0;
            this.bLogOut.Text = "Выйти";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Visible = false;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // Ac
            // 
            this.Ac.AutoSize = true;
            this.Ac.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.Ac.ForeColor = System.Drawing.Color.Black;
            this.Ac.Location = new System.Drawing.Point(980, 16);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(0, 51);
            this.Ac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Авторизация";
            // 
            // bSk
            // 
            this.bSk.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSk.Location = new System.Drawing.Point(21, 141);
            this.bSk.Name = "bSk";
            this.bSk.Size = new System.Drawing.Size(246, 67);
            this.bSk.TabIndex = 3;
            this.bSk.Text = "Склад";
            this.bSk.UseVisualStyleBackColor = true;
            this.bSk.Visible = false;
            this.bSk.Click += new System.EventHandler(this.toSk);
            // 
            // bOK
            // 
            this.bOK.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOK.Location = new System.Drawing.Point(21, 315);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(246, 67);
            this.bOK.TabIndex = 4;
            this.bOK.Text = "Отдел кадров";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Visible = false;
            this.bOK.Click += new System.EventHandler(this.toOK);
            // 
            // bLog
            // 
            this.bLog.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLog.Location = new System.Drawing.Point(463, 404);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(511, 67);
            this.bLog.TabIndex = 5;
            this.bLog.Text = "Войти";
            this.bLog.UseVisualStyleBackColor = true;
            this.bLog.Click += new System.EventHandler(this.Log);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(477, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(454, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(624, 244);
            this.login.MaxLength = 30;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(350, 55);
            this.login.TabIndex = 8;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(624, 331);
            this.password.MaxLength = 30;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(350, 55);
            this.password.TabIndex = 9;
            // 
            // bPos
            // 
            this.bPos.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPos.Location = new System.Drawing.Point(21, 404);
            this.bPos.Name = "bPos";
            this.bPos.Size = new System.Drawing.Size(246, 67);
            this.bPos.TabIndex = 10;
            this.bPos.Text = "Должности";
            this.bPos.UseVisualStyleBackColor = true;
            this.bPos.Visible = false;
            this.bPos.Click += new System.EventHandler(this.toPos);
            // 
            // bCli
            // 
            this.bCli.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCli.Location = new System.Drawing.Point(21, 228);
            this.bCli.Name = "bCli";
            this.bCli.Size = new System.Drawing.Size(246, 67);
            this.bCli.TabIndex = 11;
            this.bCli.Text = "Клиенты";
            this.bCli.UseVisualStyleBackColor = true;
            this.bCli.Visible = false;
            this.bCli.Click += new System.EventHandler(this.bCli_Click);
            // 
            // bBuh
            // 
            this.bBuh.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBuh.Location = new System.Drawing.Point(21, 490);
            this.bBuh.Name = "bBuh";
            this.bBuh.Size = new System.Drawing.Size(246, 67);
            this.bBuh.TabIndex = 12;
            this.bBuh.Text = "Бухгалтерия";
            this.bBuh.UseVisualStyleBackColor = true;
            this.bBuh.Visible = false;
            this.bBuh.Click += new System.EventHandler(this.bBuh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.bBuh);
            this.Controls.Add(this.bCli);
            this.Controls.Add(this.bPos);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bLog);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bSk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ac);
            this.Controls.Add(this.bLogOut);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Label Ac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSk;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button bPos;
        private System.Windows.Forms.Button bCli;
        private System.Windows.Forms.Button bBuh;
    }
}

