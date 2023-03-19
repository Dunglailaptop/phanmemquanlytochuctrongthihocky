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

namespace phanmemquanlylichthi.formGiangvien
{
    public partial class frTHONGTINTHISINH : DevExpress.XtraEditors.XtraForm
    {
        public frTHONGTINTHISINH()
        {
            InitializeComponent();
        }

        private void frTHONGTINTHISINH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet18.thisinh' table. You can move, or remove it, as needed.
            this.thisinhTableAdapter.Fill(this.phanmemquanlylichthiDataSet18.thisinh);

        }
    }
}