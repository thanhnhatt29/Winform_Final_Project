using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CardBLL
    {
        CardDAL cardDAL= new CardDAL();
        public List<TheThuVien> LoadDataBLL()
        {
            return cardDAL.LoadDataDAL();
        }

        public List<string> DocGiaBLL()
        {
            CardDAL cardDAL = new CardDAL();
            return cardDAL.DocGiaDAL();
        }

        public bool checkCard(string ReaderID)
        {
            List<TheThuVien> list=cardDAL.LoadDataDAL();
            foreach(var i in list)
            {
                if(i.MaDocGia.TrimEnd()==ReaderID)
                {
                    return true;
                }
            }
            return false;

        }

        public bool AddCard(string readerID, string ps)
        {
            return cardDAL.AddCardDAL(readerID, ps);
        }
    }
}
