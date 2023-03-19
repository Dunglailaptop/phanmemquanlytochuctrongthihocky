using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanmemquanlylichthi.DTO
{
    public class innerjoin
    {
        //sinhvien
        public string MSSV { get; set; }
        public string hoten { get; set; }
        public byte[] hinhanh { get; set; }
        public DateTime ngaysinh { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string quequan { get; set; }
        public string tenkhoa { get; set; }
        public string tenchuyennganh { get; set; }
        //canbocanhthi
        public string Macanbo { get; set; }
        public string tenphonglamviec { get; set; }
        public string tenquyen { get; set; }
        public string bomon { get; set; }
        public string email { get; set; }
        // giangvien
        public string tenphong { get; set; }
        public string tenlop { get; set; }
        public int maphong { get; set; }
        public int maquyen { get; set; }
        public int malop { get; set; }
        //lop
        public DateTime ngaymolop { get; set; }
        public int soluongsv { get; set; }
        public int trangthai { get; set; }
        public string tentrangthai { get; set; }
        public string dotmolop { get; set; }
        public string tenhocky { get; set; }
        //dethi
        public int Madethi { get; set; }
        //canhthi
        public int macanhthi { get; set; }
        //lichthi
        public string mamonhoc { get; set; }
        public string ghichu { get; set; }
        public string tuan { get; set; }
        public string thu { get; set; }
        public DateTime ngaythi { get; set; }
        public string kip { get; set; }
        public int sldk { get; set; }
        public int malichthi { get; set; }
        //public int trangthai { get; set; }
        //kinhphi
        public int id { get; set; }
        public decimal tongkinhphi {get;set;}
        public decimal dongia { get; set;}
        public string trangthaii { get; set; }
        //account
        public string username { get; set; }
        public string password { get; set; }

        public string magv { get; set; }

    }
}
