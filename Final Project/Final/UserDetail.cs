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
    public partial class UserDetail : Form
    {
        
        public UserDetail(string user)
        {
            InitializeComponent();
            LoadData(user);
            this.user = user;
        }
        public string user;

        /*public string Message
        {
            get { return user; }
            set { user = value; }
        }*/

        #region Methods
        void LoadData(string user)
        {
            string a = user;
            LogInBLL logInBLL = new LogInBLL();
            QuanLy Info = logInBLL.InfoBLL(a);

            UName.Text = Info.MaNhanVien.TrimEnd();
            NameBox.Text = Info.TenNhanVien.TrimEnd();
            dateBirth.Value = Info.NgaySinh.Value;
            Phone.Text = Info.SDT.TrimEnd();
            Password.Text = Info.MatKhau.TrimEnd();
            DisableButton();
        }

        void EnableButton()
        {
            UName.Enabled = true;
            NameBox.Enabled = true;
            dateBirth.Enabled = true;
            Phone.Enabled = true;
            Password.Enabled = true;
            butt_Cancel.Enabled = true;
            butt_Do.Enabled = true;

        }

        void DisableButton()
        {
            UName.Enabled = false;
            NameBox.Enabled = false;
            dateBirth.Enabled = false;
            Phone.Enabled = false;
            Password.Enabled = false;
            butt_Cancel.Enabled = false;
            butt_Do.Enabled = false;
        }

        void Edit(string user, string name, string phone, string pass, DateTime dob)
        {
            LogInBLL logInBLL = new LogInBLL();
            logInBLL.EditBLL(user, name, phone, pass, dob);
        }
        void Delete(string user)
        {
            LogInBLL logInBLL = new LogInBLL();
            logInBLL.DelBLL(user);
        }

        #endregion

        private void EditInfo_Click(object sender, EventArgs e)
        {
            EnableButton();
            EditInfo.Enabled = false;

        }

        private void butt_Do_Click(object sender, EventArgs e)
        {
            Edit(UName.Text, NameBox.Text, Phone.Text, Password.Text, dateBirth.Value);
            EditInfo.Enabled = true;
            LoadData(user);
        }

        private void butt_Cancel_Click(object sender, EventArgs e)
        {
            LoadData(user);
            EditInfo.Enabled = true;
        }

        private void butt_Del_Click(object sender, EventArgs e)
        {
            Delete(UName.Text);
            this.Close();
        }
    }
}
