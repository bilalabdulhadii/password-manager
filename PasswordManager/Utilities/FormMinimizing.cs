using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Utilities
{
    internal class FormMinimizing
    {
        private System.Windows.Forms.Label MinimizeLabel;
        private Form MinimizeForm;
        public FormMinimizing(Form MinimizeForm, System.Windows.Forms.Label MinimizeLabel) 
        {
            this.MinimizeLabel = MinimizeLabel;
            this.MinimizeForm = MinimizeForm;

            MinimizeLabel.MouseEnter += MinimizeBtn_MouseEnter;
            MinimizeLabel.MouseLeave += MinimizeBtn_MouseLeave;
            MinimizeLabel.Click += MinimizeBtn_Click;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            MinimizeForm.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            MinimizeLabel.ForeColor = System.Drawing.Color.White;
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLabel.ForeColor = System.Drawing.Color.Black;
        }
    }
}
