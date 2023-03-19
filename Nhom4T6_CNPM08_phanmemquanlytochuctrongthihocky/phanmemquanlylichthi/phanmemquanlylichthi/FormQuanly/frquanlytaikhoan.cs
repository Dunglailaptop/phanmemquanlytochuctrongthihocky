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
    public partial class frquanlytaikhoan : DevExpress.XtraEditors.XtraForm
    {
        modelDataContext db = new modelDataContext();
        string idgv,idcb;
        int idq,idqcb;
        string canbo;
        public frquanlytaikhoan()
        {
            InitializeComponent();
            giangvien();
            laydsgiangvien();
            laydscanbo();
            quyen();
            dscanbo();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (idgv!=null)
                {
                  
                    if (AccountDAO.Instance.themtaikhoan(txtusername.Text, txtpass.Text, idq, idgv))
                    {
                        MessageBox.Show("Them thanh cong");
                    laydsgiangvien();
                    }
                    else
                    {
                        MessageBox.Show("Them that bai");
                    }
                }

            //}
            //catch
            //{

            //}
        }
        void giangvien()
        {
            cbmagv.DataSource = db.giangviens.ToList();
            cbmagv.DisplayMember = "hoten";
        }
      
        void dscanbo()
        {
            cbcanbo.DataSource = db.canbocanhthis.ToList();
            cbcanbo.DisplayMember = "hoten";
        }
        void quyen()
        {
            cbquyen.DataSource = db.phanquyens.ToList();
            cbquyen.DisplayMember = "tenquyen";
            cbphanquyen.DataSource = db.phanquyens.ToList();
            cbphanquyen.DisplayMember = "tenquyen";
        }
        private void cbmagv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            giangvien selected = cb.SelectedItem as giangvien;
            idgv = selected.Magiangvien;
        }
        void laydsgiangvien()
        {
            gridControl1.DataSource = AccountDAO.Instance.laydstaikhoan();
            gridView1.OptionsBehavior.Editable = false;
        }
        void laydscanbo()
        {
            gridControl2.DataSource = AccountDAO.Instance.laydstaikhoancb();
            gridView2.OptionsBehavior.Editable = false;
        }
        private void cbquyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

          phanquyen selected = cb.SelectedItem as phanquyen;
            idq = selected.Maquyen;
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
         //try
         //   {
                if (idcb != null)
                {
                    idgv = "0";
                    if (AccountDAO.Instance.themtaikhoancb(txtusernamecb.Text, txtpasscb.Text, idqcb, idcb))
                    {
                        MessageBox.Show("Them thanh cong");
                        laydscanbo();
                    }
                    else
                    {
                        MessageBox.Show("Them that bai");
                    }
                }
            //}catch
            //{

            //}
      
        }

        private void cbcanbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            canbocanhthi selected = cb.SelectedItem as canbocanhthi;
            idcb = selected.MaCanbo;
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

            if (idcb != null && txtusernamecb.Text!=null)
            {
                if (AccountDAO.Instance.xoataikhoangv(txtusernamecb.Text, txtusernamecb.Tag.ToString()))
                {
                    MessageBox.Show("xóa thành công");
                }
                else
                {
                    MessageBox.Show("xóa thất bại");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (idgv != null && txtusername.Text!=null)
            {
                if (AccountDAO.Instance.xoataikhoangv(txtusername.Text, txtusername.Tag.ToString()))
                {
                    MessageBox.Show("xóa thành công");
                }
                else
                {
                    MessageBox.Show("xóa thất bại");
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("magv")!=null)
            {
                string id = gridView1.GetFocusedRowCellValue("magv").ToString();
                innerjoin nj = AccountDAO.Instance.laydstaikhoanbyid(id);
                txtusername.Text = nj.username;
                txtusername.Tag = nj.magv;
                txtpass.Text = nj.password;
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("magv") != null)
            {
                string id = gridView1.GetFocusedRowCellValue("magv").ToString();
                innerjoin nj = AccountDAO.Instance.laydstaikhoanbyid(id);
                txtusernamecb.Text = nj.username;
                txtusernamecb.Tag = nj.magv;
                txtpasscb.Text = nj.password;
            }
        }

        private void frquanlytaikhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet21.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.phanmemquanlylichthiDataSet21.account);

        }

        private void cbphanquyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            phanquyen selected = cb.SelectedItem as phanquyen;
            idqcb = selected.Maquyen;
        }
    }
}