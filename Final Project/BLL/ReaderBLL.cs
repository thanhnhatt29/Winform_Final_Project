using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ReaderBLL
    {
        ReaderDAL reader = new ReaderDAL();
        public List<DocGia> LoadAll()
        {

            List<DocGia> list = reader.LoadData();
            return list;

        }

        public bool AddReaderBLL(string ID, string name, string adr, string sdt)
        {
            return reader.AddReaderDAL(ID, name, adr, sdt);
        }
        public bool EditReaderBLL(string id, string name, string adr, string sdt)
        {
            return reader.EditReaderDAL(id, name, adr, sdt);
        }
        public bool DelReaderBLL(string id)
        {
            return reader.DelReaderDAL(id);
        }
        public List<DocGia> FindReaderBLL(string name)
        {
            return reader.FindReaderDAL(name);
        }
    }
}
