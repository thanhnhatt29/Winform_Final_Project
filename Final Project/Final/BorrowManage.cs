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
            TongLuotMuonTrongThang();
        }
        public void TongLuotMuonTrongThang()
        {
            int count= 0;
            var list = bw.LoadData();
            foreach( MuonTra m in list)
            {
                if (m.NgayMuon.Month == DateTime.Today.Month && m.NgayMuon.Year == DateTime.Today.Year)
                {
                    count++;
                }
            }
            string total = string.Format("Tháng này có tổng {0} lượt mượn sách", count);
            lbTongMuon.Text = total;
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
        private void buttonCSV_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataBorrow.RowCount - 1; i++)
            {
                for (j = 0; j <= dataBorrow.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataBorrow[j, i];
                    if ( (i == 4 || i == 7) && cell.Value != null)
                    {
                        cell.Value.ToString().Split(' ');
                    }
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    
                }
            }

            xlWorkBook.SaveAs("borrow.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            xlWorkBook.Close(0);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show(@"Excel file created , you can find the file C:\Users\ADMIN\OneDrive\Documents\borrow.xls");


        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
