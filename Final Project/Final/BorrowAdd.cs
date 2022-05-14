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
        QLTHUVIENEntities db = new QLTHUVIENEntities();
        BorrowBLL bw = new BorrowBLL();
        public string user;
        public BorrowAdd(string user)
        {
            InitializeComponent();
            this.user = user;
            LoadData();
        }
        
        public void LoadData()
        {
            dataBook.DataSource = db.Saches.Where(c => c.SoLuongConLai != 0).Select(c => new
            {
                MaSach = c.MaSach,
                TenSach = c.TenSach
            }).ToList();
        }
        private void btMuon_Click(object sender, EventArgs e)
        {
            if (lstMuon.Count > 0)
            {
                foreach (MuonTra i in lstMuon)
                {
                    db.MuonTras.Add(i);
                }
                db.SaveChanges();
                lstMuon.Clear();
                dataBorrow.DataSource = null;
                MessageBox.Show("Mượn thành công");
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
        List<MuonTra> lstMuon = new List<MuonTra>();
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
