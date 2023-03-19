using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO;
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
using ComboBox = System.Windows.Forms.ComboBox;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYDETHI : DevExpress.XtraEditors.XtraForm
    {
        bool them,sua,xoa;
        modelDataContext db = new modelDataContext();
        string idmonhoc;
        int idhocky;
        public frQUANLYDETHI()
        {
            InitializeComponent();
            loaddsdethi();
            loadhocky();
            loadmonhoc();
            check(true);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loaddsdethi()
        {
            gridControl1.DataSource = dethiDAO.Instance.loaddsdethi();
            gridView1.OptionsBehavior.Editable = false;
        }
        void loadmonhoc()
        {
            cbmonhoc.DataSource = db.monhocs.ToList();
            cbmonhoc.DisplayMember = "Tenmonhoc";
        }
        void loadhocky()
        {
            cbhocky.DataSource = db.hockies.ToList();
            cbhocky.DisplayMember = "tenhocky";
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
        private void frQUANLYDETHI_Load(object sender, EventArgs e)
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

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if (them == true)
            {
                try
                {
                    if (dethiDAO.Instance.themdethi(idhocky,idmonhoc,ngaytao.Value))
                    {

                    }
                    MessageBox.Show("Thêm thành công");
                    loaddsdethi();
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
                    dethiDAO.Instance.suadethi(idhocky, idmonhoc, ngaytao.Value,int.Parse(txtdethi.Text));
                    MessageBox.Show("Sửa thành công");
                    loaddsdethi();
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
                    if (dethiDAO.Instance.xoadethi(int.Parse(txtdethi.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                        loaddsdethi();
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void cbmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            monhoc selected = cb.SelectedItem as monhoc;
            idmonhoc = selected.MaMonHoc;
        }

        private void cbhocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

           hocky selected = cb.SelectedItem as hocky;
            idhocky = selected.Mahocky;
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
        void getdetial(int id)
        {
            innerjoin dt = dethiDAO.Instance.loaddsdethibyid(id);
            txtdethi.Text = dt.Madethi.ToString();
            cbhocky.Text = dt.tenhocky;
            cbmonhoc.Text = dt.bomon;
            ngaytao.Value = dt.ngaymolop;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("Madethi")!=null)
            {
                try
                {
                    int id = int.Parse(gridView1.GetFocusedRowCellValue("Madethi").ToString());
                    getdetial(id);
                }catch
                {

                }
            }
        }
    }
}