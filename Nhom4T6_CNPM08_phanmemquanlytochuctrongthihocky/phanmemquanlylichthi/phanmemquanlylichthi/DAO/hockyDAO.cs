using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
   public class hockyDAO
    {
        modelDataContext db = new modelDataContext();
        private static hockyDAO instance;
        public static hockyDAO Instance
        {
            get { if (instance == null) instance = new hockyDAO(); return hockyDAO.instance; }
            private set { hockyDAO.instance = value; }
        }

        private hockyDAO()
        { }

        public List<hocky> loaddshocky()
        {
            List<hocky> loaddshocky = new List<hocky>();
            string q="select * from hocky";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow row in data.Rows)
            {
                hocky hk = new hocky();
                hk.Mahocky = (int)row["Mahocky"];
                hk.tenhocky = row["tenhocky"].ToString();
                hk.ngaybatdau = (DateTime)row["ngaybatdau"];
                hk.ngayketthuc = (DateTime)row["ngayketthuc"];
                hk.soluongtuan = (int)row["soluongtuan"];
                loaddshocky.Add(hk);
            }
            return loaddshocky;
        }
        public hocky loaddshockybyid(int mahocky)
        {
            hocky hk = new hocky();
            string q = "select * from hocky where Mahocky='"+mahocky+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
              
                hk.Mahocky = (int)row["Mahocky"];
                hk.tenhocky = row["tenhocky"].ToString();
                hk.ngaybatdau = (DateTime)row["ngaybatdau"];
                hk.ngayketthuc = (DateTime)row["ngayketthuc"];
                hk.soluongtuan = (int)row["soluongtuan"];
          
            }
            return hk;
        }
        public bool themhocky(string tenhocky,DateTime ngaybatdau,DateTime ngayketthuc,int soluongtuan)
        {
            string q = "insert into hocky(tenhocky,ngaybatdau,ngayketthuc,soluongtuan) values (N'" + tenhocky + "','" + ngaybatdau + "','" + ngayketthuc + "','" + soluongtuan + "')";
            int c = DataProvider.Instance.ExecuteNonQuery(q);
            return c > 0;
        }
        public bool suahocky(string tenhocky, DateTime ngaybatdau, DateTime ngayketthuc, int soluongtuan,int mahocky)
        {
            string q = "update hocky set tenhocky=N'" + tenhocky + "',ngaybatdau='" + ngaybatdau + "',ngayketthuc='" + ngayketthuc + "',soluongtuan='" + soluongtuan + "' where Mahocky='"+mahocky+"'";
            int c = DataProvider.Instance.ExecuteNonQuery(q);
            return c > 0;
        }
        public bool xoahocky(int mahocky)
        {
            string q = "delete from hocky where Mahocky='"+mahocky+"'";
            int c = DataProvider.Instance.ExecuteNonQuery(q);
            return c > 0;
        }
    }
}
