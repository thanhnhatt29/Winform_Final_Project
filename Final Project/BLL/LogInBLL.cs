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
            List<QuanLi> list = new List<QuanLi>();
            
            list = log.getAccount();
            foreach (var i in list)
            {
                if (i.username == ten && i.passw == mk)
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
