using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentPrInj
{
    public partial class Menu : Form
    {
        SqlConnection connection;
        SqlCommand command;

        public Menu()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DAGIR\DEAGTOM;Initial Catalog=Student;Integrated Security=SSPI");
            connection.Open();
        }

        private void LoginBN_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT * FROM [User]", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == LoginTB.Text && reader[1].ToString() == PasswordTB.Text)
                {
                    Login.login = LoginTB.Text;
                    Login loginMenu = new Login();
                    this.Hide();
                    loginMenu.Show();
                }
            }
            reader.Close();
        }

        private void RegistrationBN_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e) => connection.Close();

        private void Menu_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

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

        private void LoginTB_TextEnter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Логин (Email)");

        private void LoginTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Логин (Email)");

        private void PasswordTB_TextEnter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            HelpMessageClear(textBox, "Пароль");
            if (!CheckPasswordCB.Checked)
                textBox.UseSystemPasswordChar = true;
        }

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            HelpMessageInsert(textBox, "Пароль");
            if (textBox.Text == "Пароль")
                textBox.UseSystemPasswordChar = false;
        }

        private void CheckPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPasswordCB.Checked && PasswordTB.Text != "Пароль")
                PasswordTB.UseSystemPasswordChar = false;
            else if (PasswordTB.Text != "Пароль")
                PasswordTB.UseSystemPasswordChar = true;
        }

        #endregion
    }
}
