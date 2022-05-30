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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void password_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_checkBox.CheckState == CheckState.Checked)
                password_textBox.UseSystemPasswordChar = false;
            else
                password_textBox.UseSystemPasswordChar = true;
        }



        private void register_button_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
