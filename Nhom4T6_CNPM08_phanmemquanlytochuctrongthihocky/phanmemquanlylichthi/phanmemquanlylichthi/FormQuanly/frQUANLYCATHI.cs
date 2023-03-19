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
    public partial class frQUANLYCATHI : DevExpress.XtraEditors.XtraForm
    {
        bool them = false;
        bool sua = false;
        bool xoa = false;
        public frQUANLYCATHI()
        {
            InitializeComponent();
            check(true);
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;
            loadcathi();
        }
        void loadcathi()
        {
            gridControl1.DataSource = cathiDAO.Instance.loaddscathi();
            gridView1.OptionsBehavior.Editable = false;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void frQUANLYCATHI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet9.cathi' table. You can move, or remove it, as needed.
            this.cathiTableAdapter.Fill(this.phanmemquanlylichthiDataSet9.cathi);

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
                    if(cathiDAO.Instance.themcathi(dateTimePicker1.Value,dateTimePicker2.Value,txtkip.Text))
                    {
                        MessageBox.Show("Thêm ca thi thành công");
                        loadcathi();
                    }else
                    {
                        MessageBox.Show("Thêm ca thi thất bại");
                    }
                }catch
                {
                    MessageBox.Show("Thêm ca thi thất bại");
                }
            }else if(sua==true)
            {
                try
                {
                    if (cathiDAO.Instance.suacathi(dateTimePicker1.Value, dateTimePicker2.Value, txtkip.Text,int.Parse(txtmacathi.Text)))
                    {
                        MessageBox.Show("Sửa ca thi thành công");
                        loadcathi();
                    }
                    else
                    {
                        MessageBox.Show("Sửa ca thi thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa ca thi thất bại");
                }
            }
            else if (xoa == true)
            {
                try
                {
                    if (cathiDAO.Instance.xoacathi(int.Parse(txtmacathi.Text)))
                    {
                        MessageBox.Show("xóa ca thi thành công");
                        loadcathi();
                    }
                    else
                    {
                        MessageBox.Show("xóa ca thi thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("xóa ca thi thất bại");
                }
            }
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
        void show(int id)
        {
            cathi ct=cathiDAO.Instance.loaddscathiBYID(id);
            txtmacathi.Text = ct.Macathi.ToString();
            txtkip.Text = ct.kip;
            dateTimePicker1.Value = (DateTime)ct.thoigianbatdau;
            dateTimePicker2.Value = (DateTime)ct.thoigianketthuc;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("Macathi")!=null)
            {
                try
                {
                    int id = int.Parse(gridView1.GetFocusedRowCellValue("Macathi").ToString());
                    show(id);
                }catch
                {

                }
            }
        }
    }
}