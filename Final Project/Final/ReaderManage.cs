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
    public partial class ReaderManage : Form
    {
        public ReaderManage()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ReaderAdd readerAdd = new ReaderAdd();
            readerAdd.ShowDialog();
        }
    }
}
