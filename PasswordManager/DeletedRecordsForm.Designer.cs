namespace PasswordManager
{
    partial class DeletedRecordsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletedRecordsForm));
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.DeletedRecordsLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RecordsTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.RecordCounterLbl = new System.Windows.Forms.Label();
            this.RestoreSelectedBtn = new System.Windows.Forms.Button();
            this.RestoreAllBtn = new System.Windows.Forms.Button();
            this.DestroySelectedBtn = new System.Windows.Forms.Button();
            this.DestroyAllBtn = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).BeginInit();
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
            this.controlPanel.Controls.Add(this.DeletedRecordsLbl, 1, 0);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 1;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Size = new System.Drawing.Size(600, 30);
            this.controlPanel.TabIndex = 4;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLbl.Font = new System.Drawing.Font("Cascadia Code Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseLbl.Location = new System.Drawing.Point(562, 0);
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
            // DeletedRecordsLbl
            // 
            this.DeletedRecordsLbl.AutoSize = true;
            this.DeletedRecordsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletedRecordsLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeletedRecordsLbl.Location = new System.Drawing.Point(43, 0);
            this.DeletedRecordsLbl.Name = "DeletedRecordsLbl";
            this.DeletedRecordsLbl.Size = new System.Drawing.Size(513, 30);
            this.DeletedRecordsLbl.TabIndex = 10;
            this.DeletedRecordsLbl.Text = "DeletedRecords";
            this.DeletedRecordsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.RecordsTable);
            this.panel1.Location = new System.Drawing.Point(9, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 573);
            this.panel1.TabIndex = 5;
            // 
            // RecordsTable
            // 
            this.RecordsTable.AllowUserToAddRows = false;
            this.RecordsTable.AllowUserToDeleteRows = false;
            this.RecordsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordsTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.RecordsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RecordsTable.ColumnHeadersHeight = 35;
            this.RecordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.url,
            this.user,
            this.password,
            this.note});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.RecordsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordsTable.Location = new System.Drawing.Point(0, 0);
            this.RecordsTable.MultiSelect = false;
            this.RecordsTable.Name = "RecordsTable";
            this.RecordsTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RecordsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RecordsTable.Size = new System.Drawing.Size(582, 573);
            this.RecordsTable.TabIndex = 1;
            this.RecordsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordsTable_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // url
            // 
            this.url.HeaderText = "URL";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "Username";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseBtn.Location = new System.Drawing.Point(12, 645);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(109, 38);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RecordCounterLbl
            // 
            this.RecordCounterLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RecordCounterLbl.AutoSize = true;
            this.RecordCounterLbl.Font = new System.Drawing.Font("Century", 10F);
            this.RecordCounterLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.RecordCounterLbl.Location = new System.Drawing.Point(9, 618);
            this.RecordCounterLbl.Name = "RecordCounterLbl";
            this.RecordCounterLbl.Size = new System.Drawing.Size(116, 17);
            this.RecordCounterLbl.TabIndex = 8;
            this.RecordCounterLbl.Text = "00 Records exist.";
            // 
            // RestoreSelectedBtn
            // 
            this.RestoreSelectedBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RestoreSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreSelectedBtn.Enabled = false;
            this.RestoreSelectedBtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RestoreSelectedBtn.ForeColor = System.Drawing.Color.Red;
            this.RestoreSelectedBtn.Location = new System.Drawing.Point(360, 645);
            this.RestoreSelectedBtn.Name = "RestoreSelectedBtn";
            this.RestoreSelectedBtn.Size = new System.Drawing.Size(109, 38);
            this.RestoreSelectedBtn.TabIndex = 10;
            this.RestoreSelectedBtn.Text = "Restore One";
            this.RestoreSelectedBtn.UseVisualStyleBackColor = true;
            this.RestoreSelectedBtn.Click += new System.EventHandler(this.RestoreSelectedBtn_Click);
            // 
            // RestoreAllBtn
            // 
            this.RestoreAllBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RestoreAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreAllBtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RestoreAllBtn.ForeColor = System.Drawing.Color.Red;
            this.RestoreAllBtn.Location = new System.Drawing.Point(476, 645);
            this.RestoreAllBtn.Name = "RestoreAllBtn";
            this.RestoreAllBtn.Size = new System.Drawing.Size(109, 38);
            this.RestoreAllBtn.TabIndex = 11;
            this.RestoreAllBtn.Text = "Restore All";
            this.RestoreAllBtn.UseVisualStyleBackColor = true;
            this.RestoreAllBtn.Click += new System.EventHandler(this.RestoreAllBtn_Click);
            // 
            // DestroySelectedBtn
            // 
            this.DestroySelectedBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DestroySelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DestroySelectedBtn.Enabled = false;
            this.DestroySelectedBtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DestroySelectedBtn.ForeColor = System.Drawing.Color.Red;
            this.DestroySelectedBtn.Location = new System.Drawing.Point(128, 645);
            this.DestroySelectedBtn.Name = "DestroySelectedBtn";
            this.DestroySelectedBtn.Size = new System.Drawing.Size(109, 38);
            this.DestroySelectedBtn.TabIndex = 12;
            this.DestroySelectedBtn.Text = "Destroy One";
            this.DestroySelectedBtn.UseVisualStyleBackColor = true;
            this.DestroySelectedBtn.Click += new System.EventHandler(this.DestroySelectedBtn_Click);
            // 
            // DestroyAllBtn
            // 
            this.DestroyAllBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DestroyAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DestroyAllBtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DestroyAllBtn.ForeColor = System.Drawing.Color.Red;
            this.DestroyAllBtn.Location = new System.Drawing.Point(244, 645);
            this.DestroyAllBtn.Name = "DestroyAllBtn";
            this.DestroyAllBtn.Size = new System.Drawing.Size(109, 38);
            this.DestroyAllBtn.TabIndex = 13;
            this.DestroyAllBtn.Text = "Destroy All";
            this.DestroyAllBtn.UseVisualStyleBackColor = true;
            this.DestroyAllBtn.Click += new System.EventHandler(this.DestroyAllBtn_Click);
            // 
            // DeletedRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.DestroyAllBtn);
            this.Controls.Add(this.DestroySelectedBtn);
            this.Controls.Add(this.RestoreAllBtn);
            this.Controls.Add(this.RestoreSelectedBtn);
            this.Controls.Add(this.RecordCounterLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "DeletedRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeletedRecordsForm";
            this.Load += new System.EventHandler(this.DeletedRecordsForm_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView RecordsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Label DeletedRecordsLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label RecordCounterLbl;
        private System.Windows.Forms.Button RestoreSelectedBtn;
        private System.Windows.Forms.Button RestoreAllBtn;
        private System.Windows.Forms.Button DestroySelectedBtn;
        private System.Windows.Forms.Button DestroyAllBtn;
    }
}