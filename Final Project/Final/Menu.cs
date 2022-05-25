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
using DAL;

namespace Final
{
    public partial class MenuSelect : Form
    {
        
        public MenuSelect(string hidname)
        {
            InitializeComponent();
            Greet.Text = "Chào " + GetUserName(hidname);
        }
        public string hidname;
        public string GetUserName(string hidname)
        {
            LogInBLL logInBLL = new LogInBLL();
            QuanLy Info = logInBLL.InfoBLL(hidname);
            return Info.TenNhanVien.TrimEnd();
        }
        void Log()
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        /*public MenuSelect (string Message):this()
        {
            hidname = Message;
            label1.Text = hidname;
        }*/

        private void Book_Click(object sender, EventArgs e)
        {
            BookManage bookManage = new BookManage();
            Delete_All_ChildenForm();
            bookManage.MdiParent = this;
            bookManage.FormBorderStyle = FormBorderStyle.None;
            bookManage.Dock = DockStyle.Fill;
            bookManage.Show();
        }

        private void Reader_Click(object sender, EventArgs e)
        {
            ReaderManage readerManage = new ReaderManage();
            Delete_All_ChildenForm();
            readerManage.MdiParent = this;
            readerManage.FormBorderStyle = FormBorderStyle.None;
            readerManage.Dock = DockStyle.Fill;
            readerManage.Show();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            BorrowManage borrowManage = new BorrowManage(hidname);
            Delete_All_ChildenForm();
            borrowManage.MdiParent = this;
            borrowManage.FormBorderStyle = FormBorderStyle.None;
            borrowManage.Dock = DockStyle.Fill;
            borrowManage.Show();
        }

        private void User_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail(hidname);
            Delete_All_ChildenForm();
            userDetail.MdiParent = this;
            userDetail.FormBorderStyle = FormBorderStyle.None;
            userDetail.Dock = DockStyle.Fill;
            userDetail.Show();

        }

        private void Quit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void Author_Click(object sender, EventArgs e)
        {
            AuthorManage authorManage = new AuthorManage();
            authorManage.MdiParent = this;
            authorManage.FormBorderStyle = FormBorderStyle.None;
            authorManage.Dock = DockStyle.Fill;
            authorManage.Show();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            Delete_All_ChildenForm();
            card.MdiParent = this;
            card.FormBorderStyle = FormBorderStyle.None;
            card.Dock = DockStyle.Fill;
            card.Show();
        }
        public void Delete_All_ChildenForm()
        {
            //Greet.Hide();
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }
    }
}
