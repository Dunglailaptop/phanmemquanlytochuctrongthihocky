using DevExpress.XtraBars;
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
    public partial class ribMENUCANBO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ribMENUCANBO()
        {
            InitializeComponent();
        }
        void openchild(Type typeForm)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.GetType() == typeForm)
                {
                    form.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            //this.Dispose();
            f.Show();
        }
        private string username;

        public string Username 
        {
            get { return username; }
            set { username = value;barStaticItem1.Caption = value; }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frTRACUUTHONGTINPHANCONG));
            frTRACUUTHONGTINPHANCONG pc = new frTRACUUTHONGTINPHANCONG();
            pc.User=username;
        }

        private void ribMENUCANBO_Load(object sender, EventArgs e)
        {

        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}