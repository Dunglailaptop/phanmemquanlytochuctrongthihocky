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

namespace phanmemquanlylichthi.formGiangvien
{
    public partial class frTHONGTINLICHTHI : DevExpress.XtraEditors.XtraForm
    {
        public frTHONGTINLICHTHI()
        {
            InitializeComponent();
        }
        
        private void gridControl1_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("Mahocky")!=null)
            {
                int id = int.Parse(gridView1.GetFocusedRowCellValue("Mahocky").ToString());
                gridControl2.DataSource = lichthiDAO.Instance.loaddulieubyhocky(id);
                gridView2.OptionsBehavior.Editable = false;
            }
        }

        private void frTHONGTINLICHTHI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet17.hocky' table. You can move, or remove it, as needed.
            this.hockyTableAdapter.Fill(this.phanmemquanlylichthiDataSet17.hocky);
            gridView1.OptionsBehavior.Editable = false;

        }
    }
}