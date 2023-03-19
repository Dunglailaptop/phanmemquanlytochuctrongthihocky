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
    public partial class frEXCELLICHTHI : DevExpress.XtraEditors.XtraForm
    {
        public frEXCELLICHTHI()
        {
            InitializeComponent();
        }
        SpreadsheetControl sheet = new SpreadsheetControl();
        modelDataContext db = new modelDataContext();
        DataTableCollection DataTableCollection;
        private void frEXCELLICHTHI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet13.lichthi' table. You can move, or remove it, as needed.
            this.lichthiTableAdapter.Fill(this.phanmemquanlylichthiDataSet13.lichthi);

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

        private void cbsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                DataTable dt = DataTableCollection[cbsheet.SelectedItem.ToString()];
                //gridControl1.DataSource = dt;
                if (dt != null)
                {
                    List<lichthi> cb = new List<lichthi>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lichthi cb2 = new lichthi();
                        cb2.Mahp = dt.Rows[i]["Mahp"].ToString();
                        cb2.Malop = int.Parse(dt.Rows[i]["Malop"].ToString());
                        cb2.Mahocky = int.Parse(dt.Rows[i]["Mahocky"].ToString());
                        cb2.ghichu = dt.Rows[i]["ghichu"].ToString();
                        cb2.phongthi = dt.Rows[i]["phongthi"].ToString();
                        cb2.tuan= dt.Rows[i]["tuan"].ToString();
                        cb2.thu= dt.Rows[i]["thu"].ToString();
                        cb2.ngaythi= (DateTime)dt.Rows[i]["ngaythi"];
                     
                        cb2.kip= int.Parse(dt.Rows[i]["kip"].ToString());
                        cb2.sldk=int.Parse(dt.Rows[i]["sldk"].ToString());
                        cb.Add(cb2);
                    }
                   lichthiBindingSource.DataSource = cb;
                }
            //}
            //catch
            //{

            //}
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionSTR = ConfigurationSettings.AppSettings.Get("myConnectionString");
                DapperPlusManager.Entity<lichthi>().Table("lichthi");
                List<lichthi> cb = lichthiBindingSource.DataSource as List<lichthi>;
                if (cb != null)
                {
                    //using(IDbConnection dc=new SqlConnection(connectionSTR))
                    //  {
                    //    dc.BulkInsert(cb);
                    //  }
                    foreach (lichthi item in cb)
                    {

                        lichthiDAO.Instance.themlichthi(item);

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
    }
}