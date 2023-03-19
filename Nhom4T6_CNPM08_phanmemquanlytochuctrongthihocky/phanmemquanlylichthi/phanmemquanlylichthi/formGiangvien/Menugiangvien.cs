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

namespace phanmemquanlylichthi.formGiangvien
{
    public partial class Menugiangvien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menugiangvien()
        {
            InitializeComponent();
        }
        private string username;

        public string Username {
            get {return username; } 
            set { username = value; barStaticItem1.Caption = value;}
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
            f.Show();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frTHONGTINLICHTHI));
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(frTHONGTINTHISINH));
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(FRTHONGTINSINHVIENTHEOLOP));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            frDANGNHAPDESGIN desgin = new frDANGNHAPDESGIN();
            desgin.Show();
        }

        private void Menugiangvien_Load(object sender, EventArgs e)
        {

        }
    }
}