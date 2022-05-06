using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string TenTheLoai { get; set; }
        public string NamXuatBan { get; set; }
        public string ViTri { get; set; }
        public int SoLuongConLai { get; set; }

        public BookDTO()
        {

        }

        public BookDTO(string MaSach,string TenSach,string MaTacGia,string TenTacGia,string TheLoai,string NamXuanBan,string ViTri, int SoLuongConLai)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.MaTacGia = MaTacGia;
            this.TenTacGia = TenTacGia;
            this.TenTheLoai = TheLoai;
            this.NamXuatBan = NamXuanBan;
            this.ViTri = ViTri;
            this.SoLuongConLai = SoLuongConLai;
        }


    }
}
