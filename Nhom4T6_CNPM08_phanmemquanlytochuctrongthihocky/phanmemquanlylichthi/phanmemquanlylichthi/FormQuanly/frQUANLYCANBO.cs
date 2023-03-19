using DevExpress.XtraEditors;
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
using phanmemquanlylichthi.DAO;
using ComboBox = System.Windows.Forms.ComboBox;
using DevExpress.XtraSpreadsheet;
using phanmemquanlylichthi.DTO;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYCANBO : DevExpress.XtraEditors.XtraForm
    {
        string imgLocation = " ";
        bool them = false;
        bool sua = false;
        bool xoa = false;
        int idphong = 0;
        int idquyen = 0;
        private byte[] hinhanh;
        modelDataContext db = new modelDataContext();
        public byte[] Hinhanh { get => hinhanh; set => hinhanh = value; }

        public frQUANLYCANBO()
        {
            InitializeComponent();
            check(true);
            try
            {
                loadphong();
                loadquyen();
                loaddscanbo();
            }catch
            {

            }
        }
        SpreadsheetControl sheet=new SpreadsheetControl();
        void loadphong()
        {
            cbphong.DataSource = db.phonglamviecs.ToList();
            cbphong.DisplayMember = "tenphonglamviec";
        }
        void loadquyen()
        {
            cbquyen.DataSource=db.phanquyens.ToList();
            cbquyen.DisplayMember = "tenquyen";
        }
        void clear()
        {
            txthoten.Text = " ";
            txtemail.Text = " ";
            txtbomon.Text = " ";
            txtMCB.Text = " ";
            txtsdt.Text = " ";
            pictureBox1.Image = null;
        }
        void  loadcanbobyid(string id)
        {
            innerjoin nj = CanbocanhthiDAO.Instance.loaddscanbobyid(id);
            txthoten.Text = nj.hoten;
            txtbomon.Text = nj.bomon;
            txtMCB.Text = nj.Macanbo;
            txtemail.Text = nj.email;
            cbphong.Text = nj.tenphonglamviec;
            cbquyen.Text = nj.tenquyen;
           
            if (nj.hinhanh != null)
            {
                pictureBox1.Image = convertbytetoimage(nj.hinhanh);
                hinhanh = nj.hinhanh;
            }

        }
        void loaddscanbo()
        {
            gridControl1.DataSource = CanbocanhthiDAO.Instance.loaddscanbo();
            gridView1.OptionsBehavior.Editable = false;
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
        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if (them == true)
            {
                try
                {
                    if (CanbocanhthiDAO.Instance.themcanbo(txthoten.Text,txtemail.Text,txtsdt.Text,txtbomon.Text,idphong,idquyen,Hinhanh))
                    {

                    }
                    loaddscanbo();
                    MessageBox.Show("Thêm cán bộ thành công");
                  
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else if (sua == true)
            {
                try
                {
                    CanbocanhthiDAO.Instance.updatecanbocanhthi(txthoten.Text, txtemail.Text, txtsdt.Text, txtbomon.Text, idphong, idquyen, Hinhanh, txtMCB.Text);
                    MessageBox.Show("Sửa thành công");
                    loaddscanbo();
                }
                catch
                {
                    MessageBox.Show("sửa thất bại");
                }
            }
            else if (xoa == true)
            {
                try
                {
                    if (CanbocanhthiDAO.Instance.xoacanbo(txtMCB.Text))
                    {
                        MessageBox.Show("Xóa cán bộ thành công");
                        loaddscanbo();
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa cán bộ thất bại");
                }
            }
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(true);
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            them = true;
            sua = false;
            xoa = false;
            clear();
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbphong_SelectedIndexChanged(object sender, EventArgs e)
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

        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            clear();
            if(gridView1.GetFocusedRowCellValue("Macanbo")!=null)
            {
                try
                {
                    string Macb = gridView1.GetFocusedRowCellValue("Macanbo").ToString();
                    loadcanbobyid(Macb);
                }
                catch
                {

                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FileExcel ec = new FileExcel();
            ec.ShowDialog();
        }
    }
}