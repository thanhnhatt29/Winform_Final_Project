using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class BorrowDAL
    {
        QLTHUVIENEntities db = new QLTHUVIENEntities();
        public List<MuonTra> FindBorrowDAL(int sothe)
        {
            return db.MuonTras.Where(c => c.SoThe == sothe).ToList();
        }

        public bool ReturnBorrowDAL(int id_tra)
        {
            try
            {
                MuonTra result = db.MuonTras.Where(i => i.MaMuonTra == id_tra).SingleOrDefault();
                if (result != null && result.Da_Tra == false)
                {
                    // Chinh sua trong bang muon tra
                    result.Da_Tra = true;
                    result.NgayTra = DateTime.Now;

                    // Chinh sua phan so luong trong Sach
                    string ma_sach = result.MaSach;
                    Sach changeSoLuong = db.Saches.Where(i => i.MaSach == ma_sach).SingleOrDefault();
                    changeSoLuong.SoLuongConLai += 1;

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            { return false; }
        }
        
        public bool AddBorrowDAL(List<MuonTra> i)
        {
            try
            {
                foreach (MuonTra mt in i)
                {
                    db.MuonTras.Add(mt);
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Sach> FindBookDAL(string text)
        {
            string filter = ConvertToUnSign(text);
            var query = db.Saches.Where(delegate (Sach c)
            {
                if (ConvertToUnSign(c.TenSach).IndexOf(filter, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();
            return query.Where(c => c.SoLuongConLai != 0).ToList();
        }
        private string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }
        public List<MuonTra> LoadData()
        {
            return db.MuonTras.ToList();
        }
    }
}
