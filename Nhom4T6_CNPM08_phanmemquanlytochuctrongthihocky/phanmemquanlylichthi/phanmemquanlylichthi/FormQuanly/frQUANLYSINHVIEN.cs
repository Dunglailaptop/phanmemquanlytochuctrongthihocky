using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using phanmemquanlylichthi.DTO.model;
using ComboBox = System.Windows.Forms.ComboBox;
using phanmemquanlylichthi.DTO;
using DevExpress.XtraGrid;
using phanmemquanlylichthi.EXCEL;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYSINHVIEN : DevExpress.XtraEditors.XtraForm
    {
        bool them = false;
        bool sua = false;
        bool xoa = false;
        int idlop;
       string  imgLocation=" ";
        private byte[] hinhanh;
        int idkhoa=0;
        int idchuyenganh=0;
        modelDataContext db = new modelDataContext();
        public byte[] Hinhanh { get => hinhanh; set => hinhanh = value; }

        public frQUANLYSINHVIEN()
        {
            InitializeComponent();
            check(true);
            try
            {
                loaddskhoa();
                loaddschuyennganh();
                loaddata();
                loadlop();
            }
            catch
            {

            }
       
        }
        void loaddskhoa()
        {
            cbkhoa.DataSource = db.khoas.ToList();
            cbkhoa.DisplayMember = "tenkhoa";
        }
        void loaddschuyennganh()
        {
            cbchuyennganh.DataSource = db.chuyenganhdaotaos.ToList();
            cbchuyennganh.DisplayMember = "tennganh";
        }
        void loaddata()
        {
            gridControl1.DataSource = SinhvienDAO.Instance.loaddssinhvien();
            gridView1.OptionsBehavior.Editable = false;
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
        void loaddetailsv(string MSSV)
        {
            innerjoin nj = SinhvienDAO.Instance.loaddssinhvienbyid(MSSV);
            pictureBox1.Image =convertbytetoimage(nj.hinhanh);
            txthoten.Text = nj.hoten;
            txtdiachi.Text = nj.diachi;
            txtquequan.Text = nj.quequan;
            txtsdt.Text = nj.sdt;
            hinhanh = nj.hinhanh;
            cbchuyennganh.Text = nj.tenchuyennganh;
            cbkhoa.Text = nj.tenkhoa;
            txtMSSV.Text = nj.MSSV;
            cblop.Text = nj.tenlop;
            ngaysinh.Value=nj.ngaysinh;
            hinhanh = nj.hinhanh;
        }
        void indd(GridControl gir)
        {
            if (!gir.IsPrintingAvailable)
            {
                MessageBox.Show("faild");
                return;
            }
            gir.ShowPrintPreview();
        }
        void check(bool kt)
        {
            btnthem.Enabled = !kt;
            btnsua.Enabled = !kt;
            btnxoa.Enabled = !kt;
            btnluu.Enabled = !kt;
            btnhuy .Enabled = !kt;
            btnin.Enabled= !kt;
        }
        void clear()
        {
            txthoten.Text = " ";
            txtMSSV.Text = " ";
            txtdiachi.Text = " ";
            txtquequan.Text = " ";
            txtsdt.Text = " ";
            pictureBox1.Image = null;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(true);
            btnluu.Enabled=true;
            btnhuy.Enabled=true;
            them = true;
            sua = false;
            xoa = false;
            clear();
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(them==true)
            {
                try
                {
                    if (SinhvienDAO.Instance.thhemsinhvien(txthoten.Text,ngaysinh.Value,Hinhanh,txtsdt.Text,txtdiachi.Text,txtquequan.Text,idkhoa,idchuyenganh,idlop))
                    {
                        
                    }
                    MessageBox.Show("Thêm sinh viên thành công");
                    loaddata();
                }catch
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }else if(sua==true)
            {
                try
                {
                    SinhvienDAO.Instance.suasinhvien(txthoten.Text, ngaysinh.Value, Hinhanh, txtsdt.Text, txtdiachi.Text, txtquequan.Text, idkhoa, idchuyenganh, txtMSSV.Text,idlop);
                    MessageBox.Show("Sửa thành công");
                    loaddata();
                }
                catch
                {
                    MessageBox.Show("sửa thất bại");
                }
            }
            else if(xoa==true)
            {
                try
                {
                    if(SinhvienDAO.Instance.xoasinhvien(txtMSSV.Text))
                    {
                        MessageBox.Show("Xóa sinh viên thành công");
                        loaddata();
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa sinh viên thất bại");
                }
            }
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(true);
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            them = false;
            sua = true;
            xoa = false;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(true);
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            them = false;
            sua = false;
            xoa = true;
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
                if (imgLocation != null)
                {

                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(stream);
                    Hinhanh = br.ReadBytes((int)stream.Length);
                }
            }
        }

        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            khoa selected = cb.SelectedItem as khoa;
            idkhoa = selected.Makhoa;
        }

        private void cbchuyennganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

             chuyenganhdaotao selected = cb.SelectedItem as chuyenganhdaotao;
            idchuyenganh = selected.Manganh;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("MSSV")!=null)
            {
                string mssv = gridView1.GetFocusedRowCellValue("MSSV").ToString();
                try
                {
                    loaddetailsv(mssv);
                }catch
                {

                }
            }
        }

        private void btnin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            indd(gridControl1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frNHAPEXCELSINHVIEN().ShowDialog();
            loaddata();
        }

        private void frQUANLYSINHVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet10.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.phanmemquanlylichthiDataSet10.sinhvien);

        }
        void loadlop()
        {
            cblop.DataSource = db.lops.ToList();
            cblop.DisplayMember = "tenlop";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            lop selected = cb.SelectedItem as lop;
            idlop = selected.Malop;
        }
    }
}