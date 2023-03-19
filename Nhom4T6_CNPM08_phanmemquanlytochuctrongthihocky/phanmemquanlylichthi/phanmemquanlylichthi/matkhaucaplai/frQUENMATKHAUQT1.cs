using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanmemquanlylichthi.matkhaucaplai
{
    public partial class frQUENMATKHAUQT1 : DevExpress.XtraEditors.XtraForm
    {
        modelDataContext db = new modelDataContext();
        public frQUENMATKHAUQT1()
        {
            InitializeComponent();
        }
        void guimail(string from, string to, string subject, string message)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("ndung983@gmail.com", "gnezzvtsarhtukhr");
            client.Send(mess);
        }
        private void frQUENMATKHAUQT1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string f = "ndung983@gmail.com";
                string tittle = "cap lai mat khau";
                Random r = new Random();
                string HD = "CL";
                //hoadon hd = new hoadon();

                string manv = crypt.Encrypt(HD.Trim() + r.Next().ToString(), true);

                account ac = db.accounts.Where(x => x.Username == textEdit1.Text).SingleOrDefault();
                if (ac != null)
                {
                    MessageBox.Show("đã tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taikhoangiangvien tkgv = db.taikhoangiangviens.Where(x => x.Username == ac.Username).Single();
                    giangvien nv = db.giangviens.Where(x => x.Magiangvien == tkgv.Magiangvien).SingleOrDefault();
                    if (nv != null)
                    {
                        guimail(f, nv.email, tittle, manv);
                        if (AccountDAO.Instance.quenmatkhau2(manv))
                        {
                            this.Dispose();
                            MessageBox.Show("gửi thành công email đăng ký tài khoản nhân viên vui lòng kiểm tra email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            frQUENMATKHAUQT2 mk = new frQUENMATKHAUQT2();
                            mk.User = ac.Username;
                            mk.ShowDialog();
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}