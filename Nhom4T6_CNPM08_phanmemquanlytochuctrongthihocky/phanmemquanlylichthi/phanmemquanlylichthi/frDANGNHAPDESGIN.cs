using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO.model;
using phanmemquanlylichthi.formGiangvien;
using phanmemquanlylichthi.FormQuanly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using OpenSSL;
//using OpenSSL.SSL;
using System.Net.Sockets;
using System.Security.Cryptography;
using phanmemquanlylichthi.fromcanbocanhthi;
using phanmemquanlylichthi.matkhaucaplai;
//using System.ServiceModel;
//using System.ServiceModel.Security;
//using System.ServiceModel.Security.Tokens;
//using static OpenSSL.Core.BigNumber;
//using System.IdentityModel.Selectors;

namespace phanmemquanlylichthi
{
    public partial class frDANGNHAPDESGIN : DevExpress.XtraEditors.XtraForm
    {
        private string orcode;
        public frDANGNHAPDESGIN()
        {
            InitializeComponent();
            //getdata();
            string id = "TS003";
            loadpicture(id);
        }
        public Image convertbytetoimage(Byte[] data)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex);
                return null;

            }

        }
        void loadpicture(string id)
        {
            thisinh ts = thisinhDAO.Instance.loaddsthisinhbyid(id);
            pictureBox1.Image =convertbytetoimage(ts.ORCODE.ToArray());
        }
        void getdata()
        {
            Task ts = new Task(
                () =>
                {
                    using (var pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.In))
                    {
                        pipeServer.WaitForConnection();
                      //pipeServer.Close();
                        using (var sr = new StreamReader(pipeServer))
                        {
                            string data = sr.ReadLine();
                          //MessageBox.Show(data);
                            orcode = data;
                            pipeServer.Close();
                            //MessageBox.Show(data);
                            string[] tach = orcode.Split(',');
                            //if (login(tach[1], tach[2]))
                            //{
                            //    account list = AccountDAO.Instance.phanquyen(tach[1], tach[2]);
                            //    if (list.Maquyen == 1)
                            //    {
                                 
                            //        MessageBox.Show("Đăng nhập quản lý thành công", "Thông báo"/*, MessageBoxButtons.OK, MessageBoxIcon.Error*/);
                            //        //this.Close();
                            //        ribMenuQuanly mn = new ribMenuQuanly();
                            //        ////mn.Hoten = list.hoten;

                            //        //mn.Show();
                            //        mn.ShowDialog();
                            //        //this.Dispose();
                            //    }
                            //    else if (list.Maquyen == 2)
                            //    {
                            //        MessageBox.Show("Đăng nhập nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //        //WaitForm1 wait = new WaitForm1();
                            //        //wait.ShowDialog();
                            //        //wait.Dispose();
                            //        this.Hide();
                            //        //MenuStaffdev mn = new MenuStaffdev();
                            //        //mn.Hoten = list.hoten;
                            //        //mn.Idnhanvien = list.manv;
                            //        ////mn.Hide();
                            //        //mn.ShowDialog();
                            //        //this.Show();
                            //        //this.Dispose();
                            //        //this.Show();
                            //    }
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu vui lòng nhập lại", "Thông báo"/*, MessageBoxButtons.OK, MessageBoxIcon.Information*/);
                            //}

                        }

                    }
                }
            );
            Task tss = new Task(
                () =>
                {
                    this.Close();
                }
                );
            ts.Start();
            //tss.Start();     


        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
     );
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frDANGNHAPDESGIN_Load(object sender, EventArgs e)
        {
            panelControl1.Location = new Point(
               this.ClientSize.Width / 2 - panelControl1.Size.Width / 2,
               this.ClientSize.Height / 2 - panelControl1.Size.Height / 2);
            panelControl1.Anchor = AnchorStyles.None;

            panelControl1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelControl1.Width,
            panelControl1.Height, 30, 30));
        }
        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }
        void xacthuc(string message2,byte[] mac,byte[] key)
        {
            //string message2 = Console.ReadLine();
            bool isVerified = VerifyMAC(message2, mac, key);
            if(isVerified=true)
            {
                ribMenuQuanly mn = new ribMenuQuanly();
                mn.Show();
            }else
            {
                MessageBox.Show("loi xac thuc");
            }
        }
        static byte[] GenerateMAC(string message, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
                return hmac.ComputeHash(messageBytes);
            }
        }
        static bool VerifyMAC(string message, byte[] mac, byte[] key)
        {
            byte[] expectedMac = GenerateMAC(message, key);
            return BitConverter.ToString(mac) == BitConverter.ToString(expectedMac);
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

                    MessageBox.Show("Đăng nhập quản lý thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ribMenuQuanly mn = new ribMenuQuanly();
                    mn.Username = list.Username;
                    //mn.Hoten = list.hoten;

                    mn.ShowDialog();
                    //this.Show();
                    //this.Dispose();
                }
                else if (list.Maquyen == 2)
                {
                    MessageBox.Show("Đăng nhập nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menugiangvien mn = new Menugiangvien();
                    mn.Username = list.Username;
                    //mn.Hoten = list.hoten;

                    mn.ShowDialog();
                }else if (list.Maquyen == 3)
                {
                    MessageBox.Show("Đăng nhập nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ribMENUCANBO mn = new ribMENUCANBO();
                    mn.Username = list.Username;
                    mn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frQUENMATKHAUQT1 KL = new frQUENMATKHAUQT1();
            KL.ShowDialog();
        }
    }
}