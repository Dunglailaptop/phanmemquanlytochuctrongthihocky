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
using DevExpress.XtraGrid;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class FRXEMDS : DevExpress.XtraEditors.XtraForm
    {
        modelDataContext db = new modelDataContext();
       private string idmonhoc;
        private int idlop;
        private string phong;

        public string Phong { get => phong; set => phong = value; }

        public FRXEMDS(string p)
        {
            InitializeComponent();
            //loadcblop();
          
            load(p);
            loadcbmonhoc();
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = true;
            simpleButton3.Enabled = false;
        }

        private void FRXEMDS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet16.phanchiade' table. You can move, or remove it, as needed.
            this.phanchiadeTableAdapter.Fill(this.phanmemquanlylichthiDataSet16.phanchiade);

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        //void loadcblop()
        //{
        //    comboBox1.DataSource = db.lops.ToList();
        //    comboBox1.DisplayMember = "tenlop";
        //}
        void loaddethi(string monhoc)
        {
            gridControl1.DataSource = dethiDAO.Instance.loaddsdethibymonhoc(monhoc);
            gridView1.OptionsBehavior.Editable = false;
        }
        void loadcbmonhoc()
        {
            comboBox2.DataSource = db.monhocs.ToList();
            comboBox2.DisplayMember = "tenmonhoc";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //if (cb.SelectedItem == null)
            //    return;

            //lop selected = cb.SelectedItem as lop;
            //idlop = selected.Malop;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            monhoc selected = cb.SelectedItem as monhoc;
            idmonhoc = selected.MaMonHoc;
            loaddethi(idmonhoc);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        void load(string maphong)
        {
            gridControl2.DataSource = dethiDAO.Instance.chiade(maphong);
            gridView2.OptionsBehavior.Editable = false;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
            simpleButton3.Enabled = true;
            try
            {
                if (dethiDAO.Instance.chiadethichanle(Phong,idmonhoc))
                {
                    MessageBox.Show("Thực hiện phân chia đề thi thành công");
                    load(Phong);
                }
                else
                {
                    MessageBox.Show("Thực hiện phân chia đề thi thất bại");
                }
            }
            catch
            {

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            simpleButton3.Enabled = false;
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = true;
            if(dethiDAO.Instance.xoachiade(Phong))
            {
                MessageBox.Show("RESET THÀNH CÔNG");
                load(Phong);
            }
            else
            {
                MessageBox.Show("RESET THẤT BẠI");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
            simpleButton3.Enabled = true;
            try
            {
                if (dethiDAO.Instance.chiadethingaunhien(Phong, idmonhoc))
                {
                    MessageBox.Show("Thực hiện phân chia đề thi thành công");
                    load(Phong);
                }
                else
                {
                    MessageBox.Show("Thực hiện phân chia đề thi thất bại");
                }
            }
            catch
            {

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            simpleButton3.Enabled = false;
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = true;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

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
        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            indd(gridControl2);
        }
    }
}