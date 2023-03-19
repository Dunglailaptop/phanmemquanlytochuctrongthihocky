using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet;
using ExcelDataReader;
using phanmemquanlylichthi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader.Core;
using phanmemquanlylichthi.DTO.model;
using System.Configuration;
using Z.Dapper.Plus;
using System.Data.SqlClient;
using DevExpress.XtraPrinting.BarCode;
using QRCoder;
using QRCodeGenerator = QRCoder.QRCodeGenerator;

namespace phanmemquanlylichthi.EXCEL
{
    public partial class FRNHAPEXCELTHISINH : DevExpress.XtraEditors.XtraForm
    {
        byte[] hinhanh;
        public FRNHAPEXCELTHISINH()
        {
            InitializeComponent();
        }
        SpreadsheetControl sheet = new SpreadsheetControl();
        modelDataContext db = new modelDataContext();
        DataTableCollection DataTableCollection;
        public delegate void updatedelegate(object sender, UpdateEventArgs args);
        public event updatedelegate updateventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }
        private void FRNHAPEXCELTHISINH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet1.thisinh' table. You can move, or remove it, as needed.
            this.thisinhTableAdapter.Fill(this.phanmemquanlylichthiDataSet1.thisinh);

        }
        void getQRcoder(thisinh th)
        {
            hinhanh = null;
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(th.Masinhvien, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
           

            th.ORCODE = (byte[])new ImageConverter().ConvertTo(code.GetGraphic(5), typeof(byte[]));
            thisinhDAO.Instance.themthisinh(th);


        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtfilename.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                DataTableCollection = result.Tables;
                                cbsheet.Items.Clear();
                                foreach (DataTable row in DataTableCollection)
                                    cbsheet.Items.Add(row.TableName);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionSTR = ConfigurationSettings.AppSettings.Get("myConnectionString");
                DapperPlusManager.Entity<thisinh>().Table("thisinh");
                List<thisinh> cb = thisinhBindingSource.DataSource as List<thisinh>;
                if (cb != null)
                {
                    //using(IDbConnection dc=new SqlConnection(connectionSTR))
                    //  {
                    //    dc.BulkInsert(cb);
                    //  }
                    foreach (thisinh item in cb)
                    {
                        getQRcoder(item);
                       

                    }
                    MessageBox.Show("Thêm thành công file excel");
                }

            }
            catch
            {
                MessageBox.Show("Thêm thất bại file excel");
            }
        }

        private void cbsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DataTableCollection[cbsheet.SelectedItem.ToString()];
                //gridControl1.DataSource = dt;
                if (dt != null)
                {
                    List<thisinh> cb = new List<thisinh>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        thisinh cb2 = new thisinh();
                        cb2.Masinhvien = dt.Rows[i]["Masinhvien"].ToString();
                        cb2.Maphongthi = dt.Rows[i]["Maphongthi"].ToString();
                        cb2.soghe = int.Parse(dt.Rows[i]["soghe"].ToString());


                        cb.Add(cb2);
                    }
                    thisinhBindingSource.DataSource = cb;
                }
            }
            catch
            {

            }
          
        }

        private void txtfilename_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}