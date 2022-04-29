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
    public partial class Book : UserControl
    {
        public Book()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }
        void LoadData()
        {
            
        }
        void AddBinding()
        { 
            /*BookName.DataBindings.Add(new Binding("Text",dataGridView1,"Name"));
            Author.DataBindings.Add(new Binding("Text",dataGridView1,"Author"));
            Genre.DataBindings.Add(new Binding("Text", dataGridView1, "Genre"));
            Amount.DataBindings.Add(new Binding("Text", dataGridView1, "Amount"));*/
        }
        public string getBookName()
        {
            return BookName.Text;
        }
        public string getAuthor()
        {
            return Author.Text;
        }
        public string getGenre()
        {
            return Genre.SelectedItem.ToString();
        }

        public int getAmount()
        {
            return Convert.ToInt32(Amount.Text);
        }
        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
