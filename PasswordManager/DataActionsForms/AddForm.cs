using PasswordManager.Classes;
using PasswordManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.DataActions
{
    public partial class AddForm : Form
    {
        public int userid;
        public AddForm(int userid)
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon);
            this.userid = userid;
        }

        private bool AddAccount(string url, string username, string password, string note)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO records (userid, url, username, password, note) VALUES (@userId, @url, @username, @password, @note);";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userid);
                    command.Parameters.AddWithValue("@url", url);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@note", note);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string url = UrlTextBox.Text.Trim();
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string note = NoteTextBox.Text;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                InvalidLbl.Visible = true;
                return;
            }

            // Get the user ID based on the username
            
            if (userid == -1)
            {
                CustomMessageBoxForm.Show("User not found.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Add the account to the database
            if (AddAccount(url, username, password, note))
            {
                this.Close();
            }
            else
            {
                CustomMessageBoxForm.Show("Failed to add a new record. Please try again.", "Error", MessageBoxButtons.OK);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UrlTextBox.Clear();
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            NoteTextBox.Clear();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneratePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";

            // Generate a new password
            PasswordTextBox.Text = PasswordGenerator();
        }

        private void GeneratePasswordLbl_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";

            // Generate a new password
            PasswordTextBox.Text = PasswordGenerator();
        }

        private string PasswordGenerator()
        {
            string defaultCharList = "";
            string validChars = "";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT default_char_list FROM defaults WHERE userid = @userid;";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userid);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            defaultCharList = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error retrieving default char list: " + ex.Message);
            }

            if (!string.IsNullOrEmpty(defaultCharList))
            {
                validChars = defaultCharList;
            }
            else
            {
                validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.-_*@#&";
            }

            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                sb.Append(validChars[random.Next(validChars.Length)]);
            }

            return sb.ToString();
        }
    }
}
