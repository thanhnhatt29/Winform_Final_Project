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
    
    public partial class BookManage : Form
    {
        int mode = 0;
        
        public BookManage()
        {
            InitializeComponent();
            LoadBook();
            buttonDo.Enabled = false;
            buttonCancel.Enabled = false;    
            
        }
        #region Methods
        void LoadBook()
        {
            BookBLL bookBLL = new BookBLL();
            dataGridBook.DataSource = bookBLL.LoadAll();
        }

        void ActivateButton()
        {
            buttonAdd.Enabled = false;
            buttonDel.Enabled = false;
            buttonEdit.Enabled = false;
            buttonFind.Enabled = false;

            buttonDo.Enabled = true;
            buttonCancel.Enabled = true;
        }

        void ButtonDone()
        {
            buttonAdd.Enabled = true;
            buttonDel.Enabled = true;
            buttonEdit.Enabled = true;
            buttonFind.Enabled = true;

            buttonDo.Enabled = false;
            buttonCancel.Enabled = false;
        }

        void AddBook()
        {

        }

        void DelBook()
        {

        }

        void EditBook()
        {

        }

        void FindBook(string ID,string Name)
        {
            BookBLL bookBLL = new BookBLL();
            dataGridBook.DataSource = bookBLL.FindBookBLL(ID,Name);
        }
#endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ActivateButton();
            mode = 1;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            ActivateButton();
            mode = 2;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ActivateButton();
            mode = 3;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            ActivateButton();
            mode = 4;
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            ButtonDone();
            switch(mode)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    DelBook();
                    break;
                case 3:
                    EditBook();
                    break;
                case 4:
                    FindBook(BookID.Text,BookName.Text);
                    break;

            }    
            mode = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ButtonDone();
            mode = 0;
        }

        
    }
}
