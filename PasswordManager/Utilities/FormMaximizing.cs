using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Utilities
{
    internal class FormMaximizing
    {
        private System.Windows.Forms.Label MaximizeLabel;
        private Form MaximizeForm;
        public FormMaximizing(Form MinimizeForm, System.Windows.Forms.Label MaximizeLabel)
        {
            this.MaximizeLabel = MaximizeLabel;
            this.MaximizeForm = MinimizeForm;

            MaximizeLabel.MouseEnter += MinimizeBtn_MouseEnter;
            MaximizeLabel.MouseLeave += MinimizeBtn_MouseLeave;
            MaximizeLabel.Click += MinimizeBtn_Click;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            if (MaximizeForm.WindowState.ToString() == "Normal")
            {
                MaximizeForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MaximizeForm.WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            MaximizeLabel.ForeColor = System.Drawing.Color.White;
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            MaximizeLabel.ForeColor = System.Drawing.Color.Black;
        }
    }
}
