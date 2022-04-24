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
            bookManage.Show();
        }

        private void Reader_Click(object sender, EventArgs e)
        {

        }

        private void Borrow_Click(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void Quit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();

        }
    }
}
