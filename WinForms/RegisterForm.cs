using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void show_pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass_checkBox.CheckState == CheckState.Checked)
                password_textBox.UseSystemPasswordChar = false;
            else
                password_textBox.UseSystemPasswordChar = true;
        }

        private void show_confirm_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_confirm_checkBox.CheckState == CheckState.Checked)
                confirm_textBox.UseSystemPasswordChar = false;
            else
                confirm_textBox.UseSystemPasswordChar = true;
        }
    }
}
