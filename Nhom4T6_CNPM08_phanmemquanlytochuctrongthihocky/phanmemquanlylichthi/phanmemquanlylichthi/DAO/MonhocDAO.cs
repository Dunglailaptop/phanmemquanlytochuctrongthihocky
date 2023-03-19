using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO.model;
namespace phanmemquanlylichthi.DAO
{
    public class MonhocDAO
    {
        modelDataContext db = new modelDataContext();
        private static MonhocDAO instance;
        public static MonhocDAO Instance
        {
            get { if (instance == null) instance = new MonhocDAO(); return MonhocDAO.instance; }
            private set { MonhocDAO.instance = value; }
        }

        private MonhocDAO()
        { }
        public bool themmonhoc(DateTime ngay,string tenmonhoc,int sotinchi)
        {
            string q = "insert into monhoc(ngaymolop,tenmonhoc,sotinchi) values ('" + ngay + "',N'" + tenmonhoc + "','" + sotinchi + "')";
            int re = DataProvider.Instance.ExecuteNonQuery(q);
            return re > 0;
        }
        public bool suamonhoc(DateTime ngay, string tenmonhoc, int sotinchi,string mamonhoc)
        {
            string q = "update monhoc set tenmonhoc=N'"+tenmonhoc+"',ngaymolop='"+ngay+"',sotinchi='"+sotinchi+"' where MaMonHoc='"+mamonhoc+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(q);
            return re > 0;
        }
        public bool xoamonhoc(string mamonhoc)
        {
            string q = "delete from monhoc where MaMonHoc='"+mamonhoc+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(q);
            return re > 0;
        }
        public List<monhoc> loadmmonhoc()
        {
            List<monhoc> list = new List<monhoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from monhoc");
            foreach(DataRow row in data.Rows)
            {
                monhoc mh = new monhoc();
                mh.MaMonHoc = row["MaMonHoc"].ToString();
                mh.tenmonhoc = row["tenmonhoc"].ToString();
                mh.ngaymolop = (DateTime)row["ngaymolop"];
                mh.sotinchi = (int)row["sotinchi"];
                list.Add(mh);
            }    
            return list;
        }
        public monhoc loadmmonhocbyid(string mamh)
        {
            monhoc mh = new monhoc();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from monhoc where MaMonhoc='"+mamh+"'");
            foreach (DataRow row in data.Rows)
            {
               
                mh.MaMonHoc = row["MaMonHoc"].ToString();
                mh.tenmonhoc = row["tenmonhoc"].ToString();
                mh.ngaymolop = (DateTime)row["ngaymolop"];
                mh.sotinchi = (int)row["sotinchi"];
               
            }
            return mh;
        }
    }
}
