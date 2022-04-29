using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LogInDAL
    {
        public List<QuanLi> getAccount()
        {
            
            List<QuanLi> list = new List<QuanLi>();
            using (MUONSACH db = new MUONSACH())
            {
                
                var table = from c in db.QuanLis
                            select c;

                foreach (var i in table)
                {
                    if (i.username == null) return list;
                    QuanLi tk = new QuanLi();
                    tk.username = i.username.TrimEnd();
                    tk.passw = i.passw.TrimEnd();

                    list.Add(tk);
                }

            }
            return list;
        }

        public bool SignInDAL(string name, string pass)
        {
            List<QuanLi> list = new List<QuanLi>();
            using (MUONSACH db = new MUONSACH())
            {
                var table = from c in db.QuanLis
                            select c;
                foreach (var i in table)
                {
                    if (name == i.username.TrimEnd())
                    {
                        return false;
                    }
                }
                db.QuanLis.Add(new QuanLi { username = name, passw = pass });
                db.SaveChanges();
                return true;

            }
        }
    }

    
}
