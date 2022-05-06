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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void ConcealPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ConcealPass.Checked==true)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }    
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
            }
        }

        private void linkSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SignIn signIn = new SignIn();
            signIn.UNameBox.Text=UNameBox.Text;
            signIn.Show();
            this.Hide();
            
        }

        private void butt_Login_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "1")
            {
                MenuSelect menuSelect = new MenuSelect();

                menuSelect.label1.Text = "Chào " + UNameBox.Text;
                menuSelect.Show();

                this.Hide();
                

            }
        }
    }
}
