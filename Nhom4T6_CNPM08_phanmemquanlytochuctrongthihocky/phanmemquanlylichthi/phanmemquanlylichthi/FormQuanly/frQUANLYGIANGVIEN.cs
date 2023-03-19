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

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYGIANGVIEN : DevExpress.XtraEditors.XtraForm
    {
        bool them = false;
        bool sua = false;
        bool xoa = false;
        string imgLocation = " ";
        int idphong;
        int idlop;
        int idquyen;
        private byte[] hinhanh;
        modelDataContext db = new modelDataContext();
        public byte[] Hinhanh { get => hinhanh; set => hinhanh = value; }

        public frQUANLYGIANGVIEN()
        {
            InitializeComponent();
            check(true);
            loaddsgiangvien();
            loadphongban();
            loadquyen();
            loadlop();
        }
        void check(bool kt)
        {
            btnthem.Enabled = !kt;
            btnsua.Enabled = !kt;
            btnxoa.Enabled = !kt;
            btnluu.Enabled = !kt;
            btnhuy.Enabled = !kt;
            btnin.Enabled = !kt;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loaddsgiangvien()
        {
            gridControl1.DataSource=GiangvienDAO.Instance.loaddsgiangvien();
            gridView1.OptionsBehavior.Editable = false;
        }
        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(true);
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            them = true;
            sua = false;
            xoa = false;
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

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(them==true)
            {
                try
                {
                    if (GiangvienDAO.Instance.themgiangvien(txthoten.Text,txtemail.Text,txtbomon.Text,txtsdt.Text,idphong,idquyen,idlop,hinhanh))
                    {
                        MessageBox.Show("Thêm giảng viên thành công");
                        loaddsgiangvien();

                    }
                }
                catch
                {

                }
            }else if(sua==true)
            {
                try
                {
                    GiangvienDAO.Instance.suagiangvien(txthoten.Text, txtemail.Text, txtbomon.Text, txtsdt.Text, idphong, idquyen, idlop, txtGiangvien.Text, Hinhanh);
                   
                        MessageBox.Show("sửa giảng viên thành công");
                        loaddsgiangvien();
                  
                }
                catch
                {

                }
            }else if(xoa==true)
            {
                try
                {
                   if(GiangvienDAO.Instance.xoagiangvien(txtGiangvien.Text))
                    {
                        MessageBox.Show("xóa thành công");
                        loaddsgiangvien();
                    }
                }catch
                {

                }
            }
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
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
        private void frQUANLYGIANGVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet7.giangvien' table. You can move, or remove it, as needed.
            this.giangvienTableAdapter.Fill(this.phanmemquanlylichthiDataSet7.giangvien);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        void load(string id)
        {
            innerjoin nj = GiangvienDAO.Instance.loaddsgiangvienbyid(id);
            txtGiangvien.Text = nj.Macanbo;
            txthoten.Text = nj.hoten;
            txtsdt.Text = nj.sdt;
            txtemail.Text = nj.email;
            txtbomon.Text = nj.bomon;
            cblop.Text = nj.tenlop;
            cbphongban.Text = nj.tenphonglamviec;
            cbquyen.Text = nj.tenquyen;
            pictureBox1.Image = convertbytetoimage(nj.hinhanh);
            hinhanh = nj.hinhanh;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            if (gridView1.GetFocusedRowCellValue("Macanbo") != null)
            {
                try
                {
                    string id = gridView1.GetFocusedRowCellValue("Macanbo").ToString();
                    load(id);
                }
                catch
                {

                }

            }
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
        void loadphongban()
        {
            cbphongban.DataSource = db.phonglamviecs.ToList();
            cbphongban.DisplayMember = "tenphonglamviec";
        }
        void loadquyen()
        {
            cbquyen.DataSource = db.phanquyens.ToList();
            cbquyen.DisplayMember = "Tenquyen";
        }
        void loadlop()
        {
            cblop.DataSource = db.lops.ToList();
            cblop.DisplayMember = "tenlop";
        }
        private void cbphongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            phonglamviec selected = cb.SelectedItem as phonglamviec;
            idphong = selected.Maphonglamviec;
        }

        private void cbquyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            phanquyen selected = cb.SelectedItem as phanquyen;
            idquyen = selected.Maquyen;
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            lop selected = cb.SelectedItem as lop;
            idlop = selected.Malop;
        }
    }
}