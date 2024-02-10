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

namespace PasswordManager
{
    public partial class DeletedRecordsForm : Form
    {
        private int userid;
        public int counter;
        private int SelectedRecordId;
        public DeletedRecordsForm(int userid)
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon, DeletedRecordsLbl);
            this.userid = userid;
        }

        private void DeletedRecordsForm_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void LoadRecords()
        {
            // Fetch user records from the database based on the username
            List<Record> Records = GetUserRecords();

            RecordsTable.Rows.Clear(); // Clear existing rows
            insertToTable(Records);
        }

        private List<Record> GetUserRecords()
        {
            List<Record> userRecords = new List<Record>();

            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT id, url, username, password, note FROM deleted_records WHERE userid = @userid;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userid", userid);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Record record = new Record
                            {
                                id = Convert.ToInt32(reader["id"]),
                                url = Convert.ToString(reader["url"]),
                                username = Convert.ToString(reader["username"]),
                                password = Convert.ToString(reader["password"]),
                                note = Convert.ToString(reader["note"])
                            };
                            userRecords.Add(record);
                        }
                    }
                }
            }
            return userRecords;
        }

        private void insertToTable(List<Record> records)
        {
            counter = 0;
            RecordsTable.Rows.Clear(); // Clear existing rows
            // Bind the records to the DataGridView
            foreach (Record record in records)
            {
                RecordsTable.Rows.Add(record.id, record.url, record.username, record.password, record.note);
                counter++;
            }
            RecordCounterLbl.Text = counter + " Records exist.";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestoreAllBtn_Click(object sender, EventArgs e)
        {
            // Display a message box to confirm the restore operation
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to restore all deleted records?", "Restore Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        // SQL command to restore records from deleted_records to records for the current user
                        string restoreQuery = "INSERT INTO records (userid, url, username, password, note) " +
                                              "SELECT userid, url, username, password, note FROM deleted_records WHERE userid = @userid;";

                        using (SQLiteCommand restoreCommand = new SQLiteCommand(restoreQuery, connection))
                        {
                            restoreCommand.Parameters.AddWithValue("@userid", userid);

                            // Execute the command to restore records
                            int rowsAffected = restoreCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Records restored successfully
                                CustomMessageBoxForm.Show("Records restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Now, delete the restored records from the deleted_records table
                                string deleteQuery = "DELETE FROM deleted_records WHERE userid = @userid;";
                                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@userid", userid);

                                    // Execute the command to delete restored records from deleted_records table
                                    int deleteRowsAffected = deleteCommand.ExecuteNonQuery();

                                    if (deleteRowsAffected > 0)
                                    {
                                        // Deleted restored records successfully from deleted_records table
                                        // Optionally, you can inform the user or handle the success scenario here
                                    }
                                    else
                                    {
                                        // No records deleted from deleted_records table
                                        // Optionally, you can inform the user or handle the scenario here
                                    }
                                }
                                this.Close();
                            }
                            else
                            {
                                // No records restored
                                CustomMessageBoxForm.Show("No records restored.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    CustomMessageBoxForm.Show("Error restoring records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RecordsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestoreSelectedBtn.Enabled = true;
            DestroySelectedBtn.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RecordsTable.Rows[e.RowIndex];
                SelectedRecordId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }

        private void RestoreSelectedBtn_Click(object sender, EventArgs e)
        {
            // Check if a record is selected in the DataGridView
            if (SelectedRecordId != 0)
            {
                DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to restore the selected record?", "Restore Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                        {
                            connection.Open();

                            // SQL command to restore the selected record from deleted_records to records
                            string restoreQuery = "INSERT INTO records (userid, url, username, password, note) " +
                                                  "SELECT userid, url, username, password, note FROM deleted_records WHERE id = @recordId;";

                            using (SQLiteCommand restoreCommand = new SQLiteCommand(restoreQuery, connection))
                            {
                                restoreCommand.Parameters.AddWithValue("@recordId", SelectedRecordId);

                                // Execute the command to restore the selected record
                                int rowsAffected = restoreCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Record restored successfully
                                    //CustomMessageBoxForm.Show("Selected record restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Now, delete the restored record from the deleted_records table
                                    string deleteQuery = "DELETE FROM deleted_records WHERE id = @recordId;";
                                    using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                                    {
                                        deleteCommand.Parameters.AddWithValue("@recordId", SelectedRecordId);

                                        // Execute the command to delete the restored record from deleted_records table
                                        int deleteRowsAffected = deleteCommand.ExecuteNonQuery();
                                    }
                                    LoadRecords();
                                }
                                else
                                {
                                    // No record restored
                                    CustomMessageBoxForm.Show("No record restored.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        CustomMessageBoxForm.Show("Error restoring selected record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                CustomMessageBoxForm.Show("Please select a record to restore.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DestroySelectedBtn_Click(object sender, EventArgs e)
        {
            if (SelectedRecordId != 0)
            {
                DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to destroy the selected record permanently?", "Destroy Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                        {
                            connection.Open();

                            // SQL command to destroy the selected record from deleted_records
                            string destroyQuery = "DELETE FROM deleted_records WHERE id = @recordId;";

                            using (SQLiteCommand destroyCommand = new SQLiteCommand(destroyQuery, connection))
                            {
                                destroyCommand.Parameters.AddWithValue("@recordId", SelectedRecordId);

                                // Execute the command to destroy the selected record
                                int rowsAffected = destroyCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    LoadRecords();
                                }
                                else
                                {
                                    // No record destroyed
                                    CustomMessageBoxForm.Show("No record destroyed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        CustomMessageBoxForm.Show("Error destroying selected record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                CustomMessageBoxForm.Show("Please select a record to destroy.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DestroyAllBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to destroy all deleted records permanently?", "Destroy Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        // SQL command to destroy records from deleted_records
                        string destroyQuery = "DELETE FROM deleted_records WHERE userid = @userid;";

                        using (SQLiteCommand destroyCommand = new SQLiteCommand(destroyQuery, connection))
                        {
                            destroyCommand.Parameters.AddWithValue("@userid", userid);

                            // Execute the command to destroy records
                            int rowsAffected = destroyCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Records destroyed successfully
                                CustomMessageBoxForm.Show("Records destroyed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                // No records destroyed
                                CustomMessageBoxForm.Show("No records destroyed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    CustomMessageBoxForm.Show("Error destroying records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
