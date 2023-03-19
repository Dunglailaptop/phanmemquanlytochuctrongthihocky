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
using ComboBox = System.Windows.Forms.ComboBox;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYKINHPHI1 : DevExpress.XtraEditors.XtraForm
    {
        bool them, sua, xoa;
        int idlop;
        string idgv;
        modelDataContext db = new modelDataContext();
        public frQUANLYKINHPHI1()
        {
            InitializeComponent();
            try
            {
                check(true);
                lop();
                giangvie();
                load();
            }catch
            {

            }
       
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void load()
        {
            gridControl1.DataSource = KinhphiDAO.Instance.loaddskinhphi();
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
        void lop()
        {
            CBLOP.DataSource = db.lops.ToList();
            CBLOP.DisplayMember = "tenlop";
        }
        void giangvie()
        {
            CBGIANGVIEN.DataSource =db.giangviens.ToList();
            CBGIANGVIEN.DisplayMember = "hoten";
        }

        private void frQUANLYKINHPHI1_Load(object sender, EventArgs e)
        {

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

        private void CBGIANGVIEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            giangvien selected = cb.SelectedItem as giangvien;
            idgv = selected.Magiangvien;
        }

        private void CBLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            lop selected = cb.SelectedItem as lop;
            idlop = selected.Malop;
        }
        void get(int id)
        {
            innerjoin nj = KinhphiDAO.Instance.loaddskinhphibyid(id);
            txtMAT.Text = nj.id.ToString();
            txtdongia.Text = nj.dongia.ToString();
            CBGIANGVIEN.Text = nj.hoten;
            CBLOP.Text = nj.tenlop;
            NGAYTAO.Value = nj.ngaythi;
            CBTRANGTHAI.Text = nj.trangthai.ToString();

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("id")!=null)
            {
                int id =int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
                try
                {
                    get(id);
                }catch
                {

                }
            }
        }

        private void CBTRANGTHAI_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    string i = "1";
                    int tong = 0;
                    if (KinhphiDAO.Instance.theminfokinhphi(i,idgv,tong,decimal.Parse(txtdongia.Text),NGAYTAO.Value,idlop,CBTRANGTHAI.Text))
                    {
                        if(KinhphiDAO.Instance.tongtien(idlop))
                        {
                            MessageBox.Show("cập nhật kinh phí  thành công");
                        }
                        MessageBox.Show("Thêm  thành công");
                        load();
                    }else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }


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
                    string i = "1";
               
                    if (KinhphiDAO.Instance.suainfokinhphi(i, idgv, decimal.Parse(txtdongia.Text), NGAYTAO.Value, idlop, CBTRANGTHAI.Text,int.Parse(txtMAT.Text)))
                     {
                        if (KinhphiDAO.Instance.tongtien(idlop))
                        {
                            MessageBox.Show("cập nhật kinh phí  thành công");
                        }
                        MessageBox.Show("sửa thành công");
                        load();
                    }
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
                    if (KinhphiDAO.Instance.deleteinfokinhphi(int.Parse(txtMAT.Text)))
                    {
                        MessageBox.Show("Xóa  thành công");
                        load();

                    }
                }
                catch
                {
                    MessageBox.Show("Xóa  thất bại");
                }
            }
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
    }
}