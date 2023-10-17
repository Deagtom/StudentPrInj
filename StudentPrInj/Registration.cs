using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentPrInj
{
    public partial class Registration : Form
    {
        SqlConnection connection;
        SqlCommand command;

        public Registration()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DAGIR\DEAGTOM;Initial Catalog=Student;Integrated Security=SSPI");
            connection.Open();
        }

        private bool IsNewAccount()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [User]", connection);
            SqlDataReader reader = command.ExecuteReader();
            bool isNew = false;
            while (reader.Read())
            {
                if (reader[0].ToString() != LoginTB.Text && LoginTB.Text != "Логин (Email)")
                    isNew = true;
                else
                    isNew = false;
            }
            reader.Close();
            return isNew;
        }

        private void RegistrationBN_Click(object sender, EventArgs e)
        {
            if (IsNewAccount())
            {
                if (PasswordTB.Text == RePasswordTB.Text)
                {
                    string sql = "INSERT INTO [NewStudent] ([FirstName], [LastName], [MiddleName], [Course], [Email], [Number], [PassportDate], [Password]) " +
                                    $"VALUES ('{FirstNameTB.Text}', '{LastNameTB.Text}', '{MiddleNameTB.Text}', '{CourseTB.Text}', '{LoginTB.Text}', '{NumberTB.Text}', '{PassportTB.Text}', '{PasswordTB.Text}')";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("INSERT INTO [User] (Login, Password) " + $"VALUES ('{LoginTB.Text}', '{PasswordTB.Text}')", connection);
                    command.ExecuteNonQuery();
                    this.Hide();
                }
                else
                    MessageBox.Show("Пароли не совпадают.", "Ошибка!");
            }
            else
                MessageBox.Show("Такой логин уже используется.", "Ошибка!");
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e) => connection.Close();

        private void Registration_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        #region HelpMsg

        private void HelpMessageClear(TextBox textBox, string helpMsg)
        {
            if (textBox.Text == helpMsg)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void HelpMessageInsert(TextBox textBox, string helpMsg)
        {
            if (textBox.Text.Length <= 0)
            {
                textBox.Text = helpMsg;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void CheckPassword()
        {
            if (RePasswordTB.Text != PasswordTB.Text && RePasswordTB.Text != "Повторите пароль")
                RePasswordTB.ForeColor = Color.Red;
            else if (RePasswordTB.Text == "Повторите пароль")
                RePasswordTB.ForeColor = Color.Gray;
            else
                RePasswordTB.ForeColor = Color.Black;
        }

        private void LoginTB_TextEnter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Логин (Email)");

        private void LoginTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Логин (Email)");

        private void FirstNameTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Имя");

        private void FirstNameTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Имя");

        private void LastNameTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Фамилия");

        private void LastNameTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Фамилия");

        private void MiddleNameTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Отчество (при наличии)");

        private void MiddleNameTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Отчество (при наличии)");

        private void NumberTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Номер телефона");

        private void NumberTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Номер телефона");

        private void PassportTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Серия и номер паспорта");

        private void PassportTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Серия и номер паспорта");

        private void CourseTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Курс");

        private void CourseTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Курс");

        private void PasswordTB_TextEnter(object sender, EventArgs e)
        {
            TextBox password = sender as TextBox;
            HelpMessageClear(password, "Пароль");
            password.UseSystemPasswordChar = true;
        }

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            TextBox password = sender as TextBox;
            HelpMessageInsert(password, "Пароль");
            if (password.Text == "Пароль")
                password.UseSystemPasswordChar = false;
        }

        private void RePasswordTB_Enter(object sender, EventArgs e)
        {
            TextBox rePassword = sender as TextBox;
            HelpMessageClear(rePassword, "Повторите пароль");
            rePassword.UseSystemPasswordChar = true;
        }

        private void RePasswordTB_Leave(object sender, EventArgs e)
        {
            TextBox rePassword = sender as TextBox;
            HelpMessageInsert(rePassword, "Повторите пароль");
            if (rePassword.Text == "Повторите пароль")
                rePassword.UseSystemPasswordChar = false;
        }

        private void RePasswordTB_TextChanged(object sender, EventArgs e) => CheckPassword();

        private void PasswordTB_TextChanged(object sender, EventArgs e) => CheckPassword();

        #endregion
    }
}