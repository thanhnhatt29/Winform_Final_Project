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
    public partial class BookAdd : Form
    {
        BookBLL bookBLL = new BookBLL();
        public BookAdd()
        {
            InitializeComponent();
            
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            /*if(bookBLL.AddBookBLL(IDBook.Text, BookName.Text, Genre.Text))
            {
                MessageBox.Show("Them thanh cong");
                this.Close();

            }
            else
            {
                MessageBox.Show("That bai");
            }*/
        }
    }
}
