using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO.model;
using phanmemquanlylichthi.REPORT;
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
    public partial class frQUANLYHOCKY : DevExpress.XtraEditors.XtraForm
    {
        bool them ;
        bool sua;
        bool xoa;
        public frQUANLYHOCKY()
        {
            InitializeComponent();
            loadds();
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
        void loadds()
        {
            gridControl1.DataSource = hockyDAO.Instance.loaddshocky();
            gridView1.OptionsBehavior.Editable = false;
        }
        private void frQUANLYHOCKY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet15.hocky' table. You can move, or remove it, as needed.
            this.hockyTableAdapter.Fill(this.phanmemquanlylichthiDataSet15.hocky);
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet14.lichthi' table. You can move, or remove it, as needed.
            this.lichthiTableAdapter.Fill(this.phanmemquanlylichthiDataSet14.lichthi);

        }

        private void btnin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                RR_LICHTHI report = new RR_LICHTHI();
                ////ReportPrintTool printTool = new ReportPrintTool(report);
                ////printTool.ShowPreview();
                ///*  report.PrintDialog()*/

                report.DataSource = lichthiDAO.Instance.loaddulieubyhocky(int.Parse(txtHOCKY.Text));
                report.CreateDocument();
                report.ShowPreview();

            }
            catch
            {

            }
        }
        void getid(int id)
        {
            hocky hk = hockyDAO.Instance.loaddshockybyid(id);
            txtHOCKY.Text = hk.Mahocky.ToString();
            ngaybatdau.Value = (DateTime)hk.ngaybatdau;
            ngayketthuc.Value = (DateTime)hk.ngayketthuc;
            txttenhocky.Text=hk.tenhocky.ToString();
            txtsolgtuan.Text = hk.soluongtuan.ToString();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if(gridView1.GetFocusedRowCellValue("Mahocky")!=null)
            {
                try
                {
                    int id = int.Parse(gridView1.GetFocusedRowCellValue("Mahocky").ToString());
                    getid(id);
                }catch
                {

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
                    if (hockyDAO.Instance.themhocky(txttenhocky.Text,ngaybatdau.Value,ngayketthuc.Value,int.Parse(txtsolgtuan.Text)))
                    {
                        MessageBox.Show("Thêm  thành công");
                        loadds();
                    }
                    else
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
                    if(hockyDAO.Instance.suahocky(txttenhocky.Text, ngaybatdau.Value, ngayketthuc.Value, int.Parse(txtsolgtuan.Text),int.Parse(txtHOCKY.Text)))
                    {
                        MessageBox.Show("sửa  thành công");
                        loadds();
                    }
                    else
                    {
                        MessageBox.Show("sửa thất bại");
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
                    if (hockyDAO.Instance.xoahocky(int.Parse(txtHOCKY.Text)))
                    {
                        MessageBox.Show("Xóa  thành công");
                        loadds();

                    }
                    else
                    {
                        MessageBox.Show("Xóa  thất bại");
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