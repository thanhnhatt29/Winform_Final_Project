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

        public bool checkBook(string ID)
        {
            List < Sach > list= book.LoadData();
            foreach(var i in list)
            {
                if (i.MaSach.TrimEnd() == ID)
                {
                    return false;
                }    
            }
            return true;

        }

        public bool AddBookBLL(string ID,string name,string genre)
        {
            //return book.AddBookDAL(ID,name, genre);
            return true;
        }

        public List<Sach> FindBookBLL(string ID,string Name)
        {
            List<Sach> list = book.LoadData();

            List<Sach> result = new List<Sach>();
                
                                
            
            foreach(var i in list)
            {
                if(i.MaSach.Contains(ID) && i.TenSach.Contains(Name))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
