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
    public partial class ChangePasswordForm : Form
    {
        private int userid;
        public ChangePasswordForm(int userid)
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon, TitleLbl);
            this.userid = userid;
        }

        private void updatePasswordState()
        {
            if (string.IsNullOrEmpty(NewPasswordTextBox.Text) && string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
            {
                InvalidLbl.Visible = false;
                SaveBtn.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(NewPasswordTextBox.Text) && string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
            {
                if (NewPasswordTextBox.Text.Length < 4 && string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
                {
                    InvalidLbl.Text = "Your password must contain at least 4 characters.";
                    InvalidLbl.Visible = true;
                    SaveBtn.Enabled = false;

                }
                else if (NewPasswordTextBox.Text.Length >= 4 && string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
                {
                    InvalidLbl.Text = "Please confirm your password.";
                    InvalidLbl.Visible = true;
                    SaveBtn.Enabled = false;
                }
            }
            else if (string.IsNullOrEmpty(NewPasswordTextBox.Text) && !string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
            {
                if (ConfirmPasswordTextBox.Text.Length < 4 && string.IsNullOrEmpty(NewPasswordTextBox.Text))
                {
                    InvalidLbl.Text = "Your password must contain at least 4 characters.";
                    InvalidLbl.Visible = true;
                    SaveBtn.Enabled = false;
                }
                else if (ConfirmPasswordTextBox.Text.Length >= 4 && string.IsNullOrEmpty(NewPasswordTextBox.Text))
                {
                    InvalidLbl.Text = "Please confirm your password.";
                    InvalidLbl.Visible = true;
                    SaveBtn.Enabled = false;
                }
            }
            else if (!string.IsNullOrEmpty(NewPasswordTextBox.Text) && !string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
            {
                if (NewPasswordTextBox.Text.Length < 4 && ConfirmPasswordTextBox.Text.Length < 4)
                {
                    InvalidLbl.Text = "Your password must contain at least 4 characters.";
                    InvalidLbl.Visible = true;
                    SaveBtn.Enabled = false;
                }
                else if (NewPasswordTextBox.Text.Length >= 4 && ConfirmPasswordTextBox.Text.Length < 4)
                {
                    InvalidLbl.Text = "Your password and confirmation password must match.";
                    InvalidLbl.Visible = true;
                    SaveBtn.Enabled = false;
                }
                else if (NewPasswordTextBox.Text.Length < 4 && ConfirmPasswordTextBox.Text.Length >= 4)
                {
                    InvalidLbl.Text = "Your password and confirmation password must match.";
                    InvalidLbl.Visible = true;
                    SaveBtn.Enabled = false;
                }
                else if (NewPasswordTextBox.Text.Length >= 4 && ConfirmPasswordTextBox.Text.Length >= 4)
                {
                    if (NewPasswordTextBox.Text == ConfirmPasswordTextBox.Text)
                    {
                        InvalidLbl.Visible = false;
                        SaveBtn.Enabled = true;

                    }
                    else
                    {
                        InvalidLbl.Text = "Your password and confirmation password must match.";
                        InvalidLbl.Visible = true;
                        SaveBtn.Enabled = false;
                    }
                }
            }
        }

        private void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            updatePasswordState();
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            updatePasswordState();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // Create the SQL update query
                string query = "UPDATE users SET password = @password WHERE id = @id;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@password", NewPasswordTextBox.Text);
                    command.Parameters.AddWithValue("@id", userid);

                    // Execute the update query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Password updated successfully
                        CustomMessageBoxForm.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        // No rows affected, possibly user with the given ID not found
                        CustomMessageBoxForm.Show("Failed to update the password. User not found or password unchanged.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordIcon1_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.UseSystemPasswordChar)
            {
                ShowPasswordIcon1.Image = Properties.Resources.show_password_icon;
                NewPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ShowPasswordIcon1.Image = Properties.Resources.hide_password_icon;
                NewPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void ShowPasswordIcon2_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.UseSystemPasswordChar)
            {
                ShowPasswordIcon2.Image = Properties.Resources.show_password_icon;
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ShowPasswordIcon2.Image = Properties.Resources.hide_password_icon;
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
