using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiTacGia();
        }
        void HienThiTacGia()
        {
            QLTHUVIENDataContext context = new QLTHUVIENDataContext();
            lstTacGia.DataSource = context.TacGias.ToList();
            lstTacGia.ValueMember = "MaTacGia"; 
            lstTacGia.DisplayMember = "TenTacGia";
            check = true;
        }
        bool check = false;
        private void HienThiSach(List<Sach> dsSach)
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
        private void lvSach_SelectedIndexChanged(object sender, EventArgs e) { 
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            QLTHUVIENDataContext context = new QLTHUVIENDataContext();
            TacGia a = context.TacGias.FirstOrDefault(x => x.MaTacGia == txtMa.Text);
            if (a == null)
            {
                a = new TacGia();
                context.TacGias.InsertOnSubmit(a);
            }
            a.MaTacGia = txtMa.Text;
            a.TenTacGia = txtTen.Text;
            context.SubmitChanges();
            HienThiTacGia();
        }

        private void lstTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check = false) return;
            if (lstTacGia.SelectedItems == null) return;
             var MaTacGia1 = lstTacGia.SelectedValue;
            QLTHUVIENDataContext context = new QLTHUVIENDataContext();
            List<Sach> dsSach = context.Saches.Where(x => x.MaTacGia == MaTacGia1).ToList();
            HienThiSach(dsSach);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLTHUVIENDataContext context = new QLTHUVIENDataContext();
            TacGia a = context.TacGias.FirstOrDefault(x => x.MaTacGia == txtMa.Text);

            context.TacGias.DeleteOnSubmit(a);
            context.SubmitChanges();
            var MaTacGia1 = lstTacGia.SelectedValue;
            List<TacGia> TG = context.TacGias.Where(x => x.MaTacGia == MaTacGia1).ToList();
            HienThiTacGia();
        }

      
    }
}
