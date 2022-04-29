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
            /*QuanLi kq= muonsach.QuanLis.Find(UNameBox.Text);
            if(kq != null)
            {
                string user = kq.username;
                user = user.TrimEnd();
                if (UNameBox.Text == user)
                {
                    MessageBox.Show("Da ton tai");
                    return;
                }
            }

            else
            {
                if(ConfirmBox.Text != PasswordBox.Text || ConfirmBox.Text == string.Empty || UNameBox.Text == string.Empty)
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    muonsach.QuanLis.Add(new QuanLi { username=UNameBox.Text,passw=PasswordBox.Text});
                    muonsach.SaveChanges();
                    MessageBox.Show("Thanh cong");
                }
                
            }*/
            if(UNameBox.Text !=""&&PasswordBox.Text !="")
            {
                LogInBLL logInBLL = new LogInBLL();
                if(logInBLL.SignInBLL(UNameBox.Text,PasswordBox.Text))
                {
                    MessageBox.Show("Thanh cong");
                }
                else
                {
                    MessageBox.Show("Da ton tai");
                }
            }
            else
            {
                MessageBox.Show("Nhap day du");
            }
        }
    }
}
