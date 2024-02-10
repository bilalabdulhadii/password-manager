namespace PasswordManager.DataActionsForms
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveAsLbl = new System.Windows.Forms.Label();
            this.FileTypesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrowseIcon = new System.Windows.Forms.PictureBox();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseIcon)).BeginInit();
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
            this.controlPanel.Controls.Add(this.TitleLbl, 1, 0);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 1;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Size = new System.Drawing.Size(500, 30);
            this.controlPanel.TabIndex = 4;
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
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleLbl.Location = new System.Drawing.Point(43, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(413, 30);
            this.TitleLbl.TabIndex = 10;
            this.TitleLbl.Text = "Save As";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBtn.Location = new System.Drawing.Point(319, 319);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(117, 47);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelBtn.Location = new System.Drawing.Point(64, 319);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(117, 47);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveAsLbl
            // 
            this.SaveAsLbl.AutoSize = true;
            this.SaveAsLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveAsLbl.Location = new System.Drawing.Point(68, 256);
            this.SaveAsLbl.Name = "SaveAsLbl";
            this.SaveAsLbl.Size = new System.Drawing.Size(99, 25);
            this.SaveAsLbl.TabIndex = 12;
            this.SaveAsLbl.Text = "File type";
            // 
            // FileTypesComboBox
            // 
            this.FileTypesComboBox.DisplayMember = "pdf";
            this.FileTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FileTypesComboBox.FormattingEnabled = true;
            this.FileTypesComboBox.Location = new System.Drawing.Point(175, 256);
            this.FileTypesComboBox.Name = "FileTypesComboBox";
            this.FileTypesComboBox.Size = new System.Drawing.Size(270, 28);
            this.FileTypesComboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "File name";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FileNameTextBox.Location = new System.Drawing.Point(175, 210);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(270, 26);
            this.FileNameTextBox.TabIndex = 15;
            this.FileNameTextBox.Text = "RecordsTable";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PathTextBox.Location = new System.Drawing.Point(55, 100);
            this.PathTextBox.Multiline = true;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PathTextBox.Size = new System.Drawing.Size(334, 85);
            this.PathTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Browse:";
            // 
            // BrowseIcon
            // 
            this.BrowseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseIcon.Image = global::PasswordManager.Properties.Resources.openedfolder_icon_50x50px;
            this.BrowseIcon.Location = new System.Drawing.Point(398, 96);
            this.BrowseIcon.Name = "BrowseIcon";
            this.BrowseIcon.Size = new System.Drawing.Size(47, 35);
            this.BrowseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BrowseIcon.TabIndex = 18;
            this.BrowseIcon.TabStop = false;
            this.BrowseIcon.Click += new System.EventHandler(this.BrowseIcon_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.BrowseIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileTypesComboBox);
            this.Controls.Add(this.SaveAsLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label SaveAsLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.ComboBox FileTypesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BrowseIcon;
    }
}