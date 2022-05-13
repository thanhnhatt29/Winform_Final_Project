using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardDAL
    {
        public List<TheThuVien> LoadDataDAL()
        {
            List<TheThuVien> list = new List<TheThuVien>();
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table=from c in db.TheThuViens
                          select c;
                foreach(var t in table)
                {
                    list.Add(t);
                }
                return list;
            }
        }

        public List<string> DocGiaDAL()
        {
            List<string> list = new List<string>();
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.DocGias
                            select c;
                foreach( var t in table)
                {
                    list.Add(t.MaDocGia.TrimEnd());
                }
            }
            return list;
        }

        public bool AddCardDAL(string readerID, string ps)
        {
            using(QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                TheThuVien card = new TheThuVien();
                card.MaDocGia = readerID;
                card.NgayBatDau = DateTime.Today;
                card.NgayHetHan = DateTime.Today.AddYears(5);
                card.GhiChu = ps;

                db.TheThuViens.Add(card);
                db.SaveChanges();
                return true;
            }
            
        }
    }
}
