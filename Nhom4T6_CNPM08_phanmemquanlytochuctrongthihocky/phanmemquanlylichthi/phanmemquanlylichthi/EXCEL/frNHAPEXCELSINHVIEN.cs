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

namespace phanmemquanlylichthi.EXCEL
{
    public partial class frNHAPEXCELSINHVIEN : DevExpress.XtraEditors.XtraForm
    {
        public frNHAPEXCELSINHVIEN()
        {
            InitializeComponent();
        }
        SpreadsheetControl sheet = new SpreadsheetControl();
        modelDataContext db = new modelDataContext();
        DataTableCollection DataTableCollection;
        private void frNHAPEXCELSINHVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet2.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.phanmemquanlylichthiDataSet2.sinhvien);

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
                DapperPlusManager.Entity<sinhvien>().Table("thisinh");
                List<sinhvien> cb =sinhvienBindingSource.DataSource as List<sinhvien>;
                if (cb != null)
                {
                    //using(IDbConnection dc=new SqlConnection(connectionSTR))
                    //  {
                    //    dc.BulkInsert(cb);
                    //  }
                    foreach (sinhvien item in cb)
                    {

                        SinhvienDAO.Instance.thhemsinhvien(item);

                    }
                    MessageBox.Show("Thêm thành công file excel");
                    this.Dispose();
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
                    List<sinhvien> cb = new List<sinhvien>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sinhvien cb2 = new sinhvien();
                        cb2.hoten = dt.Rows[i]["hoten"].ToString();
                        cb2.sdt = dt.Rows[i]["sdt"].ToString();
                        cb2.quequan = dt.Rows[i]["quequan"].ToString();
                        cb2.ngaysinh = (DateTime)dt.Rows[i]["ngaysinh"];
                        cb2.diachi = dt.Rows[i]["diachi"].ToString();
                        cb2.Makhoa = int.Parse(dt.Rows[i]["Makhoa"].ToString());
                        cb2.MaCN = int.Parse(dt.Rows[i]["MaCN"].ToString());
                        cb2.malop = int.Parse(dt.Rows[i]["malop"].ToString());
                        cb.Add(cb2);
                    }
                    sinhvienBindingSource.DataSource = cb;
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