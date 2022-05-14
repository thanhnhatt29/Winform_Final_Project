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
using DAL;
namespace Final
{
    
    public partial class BorrowManage : Form
    {
        QLTHUVIENEntities QLTHUVIEN = new QLTHUVIENEntities();
        BorrowBLL bw = new BorrowBLL();
        public string user;
        public BorrowManage(string hidname)
        {
            InitializeComponent();
            this.user = hidname;
            LoadData();
        }
        
        public void LoadData()
        {
                dataBorrow.DataSource = bw.LoadData();
        }

        private void txbSoThe_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbSoThe.Text))
            {
                dataBorrow.DataSource = bw.FindBorrowBLL(Convert.ToInt16(txbSoThe.Text));
            }
            else
            {
                LoadData();
            }
        }

        private void buttonGiveBack_Click(object sender, EventArgs e)
        {
            int id_tra = (int)dataBorrow.CurrentRow.Cells[0].Value;
            if (bw.ReturnBorrowBLL(id_tra))
            {
                MessageBox.Show("Tra thanh cong");
                LoadData();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            BorrowAdd borrowAdd = new BorrowAdd(user);
            borrowAdd.ShowDialog();
        }

        private void cb_DaTra_CheckedChanged(object sender, EventArgs e)
        {
            /*var result = bw.LoadData();
            dataBorrow.DataSource = result.Where(c => c.Da_Tra == false).ToList();*/
        }

        private void cb_DaTra_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_DaTra.Checked)
            {
                if (string.IsNullOrEmpty(txbSoThe.Text))
                {
                    var result = bw.LoadData();
                    dataBorrow.DataSource = result.Where(c => c.Da_Tra == false).ToList();
                }
                else
                {
                    var result = bw.FindBorrowBLL(Convert.ToInt16(txbSoThe.Text));
                    dataBorrow.DataSource = result.Where(c => c.Da_Tra == false).ToList();
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}
