using DevExpress.XtraEditors;
using phanmemquanlylichthi.DTO.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.FormQuanly;

namespace phanmemquanlylichthi
{
    public partial class FrDangNhap : DevExpress.XtraEditors.XtraForm
    {
        modelDataContext db = new modelDataContext();
        public FrDangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool login(string username,string password)
        {
            return AccountDAO.Instance.login(username, password);
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (login(username, password))
            {
                account list = AccountDAO.Instance.phanquyen(username, password);
                if (list.Maquyen == 1)
                {

                    //MessageBox.Show("Đăng nhập quản lý thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Hide();
                    //ribMenuQuanly mn = new ribMenuQuanly();
                    ////mn.Hoten = list.hoten;

                    //mn.ShowDialog();
                    ////this.Show();
                    ////this.Dispose();
                }
                else if (list.Maquyen == 2)
                {
                    MessageBox.Show("Đăng nhập nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //WaitForm1 wait = new WaitForm1();
                    //wait.ShowDialog();
                    //wait.Dispose();
                    this.Hide();
                    //MenuStaffdev mn = new MenuStaffdev();
                    //mn.Hoten = list.hoten;
                    //mn.Idnhanvien = list.manv;
                    ////mn.Hide();
                    //mn.ShowDialog();
                    //this.Show();
                    //this.Dispose();
                    //this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}