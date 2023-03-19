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

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class FileExcel : DevExpress.XtraEditors.XtraForm
    {
        public FileExcel()
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
                DapperPlusManager.Entity<canbocanhthi>().Table("canbocanhthi");
                List<canbocanhthi> cb = canbocanhthiBindingSource3.DataSource as List<canbocanhthi>;
                if(cb != null)
                {
                //using(IDbConnection dc=new SqlConnection(connectionSTR))
                //  {
                //    dc.BulkInsert(cb);
                //  }
                foreach(canbocanhthi item in cb)
                {
                    CanbocanhthiDAO.Instance.themcanboex(item);
                
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
            DataTable dt = DataTableCollection[cbsheet.SelectedItem.ToString()];
            //gridControl1.DataSource = dt;
            if (dt != null)
            {
                List<canbocanhthi> cb = new List<canbocanhthi>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    canbocanhthi cb2 = new canbocanhthi();
                    cb2.hoten = dt.Rows[i]["hoten"].ToString();
                    cb2.email = dt.Rows[i]["email"].ToString();
                    cb2.sdt = dt.Rows[i]["sdt"].ToString();
                    cb2.bomon = dt.Rows[i]["bomon"].ToString();
                    cb2.Maphonglamviec = int.Parse(dt.Rows[i]["Maphonglamviec"].ToString());
                    cb2.Maquyen = int.Parse(dt.Rows[i]["Maquyen"].ToString());
                    
                    cb.Add(cb2);
                }
                canbocanhthiBindingSource3.DataSource = cb;
            }
        }

        private void FileExcel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanmemquanlylichthiDataSet.canbocanhthi' table. You can move, or remove it, as needed.
            this.canbocanhthiTableAdapter.Fill(this.phanmemquanlylichthiDataSet.canbocanhthi);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtfilename_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}