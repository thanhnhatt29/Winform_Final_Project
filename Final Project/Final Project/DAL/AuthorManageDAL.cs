using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AuthorManageDAL
    {
        public List<TacGiaDTO> LoadData()
        {
            List<TacGiaDTO> list = new List<TacGiaDTO>();
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.TacGias
                            select c;
                foreach (var i in table)
                {
                    //BookDTO sach = new BookDTO(i.MaSach,i.TenSach,i.MaTacGia,i.TacGia.TenTacGia,i.TenTheLoai,i.NamXuatBan,i.ViTri,i.SoLuongConLai);

                    TacGiaDTO tacgia = new TacGiaDTO();
                    tacgia.MaTacGia = i.MaTacGia;
                    tacgia.TenTacGia = i.TenTacGia;
                    tacgia.GhiChu = i.GhiChu;
                    list.Add(tacgia);
                }

            }
            return list;
        }
        public void DelAuthorDAL(string id)
        {
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                db.TacGias.Remove(db.TacGias.Where(p => p.MaTacGia == id).SingleOrDefault());
                db.SaveChanges();
            }
        }
        public bool AddAuthorDAL(string id, string name, string ghichu)
        {
            using (QLTHUVIENEntities db = new QLTHUVIENEntities())
            {
                var table = from c in db.TacGias
                            select c;
                foreach (var i in table)
                {
                    if (i.TenTacGia.TrimEnd() == name || i.MaTacGia == id)
                    {
                        return false;
                    }
                }

                TacGia tacgia = new TacGia();

                tacgia.MaTacGia = id;
                tacgia.TenTacGia = name;
                tacgia.GhiChu = ghichu;
                db.TacGias.Add(tacgia);
                db.SaveChanges();
                return true;
            }

        }
    }
}
