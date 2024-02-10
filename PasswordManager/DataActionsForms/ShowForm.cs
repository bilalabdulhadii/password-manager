using PasswordManager.Classes;
using PasswordManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace PasswordManager.DataActions
{
    public partial class ShowForm : Form
    {
        Record selectedRecord = new Record();
        public ShowForm(int userid, int id, string url, string username, string password, string note)
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
            if (selectedRecord != null)
            {
                UpdateForm updateform = new UpdateForm(
                    selectedRecord.userid,
                    selectedRecord.id,
                    selectedRecord.url,
                    selectedRecord.username,
                    selectedRecord.password,
                    selectedRecord.note);
                updateform.ShowDialog();
            }
            reloadRecord();
        }

        private void reloadRecord()
        {
            Record record = null;

            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT url, username, password, note FROM records WHERE userid = @userid AND id = @id;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", selectedRecord.id);
                    command.Parameters.AddWithValue("@userid", selectedRecord.userid);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Check if there are rows to read
                        {
                            record = new Record
                            {
                                url = Convert.ToString(reader["url"]),
                                username = Convert.ToString(reader["username"]),
                                password = Convert.ToString(reader["password"]),
                                note = Convert.ToString(reader["note"])
                            };
                        }
                    }
                }
            }
            selectedRecord.url = record.url;
            selectedRecord.username = record.username;
            selectedRecord.password = record.password;
            selectedRecord.note = record.note;
            UrlTextBox.Text = selectedRecord.url;
            UsernameTextBox.Text = selectedRecord.username;
            PasswordTextBox.Text = selectedRecord.password;
            NoteTextBox.Text = selectedRecord.note;
        }
        
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                deleteRecord();
            }
        }

        private void deleteRecord()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // First, insert the record into the 'deleted_records' table
                string insertQuery = "INSERT INTO deleted_records (userid, url, username, password, note) " +
                                     "SELECT userid, url, username, password, note FROM records " +
                                     "WHERE userid = @userid AND id = @id;";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@id", selectedRecord.id);
                    insertCommand.Parameters.AddWithValue("@userid", selectedRecord.userid);

                    int rowsInserted = insertCommand.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        // Next, delete the record from the 'records' table
                        string deleteQuery = "DELETE FROM records WHERE userid = @userid AND id = @id;";

                        using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@id", selectedRecord.id);
                            deleteCommand.Parameters.AddWithValue("@userid", selectedRecord.userid);

                            int rowsDeleted = deleteCommand.ExecuteNonQuery();

                            if (rowsDeleted > 0)
                            {
                                this.Close();
                            }
                            else
                            {
                                CustomMessageBoxForm.Show("Failed to delete the record. Please try again.", "Delete Error", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else
                    {
                        CustomMessageBoxForm.Show("Failed to delete the record. Please try again.", "Delete Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            using (PrintDocument pd = new PrintDocument())
            {
                pd.PrintPage += new PrintPageEventHandler(PrintPage);
                pd.PrintController = new StandardPrintController(); // Set the printing to use the StandardPrintController
                //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Record.pdf");
                //pd.PrinterSettings.PrintFileName = fileName; // Set the default file name and location
                pd.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics) + 5;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Draw text on the print page
            e.Graphics.DrawString("URL: " + selectedRecord.url, font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Username: " + selectedRecord.username, font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Password: " + selectedRecord.password, font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Note: " + selectedRecord.note, font, Brushes.Black, x, y);
        }

    }
}
