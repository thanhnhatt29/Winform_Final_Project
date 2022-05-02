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
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.Saches 
                            select c;
                foreach(var i in table)
                {
                    Sach sach = new Sach();
                    sach.MaSach=i.MaSach;
                    sach.MaTacGia=i.MaTacGia;
                    sach.TenSach=i.TenSach;
                    sach.TenTheLoai=i.TenTheLoai;
                    sach.NamXuatBan=i.NamXuatBan;
                    sach.ViTri=i.ViTri;
                    sach.SoLuongConLai=i.SoLuongConLai;
                    

                    list.Add(sach);
                }

            }
            return list;
        }
        
        public bool AddBookDAL(string ID, string name,string author, string genre,
                                string year,string location,int amount)
        {
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
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

                sach.MaSach = ID;
                sach.TenSach = name;
                sach.MaTacGia = author;
                sach.TenTheLoai = genre;
                sach.NamXuatBan = year;
                sach.ViTri = location;
                sach.SoLuongConLai = amount;

                db.Saches.Add(sach);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        
        

        
    }
}
