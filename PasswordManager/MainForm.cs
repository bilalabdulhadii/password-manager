using Microsoft.Office.Interop.Excel;
using PasswordManager.Classes;
using PasswordManager.DataActions;
using PasswordManager.DataActionsForms;
using PasswordManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Management;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        private bool isLogin = false;
        bool allFieldsFilled = false;
        private string deviceId;
        public int UserId;
        public int counter;
        User CurrentUser = new User();
        Record SelectedRecord = new Record();

        public MainForm()
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon);
            FormMinimizing formMinimizing = new FormMinimizing(this, MinimizeLbl);
            FormMaximizing formMaximizing = new FormMaximizing(this, MaximizeLbl);

            // For Resizing Form
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Check the database
            string dbFilePath = Path.Combine(Program.DatabaseFilePath, Program.DatabaseFileName);
            if (!File.Exists(dbFilePath))
            {
                // Handle the case where the database doesn't exist
                CustomMessageBoxForm.Show("Database not found. Please create the database first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            MainFormPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
            GetDeviceID();
            AutoLogin();

            RegisterEmailTextBox.TextChanged += TextBox_TextChanged;
            RegisterUsernameTextBox.TextChanged += TextBox_TextChanged;
            RegisterFirstnameTextBox.TextChanged += TextBox_TextChanged;
            RegisterLastnameTextBox.TextChanged += TextBox_TextChanged;
            RegisterPasswordTextBox.TextChanged += TextBox_TextChanged;
            RegisterPasswordConfirmTextBox.TextChanged += TextBox_TextChanged;
        }


        // Resizing Starts
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush controlBrush = new SolidBrush(SystemColors.Control);
            e.Graphics.FillRectangle(controlBrush, Top);
            e.Graphics.FillRectangle(controlBrush, Left);
            e.Graphics.FillRectangle(controlBrush, Right);
            e.Graphics.FillRectangle(controlBrush, Bottom);
        }
        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;
        const int _ = 10;

        new System.Drawing.Rectangle Top { get { return new System.Drawing.Rectangle(0, 0, this.ClientSize.Width, _); } }
        new System.Drawing.Rectangle Left { get { return new System.Drawing.Rectangle(0, 0, _, this.ClientSize.Height); } }
        new System.Drawing.Rectangle Bottom { get { return new System.Drawing.Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        new System.Drawing.Rectangle Right { get { return new System.Drawing.Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        System.Drawing.Rectangle TopLeft { get { return new System.Drawing.Rectangle(0, 0, _, _); } }
        System.Drawing.Rectangle TopRight { get { return new System.Drawing.Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        System.Drawing.Rectangle BottomLeft { get { return new System.Drawing.Rectangle(0, this.ClientSize.Height - _, _, _); } }
        System.Drawing.Rectangle BottomRight { get { return new System.Drawing.Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        // Resizing Ends 

        private void ReloadMainForm()
        {
            UserInfoFinderByUserId();
            LoadRecords();
            RecordsTable.ClearSelection();
            UsernameLbl.Text = CurrentUser.firstname + " " + CurrentUser.lastname;
            UpdateBtn.Enabled = false; // Disable update button
            DeleteBtn.Enabled = false; // Disable delete button
            ShowBtn.Enabled = false; // Disable delete button
            SelectedUrlLbl.Visible = false; // Disable Selected URL
        }
        public void ReloadMainFormAfterDeletingAccount()
        {
            MainForm_Load(this, EventArgs.Empty);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin)
            {
                LogedOutUpdateSession(false);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void LogedOutUpdateSession(bool state)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    // Get the current value of remember_password_flag from the database
                    bool rememberPasswordFlag;
                    string selectQuery = "SELECT remember_password_flag FROM sessions WHERE userid = @userid";
                    using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                        rememberPasswordFlag = Convert.ToBoolean(selectCommand.ExecuteScalar());
                    }

                    // Update the session
                    string updateQuery = "UPDATE sessions SET logout_flag = @logoutFlag, last_close_time = @lastCloseTime, remember_password_flag = @rememberPasswordFlag WHERE userid = @userid";
                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                        updateCommand.Parameters.AddWithValue("@lastCloseTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        updateCommand.Parameters.AddWithValue("@logoutFlag", state);
                        updateCommand.Parameters.AddWithValue("@rememberPasswordFlag", state ? false : rememberPasswordFlag);

                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error updating session logout: " + ex.Message);
            }
        }

        private void LogedInUpdateSession()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT COUNT(*) FROM sessions WHERE device_id = @deviceId AND userid = @userid;";
                    using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@deviceId", deviceId);
                        selectCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                        int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            // Update existing session
                            string updateQuery = "UPDATE sessions SET logout_flag = @logoutFlag, remember_password_flag = @rememberPasswordFlag WHERE device_id = @deviceId AND userid = @userid;";
                            using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@logoutFlag", false);
                                updateCommand.Parameters.AddWithValue("@deviceId", deviceId);
                                updateCommand.Parameters.AddWithValue("@userid", CurrentUser.id);
                                if (RememberPasswordCheckBox.Checked)
                                {
                                    updateCommand.Parameters.AddWithValue("@rememberPasswordFlag", true);
                                }
                                else
                                {
                                    updateCommand.Parameters.AddWithValue("@rememberPasswordFlag", false);
                                }
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert new session
                            string insertQuery = "INSERT INTO sessions (userid, device_id, username, password, logout_flag, remember_password_flag) VALUES (@userId, @deviceId, @username, @password, @logoutFlag, @rememberPasswordFlag);";
                            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@userId", CurrentUser.id);
                                insertCommand.Parameters.AddWithValue("@deviceId", deviceId);
                                insertCommand.Parameters.AddWithValue("@username", CurrentUser.username);
                                insertCommand.Parameters.AddWithValue("@password", CurrentUser.password);
                                insertCommand.Parameters.AddWithValue("@logoutFlag", false);
                                if (RememberPasswordCheckBox.Checked)
                                {
                                    insertCommand.Parameters.AddWithValue("@rememberPasswordFlag", true);
                                }
                                else
                                {
                                    insertCommand.Parameters.AddWithValue("@rememberPasswordFlag", false);
                                }
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error updating session: " + ex.Message);
            }
        }

        private void UserInfoFinderByUserId()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT email, username, firstname, lastname, password, phone FROM users WHERE id = @id;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", UserId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Check if there are rows to read
                        {
                            CurrentUser = new User
                            {
                                id = UserId,
                                email = Convert.ToString(reader["email"]),
                                username = Convert.ToString(reader["username"]),
                                firstname = Convert.ToString(reader["firstname"]),
                                lastname = Convert.ToString(reader["lastname"]),
                                password = Convert.ToString(reader["password"]),
                                phone = reader["phone"] != DBNull.Value ? Convert.ToInt32(reader["phone"]) : 0
                            };
                        }
                    }
                }
            }
        }

        private void LoadRecords()
        {
            // Fetch user records from the database based on the username
            List<Record> Records = GetUserRecords();

            RecordsTable.Rows.Clear(); // Clear existing rows
            insertToTable(Records);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(CurrentUser.id);
            addForm.userid = CurrentUser.id;
            addForm.FormClosed += Form_FormClosed;
            addForm.Show();
        }

        private List<Record> GetUserRecords()
        {
            List<Record> userRecords = new List<Record>();

            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT id, url, username, password, note FROM records WHERE userid = @userid;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userid", CurrentUser.id);

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

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (SelectedRecord != null)
            {
                ShowForm showform = new ShowForm(
                    CurrentUser.id,
                    SelectedRecord.id,
                    SelectedRecord.url,
                    SelectedRecord.username,
                    SelectedRecord.password,
                    SelectedRecord.note);
                showform.FormClosed += Form_FormClosed;
                showform.Show();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (SelectedRecord != null)
            {
                UpdateForm updateform = new UpdateForm(
                    CurrentUser.id,
                    SelectedRecord.id,
                    SelectedRecord.url,
                    SelectedRecord.username,
                    SelectedRecord.password,
                    SelectedRecord.note);
                updateform.FormClosed += Form_FormClosed;
                updateform.Show();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBoxForm.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                deleteRecord();
                UpdateBtn.Enabled = false; // Disable update button after deletion
                DeleteBtn.Enabled = false; // Disable delete button after deletion
                ShowBtn.Enabled = false; // Disable delete button after deletion
                SelectedUrlLbl.Visible = false; // Disable Selected URL after deletion
            }
        }

        private void HelpIcon_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            LoggedOut();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameOrEmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            CheckUsername(username);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                invalidLbl.Visible = true;
                invalidLbl.Text = "Please enter both username and password.";
                return;
            }

            // Check login credentials
            if (AuthenticateUser(username, password))
            {
                ReloadMainForm();
                LoggedIn();
            }
            else
            {
                invalidLbl.Text = "Invalid username or password, Login Error.";
                invalidLbl.Visible = true;
            }
        }

        private void AutoLogin()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    // Check if there are any active sessions for the current device
                    string query = "SELECT * FROM sessions WHERE device_id = @deviceId ORDER BY last_close_time DESC;";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@deviceId", deviceId);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int UserId = Convert.ToInt32(reader["userid"]);
                                bool logoutFlag = Convert.ToBoolean(reader["logout_flag"]);
                                DateTime lastCloseTime = Convert.ToDateTime(reader["last_close_time"]);
                                bool rememberPasswordFlag = Convert.ToBoolean(reader["remember_password_flag"]);

                                if (rememberPasswordFlag && !logoutFlag)
                                {
                                    this.UserId = UserId;
                                    ReloadMainForm();
                                    LoggedIn();
                                }
                                else
                                {
                                    // Check if the user logged out before closing and within the specified time
                                    if (!logoutFlag && DateTime.Now.Subtract(lastCloseTime).TotalDays < 30)
                                    {
                                        // Perform auto login for the most recent user
                                        this.UserId = UserId;
                                        ReloadMainForm();
                                        LoggedIn();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("AutoLogin error: " + ex.Message);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE (username = @username OR email = @username) AND password = @password;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        // Login successful
                        return true;
                    }
                    else
                    {
                        // Login failed
                        return false;
                    }
                }
            }
        }

        private void LoggedIn()
        {
            // Perform actions after successful login
            LogedInUpdateSession();

            MainFormPanel.Visible = true;
            LoginPanel.Visible = false;
            RegisterPanel.Visible = false;
            isLogin = true;
        }

        private void Registered()
        {
            // Perform actions after successful login
            LogedInUpdateSession();

            MainFormPanel.Visible = true;
            LoginPanel.Visible = false;
            RegisterPanel.Visible = false;
            isLogin = true;
        }

        private void LoggedOut()
        {
            // Perform actions after successful logout
            LogedOutUpdateSession(true);
            //CurrentUser = null;
            if (RememberPasswordCheckBox.Checked)
            {
                RememberPasswordCheckBox.Checked = false;
            }
            ShowPasswordIcon.Image = Properties.Resources.hide_password_icon;
            RegisterShowPasswordIcon1.Image = Properties.Resources.hide_password_icon;
            RegisterShowPasswordIcon2.Image = Properties.Resources.hide_password_icon;
            UsernameOrEmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            RegisterEmailTextBox.Text = "";
            RegisterUsernameTextBox.Text = "";
            RegisterFirstnameTextBox.Text = "";
            RegisterLastnameTextBox.Text = "";
            RegisterPhoneTextBox.Text = "";
            RegisterPasswordTextBox.Text = "";
            RegisterPasswordConfirmTextBox.Text = "";
            invalidLbl.Visible = false;
            RegisterInvalidLbl.Visible = false;
            MainFormPanel.Visible = false;
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
            isLogin = false;
        }

        private void CheckUsername(string username)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT id FROM users WHERE (username = @username OR email = @username);";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Check if there are rows to read
                        {
                            UserId = Convert.ToInt32(reader["id"]);
                        }
                    }
                }
            }
        }

        private void GetDeviceID()
        {
            string deviceId = string.Empty;
            try
            {
                // Query for system information to generate a unique identifier
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    deviceId += obj["ProcessorId"].ToString();
                }

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    deviceId += obj["SerialNumber"].ToString();
                }

                // Hash the concatenated hardware information to generate a unique identifier

                // Compute SHA256 hash of the input string
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(deviceId));
                    deviceId = BitConverter.ToString(hashBytes).Replace("-", "");
                }

                //deviceId = GetHash(deviceId);
                //deviceId = deviceId;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error getting device ID: " + ex.Message);
            }
            this.deviceId = deviceId;
        }

        private void ShowPasswordIcon_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar)
            {
                ShowPasswordIcon.Image = Properties.Resources.show_password_icon;
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ShowPasswordIcon.Image = Properties.Resources.hide_password_icon;
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginHelpIcon_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled && !EmailExists() && !PhoneExists() && !UsernameExists() && (RegisterPasswordState() == 4))
            {
                if(InsertUserRecord())
                {
                    ReloadMainForm();
                    Registered();
                }
            }
        }

        private bool InsertUserRecord()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO users (email, username, firstname, lastname, password, phone) " +
                                         "VALUES (@email, @username, @firstname, @lastname, @password, @phone);";

                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@email", RegisterEmailTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@username", RegisterUsernameTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@firstname", RegisterFirstnameTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@lastname", RegisterLastnameTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@password", RegisterPasswordTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(RegisterPhoneTextBox.Text) ? DBNull.Value : (object)RegisterPhoneTextBox.Text);

                        int rowsInserted = insertCommand.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            // Insert successful
                            CustomMessageBoxForm.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // You can perform additional actions here, such as clearing the textboxes or navigating to another form

                            string query = "SELECT id FROM users WHERE username = @username;";
                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@username", RegisterUsernameTextBox.Text);

                                object result = command.ExecuteScalar();
                                if (result != null)
                                {
                                    UserId = Convert.ToInt32(result);
                                }
                            }

                            return true;
                        }
                        else
                        {
                            // Insert failed
                            CustomMessageBoxForm.Show("Failed to register. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                CustomMessageBoxForm.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if all required textboxes have values
            allFieldsFilled = !string.IsNullOrEmpty(RegisterEmailTextBox.Text.Trim()) &&
                                   !string.IsNullOrEmpty(RegisterUsernameTextBox.Text.Trim()) &&
                                   !string.IsNullOrEmpty(RegisterFirstnameTextBox.Text.Trim()) &&
                                   !string.IsNullOrEmpty(RegisterLastnameTextBox.Text.Trim()) &&
                                   !string.IsNullOrEmpty(RegisterPasswordTextBox.Text.Trim()) &&
                                   !string.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Text.Trim());

            // Enable the Register button if all required fields are filled, otherwise disable it
            bool State = allFieldsFilled && !EmailExists() && !PhoneExists() && !UsernameExists() && (RegisterPasswordState() == 4);
            if (State)
            {
                RegisterInvalidLbl.Visible = false;
                RegisterBtn.Enabled = true;
            }
            else
            {
                RegisterBtn.Enabled = false; 
            }
        }

        private bool EmailExists()
        {
            // Query the database to check if the email exists
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE email = @email;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", RegisterEmailTextBox.Text.Trim());
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool PhoneExists()
        {
            // Query the database to check if the phone exists
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE phone = @phone;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phone", RegisterPhoneTextBox.Text.Trim());
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool UsernameExists()
        {
            // Query the database to check if the entered username already exists
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", RegisterUsernameTextBox.Text);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        // Username already exists
                        return true;
                        // Display a message or perform any action to indicate that the username is not unique
                    }
                    else
                    {
                        // Username is unique
                        return false;
                        // Perform any action for a unique username
                    }
                }
            }
        }

        private int RegisterPasswordState()
        {
            // Empty = 0, Confirm = 1, Contains = 2, Match = 3, Full = 4
            if (string.IsNullOrEmpty(RegisterPasswordTextBox.Text) && string.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Text))
            {
                return 0;
            }
            else if (!string.IsNullOrEmpty(RegisterPasswordTextBox.Text) && string.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Text))
            {
                if (RegisterPasswordTextBox.Text.Length < 4 && string.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Text))
                {
                    return 2;

                }
                else if (RegisterPasswordTextBox.Text.Length >= 4 && string.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Text))
                {
                    return 1;
                }
            }
            else if (string.IsNullOrEmpty(RegisterPasswordTextBox.Text) && !string.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Text))
            {
                if (RegisterPasswordConfirmTextBox.Text.Length < 4 && string.IsNullOrEmpty(RegisterPasswordTextBox.Text))
                {
                    return 2;
                }
                else if (RegisterPasswordConfirmTextBox.Text.Length >= 4 && string.IsNullOrEmpty(RegisterPasswordTextBox.Text))
                {
                    return 1;
                }
            }
            else if (!string.IsNullOrEmpty(RegisterPasswordTextBox.Text) && !string.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Text))
            {
                if (RegisterPasswordTextBox.Text.Length < 4 && RegisterPasswordConfirmTextBox.Text.Length < 4)
                {
                    return 2;
                }
                else if (RegisterPasswordTextBox.Text.Length >= 4 && RegisterPasswordConfirmTextBox.Text.Length < 4)
                {
                    return 3;
                }
                else if (RegisterPasswordTextBox.Text.Length < 4 && RegisterPasswordConfirmTextBox.Text.Length >= 4)
                {
                    return 3;
                }
                else if (RegisterPasswordTextBox.Text.Length >= 4 && RegisterPasswordConfirmTextBox.Text.Length >= 4)
                {
                    if (RegisterPasswordTextBox.Text == RegisterPasswordConfirmTextBox.Text)
                    {
                        return 4;

                    }
                    else
                    {
                        return 3;
                    }
                }
            }
            return -1;
        }

        private void RegisterShowPasswordIcon1_Click(object sender, EventArgs e)
        {
            if (RegisterPasswordTextBox.UseSystemPasswordChar)
            {
                RegisterShowPasswordIcon1.Image = Properties.Resources.show_password_icon;
                RegisterPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                RegisterShowPasswordIcon1.Image = Properties.Resources.hide_password_icon;
                RegisterPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void RegisterShowPasswordIcon2_Click(object sender, EventArgs e)
        {
            if (RegisterPasswordConfirmTextBox.UseSystemPasswordChar)
            {
                RegisterShowPasswordIcon2.Image = Properties.Resources.show_password_icon;
                RegisterPasswordConfirmTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                RegisterShowPasswordIcon2.Image = Properties.Resources.hide_password_icon;
                RegisterPasswordConfirmTextBox.UseSystemPasswordChar = true;
            }
        }

        private void RegisterUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the username is empty
            if (string.IsNullOrEmpty(RegisterUsernameTextBox.Text))
            {
                // Display a message or perform any action for an empty username
                RegisterInvalidLbl.Text = "Please fill in all required fields.";
                RegisterInvalidLbl.Visible = true;
            }
            else
            {
                if (UsernameExists())
                {
                    // Username already exists
                    RegisterInvalidLbl.Text = "This Username already exists.";
                    RegisterInvalidLbl.Visible = true;
                }
                else
                {
                    // Username is unique
                    RegisterInvalidLbl.Visible = false;
                }
            }
        }

        private void RegisterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            int State = RegisterPasswordState();
            switch (State)
            {
                case 0:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Please fill in all required fields.";
                    break;
                case 1:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Please confirm your password.";
                    break;
                case 2:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Your password must contain at least 4 characters.";
                    break;
                case 3:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Your password and confirmation password must match.";
                    break;
                case 4:
                    RegisterInvalidLbl.Visible = false;
                    break;
            }
        }

        private void RegisterPasswordConfirmTextBox_TextChanged(object sender, EventArgs e)
        {
            int State = RegisterPasswordState();
            switch (State)
            {
                case 0:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Please fill in all required fields.";
                    break;
                case 1:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Please confirm your password.";
                    break;
                case 2:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Your password must contain at least 4 characters.";
                    break;
                case 3:
                    RegisterInvalidLbl.Visible = true;
                    RegisterInvalidLbl.Text = "Your password and confirmation password must match.";
                    break;
                case 4:
                    RegisterInvalidLbl.Visible = false;
                    break;
            }
        }

        private void RegisterEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the email is empty
            if (string.IsNullOrEmpty(RegisterEmailTextBox.Text))
            {
                // Display a message or perform any action for an empty email
                RegisterInvalidLbl.Text = "Please fill in all required fields.";
                RegisterInvalidLbl.Visible = true;
            }
            else
            {
                if (EmailExists())
                {
                    // Email already exists
                    RegisterInvalidLbl.Text = "This Email already exists.";
                    RegisterInvalidLbl.Visible = true;
                }
                else
                {
                    // Email is unique
                    RegisterInvalidLbl.Visible = false;
                }
            }
        }

        private void RegisterFirstnameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the firstname is empty
            if (string.IsNullOrEmpty(RegisterFirstnameTextBox.Text))
            {
                // Display a message or perform any action for an empty firstname
                RegisterInvalidLbl.Text = "Please fill in all required fields.";
                RegisterInvalidLbl.Visible = true;
            }
        }

        private void RegisterLastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the lastname is empty
            if (string.IsNullOrEmpty(RegisterLastnameTextBox.Text))
            {
                // Display a message or perform any action for an empty lastname
                RegisterInvalidLbl.Text = "Please fill in all required fields.";
                RegisterInvalidLbl.Visible = true;
            }
        }

        private void RegisterPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneExists())
            {
                // Phone already exists
                RegisterInvalidLbl.Text = "This Phone number already exists.";
                RegisterInvalidLbl.Visible = true;
            }
            else
            {
                // Phone is unique
                RegisterInvalidLbl.Visible = false;
            }
        }

        private void RegisterHelpIcon_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void LoginLbl_Click(object sender, EventArgs e)
        {
            MainFormPanel.Visible = false;
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
        }

        private void RegisterLbl_Click(object sender, EventArgs e)
        {
            MainFormPanel.Visible = false;
            LoginPanel.Visible = false;
            RegisterPanel.Visible = true;
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
                    insertCommand.Parameters.AddWithValue("@id", SelectedRecord.id);
                    insertCommand.Parameters.AddWithValue("@userid", CurrentUser.id);

                    int rowsInserted = insertCommand.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        // Next, delete the record from the 'records' table
                        string deleteQuery = "DELETE FROM records WHERE userid = @userid AND id = @id;";

                        using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@id", SelectedRecord.id);
                            deleteCommand.Parameters.AddWithValue("@userid", CurrentUser.id);

                            int rowsDeleted = deleteCommand.ExecuteNonQuery();

                            if (rowsDeleted > 0)
                            {
                                ReloadMainForm(); // Refresh the grid after deletion
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ReloadMainForm();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text;

            List<Record> filteredRecords = GetUserRecords()
            .Where(record => record.url.Contains(keyword) ||
                              record.username.Contains(keyword) ||
                              record.note.Contains(keyword))
            .ToList();

            insertToTable(filteredRecords);
        }

        private void RecordsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBtn.Enabled = true;
            DeleteBtn.Enabled = true;
            ShowBtn.Enabled = true;
            SelectedUrlLbl.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RecordsTable.Rows[e.RowIndex];
                SelectedRecord.id = Convert.ToInt32(row.Cells["Id"].Value);
                SelectedRecord.url = Convert.ToString(row.Cells["URL"].Value);
                SelectedRecord.username = Convert.ToString(row.Cells["User"].Value);
                SelectedRecord.password = Convert.ToString(row.Cells["Password"].Value);
                SelectedRecord.note = Convert.ToString(row.Cells["Note"].Value);
            }
            SelectedUrlLbl.Text = SelectedRecord.url;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            ExportForm exportFile = new ExportForm(CurrentUser.id);
            exportFile.Show();
        }

        private void SettingsIcon_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(
                CurrentUser.id,
                CurrentUser.email,
                CurrentUser.username,
                CurrentUser.firstname,
                CurrentUser.lastname,
                CurrentUser.password,
                CurrentUser.phone);
            settingsForm.FormClosed += Form_FormClosed;
            settingsForm.Show();

        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadMainForm();
        }
    }
}