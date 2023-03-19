using phanmemquanlylichthi.DTO;
using phanmemquanlylichthi.DTO.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanmemquanlylichthi.DAO
{
    public class SinhvienDAO
    {
        modelDataContext db = new modelDataContext();
        private static SinhvienDAO instance;
        public static SinhvienDAO Instance
        {
            get { if (instance == null) instance = new SinhvienDAO(); return SinhvienDAO.instance; }
            private set { SinhvienDAO.instance = value; }
        }

        private SinhvienDAO()
        { }
        public bool thhemsinhvien(string hoten,DateTime ngaysinh, byte[] hinhanh,string sdt, string diachi,string quequan,int makhoa,int macn,int malop)
        {
            int result = db.USP_THEMSINHVIEN(hoten, ngaysinh, hinhanh, sdt, diachi, quequan, makhoa, macn,malop);
            return result > 0;
        }
        byte[] imageData = null;
        string filePath = @"C:\Users\Admin\source\repos\phanmemquanlylichthi\phanmemquanlylichthi\IMG\noimage.jpg";
        public bool thhemsinhvien(sinhvien sv)
        {
            if (sv.hinhanh == null)
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        sv.hinhanh = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
           
            int result = db.USP_THEMSINHVIEN(sv.hoten,sv.ngaysinh,sv.hinhanh,sv.sdt,sv.diachi,sv.quequan,sv.Makhoa,sv.MaCN,sv.malop);
            return result > 0;
        }
        public List<innerjoin> loaddssinhvien()
        {
            List<innerjoin> nj = new List<innerjoin>();
            string quye = "select * from sinhvien sv inner join chuyenganhdaotao cn on cn.Manganh = sv.MaCN inner join khoa k on k.Makhoa = sv.Makhoa inner join lop p on p.Malop=sv.malop";
            DataTable data = DataProvider.Instance.ExecuteQuery(quye);
            foreach(DataRow row in data.Rows)
            {
                innerjoin ji = new innerjoin();
                ji.MSSV = row["MSSV"].ToString();
                ji.hinhanh = (byte[])row["hinhanh"];
                ji.diachi = row["diachi"].ToString();
                ji.hoten = row["hoten"].ToString();
                ji.ngaysinh = (DateTime)row["ngaysinh"];
                ji.quequan = row["quequan"].ToString();
                ji.sdt = row["sdt"].ToString();
                ji.tenchuyennganh = row["tennganh"].ToString();
                ji.tenkhoa = row["tenkhoa"].ToString();
                ji.malop = (int)row["malop"];
                ji.tenlop = row["tenlop"].ToString();
                nj.Add(ji);
            }
            return nj;
        }
        public List<innerjoin> loaddssinhvienbylop(int lop)
        {
            List<innerjoin> nj = new List<innerjoin>();
            string quye = "select * from sinhvien sv inner join chuyenganhdaotao cn on cn.Manganh = sv.MaCN inner join khoa k on k.Makhoa = sv.Makhoa inner join lop p on p.Malop=sv.malop where p.Malop='"+lop+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(quye);
            foreach (DataRow row in data.Rows)
            {
                innerjoin ji = new innerjoin();
                ji.MSSV = row["MSSV"].ToString();
                ji.hinhanh = (byte[])row["hinhanh"];
                ji.diachi = row["diachi"].ToString();
                ji.hoten = row["hoten"].ToString();
                ji.ngaysinh = (DateTime)row["ngaysinh"];
                ji.quequan = row["quequan"].ToString();
                ji.sdt = row["sdt"].ToString();
                ji.tenchuyennganh = row["tennganh"].ToString();
                ji.tenkhoa = row["tenkhoa"].ToString();
                ji.malop = (int)row["malop"];
                ji.tenlop = row["tenlop"].ToString();
                nj.Add(ji);
            }
            return nj;
        }
        public innerjoin loaddssinhvienbyid(string MSSV)
        {
            innerjoin ji = new innerjoin();
            string quye = "select * from sinhvien sv inner join chuyenganhdaotao cn on cn.Manganh = sv.MaCN inner join khoa k on k.Makhoa = sv.Makhoa inner join lop p on p.Malop=sv.malop WHERE sv.MSSV='"+MSSV+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(quye);
            foreach (DataRow row in data.Rows)
            {
             
                ji.MSSV = row["MSSV"].ToString();
                ji.hinhanh = (byte[])row["hinhanh"];
                ji.diachi = row["diachi"].ToString();
                ji.hoten = row["hoten"].ToString();
                ji.quequan = row["quequan"].ToString();
                ji.ngaysinh = (DateTime)row["ngaysinh"];
                ji.sdt = row["sdt"].ToString();
                ji.tenchuyennganh = row["tennganh"].ToString();
                ji.tenkhoa = row["tenkhoa"].ToString();
                ji.tenlop = row["tenlop"].ToString();
            }
            return ji;
        }
        public bool suasinhvien(string hoten, DateTime ngaysinh, byte[] hinhanh, string sdt, string diachi, string quequan, int makhoa, int macn,string mssv,int idlop)
        {
            int result = db.USP_UPDATESINHVIEN(hoten, ngaysinh, hinhanh, sdt, diachi, quequan, makhoa, macn,mssv,idlop);
            return result > 0;
        }
        public bool xoasinhvien(string mssv)
        {
            string q = "delete from sinhvien where MSSV='"+mssv+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
    }
}
