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

namespace phanmemquanlylichthi.matkhaucaplai
{
    public partial class SUAMK : DevExpress.XtraEditors.XtraForm
    {
        public SUAMK()
        {
            InitializeComponent();
        }
        private string TEN1;

        public string TEN11
        {
            get { return TEN1; }
            set { TEN1 = value;textEdit1.Text = value; } 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != null)
            {
                if (AccountDAO.Instance.suamk(TEN1, textEdit2.Text))
                {
                    MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                }
            }
        }
    }
}