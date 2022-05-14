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
        public List<MuonTra> FindBorrowBLL(int sothe)
        {
            return bw.FindBorrowDAL(sothe);
        }

        public bool ReturnBorrowBLL(int id_tra)
        {
            return bw.ReturnBorrowDAL(id_tra);
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
