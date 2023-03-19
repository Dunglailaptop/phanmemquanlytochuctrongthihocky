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
    public class lichthiDAO
    {
        modelDataContext db = new modelDataContext();
        private static lichthiDAO instance;
        public static lichthiDAO Instance
        {
            get { if (instance == null) instance = new lichthiDAO(); return lichthiDAO.instance; }
            private set { lichthiDAO.instance = value; }
        }

        private lichthiDAO()
        { }

        public List<innerjoin> loaddulieu()
        {
            List<innerjoin> nk = new List<innerjoin>();
            string q = "select *,ct.kip [ca] from lichthi lt inner join hocky hk on hk.Mahocky=lt.Mahocky inner join lop p on p.Malop=lt.Malop  inner join cathi ct on ct.Macathi=lt.kip inner join phongthi pt on pt.phongthi=lt.phongthi inner join monhoc mh on mh.MaMonHoc=lt.Mahp";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow row in  data.Rows)
            {
                innerjoin join = new innerjoin();
                join.malop = (int)row["Malop"];
                join.malichthi = (int)row["malichthi"];
                join.mamonhoc = row["Mahp"].ToString();
                join.hoten = row["tenmonhoc"].ToString();
                join.ghichu = row["ghichu"].ToString ();
                join.tenlop = row["tenlop"].ToString();
                join.dotmolop = row["Dotmolop"].ToString();
                join.tuan = row["tuan"].ToString();
                join.thu = row["thu"].ToString();
                join.ngaythi = (DateTime)row["ngaythi"];
                join.sldk = (int)row["sldk"];
                join.kip = row["ca"].ToString();
                
                join.tenphong = row["Tenphongthi"].ToString();
                nk.Add(join);

            }
            return nk;
        }
        public innerjoin loaddulieubyid(int malichthi)
        {
            innerjoin join = new innerjoin();
            string q = "select *,ct.kip [ca] from lichthi lt inner join hocky hk on hk.Mahocky=lt.Mahocky inner join lop p on p.Malop=lt.Malop  inner join cathi ct on ct.Macathi=lt.kip inner join phongthi pt on pt.phongthi=lt.phongthi inner join monhoc mh on mh.MaMonHoc=lt.Mahp where lt.malichthi='"+malichthi+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                join.malichthi = (int)row["malichthi"];
                join.malop = (int)row["Malop"];
                join.mamonhoc = row["Mahp"].ToString();
                join.hoten = row["tenmonhoc"].ToString();
                join.ghichu = row["ghichu"].ToString();
                join.tenlop = row["tenlop"].ToString();
                join.dotmolop = row["Dotmolop"].ToString();
                join.tuan = row["tuan"].ToString();
                join.thu = row["thu"].ToString();
                join.ngaythi = (DateTime)row["ngaythi"];
                join.sldk = (int)row["sldk"];
                join.tenhocky = row["tenhocky"].ToString();
                join.kip = row["ca"].ToString();
                join.tenphong = row["Tenphongthi"].ToString();
                join.trangthai = (int)row["trangthai"];

            }
            return join;
        }
        public List<innerjoin> loaddulieubyhocky(int mahocky)
        {
            List<innerjoin> joinn = new List<innerjoin>();
            string q = "select *,ct.kip [ca] from lichthi lt inner join hocky hk on hk.Mahocky=lt.Mahocky inner join lop p on p.Malop=lt.Malop  inner join cathi ct on ct.Macathi=lt.kip inner join phongthi pt on pt.phongthi=lt.phongthi inner join monhoc mh on mh.MaMonHoc=lt.Mahp where lt.Mahocky='" + mahocky + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                innerjoin join = new innerjoin();
                join.malichthi = (int)row["malichthi"];
                join.malop = (int)row["Malop"];
                join.mamonhoc = row["Mahp"].ToString();
                join.hoten = row["tenmonhoc"].ToString();
                join.ghichu = row["ghichu"].ToString();
                join.tenlop = row["tenlop"].ToString();
                join.dotmolop = row["Dotmolop"].ToString();
                join.tuan = row["tuan"].ToString();
                join.thu = row["thu"].ToString();
                join.ngaythi = (DateTime)row["ngaythi"];
                join.sldk = (int)row["sldk"];
                join.tenhocky = row["tenhocky"].ToString();
                join.kip = row["ca"].ToString();
                join.tenphong = row["Tenphongthi"].ToString();
                joinn.Add(join);

            }
            return joinn;
        }
        public bool themlichthi(string mahp, string ghichu, string tuan, string thu, DateTime ngaythi, int sldk, int mahocky, int malop, int kip, string maphongthi)
        {
            string q = "usp_themlichthi '" + mahp + "',N'" + ghichu + "','" + tuan + "','" + thu + "','" + ngaythi + "','" + sldk + "','" + mahocky + "','" + malop + "','" + kip + "','" + maphongthi + "'";
            int rs = DataProvider.Instance.ExecuteNonQuery(q);
            return rs > 0;
        }
        public bool themlichthi(lichthi lt)
        {
            string q = "usp_themlichthi '" + lt.Mahp + "',N'" + lt.ghichu + "','" + lt.tuan + "','" + lt.thu + "','" + lt.ngaythi + "','" + lt.sldk + "','" + lt.Mahocky + "','" + lt.Malop + "','" + lt.kip + "','" + lt.phongthi + "'";
            int rs = DataProvider.Instance.ExecuteNonQuery(q);
            return rs > 0;
        }
        public bool sualichthi(string mahp, string ghichu, string tuan, string thu, DateTime ngaythi, int sldk, int mahocky, int malop, int kip, string maphongthi,int malichthi)
        {
            string q = "usp_sualichthi '" + mahp + "',N'" + ghichu + "','" + tuan + "','" + thu + "','" + ngaythi + "','" + sldk + "','" + mahocky + "','" + malop + "','" + kip + "','" + maphongthi + "','"+malichthi+"'";
            int rs = DataProvider.Instance.ExecuteNonQuery(q);
            return rs > 0;
        }
        public bool xoalichthi(int malichti)
        {
            string q = "delete from lichthi where malichthi='"+malichti+"'";
            int rs = DataProvider.Instance.ExecuteNonQuery(q);
            return rs > 0;
        }
    }
}
