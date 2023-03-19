using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using phanmemquanlylichthi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using phanmemquanlylichthi.DTO.model;
using DevExpress.XtraGrid;

namespace phanmemquanlylichthi.FormQuanly
{
    public partial class frQUANLYPHONGTHI : DevExpress.XtraEditors.XtraForm
    {
        public frQUANLYPHONGTHI()
        {
            InitializeComponent();
            try
            {
                loaddsphongthi();
            }
            catch
            {

            }
            
           
        }
        modelDataContext db = new modelDataContext();
        private string idp;

       

        public string Idp1
        {
            get { return idp; }
            set { idp = value;lbmap.Text = value; } 
        }

        private void F2_updateEventHandler(object sender, frTHEMPHONGTHI.UpdateEventArgs args)
        {
            loaddsphongthi();
        }
        private void simpleButton11_Click(object sender, EventArgs e)
        {
            new frTHEMPHONGTHI().ShowDialog();
            loaddsphongthi();
         
        }
        void loadghengoi(string id)
        {
            panel1.Controls.Clear();
            phongthi pt = PhongthiDAO.Instance.showghe(id);
            if(pt != null)
            {
                khoitaosoghe(pt.tongsodayngang, pt.tongsoday,id);
              
                lbtongvitri.Text = pt.soluongghe.ToString();
            }else
            {
                MessageBox.Show("some thing went error");
            }
            
        }
        private void khoitaosoghe(int dong, int cot,string pt)
        {
            int x, y = 10, khoangcachx = 120, khoangcachy = 120, dem = 1,dem2=0;
            Button btnghe;
           
            for (int i = 0; i < dong; i++)
                {
                    x = 20;
                    for (int j = 0; j < cot; j++)
                    {
                        btnghe = new Button();
                        btnghe.Location = new Point(x, y);
                        btnghe.Size = new Size(100, 90);
                        btnghe.FlatAppearance.BorderColor = Color.Blue;
                        btnghe.FlatStyle = FlatStyle.Flat;


                    thisinh ts = thisinhDAO.Instance.loaddsthisinhbyphongthi(dem,pt);
                    string mathisinh = null;
                    string madethi=null;
                    if (ts!=null)
                    {
                        mathisinh = ts.Mathisinh;
                        madethi = ts.Masinhvien;
                    }
                    else
                    {
                        mathisinh = null;
                    }
             
                    btnghe.Text = "STT: " + dem.ToString() + "\n" +"Mã đề:" +madethi + "\n"+mathisinh;
                    dem++;
                    btnghe.BackColor = Color.White;
                        btnghe.Click += BtnGhe_Click;
                        panel1.Controls.Add(btnghe);

                        x += khoangcachx;
                    }

                    y += khoangcachy;
                }
          
         
        }
        void loaddsphongthi()
        {
            gridControl1.DataSource = PhongthiDAO.Instance.loadds();
            gridView1.OptionsBehavior.Editable = false;
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
           
        }

        void loadbutton()
        {
            Button btn;
            for(int i=0;i<=10;i++)
            {
                btn = new Button();
                btn.Size = new Size(50, 50);
                panelControl5.Controls.Add(btn);
            }
        }
        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
        void laysouong(string p)
        {
            phanchiade pc = thisinhDAO.Instance.laysoluong(p);
            lbsoluongthisinh.Text = pc.idphanchia.ToString();
        }
        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            
            if(gridView1.GetFocusedRowCellValue("phongthi1")!=null)
            {
                string id = gridView1.GetFocusedRowCellValue("phongthi1").ToString();
                Idp1 = id;
                phongthi pt = db.phongthis.Where(x=>x.phongthi1==id).Single();
                loadghengoi(id);
                laysouong(id);
                 txtghe.Text = pt.soluongghe.ToString();
                txtphong.Text = pt.Tenphongthi;
                txtday.Text=pt.tongsoday.ToString();
                txthang.Text = pt.tongsodayngang.ToString();
                //panelControl3.Visible = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FRXEMDS DS = new FRXEMDS(lbmap.Text);
            DS.Phong = lbmap.Text;
            DS.ShowDialog();
           
            loadghengoi(lbmap.Text);
         
            //if(panelControl3.Visible == false)
            //{
            //    panelControl3.Visible = true;
            //}else if(panelControl3.Visible == true)
            //{
            //    panelControl3.Visible = false;
            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedItem == "Chia đề thi chẳn lẻ")
            //{
            // try
            //    {
            //        if (dethiDAO.Instance.chiadethichanle(lbmap.Text))
            //        {
            //            MessageBox.Show("Thực hiện phân chia đề thi thành công");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Thực hiện phân chia đề thi thất bại");
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Thực hiện phân chia đề thi thành công");
            //    }
              
            //}
        }

        private void frQUANLYPHONGTHI_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            try
            {
                if (PhongthiDAO.Instance.suaphong(lbmap.Text, txtphong.Text))
                {
                    MessageBox.Show("sửa thành công");
                    loaddsphongthi();
                }
                else
                {
                    MessageBox.Show("sửa thất bại");

                }
            }catch
            { 
             
            }
          
        }
        void indd(GridControl gir)
        {
            if (!gir.IsPrintingAvailable)
            {
                MessageBox.Show("faild");
                return;
            }
            gir.ShowPrintPreview();
        }
        private void simpleButton17_Click(object sender, EventArgs e)
        {
            indd(gridControl1);
        }
    }
}