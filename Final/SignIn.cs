using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void ConcealPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ConcealPass.Checked == true)
            {
                PasswordBox.UseSystemPasswordChar = false;
                ConfirmBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
                ConfirmBox.UseSystemPasswordChar = true;
            }
        }

        private void linkLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void butt_Sign_Click(object sender, EventArgs e)
        {
            if(ConfirmBox.Text != PasswordBox.Text || ConfirmBox.Text==string.Empty || UNameBox.Text==string.Empty)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Thành công");
            }
        }
    }
}
