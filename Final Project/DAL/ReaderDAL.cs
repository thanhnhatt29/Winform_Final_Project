using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class ReaderDAL
    {
        QLTHUVIENEntities db = new QLTHUVIENEntities();
        public List<DocGia> LoadData()
        {
            List<DocGia> list = new List<DocGia>();
            list = db.DocGias.ToList();
            /*foreach (DocGia d in list)
            {
                d.MaDocGia = d.MaDocGia.TrimEnd();
                d.TenDocGia = d.TenDocGia.TrimEnd();
                d.DiaChi = d.DiaChi.TrimEnd();
                d.SDT = d.SDT.TrimEnd();
            }*/
            return list;
        }

        public bool AddReaderDAL(string ID, string name, string adr, string sdt)
        {
            var table = from c in db.DocGias
                        select c;
            foreach (var i in table)
            {
                if (i.SDT == sdt)
                {
                    return false;
                }
            }
            try
            {
                DocGia dg = new DocGia();
                dg.MaDocGia = ID;
                dg.TenDocGia = name;
                dg.DiaChi = adr;
                dg.SDT = sdt;

                db.DocGias.Add(dg);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditReaderDAL(string ID, string name, string adr, string sdt)
        {
            try
            {
                DocGia result = db.DocGias.Where(i => i.MaDocGia == ID).SingleOrDefault();
                result.TenDocGia = name;
                result.DiaChi = adr;
                result.SDT = sdt;
                db.SaveChanges();
                return true;
            }
            catch
            { return false; }
        }

        public bool DelReaderDAL(string ID)
        {
            try
            {
                DocGia result = db.DocGias.Where(i => i.MaDocGia == ID).SingleOrDefault();
                if (result != null)
                {
                    db.DocGias.Remove(result);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            { return false; }
        }

        public List<DocGia> FindReaderDAL(string name)
        {
            //return db.DocGias.Where(c => c.TenDocGia.Contains(name)).ToList();
            string filter = ConvertToUnSign(name);
            var query = db.DocGias.Where(delegate (DocGia c)
            {
                if (ConvertToUnSign(c.TenDocGia).IndexOf(filter, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();
            return query.ToList();

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
    }
}
