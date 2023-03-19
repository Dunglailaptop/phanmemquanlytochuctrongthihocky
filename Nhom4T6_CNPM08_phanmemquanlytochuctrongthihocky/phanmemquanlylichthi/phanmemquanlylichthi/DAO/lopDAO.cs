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
    public class lopDAO
    {
        modelDataContext db = new modelDataContext();
        private static lopDAO instance;
        public static lopDAO Instance
        {
            get { if (instance == null) instance = new lopDAO(); return lopDAO.instance; }
            private set { lopDAO.instance = value; }
        }

        private lopDAO()
        { }
        public List<innerjoin> loaddslop()
        {
            List<innerjoin> loaddslop = new List<innerjoin>();
            string q = "select * from lop p inner join monhoc mh on mh.MaMonHoc=p.MaMonHoc inner join hocky hk on hk.Mahocky=p.Mahocky";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow row in data.Rows)
            {
                innerjoin nj=new innerjoin();
                nj.malop = (int)row["Malop"];
                nj.tenlop = row["tenlop"].ToString();
                nj.ngaymolop = (DateTime)row["ngaymolop"];
                nj.soluongsv = (int)row["soluongsv"];
                nj.dotmolop = row["Dotmolop"].ToString();
                nj.tenhocky = row["tenhocky"].ToString();
                nj.trangthai = (int)row["trangthailop"];
                nj.bomon = row["tenmonhoc"].ToString();
                loaddslop.Add(nj);
            }
            return loaddslop;
        }
        public innerjoin loaddslopBYID(int id)
        {
            innerjoin nj = new innerjoin();
            string q = "select * from lop p inner join monhoc mh on mh.MaMonHoc=p.MaMonHoc inner join hocky hk on hk.Mahocky=p.Mahocky where p.Malop='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                
                nj.malop = (int)row["Malop"];
                nj.tenlop = row["tenlop"].ToString();
                nj.ngaymolop = (DateTime)row["ngaymolop"];
                nj.soluongsv = (int)row["soluongsv"];
                nj.dotmolop = row["Dotmolop"].ToString();
                nj.tenhocky = row["tenhocky"].ToString();
                nj.trangthai = (int)row["trangthailop"];
                nj.bomon = row["tenmonhoc"].ToString();
                
            }
            return nj;
        }
        public bool themlop(string tenlop,DateTime ngay,int mahocky,string dot,string mamon)
        {
            int trangthai = 0,slg=0;
            string q = "insert into lop(tenlop,ngaymolop,soluongsv,trangthailop,Dotmolop,MaMonHoc,Mahocky) values (N'" + tenlop + "','" + ngay + "','" + slg + "','" + trangthai + "','" + dot + "','" + mamon + "','" + mahocky + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool sualop(string tenlop, DateTime ngay, int mahocky, string dot, string mamon,int malop)
        {
            int trangthai = 0, slg = 0;
            string q = "update lop set tenlop='"+tenlop+"',ngaymolop='"+ngay+"',Dotmolop='"+dot+"',MaHocKy='"+mahocky+"',MaMonHoc='"+mamon+"' where Malop='"+malop+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool xoalop(int lop)
        {
          
            string q = "delete from lop where Malop='" + lop + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
    }
}
