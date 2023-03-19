using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
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
using ComboBox = System.Windows.Forms.ComboBox;

using QRCoder;
using System.IO;
using phanmemquanlylichthi.EXCEL;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYTHISINH : DevExpress.XtraEditors.XtraForm
    {

        bool them=false;
        bool sua=false;
        bool xoa = false;
        string idphong;
        byte[] hinhanh;
        modelDataContext db = new modelDataContext();
        public frQUANLYTHISINH()
        {
            InitializeComponent();
            check(true);
            LOADDSPHONGTHI();
            loadthisinh();
           
        }
        private void F2_updateEventHandler(object sender, FRNHAPEXCELTHISINH.UpdateEventArgs args)
        {
            loadthisinh();
        }
        void LOADDSPHONGTHI()
        {
            cbphongthi.DataSource = db.phongthis.ToList();
            cbphongthi.DisplayMember = "Tenphongthi";
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
        void loadthisinh()
        {
            gridControl1.DataSource = thisinhDAO.Instance.loaddsthisinh();
            gridView1.OptionsBehavior.Editable = false;
        }
        void clear()
        {
            txtmssv.Text = " ";
            txtstt.Text = " ";
            
        }
        void getQRcoder(string mathisinh)
        {
            QRCodeGenerator qr=new QRCodeGenerator();
            QRCodeData data=qr.CreateQrCode(mathisinh,QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);
           
                hinhanh = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[]));
            
         

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

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(them==true)
            {
                try
                {
                    getQRcoder(txtmssv.Text);
                    if(hinhanh!=null)
                    {
                    //MessageBox.Show(hinhanh.ToString());
                    thisinhDAO.Instance.themthisinh(txtmssv.Text, idphong, int.Parse(txtstt.Text), hinhanh);
                     

                        MessageBox.Show("thêm thành công");
                        loadthisinh();
                    }

            }
                catch
            {
                MessageBox.Show("thêm thất bại");
            }
        }else if(xoa==true)
            {
                try
                {
                    if(thisinhDAO.Instance.xoathisinh(txtthisinh.Text))
                    {
                        MessageBox.Show("Xóa thành công thí sinh");
                        loadthisinh();
                    }
                }catch
                {
                    MessageBox.Show("Xóa thất bại thí sinh");
                }
            }
            else if(sua==true)
            {
                try
                {
                    if(thisinhDAO.Instance.suathisinh(txtthisinh.Text,txtmssv.Text,int.Parse(txtstt.Text),idphong))
                    {
                        MessageBox.Show("sửa thành công");
                        loadthisinh();
                    }
                }catch
                {
                    MessageBox.Show("sửa thất bại");
                }
            }
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
        void loadghengoi(string id)
        {
            txtstt.DataSource = db.ghengois.Where(x => x.phongthi == id).ToList();
            txtstt.DisplayMember = "soghe";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            phongthi selected = cb.SelectedItem as phongthi;
            idphong = selected.phongthi1;
            txtstt.Enabled = true;
            loadghengoi(idphong);
        }
        void loadthisinhbyid(string id)
        {
            thisinh th = thisinhDAO.Instance.loaddsthisinhbyid(id);
            txtmssv.Text = th.Masinhvien;
            txtthisinh.Text = th.Mathisinh;
            phongthi pt = db.phongthis.Where(x => x.phongthi1 == th.Maphongthi).Single();
            pictureBox1.Image = convertbytetoimage(th.ORCODE.ToArray());
            if(pt!=null)
            {
                cbphongthi.Text =pt.Tenphongthi;
            }
            txtstt.Text = th.soghe.ToString();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("Mathisinh")!=null)
            {
                string thisinhid = gridView1.GetFocusedRowCellValue("Mathisinh").ToString();
                try
                {
                    loadthisinhbyid(thisinhid);
                }catch
                {

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
         
                try
                {
                string id = txtmssv.Text;
                   frTHONGTINCHITIET f=new frTHONGTINCHITIET(id);
                    f.ShowDialog();
                }
                catch
                {

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
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FRNHAPEXCELTHISINH().ShowDialog();
            loadthisinh();

        }

        private void txtstt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}