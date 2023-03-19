using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO;
using phanmemquanlylichthi.DTO.model;
using phanmemquanlylichthi.EXCEL;
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
using ComboBox = System.Windows.Forms.ComboBox;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class FRQUANLYLICHTHI : DevExpress.XtraEditors.XtraForm
    {
        bool them = false;
        bool sua = false;
        bool xoa = false;
        string idmon,idp;
        int idlop,idhocky;
        int idcathi;

        modelDataContext db = new modelDataContext();
        public FRQUANLYLICHTHI()
        {
            InitializeComponent();
            loadddslicthi();
            loadcathi();
            loadhocphan();
            loadphongthi();
            loadhocphan();
            hocky();
            lop();
            check(true);
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
        void loadddslicthi()
        {
            gridControl1.DataSource = lichthiDAO.Instance.loaddulieu();
            gridView1.OptionsBehavior.Editable = false;
        }
        void loadcathi()
        {
            cbkip.DataSource = db.cathis.ToList();
            cbkip.DisplayMember = "kip";
        }
        void loadphongthi()
        {
            cbphongthi.DataSource = db.phongthis.ToList();
            cbphongthi.DisplayMember = "Tenphongthi";
        }
        void loadhocphan()
        {
            cbhocphan.DataSource=db.monhocs.ToList();
            cbhocphan.DisplayMember = "tenmonhoc";
        }
        void hocky()
        {
            cbhocky.DataSource = db.hockies.ToList();
            MessageBox.Show(db.hockies.ToList().ToString());
            cbhocky.DisplayMember = "tenhocky";
        }
        void lop()
        {
            cblop.DataSource = db.lops.ToList();
            cblop.DisplayMember = "tenlop";
        }
        private void FRQUANLYLICHTHI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet4.lichthi' table. You can move, or remove it, as needed.
            this.lichthiTableAdapter1.Fill(this.phanmemquanlylichthiDataSet4.lichthi);
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet3.lichthi' table. You can move, or remove it, as needed.
            this.lichthiTableAdapter.Fill(this.phanmemquanlylichthiDataSet3.lichthi);

        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1.Enabled = true;
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
                    if (lichthiDAO.Instance.themlichthi(idmon,rtghichu.Text,txttuan.Text,cbthu.Text,ngaythi.Value,int.Parse(txtsldk.Text),idhocky,idlop,idcathi,idp))
                    {
                        MessageBox.Show("Thêm thành công");
                    }else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                   
                    loadddslicthi();
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else if (sua == true)
            {
                //try
                //{
                  if(lichthiDAO.Instance.sualichthi(idmon, rtghichu.Text, txttuan.Text, cbthu.Text, ngaythi.Value, int.Parse(txtsldk.Text), idhocky, idlop, idcathi, idp,int.Parse(txtMalichthi.Text)))
                    {
                        MessageBox.Show("sửa thành công");
                    }else
                    {
                        MessageBox.Show("sửa thất bại");
                    }
                    loadddslicthi();
                //}
                //catch
                //{
                  //  MessageBox.Show("sửa thất bại");
                //}
            }
            else if (xoa == true)
            {
                try
                {
                  if(lichthiDAO.Instance.xoalichthi(int.Parse(txtMalichthi.Text)))
                    {
                        MessageBox.Show("xóa thành công");
                    }
                    loadddslicthi();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            cathi selected = cb.SelectedItem as cathi;
            idcathi = selected.Macathi;
        }
        void ktkhoalichthi()
        {
            
        }
        void selectbyid(int id)
        {
            innerjoin nj = lichthiDAO.Instance.loaddulieubyid(id);
            MessageBox.Show(nj.trangthai.ToString());
            if (nj.trangthai==0)
            {
              
                splitContainer1.Panel1.Enabled = false;
            }else
            {
                splitContainer1.Panel1.Enabled = true;
                txtMalichthi.Text = nj.malichthi.ToString();
                cbhocphan.Text = nj.hoten;
                txttuan.Text = nj.tuan;
                cbthu.Text = nj.thu;
                cbkip.Text = nj.kip;
                cbphongthi.Text = nj.tenphong;
                cblop.Text = nj.tenlop;
                cbhocky.Text = nj.tenhocky;
                rtghichu.Text = nj.ghichu;
                ngaythi.Value = nj.ngaythi;
                txtsldk.Text = nj.sldk.ToString();
            }
         

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            check(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            if (gridView1.GetFocusedRowCellValue("malichthi")!=null)
            {
                try
                {
                    int id = int.Parse(gridView1.GetFocusedRowCellValue("malichthi").ToString());
                    selectbyid(id);
                }catch
                {

                }
            }
        }

        private void cbhocphan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            monhoc selected = cb.SelectedItem as monhoc;
            idmon = selected.MaMonHoc;
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            lop selected = cb.SelectedItem as lop;
            idlop = selected.Malop;
        }

        private void txttuan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbthu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frEXCELLICHTHI fr = new frEXCELLICHTHI();
            fr.ShowDialog();
            loadddslicthi();
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
        private void btnin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //RR_LICHTHI report = new RR_LICHTHI();
            ////ReportPrintTool printTool = new ReportPrintTool(report);
            ////printTool.ShowPreview();
            ///*  report.PrintDialog()*/

            //report.DataSource = lichthiDAO.Instance.loaddulieu();
            //report.CreateDocument();
            //report.ShowPreview();
            indd(gridControl1);
        }

        private void cbphongthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

           phongthi selected = cb.SelectedItem as phongthi;
            idp = selected.phongthi1;
        }

        private void cbhocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            hocky selected = cb.SelectedItem as hocky;
            idhocky = selected.Mahocky;
        }
    }
}