using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO;
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
    public partial class frTHONGKETHEOGIANGVIEN : DevExpress.XtraEditors.XtraForm
    {
        public frTHONGKETHEOGIANGVIEN()
        {
            InitializeComponent();
            chart();
            load();
        }
        void load()
        {
            gridControl1.DataSource = KinhphiDAO.Instance.thongketheogiangvienloaddskinhphi();
            gridView1.OptionsBehavior.Editable = false;
        }
        void chart()
        {
            chartControl1.Series.Clear();
            Series _SE = new Series("Tên giảng viên", ViewType.Pie);
            //Series _SE2 = new Series("Tổng thu", ViewType.Bar);
            //_SE.Points.Clear();
            List<innerjoin> nk = KinhphiDAO.Instance.thongketheogiangvienloaddskinhphi();
            //List<Class> pv1 = phieuthuDAO.Instance.phieuthubymonth(date1, date2);
            foreach (innerjoin p in nk)
            {
                _SE.Points.Add(new SeriesPoint(p.tenlop.ToString(), p.tongkinhphi));
                //foreach (Class p2 in pv1)
                //{
                //    _SE2.Points.Add(new SeriesPoint("tháng" + p2.Thoigian_name, p2.sotien));
                //}

            }
            chartControl1.Series.Add(_SE);
            //chartControl3.Series.Add(_SE2);
            _SE.Label.TextPattern = "{A}: {VP: p0}";
        }
        private void frTHONGKETHEOGIANGVIEN_Load(object sender, EventArgs e)
        {

        }
    }
}