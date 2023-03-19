using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
using phanmemquanlylichthi.DTO.model;
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
    public partial class frTHEMPHONGTHI : DevExpress.XtraEditors.XtraForm
    {
        public frTHEMPHONGTHI()
        {
            InitializeComponent();
        }
        public delegate void updatedelegate(object sender, UpdateEventArgs args);
        public event updatedelegate updateventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }
        void themphongthi(string tenphong,int soluong,int tongsoday,int tongsodayngang)
        {
            

        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                phongthi ph=PhongthiDAO.Instance.themphong(txttenphong.Text, int.Parse(txtsoluongghe.Text), int.Parse(txttongsoday.Text), int.Parse(txttongsodayngang.Text));
             
                MessageBox.Show("them phong thanh cong");
                this.Dispose();
                try
                {
                    for (int i = 1; i <= int.Parse(txtsoluongghe.Text); i++)
                    {
                        if (ghengoiDAO.Instance.insertghengoi(ph.phongthi1, i))
                        {

                        }

                    }
                    MessageBox.Show("thêm ghế ngồi thành công");
                }
                catch
                {
                    MessageBox.Show("thêm ghế ngồi thất bại");
                }
             
               
            }
            catch
            {
                MessageBox.Show("thêm phòng thất bại");
            }
        }

        private void frTHEMPHONGTHI_Load(object sender, EventArgs e)
        {

        }
    }
}