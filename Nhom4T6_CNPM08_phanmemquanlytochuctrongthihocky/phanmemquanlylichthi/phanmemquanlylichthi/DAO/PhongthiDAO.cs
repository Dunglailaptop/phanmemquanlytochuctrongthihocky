using phanmemquanlylichthi.DTO.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanmemquanlylichthi.DAO
{
    public class PhongthiDAO
    {
        modelDataContext db = new modelDataContext();
        private static PhongthiDAO instance;
        public static PhongthiDAO Instance
        {
            get { if (instance == null) instance = new PhongthiDAO(); return PhongthiDAO.instance; }
            private set { PhongthiDAO.instance = value; }
        }

        private PhongthiDAO()
        { }

        public List<phongthi> loadds()
        {
            List<phongthi> list = new List<phongthi>();
            string q = "select * from phongthi";
            DataTable DATA = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow row in DATA.Rows)
            {
                phongthi l = new phongthi();
                l.phongthi1 = row["phongthi"].ToString();
                l.Tenphongthi = row["Tenphongthi"].ToString();
                l.soluongghe = (int)row["soluongghe"];
                list.Add(l);
            }
            return list;
        }
        public phongthi themphong(string tenphong,int soluong,int tongsoday,int tongsodayngang)
        {
            phongthi pt = new phongthi();
            string q = "insert into phongthi(Tenphongthi,soluongghe,trangthai,tongsoday,tongsodayngang) output inserted.phongthi as [id] values ('"+tenphong+"','"+soluong+"','0','"+tongsoday+"','"+tongsodayngang+"')";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow dt in data.Rows)
            {
                pt.phongthi1 = dt["id"].ToString();

            }
            return pt;

        }
        public bool suaphong(string maphong,string tenphong)
        {
            string p = "update phongthi set Tenphongthi='"+tenphong+"' where phongthi='"+maphong+"'";
            int r = DataProvider.Instance.ExecuteNonQuery(p);
            return r > 0;

        }
        public phongthi showghe(string maphong)
        {
            phongthi pn = new phongthi();
            string q = "SELECT DISTINCT pt.tongsoday, pt.tongsodayngang,pt.soluongghe  FROM ghengoi gn inner join phongthi pt on pt.phongthi=gn.phongthi where gn.phongthi='" + maphong + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                
                pn.tongsoday = (int)row["tongsoday"];
                pn.tongsodayngang = (int)row["tongsodayngang"];
                pn.soluongghe = (int)row["soluongghe"];
               
            }
            return pn;
        }
    }
}
