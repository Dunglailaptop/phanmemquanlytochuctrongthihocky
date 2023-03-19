using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
    public class thisinhDAO
    {
        modelDataContext db = new modelDataContext();
        private static thisinhDAO instance;
        public static thisinhDAO Instance
        {
            get { if (instance == null) instance = new thisinhDAO(); return thisinhDAO.instance; }
            private set { thisinhDAO.instance = value; }
        }

        private thisinhDAO()
        { }

        public bool themthisinh(string masinhvien,string maphongthi,int stt, byte[] orcode)
        {
            int result = db.usp_themthisinh(masinhvien, maphongthi, stt, orcode);
            return result > 0;
        }
        public bool themthisinh(thisinh th)
        {
            int result = db.usp_themthisinh(th.Masinhvien, th.Maphongthi, th.soghe,th.ORCODE);
            return result > 0;
        }
        public List<thisinh> loaddsthisinh()
        {
            List<thisinh> ts = new List<thisinh>();
            string q = "select * from thisinh";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow dr in data.Rows)
            {
                thisinh s = new thisinh();
                s.Mathisinh = dr["Mathisinh"].ToString();
                s.Masinhvien = dr["Masinhvien"].ToString();
                s.Maphongthi = dr["Maphongthi"].ToString();
                s.ORCODE = (byte[])dr["ORCODE"];
                s.soghe = (int)dr["soghe"];
                ts.Add(s);
            }
            return ts;
        }
        public thisinh loaddsthisinhbyid(string id)
        {
            thisinh s = new thisinh();
            string q = "select * from thisinh where Mathisinh='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow dr in data.Rows)
            {
                
                s.Mathisinh = dr["Mathisinh"].ToString();
                s.Masinhvien = dr["Masinhvien"].ToString();
                s.Maphongthi = dr["Maphongthi"].ToString();
                s.ORCODE = (byte[])dr["ORCODE"];
                s.soghe = (int)dr["soghe"];
               
            }
            return s;
        }
        public thisinh loaddsthisinhbyphongthi(int id,string idphongt)
        {
            thisinh s = new thisinh();
            string q = "SELECT ROW_NUMBER() over (order by ts.Mathisinh) as [stt],ts.Mathisinh,dt.Madethi FROM thisinh ts inner join phanchiade pc on pc.Mathisinh=ts.Mathisinh inner join dethi dt on dt.Madethi=pc.Madethi where ts.Maphongthi='"+idphongt+"' and ts.soghe='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow dr in data.Rows)
            {
                
                s.Mathisinh = dr["Mathisinh"].ToString();
                s.Masinhvien = dr["Madethi"].ToString();
                //s.Maphongthi = dr["Maphongthi"].ToString();
                //s.ORCODE = (byte[])dr["ORCODE"];
                //s.soghe = (int)dr["soghe"];

            }
            return s;
        }
        public phanchiade laysoluong(string p)
        {
            phanchiade ts = new phanchiade();
            string q="select count(*) as [solg] from phanchiade where maphongthi='"+p+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow dr in data.Rows)
            {
                ts.idphanchia = (int)dr["solg"];
            }
            return ts;
        }
        public bool xoathisinh(string mathisinh)
        {
            string q = "delete from thisinh where Mathisinh='" + mathisinh + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool suathisinh(string mathisinh,string MSSV,int soghe,string maphongthi)
        {
            string q = "update thisinh set Masinhvien='"+MSSV+"',soghe='"+soghe+"',Maphongthi='"+maphongthi+"' where Mathisinh='"+mathisinh+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
    }
}
