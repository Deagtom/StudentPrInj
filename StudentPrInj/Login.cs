using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentPrInj
{
    public partial class Login : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public static string login;
        
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DAGIR\DEAGTOM;Initial Catalog=Student;Integrated Security=SSPI");
            connection.Open();
            LoadingProjects();
        }

        private void LoadingProjects()
        {
            command = new SqlCommand("SELECT * FROM [Projects]", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == login)
                    ProjectsLB.Items.Add(reader[1].ToString());
            }
            reader.Close();
        }
        
        private void ProjectsLB_Click(object sender, EventArgs e)
        {
            string name = ProjectsLB.SelectedItem.ToString();
            command = new SqlCommand("SELECT * FROM [Projects]", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == login && reader[1].ToString() == name)
                {
                    NameTB.Text = name;
                    InfoTB.Text = reader[2].ToString();
                    NameTB.ForeColor = Color.Black;
                    InfoTB.ForeColor = Color.Black;
                }
            }
            reader.Close();
        }

        private void AddBN_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO [Projects] ([ProjectName], [ProjectDescription], [Login]) VALUES ('{NameTB.Text}', '{InfoTB.Text}', '{login}')";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            ProjectsLB.Items.Add(NameTB.Text);
            NameTB.Text = string.Empty;
            InfoTB.Text = string.Empty;
        }

        private void DeleteBN_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"DELETE FROM [Projects] WHERE [ProjectName] = '{NameTB.Text}'", connection);
            command.ExecuteNonQuery();
            ProjectsLB.Items.Remove(ProjectsLB.Items[ProjectsLB.SelectedIndex]);
            NameTB.Text = string.Empty;
            InfoTB.Text = string.Empty;
        }
        
        private void Login_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void Login_FormClosing(object sender, FormClosingEventArgs e) => connection.Close();

        #region HelpMsg

        private void HelpMessageClear(TextBox textBox, string helpMsg)
        {
            if (textBox.Text == helpMsg)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }
        
        private void HelpMessageClear(RichTextBox textBox, string helpMsg)
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
        
        private void HelpMessageInsert(RichTextBox textBox, string helpMsg)
        {
            if (textBox.Text.Length <= 0)
            {
                textBox.Text = helpMsg;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void NameTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as TextBox, "Название проекта");

        private void NameTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as TextBox, "Название проекта");

        private void InfoTB_Enter(object sender, EventArgs e) => HelpMessageClear(sender as RichTextBox, "Описание проекта");

        private void InfoTB_Leave(object sender, EventArgs e) => HelpMessageInsert(sender as RichTextBox, "Описание проекта");
        
        #endregion
    }
}