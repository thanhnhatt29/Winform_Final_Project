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
        QLTHUVIENEntities QLTHUVIEN=new QLTHUVIENEntities();
        public BorrowManage()
        {
            InitializeComponent();
            BookBLL bookBLL = new BookBLL();
            dataBook.DataSource= bookBLL.LoadAll();
            dataBorrow.DataSource= QLTHUVIEN.MuonTras.ToList();

        }
        
    }
}
