namespace PasswordManager
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.PersonalInfoTab = new System.Windows.Forms.TabPage();
            this.ChangeCurrentPasswordLbl = new System.Windows.Forms.Label();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.ChangeInfoLbl = new System.Windows.Forms.Label();
            this.ChangePasswordLbl = new System.Windows.Forms.Label();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.LastnameLbl = new System.Windows.Forms.Label();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.FirstnameLbl = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.BackupAndRestoreTab = new System.Windows.Forms.TabPage();
            this.DeletedRecordsCountLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportDeletedRecordsBtn = new System.Windows.Forms.Button();
            this.DestroyLbl = new System.Windows.Forms.Label();
            this.DestroyAllDeletedBtn = new System.Windows.Forms.Button();
            this.ExportLbl = new System.Windows.Forms.Label();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.BackupLbl = new System.Windows.Forms.Label();
            this.RestoreLbl = new System.Windows.Forms.Label();
            this.ShowLbl = new System.Windows.Forms.Label();
            this.RestoreAllDeletedBtn = new System.Windows.Forms.Button();
            this.ShowAllDeletedBtn = new System.Windows.Forms.Button();
            this.DeletedPasswordsLbl = new System.Windows.Forms.Label();
            this.Defaults = new System.Windows.Forms.TabPage();
            this.DefaultCharListTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordGenerationLbl = new System.Windows.Forms.Label();
            this.DefaultFormatComboBox = new System.Windows.Forms.ComboBox();
            this.DefaultFormatLbl = new System.Windows.Forms.Label();
            this.DefaultNameTextBox = new System.Windows.Forms.TextBox();
            this.DefaultNameLbl = new System.Windows.Forms.Label();
            this.ExportDefaultsLbl = new System.Windows.Forms.Label();
            this.DefaultPathTextBox = new System.Windows.Forms.TextBox();
            this.SavePathLbl = new System.Windows.Forms.Label();
            this.BrowseIcon = new System.Windows.Forms.PictureBox();
            this.Advanced = new System.Windows.Forms.TabPage();
            this.deleteaccount = new System.Windows.Forms.Label();
            this.DeleteAccountBtn = new System.Windows.Forms.Button();
            this.DeleteAccountLbl = new System.Windows.Forms.Label();
            this.ResetLbl = new System.Windows.Forms.Label();
            this.ResetDefaultsBtn = new System.Windows.Forms.Button();
            this.ResetDefaultsLbl = new System.Windows.Forms.Label();
            this.Deletedatalbl = new System.Windows.Forms.Label();
            this.DeleteAllDataBtn = new System.Windows.Forms.Button();
            this.DeleteLbl = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.CLoseBtn = new System.Windows.Forms.Button();
            this.InvalidLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SettingsTabControl.SuspendLayout();
            this.PersonalInfoTab.SuspendLayout();
            this.BackupAndRestoreTab.SuspendLayout();
            this.Defaults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseIcon)).BeginInit();
            this.Advanced.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTabControl.Controls.Add(this.PersonalInfoTab);
            this.SettingsTabControl.Controls.Add(this.BackupAndRestoreTab);
            this.SettingsTabControl.Controls.Add(this.Defaults);
            this.SettingsTabControl.Controls.Add(this.Advanced);
            this.SettingsTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsTabControl.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SettingsTabControl.Location = new System.Drawing.Point(17, 38);
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(496, 417);
            this.SettingsTabControl.TabIndex = 0;
            // 
            // PersonalInfoTab
            // 
            this.PersonalInfoTab.Controls.Add(this.ChangeCurrentPasswordLbl);
            this.PersonalInfoTab.Controls.Add(this.ChangePasswordBtn);
            this.PersonalInfoTab.Controls.Add(this.PhoneNumberTextBox);
            this.PersonalInfoTab.Controls.Add(this.PhoneNumberLbl);
            this.PersonalInfoTab.Controls.Add(this.EmailTextBox);
            this.PersonalInfoTab.Controls.Add(this.EmailLbl);
            this.PersonalInfoTab.Controls.Add(this.ChangeInfoLbl);
            this.PersonalInfoTab.Controls.Add(this.ChangePasswordLbl);
            this.PersonalInfoTab.Controls.Add(this.LastnameTextBox);
            this.PersonalInfoTab.Controls.Add(this.LastnameLbl);
            this.PersonalInfoTab.Controls.Add(this.FirstnameTextBox);
            this.PersonalInfoTab.Controls.Add(this.FirstnameLbl);
            this.PersonalInfoTab.Controls.Add(this.UsernameTextBox);
            this.PersonalInfoTab.Controls.Add(this.UsernameLbl);
            this.PersonalInfoTab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonalInfoTab.Location = new System.Drawing.Point(4, 28);
            this.PersonalInfoTab.Name = "PersonalInfoTab";
            this.PersonalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfoTab.Size = new System.Drawing.Size(488, 385);
            this.PersonalInfoTab.TabIndex = 0;
            this.PersonalInfoTab.Text = "Personal Information";
            this.PersonalInfoTab.UseVisualStyleBackColor = true;
            // 
            // ChangeCurrentPasswordLbl
            // 
            this.ChangeCurrentPasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeCurrentPasswordLbl.AutoSize = true;
            this.ChangeCurrentPasswordLbl.Location = new System.Drawing.Point(27, 326);
            this.ChangeCurrentPasswordLbl.Name = "ChangeCurrentPasswordLbl";
            this.ChangeCurrentPasswordLbl.Size = new System.Drawing.Size(201, 21);
            this.ChangeCurrentPasswordLbl.TabIndex = 25;
            this.ChangeCurrentPasswordLbl.Text = "Change current password";
            this.ChangeCurrentPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangePasswordBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ChangePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordBtn.Location = new System.Drawing.Point(235, 313);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(215, 47);
            this.ChangePasswordBtn.TabIndex = 24;
            this.ChangePasswordBtn.Text = "Change";
            this.ChangePasswordBtn.UseVisualStyleBackColor = false;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(197, 238);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(280, 27);
            this.PhoneNumberTextBox.TabIndex = 23;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Location = new System.Drawing.Point(27, 241);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(122, 21);
            this.PhoneNumberLbl.TabIndex = 22;
            this.PhoneNumberLbl.Text = "Phone Number";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailTextBox.Location = new System.Drawing.Point(197, 58);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(280, 27);
            this.EmailTextBox.TabIndex = 21;
            // 
            // EmailLbl
            // 
            this.EmailLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(27, 61);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(51, 21);
            this.EmailLbl.TabIndex = 20;
            this.EmailLbl.Text = "Email";
            // 
            // ChangeInfoLbl
            // 
            this.ChangeInfoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeInfoLbl.AutoSize = true;
            this.ChangeInfoLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChangeInfoLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.ChangeInfoLbl.Location = new System.Drawing.Point(5, 13);
            this.ChangeInfoLbl.Name = "ChangeInfoLbl";
            this.ChangeInfoLbl.Size = new System.Drawing.Size(300, 27);
            this.ChangeInfoLbl.TabIndex = 19;
            this.ChangeInfoLbl.Text = "Change Personal Information:";
            // 
            // ChangePasswordLbl
            // 
            this.ChangePasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangePasswordLbl.AutoSize = true;
            this.ChangePasswordLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChangePasswordLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.ChangePasswordLbl.Location = new System.Drawing.Point(5, 281);
            this.ChangePasswordLbl.Name = "ChangePasswordLbl";
            this.ChangePasswordLbl.Size = new System.Drawing.Size(189, 27);
            this.ChangePasswordLbl.TabIndex = 18;
            this.ChangePasswordLbl.Text = "Change Password:";
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastnameTextBox.Location = new System.Drawing.Point(197, 193);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(280, 27);
            this.LastnameTextBox.TabIndex = 5;
            this.LastnameTextBox.TextChanged += new System.EventHandler(this.LastnameTextBox_TextChanged);
            // 
            // LastnameLbl
            // 
            this.LastnameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastnameLbl.AutoSize = true;
            this.LastnameLbl.Location = new System.Drawing.Point(27, 196);
            this.LastnameLbl.Name = "LastnameLbl";
            this.LastnameLbl.Size = new System.Drawing.Size(90, 21);
            this.LastnameLbl.TabIndex = 4;
            this.LastnameLbl.Text = "Last Name";
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstnameTextBox.Location = new System.Drawing.Point(197, 148);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(280, 27);
            this.FirstnameTextBox.TabIndex = 3;
            this.FirstnameTextBox.TextChanged += new System.EventHandler(this.FirstnameTextBox_TextChanged);
            // 
            // FirstnameLbl
            // 
            this.FirstnameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstnameLbl.AutoSize = true;
            this.FirstnameLbl.Location = new System.Drawing.Point(27, 151);
            this.FirstnameLbl.Name = "FirstnameLbl";
            this.FirstnameLbl.Size = new System.Drawing.Size(92, 21);
            this.FirstnameLbl.TabIndex = 2;
            this.FirstnameLbl.Text = "First Name";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTextBox.Location = new System.Drawing.Point(197, 103);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(280, 27);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(27, 106);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(84, 21);
            this.UsernameLbl.TabIndex = 0;
            this.UsernameLbl.Text = "Username";
            // 
            // BackupAndRestoreTab
            // 
            this.BackupAndRestoreTab.Controls.Add(this.DeletedRecordsCountLbl);
            this.BackupAndRestoreTab.Controls.Add(this.label1);
            this.BackupAndRestoreTab.Controls.Add(this.ExportDeletedRecordsBtn);
            this.BackupAndRestoreTab.Controls.Add(this.DestroyLbl);
            this.BackupAndRestoreTab.Controls.Add(this.DestroyAllDeletedBtn);
            this.BackupAndRestoreTab.Controls.Add(this.ExportLbl);
            this.BackupAndRestoreTab.Controls.Add(this.ExportBtn);
            this.BackupAndRestoreTab.Controls.Add(this.BackupLbl);
            this.BackupAndRestoreTab.Controls.Add(this.RestoreLbl);
            this.BackupAndRestoreTab.Controls.Add(this.ShowLbl);
            this.BackupAndRestoreTab.Controls.Add(this.RestoreAllDeletedBtn);
            this.BackupAndRestoreTab.Controls.Add(this.ShowAllDeletedBtn);
            this.BackupAndRestoreTab.Controls.Add(this.DeletedPasswordsLbl);
            this.BackupAndRestoreTab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackupAndRestoreTab.Location = new System.Drawing.Point(4, 28);
            this.BackupAndRestoreTab.Name = "BackupAndRestoreTab";
            this.BackupAndRestoreTab.Padding = new System.Windows.Forms.Padding(3);
            this.BackupAndRestoreTab.Size = new System.Drawing.Size(488, 385);
            this.BackupAndRestoreTab.TabIndex = 1;
            this.BackupAndRestoreTab.Text = "Backup and Restore";
            this.BackupAndRestoreTab.UseVisualStyleBackColor = true;
            // 
            // DeletedRecordsCountLbl
            // 
            this.DeletedRecordsCountLbl.AutoSize = true;
            this.DeletedRecordsCountLbl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeletedRecordsCountLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.DeletedRecordsCountLbl.Location = new System.Drawing.Point(281, 112);
            this.DeletedRecordsCountLbl.Name = "DeletedRecordsCountLbl";
            this.DeletedRecordsCountLbl.Size = new System.Drawing.Size(153, 20);
            this.DeletedRecordsCountLbl.TabIndex = 33;
            this.DeletedRecordsCountLbl.Text = "00 Deleted Records.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Export all deleted records";
            // 
            // ExportDeletedRecordsBtn
            // 
            this.ExportDeletedRecordsBtn.BackColor = System.Drawing.Color.Silver;
            this.ExportDeletedRecordsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportDeletedRecordsBtn.Enabled = false;
            this.ExportDeletedRecordsBtn.Location = new System.Drawing.Point(275, 211);
            this.ExportDeletedRecordsBtn.Name = "ExportDeletedRecordsBtn";
            this.ExportDeletedRecordsBtn.Size = new System.Drawing.Size(196, 42);
            this.ExportDeletedRecordsBtn.TabIndex = 31;
            this.ExportDeletedRecordsBtn.Text = "Export";
            this.ExportDeletedRecordsBtn.UseVisualStyleBackColor = false;
            this.ExportDeletedRecordsBtn.Click += new System.EventHandler(this.ExportDeletedRecordsBtn_Click);
            // 
            // DestroyLbl
            // 
            this.DestroyLbl.AutoSize = true;
            this.DestroyLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DestroyLbl.Location = new System.Drawing.Point(31, 325);
            this.DestroyLbl.Name = "DestroyLbl";
            this.DestroyLbl.Size = new System.Drawing.Size(205, 23);
            this.DestroyLbl.TabIndex = 30;
            this.DestroyLbl.Text = "Destroy deleted records";
            // 
            // DestroyAllDeletedBtn
            // 
            this.DestroyAllDeletedBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.DestroyAllDeletedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DestroyAllDeletedBtn.Enabled = false;
            this.DestroyAllDeletedBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DestroyAllDeletedBtn.Location = new System.Drawing.Point(275, 315);
            this.DestroyAllDeletedBtn.Name = "DestroyAllDeletedBtn";
            this.DestroyAllDeletedBtn.Size = new System.Drawing.Size(196, 42);
            this.DestroyAllDeletedBtn.TabIndex = 29;
            this.DestroyAllDeletedBtn.Text = "Destroy";
            this.DestroyAllDeletedBtn.UseVisualStyleBackColor = false;
            this.DestroyAllDeletedBtn.Click += new System.EventHandler(this.DestroyAllDeletedBtn_Click);
            // 
            // ExportLbl
            // 
            this.ExportLbl.AutoSize = true;
            this.ExportLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExportLbl.Location = new System.Drawing.Point(31, 55);
            this.ExportLbl.Name = "ExportLbl";
            this.ExportLbl.Size = new System.Drawing.Size(159, 23);
            this.ExportLbl.TabIndex = 28;
            this.ExportLbl.Text = "Export all records";
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.Color.Silver;
            this.ExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportBtn.Location = new System.Drawing.Point(275, 45);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(196, 42);
            this.ExportBtn.TabIndex = 26;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // BackupLbl
            // 
            this.BackupLbl.AutoSize = true;
            this.BackupLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackupLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.BackupLbl.Location = new System.Drawing.Point(8, 12);
            this.BackupLbl.Name = "BackupLbl";
            this.BackupLbl.Size = new System.Drawing.Size(144, 27);
            this.BackupLbl.TabIndex = 25;
            this.BackupLbl.Text = "Backup Data:";
            // 
            // RestoreLbl
            // 
            this.RestoreLbl.AutoSize = true;
            this.RestoreLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RestoreLbl.Location = new System.Drawing.Point(31, 273);
            this.RestoreLbl.Name = "RestoreLbl";
            this.RestoreLbl.Size = new System.Drawing.Size(230, 23);
            this.RestoreLbl.TabIndex = 24;
            this.RestoreLbl.Text = "Restore all deleted records";
            // 
            // ShowLbl
            // 
            this.ShowLbl.AutoSize = true;
            this.ShowLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowLbl.Location = new System.Drawing.Point(31, 169);
            this.ShowLbl.Name = "ShowLbl";
            this.ShowLbl.Size = new System.Drawing.Size(213, 23);
            this.ShowLbl.TabIndex = 23;
            this.ShowLbl.Text = "Show all deleted records";
            // 
            // RestoreAllDeletedBtn
            // 
            this.RestoreAllDeletedBtn.BackColor = System.Drawing.Color.Silver;
            this.RestoreAllDeletedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreAllDeletedBtn.Enabled = false;
            this.RestoreAllDeletedBtn.Location = new System.Drawing.Point(275, 263);
            this.RestoreAllDeletedBtn.Name = "RestoreAllDeletedBtn";
            this.RestoreAllDeletedBtn.Size = new System.Drawing.Size(196, 42);
            this.RestoreAllDeletedBtn.TabIndex = 22;
            this.RestoreAllDeletedBtn.Text = "Restore";
            this.RestoreAllDeletedBtn.UseVisualStyleBackColor = false;
            this.RestoreAllDeletedBtn.Click += new System.EventHandler(this.RestoreAllDeletedBtn_Click);
            // 
            // ShowAllDeletedBtn
            // 
            this.ShowAllDeletedBtn.BackColor = System.Drawing.Color.Silver;
            this.ShowAllDeletedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAllDeletedBtn.Enabled = false;
            this.ShowAllDeletedBtn.Location = new System.Drawing.Point(275, 159);
            this.ShowAllDeletedBtn.Name = "ShowAllDeletedBtn";
            this.ShowAllDeletedBtn.Size = new System.Drawing.Size(196, 42);
            this.ShowAllDeletedBtn.TabIndex = 21;
            this.ShowAllDeletedBtn.Text = "Show";
            this.ShowAllDeletedBtn.UseVisualStyleBackColor = false;
            this.ShowAllDeletedBtn.Click += new System.EventHandler(this.ShowAllDeletedBtn_Click);
            // 
            // DeletedPasswordsLbl
            // 
            this.DeletedPasswordsLbl.AutoSize = true;
            this.DeletedPasswordsLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeletedPasswordsLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.DeletedPasswordsLbl.Location = new System.Drawing.Point(8, 112);
            this.DeletedPasswordsLbl.Name = "DeletedPasswordsLbl";
            this.DeletedPasswordsLbl.Size = new System.Drawing.Size(178, 27);
            this.DeletedPasswordsLbl.TabIndex = 20;
            this.DeletedPasswordsLbl.Text = "Deleted Records:";
            // 
            // Defaults
            // 
            this.Defaults.Controls.Add(this.DefaultCharListTextBox);
            this.Defaults.Controls.Add(this.label2);
            this.Defaults.Controls.Add(this.PasswordGenerationLbl);
            this.Defaults.Controls.Add(this.DefaultFormatComboBox);
            this.Defaults.Controls.Add(this.DefaultFormatLbl);
            this.Defaults.Controls.Add(this.DefaultNameTextBox);
            this.Defaults.Controls.Add(this.DefaultNameLbl);
            this.Defaults.Controls.Add(this.ExportDefaultsLbl);
            this.Defaults.Controls.Add(this.DefaultPathTextBox);
            this.Defaults.Controls.Add(this.SavePathLbl);
            this.Defaults.Controls.Add(this.BrowseIcon);
            this.Defaults.Location = new System.Drawing.Point(4, 28);
            this.Defaults.Name = "Defaults";
            this.Defaults.Size = new System.Drawing.Size(488, 385);
            this.Defaults.TabIndex = 2;
            this.Defaults.Text = "Defaults";
            this.Defaults.UseVisualStyleBackColor = true;
            // 
            // DefaultCharListTextBox
            // 
            this.DefaultCharListTextBox.Location = new System.Drawing.Point(38, 295);
            this.DefaultCharListTextBox.Multiline = true;
            this.DefaultCharListTextBox.Name = "DefaultCharListTextBox";
            this.DefaultCharListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DefaultCharListTextBox.Size = new System.Drawing.Size(433, 73);
            this.DefaultCharListTextBox.TabIndex = 30;
            this.DefaultCharListTextBox.TextChanged += new System.EventHandler(this.DefaultCharListTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Password generator character list";
            // 
            // PasswordGenerationLbl
            // 
            this.PasswordGenerationLbl.AutoSize = true;
            this.PasswordGenerationLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordGenerationLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.PasswordGenerationLbl.Location = new System.Drawing.Point(6, 229);
            this.PasswordGenerationLbl.Name = "PasswordGenerationLbl";
            this.PasswordGenerationLbl.Size = new System.Drawing.Size(223, 27);
            this.PasswordGenerationLbl.TabIndex = 28;
            this.PasswordGenerationLbl.Text = "Password Generation:";
            // 
            // DefaultFormatComboBox
            // 
            this.DefaultFormatComboBox.DisplayMember = "pdf";
            this.DefaultFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultFormatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DefaultFormatComboBox.FormattingEnabled = true;
            this.DefaultFormatComboBox.Location = new System.Drawing.Point(191, 186);
            this.DefaultFormatComboBox.Name = "DefaultFormatComboBox";
            this.DefaultFormatComboBox.Size = new System.Drawing.Size(280, 28);
            this.DefaultFormatComboBox.TabIndex = 27;
            this.DefaultFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.DefaultFormatComboBox_SelectedIndexChanged);
            // 
            // DefaultFormatLbl
            // 
            this.DefaultFormatLbl.AutoSize = true;
            this.DefaultFormatLbl.Location = new System.Drawing.Point(34, 191);
            this.DefaultFormatLbl.Name = "DefaultFormatLbl";
            this.DefaultFormatLbl.Size = new System.Drawing.Size(110, 19);
            this.DefaultFormatLbl.TabIndex = 24;
            this.DefaultFormatLbl.Text = "Default format";
            // 
            // DefaultNameTextBox
            // 
            this.DefaultNameTextBox.Location = new System.Drawing.Point(191, 152);
            this.DefaultNameTextBox.Name = "DefaultNameTextBox";
            this.DefaultNameTextBox.Size = new System.Drawing.Size(280, 27);
            this.DefaultNameTextBox.TabIndex = 23;
            this.DefaultNameTextBox.TextChanged += new System.EventHandler(this.DefaultNameTextBox_TextChanged);
            // 
            // DefaultNameLbl
            // 
            this.DefaultNameLbl.AutoSize = true;
            this.DefaultNameLbl.Location = new System.Drawing.Point(34, 156);
            this.DefaultNameLbl.Name = "DefaultNameLbl";
            this.DefaultNameLbl.Size = new System.Drawing.Size(128, 19);
            this.DefaultNameLbl.TabIndex = 22;
            this.DefaultNameLbl.Text = "Default file name";
            // 
            // ExportDefaultsLbl
            // 
            this.ExportDefaultsLbl.AutoSize = true;
            this.ExportDefaultsLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExportDefaultsLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.ExportDefaultsLbl.Location = new System.Drawing.Point(6, 16);
            this.ExportDefaultsLbl.Name = "ExportDefaultsLbl";
            this.ExportDefaultsLbl.Size = new System.Drawing.Size(171, 27);
            this.ExportDefaultsLbl.TabIndex = 21;
            this.ExportDefaultsLbl.Text = "Export Defaults:";
            // 
            // DefaultPathTextBox
            // 
            this.DefaultPathTextBox.Location = new System.Drawing.Point(191, 49);
            this.DefaultPathTextBox.Multiline = true;
            this.DefaultPathTextBox.Name = "DefaultPathTextBox";
            this.DefaultPathTextBox.ReadOnly = true;
            this.DefaultPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DefaultPathTextBox.Size = new System.Drawing.Size(280, 95);
            this.DefaultPathTextBox.TabIndex = 20;
            this.DefaultPathTextBox.TextChanged += new System.EventHandler(this.DefaultPathTextBox_TextChanged);
            // 
            // SavePathLbl
            // 
            this.SavePathLbl.AutoSize = true;
            this.SavePathLbl.Location = new System.Drawing.Point(34, 53);
            this.SavePathLbl.Name = "SavePathLbl";
            this.SavePathLbl.Size = new System.Drawing.Size(92, 19);
            this.SavePathLbl.TabIndex = 19;
            this.SavePathLbl.Text = "Default path";
            // 
            // BrowseIcon
            // 
            this.BrowseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseIcon.Image = global::PasswordManager.Properties.Resources.openedfolder_icon_50x50px;
            this.BrowseIcon.Location = new System.Drawing.Point(424, 8);
            this.BrowseIcon.Name = "BrowseIcon";
            this.BrowseIcon.Size = new System.Drawing.Size(47, 35);
            this.BrowseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BrowseIcon.TabIndex = 26;
            this.BrowseIcon.TabStop = false;
            this.BrowseIcon.Click += new System.EventHandler(this.BrowseIcon_Click);
            // 
            // Advanced
            // 
            this.Advanced.Controls.Add(this.deleteaccount);
            this.Advanced.Controls.Add(this.DeleteAccountBtn);
            this.Advanced.Controls.Add(this.DeleteAccountLbl);
            this.Advanced.Controls.Add(this.ResetLbl);
            this.Advanced.Controls.Add(this.ResetDefaultsBtn);
            this.Advanced.Controls.Add(this.ResetDefaultsLbl);
            this.Advanced.Controls.Add(this.Deletedatalbl);
            this.Advanced.Controls.Add(this.DeleteAllDataBtn);
            this.Advanced.Controls.Add(this.DeleteLbl);
            this.Advanced.Location = new System.Drawing.Point(4, 28);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(488, 385);
            this.Advanced.TabIndex = 3;
            this.Advanced.Text = "Advanced";
            this.Advanced.UseVisualStyleBackColor = true;
            // 
            // deleteaccount
            // 
            this.deleteaccount.AutoSize = true;
            this.deleteaccount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteaccount.Location = new System.Drawing.Point(43, 241);
            this.deleteaccount.Name = "deleteaccount";
            this.deleteaccount.Size = new System.Drawing.Size(164, 23);
            this.deleteaccount.TabIndex = 37;
            this.deleteaccount.Text = "Delete my account";
            // 
            // DeleteAccountBtn
            // 
            this.DeleteAccountBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAccountBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteAccountBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteAccountBtn.Location = new System.Drawing.Point(262, 232);
            this.DeleteAccountBtn.Name = "DeleteAccountBtn";
            this.DeleteAccountBtn.Size = new System.Drawing.Size(196, 42);
            this.DeleteAccountBtn.TabIndex = 36;
            this.DeleteAccountBtn.Text = "Delete";
            this.DeleteAccountBtn.UseVisualStyleBackColor = false;
            this.DeleteAccountBtn.Click += new System.EventHandler(this.DeleteAccountBtn_Click);
            // 
            // DeleteAccountLbl
            // 
            this.DeleteAccountLbl.AutoSize = true;
            this.DeleteAccountLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteAccountLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.DeleteAccountLbl.Location = new System.Drawing.Point(13, 193);
            this.DeleteAccountLbl.Name = "DeleteAccountLbl";
            this.DeleteAccountLbl.Size = new System.Drawing.Size(162, 27);
            this.DeleteAccountLbl.TabIndex = 35;
            this.DeleteAccountLbl.Text = "Delete Account";
            // 
            // ResetLbl
            // 
            this.ResetLbl.AutoSize = true;
            this.ResetLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetLbl.Location = new System.Drawing.Point(43, 149);
            this.ResetLbl.Name = "ResetLbl";
            this.ResetLbl.Size = new System.Drawing.Size(153, 23);
            this.ResetLbl.TabIndex = 34;
            this.ResetLbl.Text = "Reset all defaults";
            // 
            // ResetDefaultsBtn
            // 
            this.ResetDefaultsBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ResetDefaultsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetDefaultsBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetDefaultsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResetDefaultsBtn.Location = new System.Drawing.Point(262, 139);
            this.ResetDefaultsBtn.Name = "ResetDefaultsBtn";
            this.ResetDefaultsBtn.Size = new System.Drawing.Size(196, 42);
            this.ResetDefaultsBtn.TabIndex = 33;
            this.ResetDefaultsBtn.Text = "Reset";
            this.ResetDefaultsBtn.UseVisualStyleBackColor = false;
            this.ResetDefaultsBtn.Click += new System.EventHandler(this.ResetDefaultsBtn_Click);
            // 
            // ResetDefaultsLbl
            // 
            this.ResetDefaultsLbl.AutoSize = true;
            this.ResetDefaultsLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetDefaultsLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.ResetDefaultsLbl.Location = new System.Drawing.Point(13, 101);
            this.ResetDefaultsLbl.Name = "ResetDefaultsLbl";
            this.ResetDefaultsLbl.Size = new System.Drawing.Size(153, 27);
            this.ResetDefaultsLbl.TabIndex = 32;
            this.ResetDefaultsLbl.Text = "Reset Defaults";
            // 
            // Deletedatalbl
            // 
            this.Deletedatalbl.AutoSize = true;
            this.Deletedatalbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Deletedatalbl.Location = new System.Drawing.Point(43, 57);
            this.Deletedatalbl.Name = "Deletedatalbl";
            this.Deletedatalbl.Size = new System.Drawing.Size(159, 23);
            this.Deletedatalbl.TabIndex = 31;
            this.Deletedatalbl.Text = "Delete all my data";
            // 
            // DeleteAllDataBtn
            // 
            this.DeleteAllDataBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteAllDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAllDataBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteAllDataBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteAllDataBtn.Location = new System.Drawing.Point(262, 47);
            this.DeleteAllDataBtn.Name = "DeleteAllDataBtn";
            this.DeleteAllDataBtn.Size = new System.Drawing.Size(196, 42);
            this.DeleteAllDataBtn.TabIndex = 30;
            this.DeleteAllDataBtn.Text = "Delete";
            this.DeleteAllDataBtn.UseVisualStyleBackColor = false;
            this.DeleteAllDataBtn.Click += new System.EventHandler(this.DeleteAllDataBtn_Click);
            // 
            // DeleteLbl
            // 
            this.DeleteLbl.AutoSize = true;
            this.DeleteLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.DeleteLbl.Location = new System.Drawing.Point(13, 9);
            this.DeleteLbl.Name = "DeleteLbl";
            this.DeleteLbl.Size = new System.Drawing.Size(133, 27);
            this.DeleteLbl.TabIndex = 29;
            this.DeleteLbl.Text = "Delete Data:";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.controlPanel.ColumnCount = 3;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.Controls.Add(this.CloseLbl, 2, 0);
            this.controlPanel.Controls.Add(this.LogoIcon, 0, 0);
            this.controlPanel.Controls.Add(this.TitleLbl, 1, 0);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 1;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Size = new System.Drawing.Size(530, 30);
            this.controlPanel.TabIndex = 3;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLbl.Font = new System.Drawing.Font("Cascadia Code Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseLbl.Location = new System.Drawing.Point(492, 0);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Padding = new System.Windows.Forms.Padding(5, 0, 4, 4);
            this.CloseLbl.Size = new System.Drawing.Size(35, 30);
            this.CloseLbl.TabIndex = 9;
            this.CloseLbl.Text = "X";
            this.CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoIcon
            // 
            this.LogoIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoIcon.Image = global::PasswordManager.Properties.Resources.LogoBlack;
            this.LogoIcon.Location = new System.Drawing.Point(6, 3);
            this.LogoIcon.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.LogoIcon.Name = "LogoIcon";
            this.LogoIcon.Size = new System.Drawing.Size(31, 24);
            this.LogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoIcon.TabIndex = 0;
            this.LogoIcon.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleLbl.Location = new System.Drawing.Point(43, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(443, 30);
            this.TitleLbl.TabIndex = 10;
            this.TitleLbl.Text = "Settings";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CLoseBtn
            // 
            this.CLoseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CLoseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLoseBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CLoseBtn.Location = new System.Drawing.Point(57, 491);
            this.CLoseBtn.Name = "CLoseBtn";
            this.CLoseBtn.Size = new System.Drawing.Size(128, 45);
            this.CLoseBtn.TabIndex = 4;
            this.CLoseBtn.Text = "Close";
            this.CLoseBtn.UseVisualStyleBackColor = true;
            this.CLoseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // InvalidLbl
            // 
            this.InvalidLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InvalidLbl.AutoSize = true;
            this.InvalidLbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InvalidLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.InvalidLbl.Location = new System.Drawing.Point(155, 463);
            this.InvalidLbl.Name = "InvalidLbl";
            this.InvalidLbl.Size = new System.Drawing.Size(220, 19);
            this.InvalidLbl.TabIndex = 26;
            this.InvalidLbl.Text = "Please fill in all required fields.";
            this.InvalidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InvalidLbl.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBtn.Location = new System.Drawing.Point(346, 491);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 45);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(530, 550);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.InvalidLbl);
            this.Controls.Add(this.CLoseBtn);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.SettingsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 550);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.SettingsTabControl.ResumeLayout(false);
            this.PersonalInfoTab.ResumeLayout(false);
            this.PersonalInfoTab.PerformLayout();
            this.BackupAndRestoreTab.ResumeLayout(false);
            this.BackupAndRestoreTab.PerformLayout();
            this.Defaults.ResumeLayout(false);
            this.Defaults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseIcon)).EndInit();
            this.Advanced.ResumeLayout(false);
            this.Advanced.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage PersonalInfoTab;
        private System.Windows.Forms.TabPage BackupAndRestoreTab;
        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Button CLoseBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.Label LastnameLbl;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.Label FirstnameLbl;
        private System.Windows.Forms.Label ChangeInfoLbl;
        private System.Windows.Forms.Label ChangePasswordLbl;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLbl;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Button ShowAllDeletedBtn;
        private System.Windows.Forms.Label DeletedPasswordsLbl;
        private System.Windows.Forms.Button RestoreAllDeletedBtn;
        private System.Windows.Forms.Label RestoreLbl;
        private System.Windows.Forms.Label ShowLbl;
        private System.Windows.Forms.Label ExportLbl;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Label BackupLbl;
        private System.Windows.Forms.TabPage Defaults;
        private System.Windows.Forms.Label ExportDefaultsLbl;
        private System.Windows.Forms.TextBox DefaultPathTextBox;
        private System.Windows.Forms.Label SavePathLbl;
        private System.Windows.Forms.Label DefaultFormatLbl;
        private System.Windows.Forms.TextBox DefaultNameTextBox;
        private System.Windows.Forms.Label DefaultNameLbl;
        private System.Windows.Forms.TabPage Advanced;
        private System.Windows.Forms.Label Deletedatalbl;
        private System.Windows.Forms.Button DeleteAllDataBtn;
        private System.Windows.Forms.Label DeleteLbl;
        private System.Windows.Forms.Label DestroyLbl;
        private System.Windows.Forms.Button DestroyAllDeletedBtn;
        private System.Windows.Forms.Label deleteaccount;
        private System.Windows.Forms.Button DeleteAccountBtn;
        private System.Windows.Forms.Label DeleteAccountLbl;
        private System.Windows.Forms.Label ResetLbl;
        private System.Windows.Forms.Button ResetDefaultsBtn;
        private System.Windows.Forms.Label ResetDefaultsLbl;
        private System.Windows.Forms.PictureBox BrowseIcon;
        private System.Windows.Forms.Label InvalidLbl;
        private System.Windows.Forms.Label ChangeCurrentPasswordLbl;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportDeletedRecordsBtn;
        private System.Windows.Forms.ComboBox DefaultFormatComboBox;
        private System.Windows.Forms.Label DeletedRecordsCountLbl;
        private System.Windows.Forms.Label PasswordGenerationLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DefaultCharListTextBox;
    }
}