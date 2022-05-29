using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BorrowBLL
    {
        BorrowDAL bw = new BorrowDAL();
        public int TongLuotMuonTrongThangBLL()
        {
            int count = 0;
            var list = bw.LoadData();
            foreach (MuonTra m in list)
            {
                if (m.NgayMuon.Month == DateTime.Today.Month && m.NgayMuon.Year == DateTime.Today.Year)
                {
                    count++;
                }
            }
            return count;
        }
        public List<MuonTra> LoadData_ChuaTra()
        {
            return bw.LoadData().Where(c => c.Da_Tra == false).ToList();
        }
        public List<MuonTra> FindBorrowBLL_ChuaTra(int sothe)
        {
            return bw.FindBorrowDAL(sothe).Where(c => c.Da_Tra == false).ToList();
        }
        public List<MuonTra> FindBorrowBLL(int sothe)
        {
            return bw.FindBorrowDAL(sothe);
        }

        public bool ReturnBorrowBLL(int id_tra)
        {
            return bw.ReturnBorrowDAL(id_tra);
        }

        public bool AddBorrowBLL(List<MuonTra> i)
        {
            return bw.AddBorrowDAL(i);
        }

        public List<MuonTra> LoadData()
        {
            return bw.LoadData();
        }

        public List<Sach> FindBookBLL(string text)
        {
            return bw.FindBookDAL(text);
        }
    }
}
