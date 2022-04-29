using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class BookDAL
    {
        public List<Sach> LoadData()
        {
            List<Sach> list = new List<Sach>();
            using(MUONSACH db = new MUONSACH())
            {
                var table = from c in db.Saches 
                            select c;
                foreach(var i in table)
                {
                    Sach sach = new Sach();
                    sach.IDSach = i.IDSach;
                    sach.TenSach = i.TenSach;
                    sach.Soluong = i.Soluong;
                    sach.TacGia = i.TacGia;
                    sach.Theloai = i.Theloai;

                    list.Add(sach);
                }

            }
            return list;
        }
        
        public bool AddBookDAL(string ID, string name, string genre)
        {
            using(MUONSACH db = new MUONSACH())
            {
                var table = from c in db.Saches
                            select c;
                foreach (var i in table)
                {
                    if(i.TenSach == name)
                    {
                        return false;
                    }
                }
                
                Sach sach = new Sach();
                sach.IDSach = ID;
                sach.TenSach = name;
                sach.Soluong = 1;
                sach.TacGia = null;
                sach.Theloai = genre;

                db.Saches.Add(sach);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        

        
    }
}
