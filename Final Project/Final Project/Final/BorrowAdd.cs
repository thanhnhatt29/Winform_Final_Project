using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace Final
{
    public partial class BorrowAdd : Form
    {
        BorrowBLL bw = new BorrowBLL();
        BookBLL book = new BookBLL();
        public string user;
        List<MuonTra> lstMuon = new List<MuonTra>();
        public BorrowAdd(string user)
        {
            InitializeComponent();
            this.user = user;
            LoadData();
        }
        
        public void LoadData()
        {
            dataBook.DataSource = book.LoadAll().Where(c => c.SoLuongConLai != 0).Select(c => new
            {
                MaSach = c.MaSach,
                TenSach = c.TenSach
            }).ToList();
        }
        private void btMuon_Click(object sender, EventArgs e)
        {
            if (lstMuon.Count > 0)
            {
                if (!bw.AddBorrowBLL(lstMuon))
                {
                    MessageBox.Show("Không thành công! Vui lòng thử lại");
                }
                else
                {
                    lstMuon.Clear();
                    dataBorrow.DataSource = null;
                    MessageBox.Show("Mượn thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin mời thêm vào danh sách trước khi mượn");
            }
        }

        private void txbTimSach_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbTimSach.Text))
            {
                var result = bw.FindBookBLL(txbTimSach.Text);
                
                dataBook.DataSource = result.Select(c => new
                {
                    MaSach = c.MaSach,
                    TenSach = c.TenSach
                }).ToList();
            }
            else
            {
                LoadData();
            }
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txbSoThe.Text))
            {
                var muonsach = new MuonTra();
                muonsach.MaSach = dataBook.CurrentRow.Cells[0].Value.ToString();
                muonsach.MaNhanVien = user;
                muonsach.SoThe = Convert.ToInt32(txbSoThe.Text);
                muonsach.NgayMuon = DateTime.Now;
                muonsach.Da_Tra = false;
                lstMuon.Add(muonsach);

                dataBorrow.DataSource = lstMuon.ToList();
            }
            else
            {
                MessageBox.Show("Mời nhập số Thẻ");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lstMuon.Count > 0)
            {
                var ma_xoa = dataBorrow.CurrentRow.Index;
                lstMuon.RemoveAt(ma_xoa);
                dataBorrow.DataSource = lstMuon.ToList();
            }
            else
            {
                MessageBox.Show("Xin mời thêm vào danh sách trước khi xoá");
            }
        }
    }
}
