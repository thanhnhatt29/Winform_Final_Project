using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LogInBLL
    {
        LogInDAL log = new LogInDAL();
        public bool IsLoggedIn(string ten, string mk)
        {
            List<QuanLy> list = new List<QuanLy>();
            
            list = log.getAccount();
            foreach (var i in list)
            {
                if (i.MaNhanVien == ten && i.MatKhau == mk)
                {
                    return true;
                }

            }
            return false;
        }

        public bool SignInBLL(string user,string name,string phone ,string pass,DateTime dob)
        {
            return log.SignInDAL(user, name, phone, pass,dob);
        }

        public QuanLy InfoBLL(string user)
        {
            string b = user;
            QuanLy acc = new QuanLy();
            acc = log.getInfoDAL(user);
            return acc;
        }

        public void EditBLL(string user, string name, string phone, string pass, DateTime dob)
        {
            log.EditDAL(user, name, phone, pass,dob);
        }

        public void DelBLL(string user)
        {
            log.DelDAL(user);
        }
    }
}
