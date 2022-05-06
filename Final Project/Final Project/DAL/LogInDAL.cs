using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LogInDAL
    {
        public List<QuanLy> getAccount()
        {
            
            List<QuanLy> list = new List<QuanLy>();
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                
                var table = from c in db.QuanLies
                            select c;

                foreach (var i in table)
                {
                    if (i.MaNhanVien == null) return list;
                    QuanLy tk = new QuanLy();
                    tk.MaNhanVien = i.MaNhanVien.TrimEnd();
                    tk.MatKhau = i.MatKhau.TrimEnd();

                    list.Add(tk);
                }

            }
            return list;
        }

        public bool SignInDAL(string user, string name, string phone , string pass,DateTime dob)
        {
            List<QuanLy> list = new List<QuanLy>();
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.QuanLies
                            select c;
                foreach (var i in table)
                {
                    if (name == i.MaNhanVien.TrimEnd())
                    {
                        return false;
                    }
                }
                db.QuanLies.Add(new QuanLy { MaNhanVien = user, TenNhanVien=name,SDT=phone, MatKhau = pass , NgaySinh = dob });
                db.SaveChanges();
                return true;

            }
        }
    }

    
}
