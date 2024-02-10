using PasswordManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PasswordManager
{
    public partial class CustomMessageBoxForm : Form
    {
        private DialogResult result = DialogResult.None;

        public CustomMessageBoxForm(string messageText, string caption = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon, TitleLbl);
            MessageTextLbl.Text = messageText;
            TitleLbl.Text = caption;
            SetButtons(buttons);
            SetIcon(icon);
        }

        public CustomMessageBoxForm(string messageText, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton) 
            : this(messageText, caption, buttons, icon)
        {
            SetDefaultButton(defaultButton);
        }

        public static DialogResult Show(string messageText, string caption = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            using (CustomMessageBoxForm messageBox = new CustomMessageBoxForm(messageText, caption, buttons, icon))
            {
                return messageBox.ShowDialogResult();
            }
        }

        public static DialogResult Show(string messageText, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            using (CustomMessageBoxForm messageBox = new CustomMessageBoxForm(messageText, caption, buttons, icon, defaultButton))
            {
                return messageBox.ShowDialogResult();
            }
        }

        private void SetButtons(MessageBoxButtons buttons)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    OneButton("Ok");
                    break;
                case MessageBoxButtons.OKCancel:
                    TwoButtons("Ok", "Cancel");
                    break;
                case MessageBoxButtons.YesNo:
                    TwoButtons("Yes", "No");
                    break;
                case MessageBoxButtons.YesNoCancel:
                    ThreeButtons("Yes", "No", "Cancel");
                    break;
                case MessageBoxButtons.RetryCancel:
                    TwoButtons("Retry", "Cancel");
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    ThreeButtons("Abort", "Retry", "Ignore");
                    break;
                default:
                    break;
            }
        }

        private void SetIcon(MessageBoxIcon icon)
        {
            if (icon == MessageBoxIcon.Information)
            {
                IconBox.Image = Properties.Resources.info_icon_100x100px;
            }
            else if (icon == MessageBoxIcon.Question)
            {
                IconBox.Image = Properties.Resources.question_icon_100x100px;
            }
            else if (icon == MessageBoxIcon.Warning)
            {
                IconBox.Image = Properties.Resources.warning_icon_100x100px;
            }
            else if (icon == MessageBoxIcon.Error)
            {
                IconBox.Image = Properties.Resources.error_icon_100x100px;
            }
            else if (icon == MessageBoxIcon.Hand)
            {
                IconBox.Image = Properties.Resources.hand_icon_100x100px;
            }
            else if (icon == MessageBoxIcon.Stop)
            {
                IconBox.Image = Properties.Resources.stop_icon_100x100px;
            }
            else if (icon == MessageBoxIcon.Asterisk)
            {
                IconBox.Image = Properties.Resources.asterisk_icon_100x100px;
            }
            else if (icon == MessageBoxIcon.Exclamation)
            {
                IconBox.Image = Properties.Resources.exclamation_icon_100x100px;
            }
            else
            {
                IconBox.Image = null; // No icon
                IconBox.Visible = false;
                MessageTextLbl.Location = new Point(40, 40);
                MessageTextLbl.MaximumSize = new Size(395, MessageTextLbl.MaximumSize.Height);

            }
        }

        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1:
                    FirstBtn.Select();
                    break;
                case MessageBoxDefaultButton.Button2:
                    SecondBtn.Select();
                    break;
                case MessageBoxDefaultButton.Button3:
                    ThirdBtn.Select();
                    break;
                default:
                    // No default button specified or invalid value
                    break;
            }
        }

        private void OneButton(string One)
        {
            ThirdBtn.Text = One;
            ThirdBtn.DialogResult = GetDialogResult(One);
            FirstBtn.Visible = false;
            SecondBtn.Visible = false;
            ThirdBtn.Visible = true;
            ThirdBtn.Select();
        }

        private void TwoButtons(string One, string Two)
        {
            SecondBtn.Text = One;
            ThirdBtn.Text = Two;
            SecondBtn.DialogResult = GetDialogResult(One);
            ThirdBtn.DialogResult = GetDialogResult(Two);
            FirstBtn.Visible = false;
            SecondBtn.Visible = true;
            ThirdBtn.Visible = true;
            SecondBtn.Select();
            if (One == "Yes" && Two == "No") { CloseLbl.Enabled = false; }
        }

        private void ThreeButtons(string One, string Two, string Three)
        {
            FirstBtn.Text = One;
            SecondBtn.Text = Two;
            ThirdBtn.Text = Three;
            FirstBtn.DialogResult = GetDialogResult(One);
            SecondBtn.DialogResult = GetDialogResult(Two);
            ThirdBtn.DialogResult = GetDialogResult(Three);
            FirstBtn.Visible = true;
            SecondBtn.Visible = true;
            ThirdBtn.Visible = true;
            FirstBtn.Select();
            if (One == "Abort" && Two == "Retry" && Three == "Ignore") { CloseLbl.Enabled = false; }
        }

        private DialogResult GetDialogResult(string buttonText)
        {
            // Map button text to DialogResult
            switch (buttonText)
            {
                case "Ok":
                    return DialogResult.OK;
                case "Yes":
                    return DialogResult.Yes;
                case "No":
                    return DialogResult.No;
                case "Cancel":
                    return DialogResult.Cancel;
                case "Abort":
                    return DialogResult.Abort;
                case "Retry":
                    return DialogResult.Retry;
                case "Ignore":
                    return DialogResult.Ignore;
                default:
                    return DialogResult.None;
            }
        }

        public DialogResult ShowDialogResult()
        {
            ShowDialog();
            return result;
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            result = FirstBtn.DialogResult;
            Close();
        }

        private void SecondBtn_Click(object sender, EventArgs e)
        {
            result = SecondBtn.DialogResult;
            Close();
        }

        private void ThirdBtn_Click(object sender, EventArgs e)
        {
            result = ThirdBtn.DialogResult;
            Close();
        }
    }
}
