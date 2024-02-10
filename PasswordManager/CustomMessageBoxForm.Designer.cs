namespace PasswordManager
{
    partial class CustomMessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBoxForm));
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.MessageTextLbl = new System.Windows.Forms.Label();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.SecondBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.ThirdBtn = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            this.MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.controlPanel.TabIndex = 17;
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
            this.TitleLbl.Text = "Title";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageTextLbl
            // 
            this.MessageTextLbl.AutoSize = true;
            this.MessageTextLbl.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MessageTextLbl.Location = new System.Drawing.Point(95, 20);
            this.MessageTextLbl.Margin = new System.Windows.Forms.Padding(0);
            this.MessageTextLbl.MaximumSize = new System.Drawing.Size(340, 0);
            this.MessageTextLbl.Name = "MessageTextLbl";
            this.MessageTextLbl.Padding = new System.Windows.Forms.Padding(0, 0, 20, 30);
            this.MessageTextLbl.Size = new System.Drawing.Size(323, 72);
            this.MessageTextLbl.TabIndex = 22;
            this.MessageTextLbl.Text = "Are you sure you want to delete this record?";
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MessagePanel.AutoScroll = true;
            this.MessagePanel.AutoSize = true;
            this.MessagePanel.Controls.Add(this.IconBox);
            this.MessagePanel.Controls.Add(this.MessageTextLbl);
            this.MessagePanel.Location = new System.Drawing.Point(0, 30);
            this.MessagePanel.MaximumSize = new System.Drawing.Size(450, 500);
            this.MessagePanel.MinimumSize = new System.Drawing.Size(450, 100);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(450, 100);
            this.MessagePanel.TabIndex = 24;
            // 
            // IconBox
            // 
            this.IconBox.Location = new System.Drawing.Point(12, 14);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(75, 75);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconBox.TabIndex = 29;
            this.IconBox.TabStop = false;
            // 
            // SecondBtn
            // 
            this.SecondBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SecondBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SecondBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondBtn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SecondBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondBtn.Location = new System.Drawing.Point(174, 143);
            this.SecondBtn.Name = "SecondBtn";
            this.SecondBtn.Size = new System.Drawing.Size(104, 45);
            this.SecondBtn.TabIndex = 28;
            this.SecondBtn.Text = "Second";
            this.SecondBtn.UseVisualStyleBackColor = false;
            this.SecondBtn.Visible = false;
            this.SecondBtn.Click += new System.EventHandler(this.SecondBtn_Click);
            // 
            // FirstBtn
            // 
            this.FirstBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FirstBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstBtn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstBtn.Location = new System.Drawing.Point(36, 143);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(104, 45);
            this.FirstBtn.TabIndex = 27;
            this.FirstBtn.Text = "First";
            this.FirstBtn.UseVisualStyleBackColor = false;
            this.FirstBtn.Visible = false;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // ThirdBtn
            // 
            this.ThirdBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ThirdBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ThirdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThirdBtn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ThirdBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThirdBtn.Location = new System.Drawing.Point(315, 143);
            this.ThirdBtn.Name = "ThirdBtn";
            this.ThirdBtn.Size = new System.Drawing.Size(104, 45);
            this.ThirdBtn.TabIndex = 26;
            this.ThirdBtn.Text = "Third";
            this.ThirdBtn.UseVisualStyleBackColor = false;
            this.ThirdBtn.Visible = false;
            this.ThirdBtn.Click += new System.EventHandler(this.ThirdBtn_Click);
            // 
            // CustomMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.SecondBtn);
            this.Controls.Add(this.FirstBtn);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.ThirdBtn);
            this.Controls.Add(this.MessagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "CustomMessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessageBox";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label MessageTextLbl;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.Button SecondBtn;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Button ThirdBtn;
        private System.Windows.Forms.PictureBox IconBox;
    }
}