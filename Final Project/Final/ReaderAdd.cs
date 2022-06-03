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
    public partial class ReaderAdd : Form
    {
        public ReaderAdd()
        {
            InitializeComponent();
        }

        private void buttonAddR_Click(object sender, EventArgs e)
        {
            ReaderBLL reader = new ReaderBLL();
            if (reader.AddReaderBLL(ReaderID.Text, ReaderName.Text, ReaderAdr.Text, ReaderPhone.Text))
            {
                MessageBox.Show("Them thanh cong");
                this.Close();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
