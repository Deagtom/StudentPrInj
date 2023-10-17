namespace StudentPrInj
{
    partial class Login
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
            this.DeleteBN = new System.Windows.Forms.Button();
            this.ProjectsLB = new System.Windows.Forms.ListBox();
            this.NameL = new System.Windows.Forms.Label();
            this.InfoTB = new System.Windows.Forms.RichTextBox();
            this.ProjectLB = new System.Windows.Forms.Label();
            this.AddBN = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ProjectsL = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.ProjectsL);
            this.Background.Controls.Add(this.DeleteBN);
            this.Background.Controls.Add(this.ProjectsLB);
            this.Background.Controls.Add(this.NameL);
            this.Background.Controls.Add(this.InfoTB);
            this.Background.Controls.Add(this.ProjectLB);
            this.Background.Controls.Add(this.AddBN);
            this.Background.Controls.Add(this.NameTB);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1184, 761);
            this.Background.TabIndex = 0;
            // 
            // DeleteBN
            // 
            this.DeleteBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBN.Location = new System.Drawing.Point(816, 524);
            this.DeleteBN.Name = "DeleteBN";
            this.DeleteBN.Size = new System.Drawing.Size(138, 47);
            this.DeleteBN.TabIndex = 4;
            this.DeleteBN.Text = "Удалить";
            this.DeleteBN.UseVisualStyleBackColor = true;
            this.DeleteBN.Click += new System.EventHandler(this.DeleteBN_Click);
            // 
            // ProjectsLB
            // 
            this.ProjectsLB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectsLB.FormattingEnabled = true;
            this.ProjectsLB.ItemHeight = 33;
            this.ProjectsLB.Location = new System.Drawing.Point(223, 162);
            this.ProjectsLB.Name = "ProjectsLB";
            this.ProjectsLB.Size = new System.Drawing.Size(207, 334);
            this.ProjectsLB.TabIndex = 5;
            this.ProjectsLB.Click += new System.EventHandler(this.ProjectsLB_Click);
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameL.Location = new System.Drawing.Point(609, 98);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(250, 39);
            this.NameL.TabIndex = 0;
            this.NameL.Text = "Добавьте проект";
            // 
            // InfoTB
            // 
            this.InfoTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTB.ForeColor = System.Drawing.Color.Gray;
            this.InfoTB.Location = new System.Drawing.Point(610, 201);
            this.InfoTB.Name = "InfoTB";
            this.InfoTB.Size = new System.Drawing.Size(344, 310);
            this.InfoTB.TabIndex = 2;
            this.InfoTB.Text = "Описание проекта";
            this.InfoTB.Enter += new System.EventHandler(this.InfoTB_Enter);
            this.InfoTB.Leave += new System.EventHandler(this.InfoTB_Leave);
            // 
            // ProjectLB
            // 
            this.ProjectLB.AutoSize = true;
            this.ProjectLB.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectLB.Location = new System.Drawing.Point(603, 98);
            this.ProjectLB.Name = "ProjectLB";
            this.ProjectLB.Size = new System.Drawing.Size(0, 39);
            this.ProjectLB.TabIndex = 9;
            // 
            // AddBN
            // 
            this.AddBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBN.Location = new System.Drawing.Point(603, 524);
            this.AddBN.Name = "AddBN";
            this.AddBN.Size = new System.Drawing.Size(138, 47);
            this.AddBN.TabIndex = 3;
            this.AddBN.Text = "Добавить";
            this.AddBN.UseVisualStyleBackColor = true;
            this.AddBN.Click += new System.EventHandler(this.AddBN_Click);
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.SystemColors.Window;
            this.NameTB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.ForeColor = System.Drawing.Color.Gray;
            this.NameTB.Location = new System.Drawing.Point(610, 155);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(344, 40);
            this.NameTB.TabIndex = 1;
            this.NameTB.Text = "Название проекта";
            this.NameTB.Enter += new System.EventHandler(this.NameTB_Enter);
            this.NameTB.Leave += new System.EventHandler(this.NameTB_Leave);
            // 
            // ProjectsL
            // 
            this.ProjectsL.AutoSize = true;
            this.ProjectsL.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectsL.Location = new System.Drawing.Point(223, 98);
            this.ProjectsL.Name = "ProjectsL";
            this.ProjectsL.Size = new System.Drawing.Size(250, 39);
            this.ProjectsL.TabIndex = 0;
            this.ProjectsL.Text = "Список проектов";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Background);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ProjectsL;

        private System.Windows.Forms.Button DeleteBN;

        private System.Windows.Forms.ListBox ProjectsLB;

        private System.Windows.Forms.Label NameL;

        private System.Windows.Forms.Label ProjectLB;
        private System.Windows.Forms.Button AddBN;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.RichTextBox InfoTB;

        #endregion

        private System.Windows.Forms.Panel Background;
    }
}