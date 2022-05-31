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

        public QuanLy getInfoDAL(string user)
        {
            string b = user;
            
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {

                //List<QuanLy> list = new List<QuanLy>();
                /*QuanLy acc=new QuanLy();
                *//*var table = from c in db.QuanLies
                       select c;
                foreach (var i in table)
                {
                    if(user==i.MaNhanVien.TrimEnd())
                    {
                        acc = i;
                        return acc;
                    }
                }*/
                QuanLy acc = db.QuanLies.Find(user);
                
                return acc;

            }
        }

        public void EditDAL(string user, string name, string phone, string pass, DateTime dob)
        {
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                QuanLy acc = db.QuanLies.Find(user);
                acc.TenNhanVien = name;
                acc.SDT = phone;
                acc.MatKhau = pass;
                acc.NgaySinh = dob;

                db.SaveChanges();
            }
        }

        public void DelDAL(string user)
        {
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                db.QuanLies.Remove(db.QuanLies.Where(p=>p.MaNhanVien==user).SingleOrDefault());
                db.SaveChanges();
            }
        }
    }

    
}
