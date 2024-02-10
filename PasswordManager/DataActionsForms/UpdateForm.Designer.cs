namespace PasswordManager.DataActions
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.NewRecordLbl = new System.Windows.Forms.Label();
            this.UrlLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.InvalidLbl = new System.Windows.Forms.Label();
            this.NoteLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.GeneratePasswordLbl = new System.Windows.Forms.Label();
            this.GeneratePasswordBtn = new System.Windows.Forms.PictureBox();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratePasswordBtn)).BeginInit();
            this.SuspendLayout();
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
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 1;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Size = new System.Drawing.Size(500, 30);
            this.controlPanel.TabIndex = 16;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLbl.Font = new System.Drawing.Font("Cascadia Code Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseLbl.Location = new System.Drawing.Point(462, 0);
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
            // NoteTextBox
            // 
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoteTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoteTextBox.Location = new System.Drawing.Point(161, 341);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(299, 116);
            this.NoteTextBox.TabIndex = 26;
            // 
            // NewRecordLbl
            // 
            this.NewRecordLbl.AutoSize = true;
            this.NewRecordLbl.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewRecordLbl.Location = new System.Drawing.Point(131, 66);
            this.NewRecordLbl.Name = "NewRecordLbl";
            this.NewRecordLbl.Size = new System.Drawing.Size(239, 33);
            this.NewRecordLbl.TabIndex = 25;
            this.NewRecordLbl.Text = "Update Password";
            // 
            // UrlLbl
            // 
            this.UrlLbl.AutoSize = true;
            this.UrlLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlLbl.Location = new System.Drawing.Point(83, 157);
            this.UrlLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.UrlLbl.Name = "UrlLbl";
            this.UrlLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.UrlLbl.Size = new System.Drawing.Size(73, 23);
            this.UrlLbl.TabIndex = 13;
            this.UrlLbl.Text = "URL *";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(40, 211);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.UsernameLbl.Size = new System.Drawing.Size(116, 23);
            this.UsernameLbl.TabIndex = 14;
            this.UsernameLbl.Text = "Username *";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(43, 268);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.PasswordLbl.Size = new System.Drawing.Size(113, 23);
            this.PasswordLbl.TabIndex = 15;
            this.PasswordLbl.Text = "Password *";
            // 
            // InvalidLbl
            // 
            this.InvalidLbl.AutoSize = true;
            this.InvalidLbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InvalidLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.InvalidLbl.Location = new System.Drawing.Point(140, 555);
            this.InvalidLbl.Name = "InvalidLbl";
            this.InvalidLbl.Size = new System.Drawing.Size(220, 19);
            this.InvalidLbl.TabIndex = 23;
            this.InvalidLbl.Text = "Please fill in all required fields.";
            this.InvalidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InvalidLbl.Visible = false;
            // 
            // NoteLbl
            // 
            this.NoteLbl.AutoSize = true;
            this.NoteLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLbl.Location = new System.Drawing.Point(82, 343);
            this.NoteLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.NoteLbl.Name = "NoteLbl";
            this.NoteLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.NoteLbl.Size = new System.Drawing.Size(59, 23);
            this.NoteLbl.TabIndex = 17;
            this.NoteLbl.Text = "Note";
            this.NoteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBtn.Location = new System.Drawing.Point(339, 485);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(117, 47);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearBtn.Location = new System.Drawing.Point(194, 485);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(117, 47);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelBtn.Location = new System.Drawing.Point(44, 485);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(117, 47);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UrlTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrlTextBox.Location = new System.Drawing.Point(161, 156);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(299, 27);
            this.UrlTextBox.TabIndex = 21;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTextBox.Location = new System.Drawing.Point(161, 210);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(299, 27);
            this.UsernameTextBox.TabIndex = 22;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTextBox.Location = new System.Drawing.Point(161, 267);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(299, 27);
            this.PasswordTextBox.TabIndex = 24;
            // 
            // GeneratePasswordLbl
            // 
            this.GeneratePasswordLbl.AutoSize = true;
            this.GeneratePasswordLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratePasswordLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeneratePasswordLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.GeneratePasswordLbl.Location = new System.Drawing.Point(194, 302);
            this.GeneratePasswordLbl.Name = "GeneratePasswordLbl";
            this.GeneratePasswordLbl.Size = new System.Drawing.Size(219, 21);
            this.GeneratePasswordLbl.TabIndex = 28;
            this.GeneratePasswordLbl.Text = "Generate a strong password";
            this.GeneratePasswordLbl.Click += new System.EventHandler(this.GeneratePasswordLbl_Click);
            // 
            // GeneratePasswordBtn
            // 
            this.GeneratePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratePasswordBtn.Image = global::PasswordManager.Properties.Resources.generate_icon_50x50px;
            this.GeneratePasswordBtn.Location = new System.Drawing.Point(163, 299);
            this.GeneratePasswordBtn.Name = "GeneratePasswordBtn";
            this.GeneratePasswordBtn.Size = new System.Drawing.Size(31, 27);
            this.GeneratePasswordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeneratePasswordBtn.TabIndex = 27;
            this.GeneratePasswordBtn.TabStop = false;
            this.GeneratePasswordBtn.Click += new System.EventHandler(this.GeneratePasswordBtn_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.GeneratePasswordLbl);
            this.Controls.Add(this.GeneratePasswordBtn);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.NewRecordLbl);
            this.Controls.Add(this.UrlLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.InvalidLbl);
            this.Controls.Add(this.NoteLbl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratePasswordBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label NewRecordLbl;
        private System.Windows.Forms.Label UrlLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label InvalidLbl;
        private System.Windows.Forms.Label NoteLbl;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label GeneratePasswordLbl;
        private System.Windows.Forms.PictureBox GeneratePasswordBtn;
    }
}