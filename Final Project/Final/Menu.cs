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
        }
        void Log()
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        

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
            BorrowManage borrowManage = new BorrowManage();
            borrowManage.ShowDialog();
        }

        private void User_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Underdevelopment");
        }

        private void Quit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();

        }
    }
}
