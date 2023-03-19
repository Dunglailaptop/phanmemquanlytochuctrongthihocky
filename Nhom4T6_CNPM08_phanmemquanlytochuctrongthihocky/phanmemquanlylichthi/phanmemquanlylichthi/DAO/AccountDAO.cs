using phanmemquanlylichthi.DTO;
using phanmemquanlylichthi.DTO.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanmemquanlylichthi.DAO
{
    public class AccountDAO
    {
        modelDataContext db = new modelDataContext();
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO()
        { }
        public bool suamk(string user, string matkhau)
        {
            string quye = "update account set  Passwordd='" + matkhau + "' where Username='" + user + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(quye);
            return result > 0;

        }
        public bool login(string username,string password)
        {
            string quye = "usp_dangnhap @username , @password";
            DataTable resullt = DataProvider.Instance.ExecuteQuery(quye, new object[] { username, password });
            return resullt.Rows.Count > 0;
        }
        public account phanquyen(string username, string password)
        {
            account account = new account();
            string quye = "usp_dangnhap @username , @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(quye,new object[] {username,password});
            foreach(DataRow row in data.Rows)
            {
                account.Maquyen = (int)row["Maquyen"];
                account.Username = row["Username"].ToString();
            }
            return account;
        }
        public account xacthuctaikhoan(string username, string password)
        {
            account account = new account();
            string quye = "usp_dangnhap @username , @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(quye, new object[] { username, password });
            foreach (DataRow row in data.Rows)
            {
                account.Username = row["Username"].ToString();
                account.passwordd = row["passwordd"].ToString();
            }
            return account;
        }
        
        public bool themtaikhoan(string username,string password,int maquyen,string magv)
        {
            string q = "usp_themtaikhoangiangvien '" + username + "','" + password + "','" + magv + "','" + maquyen + "'";
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool themtaikhoancb(string username, string password, int maquyen, string magv)
        {
            string q = "usp_themtaikhoangcanbo '" + username + "','" + password + "','" + magv + "','" + maquyen + "'";
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool xoataikhoangv(string username, string magv)
        {
            string q = "usp_xoagiangvien '" + magv + "','" + username + "'";
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
        public bool xoataikhoangcb(string username, string magv)
        {
            string q = "usp_xoacanbo '" + magv + "','" + username + "'";
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
        public List<innerjoin> laydstaikhoan()
        {
            List<innerjoin> laydstaikhoan = new List<innerjoin>();
            string q = "select * from account a inner join taikhoangiangvien tkgv on tkgv.Username=a.Username";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                innerjoin nj = new innerjoin();
                nj.username = row["Username"].ToString();
                nj.password = row["Passwordd"].ToString();
                nj.magv = row["Magiangvien"].ToString();
                laydstaikhoan.Add(nj);
            }
            return laydstaikhoan;
        }
        public List<innerjoin> laydstaikhoancb()
        {
            List<innerjoin> laydstaikhoan = new List<innerjoin>();
            string q = "select * from account a inner join taikhoancanbo tkcb on tkcb.Username=a.Username";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
                innerjoin nj = new innerjoin();
                nj.username = row["Username"].ToString();
                nj.password = row["Passwordd"].ToString();
                nj.magv = row["Macanbo"].ToString();
                laydstaikhoan.Add(nj);
            }
            return laydstaikhoan;
        }

        public innerjoin laydstaikhoanbyid(string idgv)
        {
            innerjoin nj = new innerjoin();
            string q = "select * from account a inner join taikhoangiangvien tkgv on tkgv.Username=a.Username";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
              
                nj.username = row["Username"].ToString();
                nj.password = row["Passwordd"].ToString();
                nj.magv = row["Magiangvien"].ToString();
          
            }
            return nj;
        }
        public innerjoin laydstaikhoancbbyid(string idcb)
        {
            innerjoin nj = new innerjoin();
            string q = "select * from account a inner join taikhoancanbo tkcb on tkcb.Username=a.Username";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow row in data.Rows)
            {
               
                nj.username = row["Username"].ToString();
                nj.password = row["Passwordd"].ToString();
                nj.magv = row["Macanbo"].ToString();
               
            }
            return nj;
        }
        public bool quenmatkhau2(string id)
        {
         
            string q = "insert into quenmatkhau(macaplai) values('" + id + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        //public
    }
}
