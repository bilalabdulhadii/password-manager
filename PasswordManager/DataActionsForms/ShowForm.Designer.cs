namespace PasswordManager.DataActions
{
    partial class ShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowForm));
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UrlLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.NoteLbl = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.LogoNameImage = new System.Windows.Forms.PictureBox();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoNameImage)).BeginInit();
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
            this.controlPanel.TabIndex = 2;
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
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.Location = new System.Drawing.Point(190, 505);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(117, 47);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBtn.Location = new System.Drawing.Point(337, 505);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(117, 47);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseBtn.Location = new System.Drawing.Point(47, 505);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(117, 47);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Location = new System.Drawing.Point(377, 111);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(76, 25);
            this.PrintBtn.TabIndex = 6;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.89116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.10884F));
            this.tableLayoutPanel1.Controls.Add(this.UrlLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UsernameLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NoteLbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.UrlTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UsernameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NoteTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 300);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // UrlLbl
            // 
            this.UrlLbl.AutoSize = true;
            this.UrlLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlLbl.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlLbl.Location = new System.Drawing.Point(4, 6);
            this.UrlLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.UrlLbl.Name = "UrlLbl";
            this.UrlLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.UrlLbl.Size = new System.Drawing.Size(106, 48);
            this.UrlLbl.TabIndex = 0;
            this.UrlLbl.Text = "URL";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameLbl.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(4, 60);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.UsernameLbl.Size = new System.Drawing.Size(106, 48);
            this.UsernameLbl.TabIndex = 1;
            this.UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLbl.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(4, 114);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.PasswordLbl.Size = new System.Drawing.Size(106, 48);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password";
            // 
            // NoteLbl
            // 
            this.NoteLbl.AutoSize = true;
            this.NoteLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoteLbl.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLbl.Location = new System.Drawing.Point(4, 168);
            this.NoteLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.NoteLbl.Name = "NoteLbl";
            this.NoteLbl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.NoteLbl.Size = new System.Drawing.Size(106, 24);
            this.NoteLbl.TabIndex = 3;
            this.NoteLbl.Text = "Note";
            this.NoteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrlTextBox.Location = new System.Drawing.Point(119, 6);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.ReadOnly = true;
            this.UrlTextBox.Size = new System.Drawing.Size(280, 27);
            this.UrlTextBox.TabIndex = 8;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTextBox.Location = new System.Drawing.Point(119, 60);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(280, 27);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTextBox.Location = new System.Drawing.Point(119, 114);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(280, 27);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoteTextBox.Location = new System.Drawing.Point(119, 168);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(280, 126);
            this.NoteTextBox.TabIndex = 11;
            // 
            // LogoNameImage
            // 
            this.LogoNameImage.Image = global::PasswordManager.Properties.Resources.LogoName;
            this.LogoNameImage.Location = new System.Drawing.Point(10, 39);
            this.LogoNameImage.Name = "LogoNameImage";
            this.LogoNameImage.Size = new System.Drawing.Size(146, 74);
            this.LogoNameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoNameImage.TabIndex = 8;
            this.LogoNameImage.TabStop = false;
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.LogoNameImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "ShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowForm";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoNameImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UrlLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label NoteLbl;
        private System.Windows.Forms.PictureBox LogoNameImage;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox NoteTextBox;
    }
}