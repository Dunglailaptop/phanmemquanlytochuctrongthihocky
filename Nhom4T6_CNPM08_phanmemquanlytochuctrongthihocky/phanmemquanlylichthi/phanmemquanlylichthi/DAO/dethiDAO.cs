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
    public class dethiDAO
    {
        modelDataContext db = new modelDataContext();
        private static dethiDAO instance;
        public static dethiDAO Instance
        {
            get { if (instance == null) instance = new dethiDAO(); return dethiDAO.instance; }
            private set { dethiDAO.instance = value; }
        }

        private dethiDAO()
        { }
        public List<innerjoin> loaddsdethi()
        {
            List<innerjoin> dt = new List<innerjoin>();
            string q = "select * from dethi dt inner join hocky hk on hk.Mahocky=dt.Mahocky inner join monhoc mh on mh.MaMonHoc=dt.Mamonhoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow row in data.Rows)
            {
                innerjoin d = new innerjoin();
                d.Madethi = (int)row["Madethi"];
                d.tenhocky = row["tenhocky"].ToString();
                d.bomon = row["tenmonhoc"].ToString();
                d.ngaymolop = (DateTime)row["ngaytao"];
                d.trangthai = (int)row["trangthai"];
                dt.Add(d);
            }
            return dt;
        }
        public List<innerjoin> loaddsdethibymonhoc(string monhoc)
        {
            List<innerjoin> dt = new List<innerjoin>();
            string q = "select * from dethi dt inner join hocky hk on hk.Mahocky=dt.Mahocky inner join monhoc mh on mh.MaMonHoc=dt.Mamonhoc where dt.Mamonhoc='"+monhoc+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                innerjoin d = new innerjoin();
                d.Madethi = (int)row["Madethi"];
                d.tenhocky = row["tenhocky"].ToString();
                d.bomon = row["tenmonhoc"].ToString();
                d.ngaymolop = (DateTime)row["ngaytao"];
                d.trangthai = (int)row["trangthai"];
                dt.Add(d);
            }
            return dt;
        }
        public innerjoin loaddsdethibyid(int id)
        {
            innerjoin d = new innerjoin();
            string q = "select * from dethi dt inner join hocky hk on hk.Mahocky=dt.Mahocky inner join monhoc mh on mh.MaMonHoc=dt.Mamonhoc where Madethi='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {

                d.Madethi = (int)row["Madethi"];
                d.tenhocky = row["tenhocky"].ToString();
                d.bomon = row["tenmonhoc"].ToString();
                d.ngaymolop = (DateTime)row["ngaytao"];
                d.trangthai = (int)row["trangthai"];

            }
            return d;
        }
        public bool themdethi(int mahocky,string mamh,DateTime ngay)
        {
            string q = "insert into dethi(Mamonhoc,Mahocky,ngaytao,trangthai) values ('" + mamh + "','" + mahocky + "','" + ngay + "','0')";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e > 0;
        }
        public bool suadethi(int mahocky, string mamh, DateTime ngay,int made)
        {
            string q = "update dethi set Mahocky='"+mahocky+"',Mamonhoc='"+mamh+"',ngaytao='"+ngay+"' where Madethi='"+made+"' ";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e > 0;
        }
        public bool xoadethi( int made)
        {
            string q = "delete from dethi where Madethi='"+made+"' ";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e > 0;
        }


        public bool chiadethichanle(string id,string monhoc)
        {
            string q = "usp_phanchiadethi '"+id+"','"+monhoc+"'";
            int tes = DataProvider.Instance.ExecuteNonQuery(q);
            return tes > 0;
        }
        public bool chiadethingaunhien(string id, string monhoc)
        {
            string q = "usp_phanchiadethingaunhien '" + id + "','" + monhoc + "'";
            int tes = DataProvider.Instance.ExecuteNonQuery(q);
            return tes > 0;
        }
        public bool xoachiade(string maphongthi)
        {
            string q = "delete from phanchiade where maphongthi='" + maphongthi + "'";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e >0;
        }

        public List<phanchiade> chiade(string maphong)
        {
            List<phanchiade> pc = new List<phanchiade>();
            string q = "select * from phanchiade where maphongthi='"+maphong+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                phanchiade p = new phanchiade();
                p.Mathisinh = row["Mathisinh"].ToString();
                p.Madethi = (int)row["Madethi"];
                p.idphanchia = (int)row["idphanchia"];
                pc.Add(p);
            }
            return pc;

        }

    }
}
