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
using phanmemquanlylichthi.DTO;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYLOP : DevExpress.XtraEditors.XtraForm
    {
        bool them;
        bool xoa;
        bool sua;
        string idmonhoc;
        int idhocky;
        modelDataContext db = new modelDataContext();
        public frQUANLYLOP()
        {
            InitializeComponent();
            loaddslop();
            loadmonhoc();
            loadhocky();
            check(true);
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
        void loaddslop()
        {
            gridControl1.DataSource = lopDAO.Instance.loaddslop();
            gridView1.OptionsBehavior.Editable = false;
        }
        private void frQUANLYLOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet8.lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.phanmemquanlylichthiDataSet8.lop);

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
                    if (lopDAO.Instance.themlop(txttenlop.Text, ngay.Value, idhocky, txtdotmo.Text, idmonhoc))
                    {
                        MessageBox.Show("thêm thành công");
                        loaddslop();
                    }else
                    {
                        MessageBox.Show("thêm lớp thất bại");
                    }
                }catch
                {

                }
            }else if(sua==true)
            {
                try
                {
                    if(lopDAO.Instance.sualop(txttenlop.Text, ngay.Value, idhocky, txtdotmo.Text, idmonhoc, int.Parse(txtMalop.Text)))
                    {
                        MessageBox.Show("sửa lớp thành công");
                        loaddslop();
                    }else
                    {
                        MessageBox.Show("sửa lớp thất bại");
                    }
                }catch
                {

                }
            }else if(xoa==true)
            {
                try
                {
                    if(lopDAO.Instance.xoalop(int.Parse(txtMalop.Text)))
                    {
                        MessageBox.Show("Xóa lớp thành công");
                        loaddslop();
                    }else
                    {
                        MessageBox.Show("Xóa lớp thất bại");
                    }
                }catch
                {
                    MessageBox.Show("Xóa lớp thất bại");
                }
            }
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
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
        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
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
        void loadgrid(int id)
        {
            innerjoin nj = lopDAO.Instance.loaddslopBYID(id);
            txttenlop.Text = nj.tenlop;
            txtdotmo.Text = nj.dotmolop;
            txtMalop.Text = nj.malop.ToString();
            txtdotmo.Text = nj.dotmolop;
            ngay.Value = nj.ngaymolop;
            cbmonhoc.Text = nj.bomon;
            cbhocky.Text = nj.tenhocky;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("malop")!=null)
            {
                try
                {
                    int id = int.Parse(gridView1.GetFocusedRowCellValue("malop").ToString());
                    loadgrid(id);
                }catch
                {

                }
            }
        }
    }
}