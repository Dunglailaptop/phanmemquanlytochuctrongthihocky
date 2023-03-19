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

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class ribMenuQuanly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ribMenuQuanly()
        {
            InitializeComponent();
        //username = q;
            //MessageBox.Show(barStaticItem1.Caption);
        }
        private string username;

        public string Username {
            get {return username; }
            set { username = value; barStaticItem1.Caption = value; } 
        }
      void loaduser(string username)
        {
            
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
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYCANBO));
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYSINHVIEN));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            frDANGNHAPDESGIN dn = new frDANGNHAPDESGIN();
            dn.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYPHONGTHI));
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYTHISINH));
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(FRQUANLYLICHTHI));
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYPHANCONGTHI));
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYGIANGVIEN));
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYMONHOC));
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYLOP));
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYCATHI));
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYDETHI));
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYHOCKY));
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frQUANLYKINHPHI1));
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frTHONGKE));
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frTHONGKETHEOGIANGVIEN));
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frthongketheocanbocanhthi));
        }

        private void ribMenuQuanly_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frquanlytaikhoan));
        }

        private void bsnameuser_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frDANGKYCANBOCANHTHI));
        }
    }
}