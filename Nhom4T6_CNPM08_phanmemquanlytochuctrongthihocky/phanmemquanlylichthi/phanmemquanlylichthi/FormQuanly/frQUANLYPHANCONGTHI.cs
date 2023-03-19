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
using phanmemquanlylichthi.DAO;
using ComboBox = System.Windows.Forms.ComboBox;
using phanmemquanlylichthi.DTO;
using phanmemquanlylichthi.EXCEL;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYPHANCONGTHI : DevExpress.XtraEditors.XtraForm
    {
        bool them = false;
        bool sua = false;
        bool xoa = false;
        int idlop,idlichthi;
        string idcanbo, idmonhoc, idphong;
        modelDataContext db = new modelDataContext();
        public frQUANLYPHANCONGTHI()
        {
            InitializeComponent();
            loadcbcanbo();
            loadphongthi();
            loaddscblichthi();
            loadsphongthi();
            monhoc();
            lop();
        }
        void loadsphongthi()
        {
            gridControl1.DataSource = CanbocanhthiDAO.Instance.laydscanhthi();
            gridView1.OptionsBehavior.Editable = false;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadcbcanbo()
        {
            cbcanbo.DataSource = db.canbocanhthis.ToList();
            cbcanbo.DisplayMember = "hoten";
        }
        void loaddscblichthi()
        {
            cblichthi.DataSource = db.lichthis.ToList();
            cblichthi.DisplayMember = "malichthi";
        }
        void loadphongthi()
        {
            cbphongthi.DataSource = db.phongthis.ToList();
            cbphongthi.DisplayMember = "Tenphongthi";
        }
        void monhoc()
        {
            cbmonhoc.DataSource=db.monhocs.ToList();
            cbmonhoc.DisplayMember = "tenmonhoc";

        }
        void lop()
        {
            cblop.DataSource = db.lops.ToList();
            cblop.DisplayMember = "tenlop";
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
            if (them == true)
            {
                try
                {
                    if (CanbocanhthiDAO.Instance.phacongcanhthi(idcanbo,idlichthi,idmonhoc,idlop,idphong))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Phân công cán bộ không thành công vui lòng kiểm tra có bị trùng lịch canh thi hay đã đủ số lượng cán bộ canh thi");

                    }
                   
                   loadsphongthi();
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
                  if(CanbocanhthiDAO.Instance.suaphacongcanhthi(idcanbo,idlichthi,idmonhoc,idlop,idphong,int.Parse(txtmaphancong.Text)))
                    {
                        MessageBox.Show("Sửa thành công");
                    }else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                    loadsphongthi();
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
                    if (CanbocanhthiDAO.Instance.xoaphacongcanhthi(int.Parse(txtmaphancong.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                        
                    }else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    loadsphongthi();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void frQUANLYPHANCONGTHI_Load(object sender, EventArgs e)
        {

        }

        private void cbcanbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            canbocanhthi selected = cb.SelectedItem as canbocanhthi;
            idcanbo = selected.MaCanbo;
        }

        private void cblichthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            lichthi selected = cb.SelectedItem as lichthi;
            idlichthi = selected.malichthi;
        }
        void getbyidcanbo(int id)
        {
            innerjoin nj = CanbocanhthiDAO.Instance.laydscanhthi(id);
            cbcanbo.Text = nj.hoten;
            cblichthi.Text = nj.Madethi.ToString();
            cbmonhoc.Text = nj.bomon;
            cbphongthi.Text = nj.tenphong;
            txtmaphancong.Text = nj.macanhthi.ToString();

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("macanhthi")!=null)
            {
                int id =  int.Parse(gridView1.GetFocusedRowCellValue("macanhthi").ToString());
                try
                {
                    getbyidcanbo(id);
                }catch
                {

                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frEXCELPHANCONG ex = new frEXCELPHANCONG();
            ex.ShowDialog();
            loadsphongthi();
        }

        private void cbmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

           monhoc selected = cb.SelectedItem as monhoc;
            idmonhoc = selected.MaMonHoc;
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            lop selected = cb.SelectedItem as lop;
            idlop = selected.Malop;
        }

        private void cbphongthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            phongthi selected = cb.SelectedItem as phongthi;
            idphong = selected.phongthi1;
        }
    }
}