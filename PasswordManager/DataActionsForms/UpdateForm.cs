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
    public partial class UpdateForm : Form
    {
        Record selectedRecord = new Record();
        public UpdateForm(int userid, int id, string url, string username, string password, string note)
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon);
            selectedRecord.id = id;
            selectedRecord.userid = userid;
            selectedRecord.url = url;
            selectedRecord.username = username;
            selectedRecord.password = password;
            selectedRecord.note = note;

            UrlTextBox.Text = url;
            UsernameTextBox.Text = username;
            PasswordTextBox.Text = password;
            NoteTextBox.Text = note;
        }
        
        private void UpdateBtn_Click(object sender, EventArgs e)
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

            // Update the account to the database
            updateRecord();
        }

        private void updateRecord()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "UPDATE records SET url = @url, username = @username, password = @password, note = @note WHERE userid = @userid AND id = @id;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", selectedRecord.id);
                    command.Parameters.AddWithValue("@userid", selectedRecord.userid);
                    command.Parameters.AddWithValue("@url", UrlTextBox.Text);
                    command.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                    command.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                    command.Parameters.AddWithValue("@note", NoteTextBox.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Record updated successfully
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the record. Please try again.", "Update Error", MessageBoxButtons.OK);
                    }
                }
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
                        command.Parameters.AddWithValue("@userid", selectedRecord.userid);
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
