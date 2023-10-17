namespace StudentPrInj
{
    partial class Registration
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
            this.Background = new System.Windows.Forms.Panel();
            this.CourseTB = new System.Windows.Forms.TextBox();
            this.PassportTB = new System.Windows.Forms.TextBox();
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.MiddleNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.RePasswordTB = new System.Windows.Forms.TextBox();
            this.RegistrationLB = new System.Windows.Forms.Label();
            this.RegistrationBN = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.CourseTB);
            this.Background.Controls.Add(this.PassportTB);
            this.Background.Controls.Add(this.NumberTB);
            this.Background.Controls.Add(this.MiddleNameTB);
            this.Background.Controls.Add(this.LastNameTB);
            this.Background.Controls.Add(this.FirstNameTB);
            this.Background.Controls.Add(this.RePasswordTB);
            this.Background.Controls.Add(this.RegistrationLB);
            this.Background.Controls.Add(this.RegistrationBN);
            this.Background.Controls.Add(this.PasswordTB);
            this.Background.Controls.Add(this.LoginTB);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1184, 761);
            this.Background.TabIndex = 0;
            // 
            // CourseTB
            // 
            this.CourseTB.BackColor = System.Drawing.SystemColors.Window;
            this.CourseTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourseTB.ForeColor = System.Drawing.Color.Gray;
            this.CourseTB.Location = new System.Drawing.Point(422, 343);
            this.CourseTB.Name = "CourseTB";
            this.CourseTB.Size = new System.Drawing.Size(344, 40);
            this.CourseTB.TabIndex = 6;
            this.CourseTB.Text = "Курс";
            this.CourseTB.Enter += new System.EventHandler(this.CourseTB_Enter);
            this.CourseTB.Leave += new System.EventHandler(this.CourseTB_Leave);
            // 
            // PassportTB
            // 
            this.PassportTB.BackColor = System.Drawing.SystemColors.Window;
            this.PassportTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportTB.ForeColor = System.Drawing.Color.Gray;
            this.PassportTB.Location = new System.Drawing.Point(422, 297);
            this.PassportTB.Name = "PassportTB";
            this.PassportTB.Size = new System.Drawing.Size(344, 40);
            this.PassportTB.TabIndex = 5;
            this.PassportTB.Text = "Серия и номер паспорта";
            this.PassportTB.Enter += new System.EventHandler(this.PassportTB_Enter);
            this.PassportTB.Leave += new System.EventHandler(this.PassportTB_Leave);
            // 
            // NumberTB
            // 
            this.NumberTB.BackColor = System.Drawing.SystemColors.Window;
            this.NumberTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberTB.ForeColor = System.Drawing.Color.Gray;
            this.NumberTB.Location = new System.Drawing.Point(422, 251);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(344, 40);
            this.NumberTB.TabIndex = 4;
            this.NumberTB.Text = "Номер телефона";
            this.NumberTB.Enter += new System.EventHandler(this.NumberTB_Enter);
            this.NumberTB.Leave += new System.EventHandler(this.NumberTB_Leave);
            // 
            // MiddleNameTB
            // 
            this.MiddleNameTB.BackColor = System.Drawing.SystemColors.Window;
            this.MiddleNameTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameTB.ForeColor = System.Drawing.Color.Gray;
            this.MiddleNameTB.Location = new System.Drawing.Point(422, 205);
            this.MiddleNameTB.Name = "MiddleNameTB";
            this.MiddleNameTB.Size = new System.Drawing.Size(344, 40);
            this.MiddleNameTB.TabIndex = 3;
            this.MiddleNameTB.Text = "Отчество (при наличии)";
            this.MiddleNameTB.Enter += new System.EventHandler(this.MiddleNameTB_Enter);
            this.MiddleNameTB.Leave += new System.EventHandler(this.MiddleNameTB_Leave);
            // 
            // LastNameTB
            // 
            this.LastNameTB.BackColor = System.Drawing.SystemColors.Window;
            this.LastNameTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTB.ForeColor = System.Drawing.Color.Gray;
            this.LastNameTB.Location = new System.Drawing.Point(422, 159);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(344, 40);
            this.LastNameTB.TabIndex = 2;
            this.LastNameTB.Text = "Фамилия";
            this.LastNameTB.Enter += new System.EventHandler(this.LastNameTB_Enter);
            this.LastNameTB.Leave += new System.EventHandler(this.LastNameTB_Leave);
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.BackColor = System.Drawing.SystemColors.Window;
            this.FirstNameTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTB.ForeColor = System.Drawing.Color.Gray;
            this.FirstNameTB.Location = new System.Drawing.Point(422, 113);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(344, 40);
            this.FirstNameTB.TabIndex = 1;
            this.FirstNameTB.Text = "Имя";
            this.FirstNameTB.Enter += new System.EventHandler(this.FirstNameTB_Enter);
            this.FirstNameTB.Leave += new System.EventHandler(this.FirstNameTB_Leave);
            // 
            // RePasswordTB
            // 
            this.RePasswordTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RePasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.RePasswordTB.Location = new System.Drawing.Point(422, 501);
            this.RePasswordTB.Name = "RePasswordTB";
            this.RePasswordTB.Size = new System.Drawing.Size(344, 40);
            this.RePasswordTB.TabIndex = 8;
            this.RePasswordTB.Text = "Повторите пароль";
            this.RePasswordTB.TextChanged += new System.EventHandler(this.RePasswordTB_TextChanged);
            this.RePasswordTB.Enter += new System.EventHandler(this.RePasswordTB_Enter);
            this.RePasswordTB.Leave += new System.EventHandler(this.RePasswordTB_Leave);
            // 
            // RegistrationLB
            // 
            this.RegistrationLB.AutoSize = true;
            this.RegistrationLB.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLB.Location = new System.Drawing.Point(415, 25);
            this.RegistrationLB.Name = "RegistrationLB";
            this.RegistrationLB.Size = new System.Drawing.Size(189, 39);
            this.RegistrationLB.TabIndex = 10;
            this.RegistrationLB.Text = "Регистрация";
            // 
            // RegistrationBN
            // 
            this.RegistrationBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationBN.Location = new System.Drawing.Point(526, 551);
            this.RegistrationBN.Name = "RegistrationBN";
            this.RegistrationBN.Size = new System.Drawing.Size(138, 47);
            this.RegistrationBN.TabIndex = 9;
            this.RegistrationBN.Text = "Регистрация";
            this.RegistrationBN.UseVisualStyleBackColor = true;
            this.RegistrationBN.Click += new System.EventHandler(this.RegistrationBN_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTB.Location = new System.Drawing.Point(422, 455);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(344, 40);
            this.PasswordTB.TabIndex = 7;
            this.PasswordTB.Text = "Пароль";
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTB_TextEnter);
            this.PasswordTB.Leave += new System.EventHandler(this.PasswordTB_Leave);
            // 
            // LoginTB
            // 
            this.LoginTB.BackColor = System.Drawing.SystemColors.Window;
            this.LoginTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.ForeColor = System.Drawing.Color.Gray;
            this.LoginTB.Location = new System.Drawing.Point(422, 67);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(344, 40);
            this.LoginTB.TabIndex = 0;
            this.LoginTB.Text = "Логин (Email)";
            this.LoginTB.Enter += new System.EventHandler(this.LoginTB_TextEnter);
            this.LoginTB.Leave += new System.EventHandler(this.LoginTB_Leave);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Background);
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.TextBox RePasswordTB;
        private System.Windows.Forms.Label RegistrationLB;
        private System.Windows.Forms.Button RegistrationBN;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox MiddleNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox PassportTB;
        private System.Windows.Forms.TextBox NumberTB;
        private System.Windows.Forms.TextBox CourseTB;
    }
}