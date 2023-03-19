using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System.Security.Cryptography.X509Certificates;
using phanmemquanlylichthi.DTO.model;
using System.Threading;
using phanmemquanlylichthi.DTO;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frDANGKYCANBOCANHTHI : DevExpress.XtraEditors.XtraForm
    {
        public frDANGKYCANBOCANHTHI()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Scopes = { SheetsService.Scope.Spreadsheets };
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets { ClientId = "1074439552328-ek68luc1ri3cn9e0gj7kd062m48ta433.apps.googleusercontent.com", ClientSecret = "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" }, Scopes, "0850080012@sv.hcmunre.edu.vn", CancellationToken.None, new FileDataStore("client_secret_1074439552328-qnhnsgb37iqtfrqjhvv3rqgn3d7cbqmv.apps.googleusercontent.com.json")).Result,
                    ApplicationName = "getformgoogle",
                });
                var values = service.Spreadsheets.Values.Get("1AIjiYnar4AzFd_484BbTH3J4CfEOOePsy58S3J0QRjY", $"Câu trả lời biểu mẫu 2!A2:F100").Execute().Values;
                int ii = 0;
                string inn = null;
                //values =new IList<IList<object>>;
                List<innerjoin> gvv = new List<innerjoin>();
                if(values != null)
                {
                    foreach (var value in values)
                    {
                        innerjoin gv = new innerjoin();
                        gv.hoten = value[1].ToString();
                        gv.sdt = value[2].ToString();
                        gv.email = value[3].ToString();
                        gv.tenphong = value[4].ToString();
                        gv.bomon = value[5].ToString();

                        //MessageBox.Show(value[0].ToString() + value[1].ToString() + value[2].ToString());
                        //gv.giangv = value[1].ToString();
                        //gv.sinhvien = value[2].ToString();
                        gvv.Add(gv);
                        //MessageBox.Show(value[1].ToString());
                        //MessageBox.Show(value[2].ToString());
                    }
                    gridControl2.DataSource = gvv;
                }else
                {
                    MessageBox.Show("not data found");
                }
              
            }
            catch
            {

            }
         
        }
    }
}