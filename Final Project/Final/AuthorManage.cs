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
    public partial class AuthorManage : Form
    {
        AuthorManageBLL authorBLL = new AuthorManageBLL();
        BookBLL bookBLL = new BookBLL();
        public AuthorManage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiTacGia();
        }
        void HienThiTacGia()
        {
            lstTacGia.DataSource = authorBLL.LoadAll();
            lstTacGia.ValueMember = "MaTacGia"; 
            lstTacGia.DisplayMember = "TenTacGia";
            check = true;
        }
        bool check = false;
        private void HienThiSach(List<BookDTO> dsSach)
        {
            lvSach.Items.Clear();
            dsSach.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(lvSach.Items.Count +1+" ");
                lvi.SubItems.Add(x.TenSach);
                lvi.SubItems.Add(x.TenTheLoai);
                lvi.SubItems.Add(x.ViTri);
                lvi.SubItems.Add(x.NamXuatBan);
                lvSach.Items.Add(lvi);
                
            });
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            authorBLL.AddAuthorBLL(txtMa.Text, txtTen.Text, txtGC.Text);
            HienThiTacGia();
        }

        private void lstTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == false) return;
            if (lstTacGia.SelectedItems == null) return;
            var MaTacGia1 = lstTacGia.SelectedValue;
            List<BookDTO> dsSach = bookBLL.LoadBookFromAuthor(MaTacGia1.ToString());
            HienThiSach(dsSach);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            authorBLL.DelAuthorBLL(txtMa.Text);
            HienThiTacGia();
        }
    }
}
