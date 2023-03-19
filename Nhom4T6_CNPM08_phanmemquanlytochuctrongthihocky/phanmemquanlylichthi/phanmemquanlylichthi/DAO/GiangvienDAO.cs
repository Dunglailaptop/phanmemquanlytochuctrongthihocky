using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
    public class GiangvienDAO
    {
        modelDataContext db = new modelDataContext();
        private static GiangvienDAO instance;
        public static GiangvienDAO Instance
        {
            get { if (instance == null) instance = new GiangvienDAO(); return GiangvienDAO.instance; }
            private set { GiangvienDAO.instance = value; }
        }

        private GiangvienDAO()
        { }
        public bool themgiangvien(string hoten,string email,string bomon,string sdt,int Maphonglamviec,int Maquyen,int Malop, byte[] hinhanh)
        {
           
            int result = db.usp_themgiangvien(hoten,email,bomon,sdt,Maphonglamviec,Maquyen,Malop,hinhanh);
            return result>0;
        }
        public  List<innerjoin> loaddsgiangvien()
        {
            List<innerjoin> gv = new List<innerjoin>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM giangvien gv inner join lop p on p.Malop = gv.Malop inner join phonglamviec plv on plv.Maphonglamviec = gv.Maphonglamviec inner join phanquyen pq on pq.Maquyen = gv.Maquyen");
            foreach(DataRow dr in data.Rows)
            {
                innerjoin ggv = new innerjoin();
                ggv.Macanbo = dr["Magiangvien"].ToString();
                ggv.hoten = dr["hoten"].ToString();
                ggv.email = dr["email"].ToString();
                ggv.bomon = dr["bomon"].ToString();
                ggv.sdt = dr["sdt"].ToString();
                ggv.tenquyen = dr["Tenquyen"].ToString();
                ggv.tenphonglamviec = dr["tenphonglamviec"].ToString();
                ggv.tenlop = dr["tenlop"].ToString();
                ggv.hinhanh = (byte[])dr["hinhanh"];
                gv.Add(ggv);
            }
            return gv;

        }
        public innerjoin loaddsgiangvienbyid(string id)
        {
            innerjoin ggv = new innerjoin();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM giangvien gv inner join lop p on p.Malop = gv.Malop inner join phonglamviec plv on plv.Maphonglamviec = gv.Maphonglamviec inner join phanquyen pq on pq.Maquyen = gv.Maquyen  where Magiangvien='"+id+"'");
            foreach (DataRow dr in data.Rows)
            {
                
                ggv.Macanbo = dr["Magiangvien"].ToString();
                ggv.hoten = dr["hoten"].ToString();
                ggv.email = dr["email"].ToString();
                ggv.bomon = dr["bomon"].ToString();
                ggv.sdt = dr["sdt"].ToString();
                ggv.tenquyen = dr["Tenquyen"].ToString();
                ggv.tenphonglamviec = dr["tenphonglamviec"].ToString();
                ggv.tenlop = dr["tenlop"].ToString();
                ggv.hinhanh = (byte[])dr["hinhanh"];
            }
            return ggv;

        }
        public bool suagiangvien(string hoten, string email, string bomon, string sdt, int Maphonglamviec, int Maquyen, int Malop,string magiangvien, byte[] hinhanh)
        {
            
            int result = db.usp_suagiangvien(hoten,email,bomon,sdt,Maphonglamviec,Maquyen,Malop,hinhanh,magiangvien);
            return result > 0;
        }
        public bool xoagiangvien(string mgv)
        {
            string q = "Delete from giangvien where Magiangvien='" + mgv + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(q);
            return re > 0;
        }
      
    }
}
