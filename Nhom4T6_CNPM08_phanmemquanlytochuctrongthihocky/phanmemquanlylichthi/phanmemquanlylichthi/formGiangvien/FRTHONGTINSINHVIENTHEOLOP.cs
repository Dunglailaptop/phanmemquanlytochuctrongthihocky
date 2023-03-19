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

namespace phanmemquanlylichthi.formGiangvien
{
    public partial class FRTHONGTINSINHVIENTHEOLOP : DevExpress.XtraEditors.XtraForm
    {
        modelDataContext db = new modelDataContext();
        public FRTHONGTINSINHVIENTHEOLOP()
        {
            InitializeComponent();
        }

        private void FRTHONGTINSINHVIENTHEOLOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet20.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter1.Fill(this.phanmemquanlylichthiDataSet20.lop);
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet19.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.phanmemquanlylichthiDataSet19.lop);
            gridView2.OptionsBehavior.Editable = false;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            if(gridView2.GetFocusedRowCellValue("Malop")!=null)
            {
                int lop = int.Parse(gridView2.GetFocusedRowCellValue("Malop").ToString());
                gridControl1.DataSource = SinhvienDAO.Instance.loaddssinhvienbylop(lop);
                gridView1.OptionsBehavior.Editable = false;
            }
        }
    }
}