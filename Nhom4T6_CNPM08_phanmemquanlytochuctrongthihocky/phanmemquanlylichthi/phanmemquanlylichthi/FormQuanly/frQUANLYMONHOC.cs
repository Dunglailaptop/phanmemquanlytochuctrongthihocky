using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
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

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYMONHOC : DevExpress.XtraEditors.XtraForm
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
        public frQUANLYMONHOC()
        {
            InitializeComponent();
            loaddsmonhoc();
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

        private void frQUANLYMONHOC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet6.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.phanmemquanlylichthiDataSet6.monhoc);

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
        void loaddsmonhoc()
        {
            gridControl1.DataSource = MonhocDAO.Instance.loadmmonhoc();
            gridView1.OptionsBehavior.Editable = false;
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
                    if (MonhocDAO.Instance.themmonhoc(ngay.Value, txttenmon.Text, int.Parse(txttinchi.Text)))
                    {
                        MessageBox.Show("thêm môn học");
                        loaddsmonhoc();
                    }
                }
                catch
                {

                }
                
            }else if(sua==true)
            {
                try
                {
                    if (MonhocDAO.Instance.suamonhoc(ngay.Value, txttenmon.Text, int.Parse(txttinchi.Text), txtMamh.Text))
                    {
                        MessageBox.Show("sửa môn thành công");
                        loaddsmonhoc();
                    }else
                    {
                        MessageBox.Show("sửa môn thất bại");
                    }
                }catch
                {

                }
              
            }else if(xoa==true)
            {
                try
                {
                    if (MonhocDAO.Instance.xoamonhoc(txtMamh.Text))
                    {
                        MessageBox.Show("Xóa môn thành công");
                    }else
                    {
                        MessageBox.Show("Xóa môn thất bại");
                    }
                }
                catch
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
        void loadgrid(string mamh)
        {
            monhoc m = MonhocDAO.Instance.loadmmonhocbyid(mamh);
            txtMamh.Text = m.MaMonHoc;
            txttenmon.Text = m.tenmonhoc;
            txttinchi.Text =m.sotinchi.ToString();
            ngay.Value = (DateTime)m.ngaymolop;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("MaMonHoc")!=null)
            {
                try
                {
                    string id = gridView1.GetFocusedRowCellValue("MaMonHoc").ToString();
                    loadgrid(id);
                }catch
                {

                }
               
            }
        }
    }
}