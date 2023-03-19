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

namespace phanmemquanlylichthi.matkhaucaplai
{
    public partial class frQUENMATKHAUQT2 : DevExpress.XtraEditors.XtraForm
    {
        modelDataContext db = new modelDataContext();
        public frQUENMATKHAUQT2()
        {
            InitializeComponent();
        }
        private string user;

        public string User { get => user; set => user = value; }

        private void frQUENMATKHAUQT2_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            quenmatkhau qmk = db.quenmatkhaus.Where(x => x.macaplai == textEdit2.Text).Single();
           //inn
            if (qmk != null)
            {
                this.Dispose();
                SUAMK SMK = new SUAMK();
                SMK.TEN11 = user;
                SMK.ShowDialog();
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}