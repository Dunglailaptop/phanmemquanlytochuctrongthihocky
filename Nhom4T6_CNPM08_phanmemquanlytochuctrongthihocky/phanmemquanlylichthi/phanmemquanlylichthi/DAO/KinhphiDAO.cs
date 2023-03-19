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
    public class KinhphiDAO
    {
        modelDataContext db = new modelDataContext();
        private static KinhphiDAO instance;
        public static KinhphiDAO Instance
        {
            get { if (instance == null) instance = new KinhphiDAO(); return KinhphiDAO.instance; }
            private set { KinhphiDAO.instance = value; }
        }

        private KinhphiDAO()
        { }

        public List<innerjoin> loaddskinhphi()
        {
            List<innerjoin> list = new List<innerjoin>();
            string q = "select * from kinhphi ki inner join giangvien gv on ki.Magiangvien = gv.Magiangvien inner join lop p on p.Malop = ki.Malop";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
           foreach(DataRow row in data.Rows)
            {
                innerjoin kp = new innerjoin();
                kp.id = (int)row["ID"];
                kp.tongkinhphi = (decimal)row["tongchiphi"];
                kp.dongia = (decimal)row["dongia"];
                kp.hoten = row["hoten"].ToString();
                kp.tenlop = row["tenlop"].ToString();
                kp.trangthaii = row["trangthai"].ToString();
                list.Add(kp);
            }
           return list;
        }
        public innerjoin loaddskinhphibyid(int id)
        {
            innerjoin kp = new innerjoin();
            string q = "select * from kinhphi ki inner join giangvien gv on ki.Magiangvien = gv.Magiangvien inner join lop p on p.Malop = ki.Malop where ID='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
              
                kp.id = (int)row["ID"];
                kp.tongkinhphi = (decimal)row["tongchiphi"];
                kp.dongia = (decimal)row["dongia"];
                kp.hoten = row["hoten"].ToString();
                kp.tenlop = row["tenlop"].ToString();
                kp.ngaythi = (DateTime)row["ngaytao"];
                kp.trangthaii = row["trangthai"].ToString();
            }
            return kp;
        }
        public bool  theminfokinhphi(string quanly,string magv,decimal tong,decimal dongia,DateTime ngaytao,int lop,string trangthai)
        {
            string q = "insert into kinhphi(MaQL,Magiangvien,tongchiphi,ngaytao,Malop,dongia,trangthai) values ('" + quanly + "','" + magv + "','" + tong + "','" + ngaytao + "','" + lop + "','" + dongia + "','" + trangthai + "')";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e>0;
        }
        public bool suainfokinhphi(string quanly, string magv,decimal dongia, DateTime ngaytao, int lop, string trangthai,int id)
        {
            string q = "update kinhphi set MaQL='"+quanly+"',Magiangvien='"+magv+"',ngaytao='"+ngaytao+"',Malop='"+lop+"',dongia='"+dongia+"',trangthai='"+trangthai+"' where id='"+id+"'";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e > 0;
        }
        public bool deleteinfokinhphi(int id)
        {
            string q = "delete from kinhphi where ID='"+id+"'";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e > 0;
        }
        public bool tongtien(int id)
        {
            string q = "usp_captongtien '" + id + "'";
            int e = DataProvider.Instance.ExecuteNonQuery(q);
            return e > 0;
        }
        public List<innerjoin> thongkrloaddskinhphi()
        {
            List<innerjoin> list = new List<innerjoin>();
            string q = "select tenlop,tongchiphi,kp.trangthai from kinhphi kp inner join lop p on p.Malop=kp.Malop";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                innerjoin kp = new innerjoin();
            
                kp.tongkinhphi = (decimal)row["tongchiphi"];
              
                kp.tenlop = row["tenlop"].ToString();
                kp.trangthaii = row["trangthai"].ToString();
                list.Add(kp);
            }
            return list;
        }
        public List<innerjoin> thongketheogiangvienloaddskinhphi()
        {
            List<innerjoin> list = new List<innerjoin>();
            string q = "select p.hoten,tongchiphi,kp.trangthai from kinhphi kp inner join giangvien p on p.Magiangvien=kp.Magiangvien";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                innerjoin kp = new innerjoin();

                kp.tongkinhphi = (decimal)row["tongchiphi"];

                kp.tenlop = row["hoten"].ToString();
                kp.trangthaii = row["trangthai"].ToString();
                list.Add(kp);
            }
            return list;
        }
        public List<innerjoin> thongketheocanbocanhthiloaddskinhphi()
        {
            List<innerjoin> list = new List<innerjoin>();
            string q = "select cbct.hoten,tongchiphi,kp.trangthai from kinhphi kp inner join lop p on p.Malop = kp.Malop inner join canhthi ct on ct.Malop = p.Malop inner join canbocanhthi cbct on cbct.MaCanbo = ct.Macanbo";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                innerjoin kp = new innerjoin();

                kp.tongkinhphi = (decimal)row["tongchiphi"];

                kp.tenlop = row["hoten"].ToString();
                kp.trangthaii = row["trangthai"].ToString();
                list.Add(kp);
            }
            return list;
        }
    }
}
