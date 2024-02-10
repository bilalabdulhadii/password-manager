using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Utilities
{
    internal class FormControls
    {
        private bool isDragging = false;
        private int mouseX, mouseY;
        private List<Control> ControlPanels;
        private Label closeLabel;

        public FormControls(Label closeLabel,params Control[] controls)
        {
            this.closeLabel = closeLabel;

            ControlPanels = new List<Control>(controls);

            foreach (Control controlPanel in ControlPanels)
            {
                controlPanel.MouseDown += controlPanel_MouseDown;
                controlPanel.MouseMove += controlPanel_MouseMove;
                controlPanel.MouseUp += controlPanel_MouseUp;
            }

            closeLabel.MouseEnter += CloseButton_MouseEnter;
            closeLabel.MouseLeave += CloseButton_MouseLeave;
            closeLabel.Click += CloseButton_Click;
        }

        // Other methods and event handlers...

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void controlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Control control = sender as Control;
                if (control != null)
                {
                    Form form = control.FindForm();
                    if (form != null)
                    {
                        int newX = form.Left + e.X - mouseX;
                        int newY = form.Top + e.Y - mouseY;
                        form.Location = new System.Drawing.Point(newX, newY);
                    }
                }
            }
        }

        private void controlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = System.Drawing.Color.OrangeRed; // Change font color on mouse over
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = System.Drawing.Color.Black; // Change font color on mouse leave
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form form = closeLabel.FindForm();
            if (form != null)
            {
                form.Close(); // Close the form on button click
            }
        }
    }
}
