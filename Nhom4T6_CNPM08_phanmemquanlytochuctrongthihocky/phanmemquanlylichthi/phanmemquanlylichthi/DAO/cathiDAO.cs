using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
    public class cathiDAO
    {
        modelDataContext db = new modelDataContext();
        private static cathiDAO instance;
        public static cathiDAO Instance
        {
            get { if (instance == null) instance = new cathiDAO(); return cathiDAO.instance; }
            private set { cathiDAO.instance = value; }
        }

        private cathiDAO()
        { }

        public bool themcathi(DateTime time1,DateTime time2,string kip)
        {
            string q= "insert into cathi(thoigianbatdau,thoigianketthuc,kip) values ('" + time1 + "','" + time2 + "','" + kip + "')";
            int re = DataProvider.Instance.ExecuteNonQuery(q);
            return re > 0;
        }
        public bool suacathi(DateTime time1, DateTime time2, string kip,int maca)
        {
            string q = "update cathi set thoigianbatdau='"+time1+"',thoigianketthuc='"+time2+"',kip='"+kip+"' where Macathi='"+maca+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(q);
            return re > 0;
        }
        public bool xoacathi(int maca)
        {
            string q = "delete from cathi where Macathi='"+maca+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(q);
            return re > 0;
        }
        public List<cathi> loaddscathi()
        {
            List<cathi> list = new List<cathi>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from cathi");
            foreach(DataRow row in data.Rows)
            {
                cathi ct = new cathi();
                ct.Macathi = (int)row["Macathi"];
                ct.thoigianbatdau = (DateTime)row["thoigianbatdau"];
                ct.thoigianketthuc = (DateTime)row["thoigianketthuc"];
                ct.kip = row["kip"].ToString();
                list.Add(ct);
            }
            return list;
        }
        public cathi loaddscathiBYID(int maca)
        {
            cathi ct = new cathi();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from cathi where Macathi='"+maca+"'");
            foreach (DataRow row in data.Rows)
            {
                ct.Macathi = (int)row["Macathi"];
                ct.thoigianbatdau = (DateTime)row["thoigianbatdau"];
                ct.thoigianketthuc = (DateTime)row["thoigianketthuc"];
                ct.kip = row["kip"].ToString();
             
            }
            return ct;
        }
    }
}
