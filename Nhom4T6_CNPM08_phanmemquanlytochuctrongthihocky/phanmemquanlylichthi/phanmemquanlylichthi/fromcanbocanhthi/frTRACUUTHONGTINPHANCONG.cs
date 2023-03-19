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

namespace phanmemquanlylichthi.fromcanbocanhthi
{
    public partial class frTRACUUTHONGTINPHANCONG : DevExpress.XtraEditors.XtraForm
    {
        private string user;
        public frTRACUUTHONGTINPHANCONG()
        {
          
            InitializeComponent();
            ribMENUCANBO cb = new ribMENUCANBO();
            user = cb.Username;
            MessageBox.Show(User);
        }

        public string User { get => user; set => user = value; }

        private void frTRACUUTHONGTINPHANCONG_Load(object sender, EventArgs e)
        {

        }
    }
}