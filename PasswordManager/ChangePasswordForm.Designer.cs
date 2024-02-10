namespace PasswordManager
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLbl = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ShowPasswordIcon1 = new System.Windows.Forms.PictureBox();
            this.ShowPasswordIcon2 = new System.Windows.Forms.PictureBox();
            this.InvalidLbl = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordIcon2)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.controlPanel.Size = new System.Drawing.Size(450, 30);
            this.controlPanel.TabIndex = 4;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLbl.Font = new System.Drawing.Font("Cascadia Code Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseLbl.Location = new System.Drawing.Point(412, 0);
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
            this.TitleLbl.Size = new System.Drawing.Size(363, 30);
            this.TitleLbl.TabIndex = 10;
            this.TitleLbl.Text = "Change Password";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(188, 108);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(226, 27);
            this.ConfirmPasswordTextBox.TabIndex = 28;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            // 
            // ConfirmPasswordLbl
            // 
            this.ConfirmPasswordLbl.AutoSize = true;
            this.ConfirmPasswordLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConfirmPasswordLbl.Location = new System.Drawing.Point(37, 111);
            this.ConfirmPasswordLbl.Name = "ConfirmPasswordLbl";
            this.ConfirmPasswordLbl.Size = new System.Drawing.Size(151, 21);
            this.ConfirmPasswordLbl.TabIndex = 27;
            this.ConfirmPasswordLbl.Text = "Confirm Password";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(188, 62);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(226, 27);
            this.NewPasswordTextBox.TabIndex = 26;
            this.NewPasswordTextBox.UseSystemPasswordChar = true;
            this.NewPasswordTextBox.TextChanged += new System.EventHandler(this.NewPasswordTextBox_TextChanged);
            // 
            // NewPasswordLbl
            // 
            this.NewPasswordLbl.AutoSize = true;
            this.NewPasswordLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewPasswordLbl.Location = new System.Drawing.Point(37, 65);
            this.NewPasswordLbl.Name = "NewPasswordLbl";
            this.NewPasswordLbl.Size = new System.Drawing.Size(123, 21);
            this.NewPasswordLbl.TabIndex = 25;
            this.NewPasswordLbl.Text = "New Password";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBtn.Location = new System.Drawing.Point(269, 221);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 45);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.Text = "Update";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelBtn.Location = new System.Drawing.Point(54, 221);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(128, 45);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ShowPasswordIcon1
            // 
            this.ShowPasswordIcon1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPasswordIcon1.BackColor = System.Drawing.SystemColors.Window;
            this.ShowPasswordIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordIcon1.Image = global::PasswordManager.Properties.Resources.hide_password_icon;
            this.ShowPasswordIcon1.Location = new System.Drawing.Point(391, 65);
            this.ShowPasswordIcon1.Name = "ShowPasswordIcon1";
            this.ShowPasswordIcon1.Size = new System.Drawing.Size(20, 20);
            this.ShowPasswordIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordIcon1.TabIndex = 35;
            this.ShowPasswordIcon1.TabStop = false;
            this.ShowPasswordIcon1.Click += new System.EventHandler(this.ShowPasswordIcon1_Click);
            // 
            // ShowPasswordIcon2
            // 
            this.ShowPasswordIcon2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPasswordIcon2.BackColor = System.Drawing.SystemColors.Window;
            this.ShowPasswordIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordIcon2.Image = global::PasswordManager.Properties.Resources.hide_password_icon;
            this.ShowPasswordIcon2.Location = new System.Drawing.Point(391, 111);
            this.ShowPasswordIcon2.Name = "ShowPasswordIcon2";
            this.ShowPasswordIcon2.Size = new System.Drawing.Size(20, 20);
            this.ShowPasswordIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordIcon2.TabIndex = 36;
            this.ShowPasswordIcon2.TabStop = false;
            this.ShowPasswordIcon2.Click += new System.EventHandler(this.ShowPasswordIcon2_Click);
            // 
            // InvalidLbl
            // 
            this.InvalidLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InvalidLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.InvalidLbl.Location = new System.Drawing.Point(36, 169);
            this.InvalidLbl.Name = "InvalidLbl";
            this.InvalidLbl.Size = new System.Drawing.Size(378, 36);
            this.InvalidLbl.TabIndex = 37;
            this.InvalidLbl.Text = "Your password and confirmation password must match.";
            this.InvalidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InvalidLbl.Visible = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.InvalidLbl);
            this.Controls.Add(this.ShowPasswordIcon2);
            this.Controls.Add(this.ShowPasswordIcon1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLbl);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewPasswordLbl);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePasswordForm";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordIcon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLbl;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label NewPasswordLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.PictureBox ShowPasswordIcon1;
        private System.Windows.Forms.PictureBox ShowPasswordIcon2;
        private System.Windows.Forms.Label InvalidLbl;
    }
}