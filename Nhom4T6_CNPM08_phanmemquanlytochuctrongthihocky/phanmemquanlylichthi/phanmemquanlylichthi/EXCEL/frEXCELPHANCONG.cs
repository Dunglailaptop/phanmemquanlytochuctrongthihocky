using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet;
using ExcelDataReader;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace phanmemquanlylichthi.EXCEL
{
    public partial class frEXCELPHANCONG : DevExpress.XtraEditors.XtraForm
    {
        public frEXCELPHANCONG()
        {
            InitializeComponent();
        }
        SpreadsheetControl sheet = new SpreadsheetControl();
        modelDataContext db = new modelDataContext();
        DataTableCollection DataTableCollection;
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
                DapperPlusManager.Entity<canhthi>().Table("canhthi");
                List<canhthi> cb = canhthiBindingSource1.DataSource as List<canhthi>;
                if (cb != null)
                {
                    //using(IDbConnection dc=new SqlConnection(connectionSTR))
                    //  {
                    //    dc.BulkInsert(cb);
                    //  }
                    foreach (canhthi item in cb)
                    {

                       CanbocanhthiDAO.Instance.phacongcanhthi(item);

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
                    List<canhthi> cb = new List<canhthi>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        canhthi cb2 = new canhthi();
                        cb2.Macanbo = dt.Rows[i]["Macanbo"].ToString();
                        cb2.Malichthi =int.Parse(dt.Rows[i]["Malichthi"].ToString());
                        cb2.Malop =int.Parse(dt.Rows[i]["Malop"].ToString());
                        cb2.Mamonhoc = dt.Rows[i]["Mamonhoc"].ToString();
                        cb2.Maphongthi = dt.Rows[i]["Maphongthi"].ToString();
                 
                        cb.Add(cb2);
                    }
                    canhthiBindingSource1.DataSource = cb;
                }
            }
            catch
            {

            }
        }

        private void frEXCELPHANCONG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet12.canhthi' table. You can move, or remove it, as needed.
            this.canhthiTableAdapter1.Fill(this.phanmemquanlylichthiDataSet12.canhthi);
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet11.canhthi' table. You can move, or remove it, as needed.
            this.canhthiTableAdapter.Fill(this.phanmemquanlylichthiDataSet11.canhthi);

        }
    }
}