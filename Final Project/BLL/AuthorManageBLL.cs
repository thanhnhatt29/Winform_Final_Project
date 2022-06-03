using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class AuthorManageBLL
    {
        AuthorManageDAL author = new AuthorManageDAL();
        public List<TacGiaDTO> LoadAll()
        {
            /*List<BookDTO> list = book.LoadData();
            return list;*/

            return author.LoadData();
        }
        public void DelAuthorBLL(string id)
        {
            author.DelAuthorDAL(id);
        }
        public bool AddAuthorBLL(string id, string name, string ghichu)
        {
            return author.AddAuthorDAL(id, name, ghichu);
        }
    }
}
