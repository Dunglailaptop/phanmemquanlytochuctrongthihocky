﻿using DevExpress.XtraCharts;
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
    public partial class frthongketheocanbocanhthi : DevExpress.XtraEditors.XtraForm
    {
        public frthongketheocanbocanhthi()
        {
            InitializeComponent();
            loachart();
            load();
        }
        void loachart()
        {
            chartControl1.Series.Clear();
            Series _SE = new Series("Tên cán bộ", ViewType.Line);
            //Series _SE2 = new Series("Tổng thu", ViewType.Bar);
            //_SE.Points.Clear();
            List<innerjoin> nk = KinhphiDAO.Instance.thongketheocanbocanhthiloaddskinhphi();
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
        void load()
        {
            gridControl1.DataSource = KinhphiDAO.Instance.thongketheocanbocanhthiloaddskinhphi();
            gridView1.OptionsBehavior.Editable = false;
        }
        private void frthongketheocanbocanhthi_Load(object sender, EventArgs e)
        {

        }
    }
}