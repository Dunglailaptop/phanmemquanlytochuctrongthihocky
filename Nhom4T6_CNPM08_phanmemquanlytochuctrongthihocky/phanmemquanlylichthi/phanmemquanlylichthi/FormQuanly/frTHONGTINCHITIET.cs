using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using phanmemquanlylichthi.DTO.model;
using System.IO;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frTHONGTINCHITIET : DevExpress.XtraEditors.XtraForm
    {
        modelDataContext db = new modelDataContext();
        public frTHONGTINCHITIET(string id)
        {
            InitializeComponent();
            try
            {
                loadthongtin(id);
            }catch
            {
                MessageBox.Show("ERROR !!!!!!");
                this.Dispose();
            }
        }
       
        void loadthongtin(string id)
        {
            sinhvien th = db.sinhviens.Where(x => x.MSSV == id).Single();
            txtMSSV.Text = th.MSSV;
            txthoten.Text = th.hoten;
            txtdiachi.Text = th.diachi;
            txtquequan.Text = th.quequan;
            txtsdt.Text = th.sdt;
            pictureBox1.Image = convertbytetoimage(th.hinhanh.ToArray());
            ngaysinh.Value = (DateTime)th.ngaysinh;
            khoa k = db.khoas.Where(x => x.Makhoa == th.Makhoa).Single();
            if(k!=null)
            {
                cbkhoa.Text = k.tenkhoa; ;
            }
            chuyenganhdaotao cn = db.chuyenganhdaotaos.Where(x => x.Manganh == th.MaCN).Single();
            if(cn!=null)
            {
                cbchuyennganh.Text=cn.tennganh; 
            }
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
        private void frTHONGTINCHITIET_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}