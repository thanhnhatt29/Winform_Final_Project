using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BookBLL
    {
        BookDAL book = new BookDAL();
        public List<BookDTO> LoadBookFromAuthor(string matacgia)
        {
            return book.LoadBookFromAuthor(matacgia);
        }
        public List<BookDTO> LoadAll()
        {
            /*List<BookDTO> list = book.LoadData();
            return list;*/

            return book.LoadData();


        }

        public bool checkBook(string ID)
        {
            List <BookDTO> list= book.LoadData();
            foreach(var i in list)
            {
                if (i.MaSach.TrimEnd() == ID)
                {
                    return true;
                }    
            }
            return false;

        }

        public bool AddBookBLL(string name, string id, string author, string genre, string amount, string location, string year)
        {
            return book.AddBookDAL(name, id, author, genre, amount, location, year);
            
        }

        public List<BookDTO> FindBookBLL(string ID,string Name,string AuthorID, string Genre, string Amount, string Location, string Year)
        {
            List<BookDTO> list = book.LoadData();

            List<BookDTO> result = new List<BookDTO>();
                
            //int Amount=Convert.ToInt32(Amount);
            if(Amount.Length==0)
            {
                Amount = "0";
            }
            
            foreach(var i in list)
            {
                if(i.MaSach.Contains(ID) && i.TenSach.Contains(Name) && i.MaTacGia.Contains(AuthorID) && i.TenTheLoai.Contains(Genre) && i.SoLuongConLai >= Convert.ToInt32(Amount) && i.ViTri.Contains(Location) && i.NamXuatBan.Contains(Year))
                {
                    result.Add(i);
                }
            }

            return result;
        }


        public void DelBookBLL(string id)
        {
            book.DelBookDAL(id);
        }

        public void EditBookBLL(string name, string id, string author, string genre, string amount, string location, string year)
        {
            BookDAL bookDAL= new BookDAL();
            bookDAL.EditBookDAL(name,id,author,genre,amount,location,year);
            
        }


        public List<string> Theloai()
        {
            List<string> genre = new List<string>();
            
            List<BookDTO> list = book.LoadData();

            List<BookDTO> result = new List<BookDTO>();
            foreach(var i in list)
            {
                string theloai = i.TenTheLoai.TrimEnd();
                if(genre.Count()==0)
                {
                    genre.Add(theloai);
                }
                else
                {
                    if(!genre.Contains(theloai))
                    {
                        genre.Add(theloai);
                    }    
                }
            }  
            return genre;

        }

        public List<string> TacGiaBLL()
        {
           BookDAL bookDAL = new BookDAL();
           return bookDAL.TacGiaDAL();
        }

        public void AddAuthorBLL(string authorid,string authorname)
        {
            BookDAL bookDAL = new BookDAL();
            bookDAL.AddAuthorDAL(authorid,authorname);
        }
    }
}
