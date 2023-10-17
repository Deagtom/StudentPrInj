namespace StudentPrInj
{
    partial class Menu
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
            this.CheckPasswordCB = new System.Windows.Forms.CheckBox();
            this.LoginLB = new System.Windows.Forms.Label();
            this.RegistrationBN = new System.Windows.Forms.Button();
            this.LoginBN = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.Background = new System.Windows.Forms.Panel();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckPasswordCB
            // 
            this.CheckPasswordCB.AutoSize = true;
            this.CheckPasswordCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPasswordCB.Location = new System.Drawing.Point(440, 371);
            this.CheckPasswordCB.Name = "CheckPasswordCB";
            this.CheckPasswordCB.Size = new System.Drawing.Size(147, 23);
            this.CheckPasswordCB.TabIndex = 2;
            this.CheckPasswordCB.Text = "Показать пароль";
            this.CheckPasswordCB.UseVisualStyleBackColor = true;
            this.CheckPasswordCB.CheckedChanged += new System.EventHandler(this.CheckPasswordCB_CheckedChanged);
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLB.Location = new System.Drawing.Point(433, 199);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(198, 39);
            this.LoginLB.TabIndex = 5;
            this.LoginLB.Text = "Авторизация";
            // 
            // RegistrationBN
            // 
            this.RegistrationBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationBN.Location = new System.Drawing.Point(646, 443);
            this.RegistrationBN.Name = "RegistrationBN";
            this.RegistrationBN.Size = new System.Drawing.Size(138, 47);
            this.RegistrationBN.TabIndex = 4;
            this.RegistrationBN.Text = "Регистрация";
            this.RegistrationBN.UseVisualStyleBackColor = true;
            this.RegistrationBN.Click += new System.EventHandler(this.RegistrationBN_Click);
            // 
            // LoginBN
            // 
            this.LoginBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBN.Location = new System.Drawing.Point(440, 443);
            this.LoginBN.Name = "LoginBN";
            this.LoginBN.Size = new System.Drawing.Size(138, 47);
            this.LoginBN.TabIndex = 3;
            this.LoginBN.Text = "Войти";
            this.LoginBN.UseVisualStyleBackColor = true;
            this.LoginBN.Click += new System.EventHandler(this.LoginBN_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTB.Location = new System.Drawing.Point(440, 325);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(344, 40);
            this.PasswordTB.TabIndex = 1;
            this.PasswordTB.Text = "Пароль";
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTB_TextEnter);
            this.PasswordTB.Leave += new System.EventHandler(this.PasswordTB_Leave);
            // 
            // LoginTB
            // 
            this.LoginTB.BackColor = System.Drawing.SystemColors.Window;
            this.LoginTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.ForeColor = System.Drawing.Color.Gray;
            this.LoginTB.Location = new System.Drawing.Point(440, 256);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(344, 40);
            this.LoginTB.TabIndex = 0;
            this.LoginTB.Text = "Логин (Email)";
            this.LoginTB.Enter += new System.EventHandler(this.LoginTB_TextEnter);
            this.LoginTB.Leave += new System.EventHandler(this.LoginTB_Leave);
            // 
            // Background
            // 
            this.Background.Controls.Add(this.CheckPasswordCB);
            this.Background.Controls.Add(this.LoginLB);
            this.Background.Controls.Add(this.RegistrationBN);
            this.Background.Controls.Add(this.LoginBN);
            this.Background.Controls.Add(this.PasswordTB);
            this.Background.Controls.Add(this.LoginTB);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1184, 761);
            this.Background.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Background);
            this.Name = "Menu";
            this.Text = "Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.Button RegistrationBN;
        private System.Windows.Forms.Button LoginBN;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.CheckBox CheckPasswordCB;
        private System.Windows.Forms.Panel Background;
    }
}

