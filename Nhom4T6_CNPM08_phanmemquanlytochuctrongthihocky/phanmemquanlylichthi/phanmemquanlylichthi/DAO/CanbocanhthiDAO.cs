using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
    public class CanbocanhthiDAO
    {
        modelDataContext db = new modelDataContext();
        private static CanbocanhthiDAO instance;
        public static CanbocanhthiDAO Instance
        {
            get { if (instance == null) instance = new CanbocanhthiDAO(); return CanbocanhthiDAO.instance; }
            private set { CanbocanhthiDAO.instance = value; }
        }

        private CanbocanhthiDAO()
        { }
        byte[] imageData = null;
        string filePath = @"C:\Users\Admin\source\repos\phanmemquanlylichthi\phanmemquanlylichthi\IMG\noimage.jpg";


        public bool themcanbo(string hoten,string email,string sdt,string bomon, int maphonglamviec,int maquyen, byte[] hinhanh)
        {
            if(hinhanh == null)
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        hinhanh = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            int data = db.usp_themcanbocanhthi(hoten, email, bomon, sdt, maphonglamviec, maquyen, hinhanh);
            return data>0;
        }
        public bool themcanboex(canbocanhthi cb)
        {
            if (cb.hinhanh == null)
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        cb.hinhanh = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            int d=  db.usp_themcanbocanhthi(cb.hoten,cb.email,cb.bomon,cb.sdt,cb.Maphonglamviec,cb.Maquyen,cb.hinhanh);
            
            return d>0;
           
        }
        public List<innerjoin> loaddscanbo()
        {
            List<innerjoin> cb = new List<innerjoin>();
            string q = "select * from canbocanhthi cb inner join phonglamviec pl on pl.Maphonglamviec = cb.Maphonglamviec inner join phanquyen pq on pq.Maquyen = cb.Maquyen";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow row in data.Rows)
            {
               innerjoin cbb = new innerjoin();
                cbb.Macanbo = row["MaCanbo"].ToString();
                cbb.hoten = row["hoten"].ToString();
                cbb.email= row["email"].ToString();
                cbb.sdt = row["sdt"].ToString();
                cbb.bomon = row["bomon"].ToString();
                cbb.tenphonglamviec = row["tenphonglamviec"].ToString();
                cbb.tenquyen = row["Tenquyen"].ToString();
                cb.Add(cbb);
            }
            return cb;
        }
        public innerjoin loaddscanbobyid(string id)
        {
            innerjoin cbb = new innerjoin();
            string q = "select * from canbocanhthi cb inner join phonglamviec pl on pl.Maphonglamviec = cb.Maphonglamviec inner join phanquyen pq on pq.Maquyen = cb.Maquyen where cb.Macanbo='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                
                cbb.Macanbo = row["MaCanbo"].ToString();
                cbb.hoten = row["hoten"].ToString();
                cbb.email = row["email"].ToString();
                cbb.sdt = row["sdt"].ToString();
                cbb.bomon = row["bomon"].ToString();
                cbb.hinhanh = (byte[])row["hinhanh"];
                cbb.tenphonglamviec = row["tenphonglamviec"].ToString();
                cbb.tenquyen = row["Tenquyen"].ToString();
              
            }
            return cbb;
        }
        public bool updatecanbocanhthi(string hoten, string email, string sdt, string bomon, int maphonglamviec, int maquyen, byte[] hinhanh,string Macb)
        {
            int reult = db.usp_suacanbocanhthi(hoten, email, bomon, sdt, maphonglamviec, maquyen, hinhanh, Macb);
            return reult> 0;
        }
        public bool xoacanbo(string macb)
        {
            string q = "delete from canbocanhthi where Macanbo='" + macb + "'";
            int rsd = DataProvider.Instance.ExecuteNonQuery(q);
            return rsd > 0;
        }
        public bool phacongcanhthi(canhthi ct)
        {
            string q = "usp_phancongcanhthi '" + ct.Malichthi + "','" + ct.Macanbo + "','" + ct.Mamonhoc + "','" + ct.Malop + "','" + ct.Maphongthi + "'";
            int reusl = DataProvider.Instance.ExecuteNonQuery(q);
            return reusl > 0;
        }

        public bool phacongcanhthi(string canbo,int lichthi,string monhoc,int lop,string phongthi)
        {
            string q = "usp_phancongcanhthi '" + lichthi+"','"+canbo+"','"+monhoc+"','"+lop+"','"+phongthi+"'";
            int reusl = DataProvider.Instance.ExecuteNonQuery(q);
            return reusl > 0;
        }

        public bool suaphacongcanhthi(string canbo, int lichthi, string monhoc, int lop, string phongthi,int macthi)
        {
            string q = "usp_suaphancongcanhthi '" + lichthi + "','" + canbo + "','" + monhoc + "','" + lop + "','" + phongthi + "','"+macthi+"'";
            int reusl = DataProvider.Instance.ExecuteNonQuery(q);
            return reusl > 0;
        }
        public bool xoaphacongcanhthi(int macthi)
        {
            string q = "delete from canhthi where Macanhthi='"+macthi+"'";
            int reusl = DataProvider.Instance.ExecuteNonQuery(q);
            return reusl > 0;
        }
        public List<innerjoin> laydscanhthi()
        {
            List<innerjoin> nj=new List<innerjoin>();
            string q = "select * from canhthi ct inner join lichthi lt on lt.malichthi=ct.Malichthi inner join lop p on p.Malop=ct.Malop inner join monhoc mh on mh.MaMonHoc=ct.Mamonhoc inner join phongthi pt on pt.phongthi=ct.Maphongthi inner join canbocanhthi cbct on cbct.MaCanbo=ct.Macanbo";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow row in data.Rows)
            {
                innerjoin ns = new innerjoin();
                ns.macanhthi = (int)row["Macanhthi"];
                ns.hoten = row["hoten"].ToString();
                ns.Madethi = (int)row["Malichthi"];
                ns.tenlop = row["tenlop"].ToString();
                ns.bomon = row["tenmonhoc"].ToString();
                ns.tenphong = row["Tenphongthi"].ToString();
                nj.Add(ns);
            }
            return nj;
        }
        public innerjoin laydscanhthi(int id)
        {
            innerjoin ns = new innerjoin();
            string q = "select * from canhthi ct inner join lichthi lt on lt.malichthi=ct.Malichthi inner join lop p on p.Malop=ct.Malop inner join monhoc mh on mh.MaMonHoc=ct.Mamonhoc inner join phongthi pt on pt.phongthi=ct.Maphongthi inner join canbocanhthi cbct on cbct.MaCanbo=ct.Macanbo where ct.Macanhthi='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
               
                ns.macanhthi = (int)row["Macanhthi"];
                ns.hoten = row["hoten"].ToString();
                ns.Madethi = (int)row["Malichthi"];
                ns.tenlop = row["tenlop"].ToString();
                ns.bomon = row["tenmonhoc"].ToString();
                ns.tenphong = row["Tenphongthi"].ToString();
            
            }
            return ns;
        }
    }
}
