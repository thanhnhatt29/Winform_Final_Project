using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BookDAL
    {
        public List<BookDTO> LoadData()
        {
            List<BookDTO> list = new List<BookDTO>();
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.Saches 
                            select c;
                foreach(var i in table)
                {
                    //BookDTO sach = new BookDTO(i.MaSach,i.TenSach,i.MaTacGia,i.TacGia.TenTacGia,i.TenTheLoai,i.NamXuatBan,i.ViTri,i.SoLuongConLai);

                    BookDTO sach=new BookDTO();
                    sach.MaSach = i.MaSach;
                    sach.MaTacGia = i.MaTacGia;
                    sach.TenSach = i.TenSach;
                    sach.TenTheLoai = i.TenTheLoai;
                    sach.NamXuatBan = i.NamXuatBan;
                    sach.ViTri = i.ViTri;
                    sach.SoLuongConLai = i.SoLuongConLai;
                    sach.TenTacGia = i.TacGia.TenTacGia;

                    
                    list.Add(sach);
                }

            }
            return list;
        }
        public List<BookDTO> LoadBookFromAuthor(string matacgia)
        {
            List<BookDTO> list = new List<BookDTO>();
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.Saches
                            select c;
                foreach (var i in table)
                {
                    //BookDTO sach = new BookDTO(i.MaSach,i.TenSach,i.MaTacGia,i.TacGia.TenTacGia,i.TenTheLoai,i.NamXuatBan,i.ViTri,i.SoLuongConLai);

                    BookDTO sach = new BookDTO();
                    sach.MaSach = i.MaSach;
                    sach.MaTacGia = i.MaTacGia;
                    sach.TenSach = i.TenSach;
                    sach.TenTheLoai = i.TenTheLoai;
                    sach.NamXuatBan = i.NamXuatBan;
                    sach.ViTri = i.ViTri;
                    sach.SoLuongConLai = i.SoLuongConLai;
                    sach.TenTacGia = i.TacGia.TenTacGia;

                    if(sach.MaTacGia == matacgia)
                        list.Add(sach);
                }

            }
            return list;
        }

        public bool AddBookDAL(string name, string ID, string author, string genre,
                                string amount,string location, string year)
        {
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.Saches
                            select c;
                foreach (var i in table)
                {
                    if(i.TenSach.TrimEnd() == name || i.MaSach==ID)
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
                sach.SoLuongConLai = Convert.ToInt32(amount);

                db.Saches.Add(sach);
                db.SaveChanges();
                return true;
            }

        }

        public void DelBookDAL(string id)
        {
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                db.Saches.Remove(db.Saches.Where(p=>p.MaSach==id).SingleOrDefault());
                db.SaveChanges();
            }    
        }

        
        public void EditBookDAL(string name, string id, string author, string genre, string amount, string location, string year)
        {
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                Sach sach = db.Saches.Find(id);
                sach.TenSach = name;
                sach.MaTacGia= author;
                sach.TenTheLoai= genre;
                sach.ViTri= location;
                sach.SoLuongConLai = Convert.ToInt32(amount);
                sach.NamXuatBan= year;

                db.SaveChanges();
            }
             
        }

        public List<string> TacGiaDAL()
        {
            List<string> list = new List<string>();
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table=from c in db.TacGias select c;
                foreach(var t in table)
                {
                    list.Add(t.MaTacGia.TrimEnd());
                }
                return list;
            }

        }

        public void AddAuthorDAL(string id, string name)
        {
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                TacGia tacGia = new TacGia();
                tacGia.MaTacGia = id;
                tacGia.TenTacGia = name;
                tacGia.GhiChu = "";

                db.TacGias.Add(tacGia);
                db.SaveChanges();
            }
        }

        
    }
}
