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

        public bool SignInBLL(string name, string pass)
        {
            return log.SignInDAL(name, pass);
        }

    }
}
