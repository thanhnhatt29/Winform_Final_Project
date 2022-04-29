using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BookBLL
    {
        BookDAL book = new BookDAL();
        public List<Sach> LoadAll()
        {
            
            
            List<Sach> list = book.LoadData();
            return list;
            
        }

        public bool AddBookBLL(string ID,string name,string genre)
        {
            return book.AddBookDAL(ID,name, genre);
        }
    }
}
