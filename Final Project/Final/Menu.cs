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
    public partial class MenuSelect : Form
    {
        
        public MenuSelect()
        {
            InitializeComponent();
            label1.Text = hidname;
            
        }
        public string hidname;
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
            bookManage.ShowDialog();
        }

        private void Reader_Click(object sender, EventArgs e)
        {
            ReaderManage readerManage = new ReaderManage();
            readerManage.ShowDialog();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            BorrowManage borrowManage = new BorrowManage(hidname);
            borrowManage.ShowDialog();
        }

        private void User_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Underdevelopment");
            UserDetail userDetail = new UserDetail(hidname);
            //userDetail.user = label1.Text;
            MessageBox.Show(hidname);
            userDetail.ShowDialog();

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
            authorManage.ShowDialog();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.ShowDialog();
        }
    }
}
