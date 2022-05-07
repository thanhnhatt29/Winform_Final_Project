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
    public partial class ReaderManage : Form
    {
        ReaderBLL reader = new ReaderBLL();
        public ReaderManage()
        {
            InitializeComponent();
            Load();
        }
        
        #region Funtions

        public void LoadData()
        {
            dataGridViewReader.DataSource = reader.LoadAll();
        }

        public void Load()
        {
            LoadData();
            ReaderID.Enabled = false;
            ReaderAdr.Enabled = false;  
            ReaderName.Enabled = false; 
            ReaderPhone.Enabled = false;
            ReaderID.Clear();
            ReaderName.Clear();
            ReaderAdr.Clear();
            ReaderPhone.Clear();
        }

        void AddBinding()
        {
            ClearBinding();
            ReaderID.DataBindings.Add("Text", dataGridViewReader.DataSource, "madocgia");
            ReaderName.DataBindings.Add("Text", dataGridViewReader.DataSource, "tendocgia");
            ReaderAdr.DataBindings.Add("Text", dataGridViewReader.DataSource, "diachi");
            ReaderPhone.DataBindings.Add("Text", dataGridViewReader.DataSource, "sdt");

        }
        void ClearBinding()
        {
            ReaderID.DataBindings.Clear();
            ReaderName.DataBindings.Clear();
            ReaderAdr.DataBindings.Clear();
            ReaderPhone.DataBindings.Clear();
        }

        #endregion

        #region Events
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ReaderAdd readerAdd = new ReaderAdd();
            readerAdd.ShowDialog();
            Load();
        }

        private void dataGridViewReader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Load();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            if (reader.EditReaderBLL(ReaderID.Text, ReaderName.Text, ReaderAdr.Text, ReaderPhone.Text))
            {
                MessageBox.Show("Sua thanh cong");
                Load();
            }
            else
            {
                MessageBox.Show("That bai");
            }
            buttonedit1.Show();
        }

        private void buttonedit1_Click(object sender, EventArgs e)
        {
            AddBinding();
            ReaderAdr.Enabled = true;
            ReaderPhone.Enabled = true;
            ReaderName.Enabled = true; 
            buttonedit1.Hide();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string id_del = dataGridViewReader.CurrentRow.Cells[0].Value.ToString();
            if (reader.DelReaderBLL(id_del))
            {
                MessageBox.Show("Xoa thanh cong");
                //Load();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dontRun = false;
            ReaderName.Enabled = true;
            buttonFind.Hide();
        }

        private void buttonUnFind_Click(object sender, EventArgs e)
        {
            dontRun = true;
            ReaderName.Enabled = false;
            buttonFind.Show();
        }
        bool dontRun = true;
        private void ReaderName_TextChanged(object sender, EventArgs e)
        {
            if (dontRun == false)
            {
                ClearBinding();
                if (ReaderName.Text != null)
                {
                    dataGridViewReader.DataSource = reader.FindReaderBLL(ReaderName.Text);
                }
                else
                {
                    MessageBox.Show("Nhap ten tim kiem");
                }
            }
        }

        

        #endregion

        
    }
}
