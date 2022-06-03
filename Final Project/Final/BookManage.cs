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
using DTO;

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
            /*BookBLL bookBLL = new BookBLL();*/
            
            //Genre.DisplayMember = "TenTheLoai";

        }
        #region Methods
        void LoadBook()
        {
            BookBLL bookBLL = new BookBLL();
            List<BookDTO> list= bookBLL.LoadAll();
            if(list==null)
            {
                MessageBox.Show("Trong");
            }
            else
            {
                
            }
            dataGridBook.DataSource = list;
            Author.DataSource = bookBLL.TacGiaBLL();
            Genre.DataSource = bookBLL.Theloai();
            AuthorName.Enabled = false;

            BookName.Clear();
            BookID.Clear();
            Author.SelectedIndex = -1;
            Genre.SelectedIndex = -1;
            BookLocate.Clear();
            Year.Clear();
            Amount.Clear();
            AuthorName.Clear();

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

        void AddBook(string name, string id, string author, string genre, string amount, string location, string year,string authorname)
        {
            BookBLL bookBLL=new BookBLL();
            

            if(!bookBLL.TacGiaBLL().Contains(author))
            {
                bookBLL.AddAuthorBLL(author, authorname);
            }

            if(bookBLL.AddBookBLL(name, id, author, genre, amount, location, year))
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }    
            LoadBook();
        }

        void DelBook(string BookID)
        {
            BookBLL bookBLL =new BookBLL();
            if(!bookBLL.checkBook(BookID))
            {
                bookBLL.DelBookBLL(BookID);
                LoadBook();
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("Khong ton tai");
            }
        }

        void EditBook(string name,string id,string author, string genre, string amount, string location, string year)
        {
            BookBLL bookBLL=new BookBLL();
            bookBLL.EditBookBLL(name,id,author,genre,amount,location,year);
            LoadBook();
        }

        void FindBook(string ID,string Name,string AuthorID,string Genre, string Amount,string Location,string Year)
        {
            BookBLL bookBLL = new BookBLL();
            
            dataGridBook.DataSource = bookBLL.FindBookBLL(ID,Name,AuthorID,Genre,Amount,Location,Year);
            AddBinding();
        }

        void AddBinding()
        {
            BookName.DataBindings.Add(new Binding("Text", dataGridBook.DataSource, "TenSach"));
            Author.DataBindings.Add(new Binding("Text", dataGridBook.DataSource, "MaTacGia"));
            Genre.DataBindings.Add(new Binding("Text", dataGridBook.DataSource, "TenTheLoai"));
            Amount.DataBindings.Add(new Binding("Text", dataGridBook.DataSource, "SoLuongConLai"));
            BookID.DataBindings.Add(new Binding("Text", dataGridBook.DataSource, "MaSach"));
            BookLocate.DataBindings.Add(new Binding("Text", dataGridBook.DataSource, "ViTri"));
            Year.DataBindings.Add(new Binding("Text", dataGridBook.DataSource, "NamXuatBan"));
        }

        void Clear()
        {
            BookName.DataBindings.Clear();
            BookID.DataBindings.Clear();
            Author.DataBindings.Clear();
            Genre.DataBindings.Clear();
            Amount.DataBindings.Clear();
            Year.DataBindings.Clear();
            BookLocate.DataBindings.Clear();

        }


        void BoxEnable()
        {
            Author.Enabled = true;
            Genre.Enabled = true;
            Amount.Enabled = true;
            BookLocate.Enabled = true;
            Year.Enabled = true;
            BookID.Enabled = true;
            BookName.Enabled = true;
            
        }
        #endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ActivateButton();
            mode = 1;
            AuthorName.Enabled = true;
            Function.Text = "Them Sach";

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            ActivateButton();
            AddBinding();
            BoxEnable();
            mode = 2;

            Function.Text = "Xoa Sach";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ActivateButton();
            AddBinding();
            BoxEnable();
            BookID.Enabled = false;
            mode = 3;
            Function.Text = "Chinh sua Sach";

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            ActivateButton();
            mode = 4;
            BoxEnable();
            Function.Text = "Tim Sach";
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            ButtonDone();
            switch(mode)
            {
                case 1:
                    AddBook(BookName.Text, BookID.Text, Author.Text, Genre.Text,
                             Amount.Text, BookLocate.Text, Year.Text,AuthorName.Text);
                    break;
                case 2:
                    DelBook(BookID.Text);
                    break;
                case 3:
                    EditBook(BookName.Text,BookID.Text,Author.Text,Genre.Text,
                             Amount.Text,BookLocate.Text,Year.Text);
                    break;
                case 4:
                    FindBook(BookID.Text,BookName.Text,Author.Text,Genre.Text,Amount.Text,BookLocate.Text,Year.Text);
                    break;

            }    
            mode = 0;
            Clear();
            BoxEnable();
            Function.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ButtonDone();
            Clear();
            LoadBook();
            BoxEnable();
            mode = 0;

            Function.Text = "";
        }


        private void dataGridBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadBook();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            LoadBook();
        }

        private void Author_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void hươngDânChungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BookManage_Load(object sender, EventArgs e)
        {

        }
    }
}
