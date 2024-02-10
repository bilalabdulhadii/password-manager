using PasswordManager.Classes;
using PasswordManager.DataActionsForms;
using PasswordManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PasswordManager
{
    public partial class SettingsForm : Form
    {
        User CurrentUser = new User();
        public SettingsForm(int id, string email, string username, string firstname, string lastname, string password, int phone)
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon, TitleLbl);
            CurrentUser.id = id;
            CurrentUser.email = email;
            CurrentUser.username = username;
            CurrentUser.firstname = firstname;
            CurrentUser.lastname = lastname;
            CurrentUser.password = password;
            CurrentUser.phone = phone;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            EmailTextBox.Text = CurrentUser.email;
            UsernameTextBox.Text = CurrentUser.username;
            FirstnameTextBox.Text = CurrentUser.firstname;
            LastnameTextBox.Text = CurrentUser.lastname;
            PhoneNumberTextBox.Text = Convert.ToString(CurrentUser.phone);

            CheckDefaults();
            CheckDeletedRecords();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (IsPersonalInfoChanged())
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE users SET username = @username, firstname = @firstname, lastname = @lastname, phone = @phone WHERE id = @id AND email = @email;";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", CurrentUser.id);
                        command.Parameters.AddWithValue("@email", CurrentUser.email);
                        command.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                        command.Parameters.AddWithValue("@firstname", FirstnameTextBox.Text);
                        command.Parameters.AddWithValue("@lastname", LastnameTextBox.Text);
                        command.Parameters.AddWithValue("@phone", Convert.ToInt32(PhoneNumberTextBox.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Record updated successfully
                            this.Close();
                        }
                        else
                        {
                            CustomMessageBoxForm.Show("Failed to update the record. Please try again.", "Update Error", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else if (IsDefaultsChanged())
            {
                UpdateDefaults();
                this.Close();
            }
        }

        private bool IsPersonalInfoChanged()
        {
            // Check if any data has been changed
            bool isChanged = UsernameTextBox.Text != CurrentUser.username ||
                             FirstnameTextBox.Text != CurrentUser.firstname ||
                             LastnameTextBox.Text != CurrentUser.lastname ||
                             PhoneNumberTextBox.Text != Convert.ToString(CurrentUser.phone);


            return isChanged;
        }

        private bool IsDefaultsChanged()
        {
            string defaultFolderPath = "";
            string defaultFileName = "";
            int DefaultFormat = 0;
            string DefaultCharList = "";

            // Check if any data has been changed
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // SQL command to retrieve defaults for the current user
                string defaultsQuery = "SELECT default_path, default_filename, default_format, default_char_list FROM defaults WHERE userid = @userid;";

                using (SQLiteCommand defaultsCommand = new SQLiteCommand(defaultsQuery, connection))
                {
                    defaultsCommand.Parameters.AddWithValue("@userid", CurrentUser.id);

                    using (SQLiteDataReader reader = defaultsCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User has defaults, compare with entered data
                            defaultFolderPath = Convert.ToString(reader["default_path"]);
                            defaultFileName = Convert.ToString(reader["default_filename"]);
                            DefaultFormat = Convert.ToInt32(reader["default_format"]);
                            DefaultCharList = Convert.ToString(reader["default_char_list"]);
                        }
                    }
                }
            }
            bool isChanged = DefaultPathTextBox.Text != defaultFolderPath ||
                             DefaultNameTextBox.Text != defaultFileName ||
                             DefaultFormatComboBox.SelectedIndex != DefaultFormat ||
                             DefaultCharListTextBox.Text != DefaultCharList;

            return isChanged;
        }

        private void CheckDefaults()
        {
            string[] itemsArray = { "Excel files (*.xlsx)", "PDF (*.pdf)", "TEXT (*.txt)", "WEB PAGE (*.html)" };
            DefaultFormatComboBox.Items.AddRange(itemsArray);

            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // SQL command to retrieve defaults for the current user
                string defaultsQuery = "SELECT default_path, default_filename, default_format, default_char_list FROM defaults WHERE userid = @userid;";

                using (SQLiteCommand defaultsCommand = new SQLiteCommand(defaultsQuery, connection))
                {
                    defaultsCommand.Parameters.AddWithValue("@userid", CurrentUser.id);

                    using (SQLiteDataReader reader = defaultsCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User has defaults, populate controls
                            DefaultPathTextBox.Text = Convert.ToString(reader["default_path"]);
                            DefaultNameTextBox.Text = Convert.ToString(reader["default_filename"]);
                            DefaultFormatComboBox.SelectedIndex = Convert.ToInt32(reader["default_format"]);
                            DefaultCharListTextBox.Text = Convert.ToString(reader["default_char_list"]);
                        }
                        else
                        {
                            // User doesn't have defaults, set default values
                            InsertDefaults();
                            CheckDefaults();
                        }
                    }
                }
            }
        }

        private void InsertDefaults()
        {
            string defaultFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string defaultFileName = "records";
            int DefaultFormat = 0;
            string DefaultCharList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.-_*@#&";

            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // SQL command to insert defaults for the current user
                string insertQuery = "INSERT INTO defaults (userid, default_path, default_filename, default_format, default_char_list) VALUES (@userid, @defaultPath, @defaultFilename, @defaultFormat, @defaultCharList);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                    insertCommand.Parameters.AddWithValue("@defaultPath", defaultFolderPath);
                    insertCommand.Parameters.AddWithValue("@defaultFilename", defaultFileName);
                    insertCommand.Parameters.AddWithValue("@defaultFormat", DefaultFormat);
                    insertCommand.Parameters.AddWithValue("@defaultCharList", DefaultCharList);

                    int rowsInserted = insertCommand.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        // Defaults inserted successfully
                    }
                    else
                    {
                        // Failed to insert defaults
                    }
                }
            }
        }

        private void UpdateDefaults()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // SQL command to update defaults for the current user
                string updateQuery = "UPDATE defaults SET default_path = @defaultPath, default_filename = @defaultFilename, default_format = @defaultFormat, default_char_list = @defaultCharList WHERE userid = @userid;";

                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                    updateCommand.Parameters.AddWithValue("@defaultPath", DefaultPathTextBox.Text);
                    updateCommand.Parameters.AddWithValue("@defaultFilename", DefaultNameTextBox.Text);
                    updateCommand.Parameters.AddWithValue("@defaultFormat", DefaultFormatComboBox.SelectedIndex);
                    updateCommand.Parameters.AddWithValue("@defaultCharList", DefaultCharListTextBox.Text);

                    int rowsUpdated = updateCommand.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        // Defaults updated successfully
                    }
                    else
                    {
                        // Failed to update defaults
                    }
                }
            }
        }

        private void UpdateSaveButtonState()
        {
            // Enable the Save button if user data is changed, otherwise disable i
            SaveBtn.Enabled = IsPersonalInfoChanged() || IsDefaultsChanged();
        }

        private void CheckDeletedRecords()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // SQL command to count the number of records in the deleted_records table for the current user
                string countQuery = "SELECT COUNT(*) FROM deleted_records WHERE userid = @userid;";

                using (SQLiteCommand countCommand = new SQLiteCommand(countQuery, connection))
                {
                    countCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                    int recordCount = Convert.ToInt32(countCommand.ExecuteScalar());
                    
                    if (recordCount > 0)
                    {
                        // Records exist in deleted_records table for the current user
                        ShowAllDeletedBtn.Enabled = true;
                        ExportDeletedRecordsBtn.Enabled = true;
                        RestoreAllDeletedBtn.Enabled = true;
                        DestroyAllDeletedBtn.Enabled = true;
                        DeletedRecordsCountLbl.Text = recordCount.ToString() + " Deleted Records.";
                    }
                    else
                    {
                        // No records in deleted_records table for the current user
                        ShowAllDeletedBtn.Enabled = false;
                        ExportDeletedRecordsBtn.Enabled = false;
                        RestoreAllDeletedBtn.Enabled = false;
                        DestroyAllDeletedBtn.Enabled = false;
                        DeletedRecordsCountLbl.Text = "No Deleted Records.";
                    }
                }
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(CurrentUser.id);
            changePasswordForm.ShowDialog();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            ExportForm exportFile = new ExportForm(CurrentUser.id);
            exportFile.ShowDialog();
        }

        private void ShowAllDeletedBtn_Click(object sender, EventArgs e)
        {
            DeletedRecordsForm deletedRecordsForm = new DeletedRecordsForm(CurrentUser.id);
            deletedRecordsForm.ShowDialog();
        }

        private void ExportDeletedRecordsBtn_Click(object sender, EventArgs e)
        {
            ExportDeletedRecordsForm exportFile = new ExportDeletedRecordsForm(CurrentUser.id);
            exportFile.ShowDialog();
        }

        private void DestroyAllDeletedBtn_Click(object sender, EventArgs e)
        {
            // Ask for confirmation from the user
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to destroy all deleted records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        // SQL command to delete all records from the deleted_records table for the current user
                        string deleteQuery = "DELETE FROM deleted_records WHERE userid = @userid;";

                        using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                            // Execute the command to delete all records
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Records deleted successfully
                                CustomMessageBoxForm.Show("All records have been destroyed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CheckDeletedRecords();
                            }
                            else
                            {
                                // No records deleted
                                CustomMessageBoxForm.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    CustomMessageBoxForm.Show("Error destroying deleted records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RestoreAllDeletedBtn_Click(object sender, EventArgs e)
        {
            // Display a message box to confirm the restore operation
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to restore all records?", "Restore Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call a method to restore records
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
                            restoreCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                            // Execute the command to restore records
                            int rowsAffected = restoreCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Records restored successfully
                                CustomMessageBoxForm.Show("Records restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Now, delete the restored records for the current user from deleted_records table
                                string deleteQuery = "DELETE FROM deleted_records WHERE userid = @userid;";
                                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@userid", CurrentUser.id);

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

        private void BrowseIcon_Click(object sender, EventArgs e)
        {
            // Open a folder browser dialog
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Get the default path from the database
                string defaultPath = "";

                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        string query = "SELECT default_path FROM defaults WHERE userid = @userid;";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@userid", CurrentUser.id);
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                defaultPath = result.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine("Error retrieving default path: " + ex.Message);
                }

                // Set the selected path to the default path if it's not empty
                if (!string.IsNullOrEmpty(defaultPath))
                {
                    folderBrowserDialog.SelectedPath = defaultPath;
                }
                else
                {
                    folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                }

                // Show the folder browser dialog
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                // If the user selects a folder, update the path in the text box
                if (dialogResult == DialogResult.OK)
                {
                    DefaultPathTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
            // Check if the username is empty
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                // Display a message or perform any action for an empty username
                InvalidLbl.Text = "The username can not be empty.";
                InvalidLbl.Visible = true;
                SaveBtn.Enabled = false;
                return;
            }

            // Query the database to check if the entered username already exists
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                    command.Parameters.AddWithValue("@id", CurrentUser.id);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        // Username already exists
                        if (UsernameTextBox.Text != CurrentUser.username)
                        {
                            InvalidLbl.Text = "Username already exists.";
                            InvalidLbl.Visible = true;
                            SaveBtn.Enabled = false;
                        }
                        // Display a message or perform any action to indicate that the username is not unique
                    }
                    else
                    {
                        // Username is unique
                        InvalidLbl.Visible = false;
                        SaveBtn.Enabled = true;
                        // Perform any action for a unique username
                    }
                }
            }
        }

        private void FirstnameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
            if (string.IsNullOrEmpty(FirstnameTextBox.Text))
            {
                InvalidLbl.Text = "Please fill in all required fields.";
                InvalidLbl.Visible = true;
                SaveBtn.Enabled = false;
            }
            else
            {
                InvalidLbl.Visible = false;
                //SaveBtn.Enabled = true;
            }
        }

        private void LastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
            if (string.IsNullOrEmpty(LastnameTextBox.Text))
            {
                InvalidLbl.Text = "Please fill in all required fields.";
                InvalidLbl.Visible = true;
                SaveBtn.Enabled = false;
            }
            else
            {
                InvalidLbl.Visible = false;
                //SaveBtn.Enabled = true;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
            // Check if the phone is empty
            if (string.IsNullOrEmpty(PhoneNumberTextBox.Text))
            {
                // Display a message or perform any action for an empty phone

            }

            // Query the database to check if the entered phone already exists
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE phone = @phone AND id <> @id;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phone", PhoneNumberTextBox.Text);
                    command.Parameters.AddWithValue("@id", CurrentUser.id);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        // Phone Number already exists
                        InvalidLbl.Text = "Phone Number already exists.";
                        InvalidLbl.Visible = true;
                        SaveBtn.Enabled = false;
                        // Display a message or perform any action to indicate that the phone is not unique
                    }
                    else
                    {
                        // phone Number is unique
                        InvalidLbl.Visible = false;
                        //SaveBtn.Enabled = true;
                        // Perform any action for a unique phone
                    }
                }
            }
        }

        private void DefaultPathTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
            if (string.IsNullOrEmpty(DefaultPathTextBox.Text))
            {
                InvalidLbl.Text = "Please fill in all required fields.";
                InvalidLbl.Visible = true;
                SaveBtn.Enabled = false;
            }
            else
            {
                InvalidLbl.Visible = false;
                //SaveBtn.Enabled = true;
            }
        }

        private void DefaultNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
            if (string.IsNullOrEmpty(DefaultNameTextBox.Text))
            {
                InvalidLbl.Text = "Please fill in all required fields.";
                InvalidLbl.Visible = true;
                SaveBtn.Enabled = false;
            }
            else
            {
                InvalidLbl.Visible = false;
                //SaveBtn.Enabled = true;
            }
        }

        private void DefaultCharListTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
            if (string.IsNullOrEmpty(DefaultCharListTextBox.Text))
            {
                InvalidLbl.Text = "Please fill in all required fields.";
                InvalidLbl.Visible = true;
                SaveBtn.Enabled = false;
            }
            else
            {
                InvalidLbl.Visible = false;
                //SaveBtn.Enabled = true;
            }
        }

        private void DefaultFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void DeleteAllDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to delete all your data? This action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int recordsDeleted = 0;
                    int deletedRecordsDeleted = 0;
                    int defaultsDeleted = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        // Delete records from the 'records' table for the current user
                        string deleteRecordsQuery = "DELETE FROM records WHERE userid = @userid;";
                        using (SQLiteCommand deleteRecordsCommand = new SQLiteCommand(deleteRecordsQuery, connection))
                        {
                            deleteRecordsCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                            recordsDeleted = deleteRecordsCommand.ExecuteNonQuery();
                        }

                        // Delete records from the 'deleted_records' table for the current user
                        string deleteDeletedRecordsQuery = "DELETE FROM deleted_records WHERE userid = @userid;";
                        using (SQLiteCommand deleteDeletedRecordsCommand = new SQLiteCommand(deleteDeletedRecordsQuery, connection))
                        {
                            deleteDeletedRecordsCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                            deletedRecordsDeleted = deleteDeletedRecordsCommand.ExecuteNonQuery();
                        }

                        // Delete user defaults if they exist
                        string deleteDefaultsQuery = "DELETE FROM defaults WHERE userid = @userid;";
                        using (SQLiteCommand deleteDefaultsCommand = new SQLiteCommand(deleteDefaultsQuery, connection))
                        {
                            deleteDefaultsCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                            defaultsDeleted = deleteDefaultsCommand.ExecuteNonQuery();
                        }
                    }

                    // Display a message indicating the deletion results
                    CustomMessageBoxForm.Show("All data deleted successfully.", "Data Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    CustomMessageBoxForm.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetDefaultsBtn_Click(object sender, EventArgs e)
        {
            // Ask for confirmation from the user
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to reset your defaults?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        // SQL command to delete defaults of the current user
                        string deleteQuery = "DELETE FROM defaults WHERE userid = @userid;";

                        using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@userid", CurrentUser.id);

                            // Execute the command to delete defaults
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Defaults deleted successfully
                                CheckDefaults();
                            }
                            else
                            {
                                // No defaults deleted
                                CustomMessageBoxForm.Show("No defaults found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    CustomMessageBoxForm.Show("Error resetting defaults: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteAccountBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to delete your account? This action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        // Delete all data associated with the user
                        string deleteDataQuery = "DELETE FROM records WHERE userid = @userid; " +
                                                 "DELETE FROM deleted_records WHERE userid = @userid; " +
                                                 "DELETE FROM defaults WHERE userid = @userid;";

                        using (SQLiteCommand deleteDataCommand = new SQLiteCommand(deleteDataQuery, connection))
                        {
                            deleteDataCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                            deleteDataCommand.ExecuteNonQuery();
                        }

                        // Delete the user
                        string deleteUserQuery = "DELETE FROM users WHERE id = @userid;";
                        using (SQLiteCommand deleteUserCommand = new SQLiteCommand(deleteUserQuery, connection))
                        {
                            deleteUserCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                            int rowsAffected = deleteUserCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // User deleted successfully
                                //CustomMessageBoxForm.Show("Your account has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Close the current form and return to the login form

                                //LoginForm loginForm = new LoginForm();
                                //loginForm.Show();
                                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                                if (mainForm != null)
                                {
                                    mainForm.ReloadMainFormAfterDeletingAccount(); // Reload Main Form
                                }
                                this.Close();
                            }
                            else
                            {
                                // User not found or not deleted
                                CustomMessageBoxForm.Show("Failed to delete your account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    CustomMessageBoxForm.Show("Error deleting account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
