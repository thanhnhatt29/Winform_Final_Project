using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

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
            signIn.ShowDialog();
            //this.Hide();
            
        }

        private void butt_Login_Click(object sender, EventArgs e)
        {
            /*QuanLi kq= muonsach.QuanLis.Find(UNameBox.Text);
            if(kq!=null)
            {
                string pass = kq.passw;
                pass = pass.TrimEnd();
                if (PasswordBox.Text == pass)
                {
                    MenuSelect menuSelect = new MenuSelect();

                    menuSelect.label1.Text = "Chào " + UNameBox.Text;
                    menuSelect.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sai mat khau");
                }    
            }   

            else
            {
                MessageBox.Show("Tai khoan chua ton tai");
            }*/

            if(UNameBox.Text!="" &&PasswordBox.Text!="")
            {
                LogInBLL logInBLL = new LogInBLL();
                if (logInBLL.IsLoggedIn(UNameBox.Text, PasswordBox.Text))
                {
                    MenuSelect menuSelect = new MenuSelect(UNameBox.Text);

                    
                    //menuSelect.Message=UNameBox.Text;
                    //menuSelect.label1.Text = "Chào " + menuSelect;
                    menuSelect.hidname = UNameBox.Text;
                    menuSelect.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Sai mat khau");
                }
            }
            else
            {
                MessageBox.Show("Nhap day du");
            }
            
        }
    }
}
