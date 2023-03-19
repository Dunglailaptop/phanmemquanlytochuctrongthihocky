namespace phanmemquanlylichthi.formGiangvien
{
    partial class frTHONGTINLICHTHI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hockyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSet17 = new phanmemquanlylichthi.phanmemquanlylichthiDataSet17();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMahocky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhocky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaybatdau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayketthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluongtuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hockyTableAdapter = new phanmemquanlylichthi.phanmemquanlylichthiDataSet17TableAdapters.hockyTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmalichthi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMahp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaythi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsldk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphongthi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hockyBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(682, 757);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // hockyBindingSource
            // 
            this.hockyBindingSource.DataMember = "hocky";
            this.hockyBindingSource.DataSource = this.phanmemquanlylichthiDataSet17;
            // 
            // phanmemquanlylichthiDataSet17
            // 
            this.phanmemquanlylichthiDataSet17.DataSetName = "phanmemquanlylichthiDataSet17";
            this.phanmemquanlylichthiDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMahocky,
            this.coltenhocky,
            this.colngaybatdau,
            this.colngayketthuc,
            this.colsoluongtuan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colMahocky
            // 
            this.colMahocky.FieldName = "Mahocky";
            this.colMahocky.MinWidth = 25;
            this.colMahocky.Name = "colMahocky";
            this.colMahocky.Visible = true;
            this.colMahocky.VisibleIndex = 0;
            this.colMahocky.Width = 94;
            // 
            // coltenhocky
            // 
            this.coltenhocky.FieldName = "tenhocky";
            this.coltenhocky.MinWidth = 25;
            this.coltenhocky.Name = "coltenhocky";
            this.coltenhocky.Visible = true;
            this.coltenhocky.VisibleIndex = 1;
            this.coltenhocky.Width = 94;
            // 
            // colngaybatdau
            // 
            this.colngaybatdau.FieldName = "ngaybatdau";
            this.colngaybatdau.MinWidth = 25;
            this.colngaybatdau.Name = "colngaybatdau";
            this.colngaybatdau.Visible = true;
            this.colngaybatdau.VisibleIndex = 2;
            this.colngaybatdau.Width = 94;
            // 
            // colngayketthuc
            // 
            this.colngayketthuc.FieldName = "ngayketthuc";
            this.colngayketthuc.MinWidth = 25;
            this.colngayketthuc.Name = "colngayketthuc";
            this.colngayketthuc.Visible = true;
            this.colngayketthuc.VisibleIndex = 3;
            this.colngayketthuc.Width = 94;
            // 
            // colsoluongtuan
            // 
            this.colsoluongtuan.FieldName = "soluongtuan";
            this.colsoluongtuan.MinWidth = 25;
            this.colsoluongtuan.Name = "colsoluongtuan";
            this.colsoluongtuan.Visible = true;
            this.colsoluongtuan.VisibleIndex = 4;
            this.colsoluongtuan.Width = 94;
            // 
            // hockyTableAdapter
            // 
            this.hockyTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Location = new System.Drawing.Point(682, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(687, 757);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmalichthi,
            this.colMahp,
            this.colghichu,
            this.coltuan,
            this.colthu,
            this.colngaythi,
            this.colsldk,
            this.gridColumn1,
            this.colMalop,
            this.colkip,
            this.colphongthi});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            // 
            // colmalichthi
            // 
            this.colmalichthi.Caption = "Mã lịch thi";
            this.colmalichthi.FieldName = "malichthi";
            this.colmalichthi.MinWidth = 25;
            this.colmalichthi.Name = "colmalichthi";
            this.colmalichthi.Visible = true;
            this.colmalichthi.VisibleIndex = 0;
            this.colmalichthi.Width = 94;
            // 
            // colMahp
            // 
            this.colMahp.Caption = "Mã học phần";
            this.colMahp.FieldName = "mamonhoc";
            this.colMahp.MinWidth = 25;
            this.colMahp.Name = "colMahp";
            this.colMahp.Visible = true;
            this.colMahp.VisibleIndex = 1;
            this.colMahp.Width = 94;
            // 
            // colghichu
            // 
            this.colghichu.Caption = "Ghi chú";
            this.colghichu.FieldName = "ghichu";
            this.colghichu.MinWidth = 25;
            this.colghichu.Name = "colghichu";
            this.colghichu.Visible = true;
            this.colghichu.VisibleIndex = 2;
            this.colghichu.Width = 94;
            // 
            // coltuan
            // 
            this.coltuan.Caption = "Tuần";
            this.coltuan.FieldName = "tuan";
            this.coltuan.MinWidth = 25;
            this.coltuan.Name = "coltuan";
            this.coltuan.Visible = true;
            this.coltuan.VisibleIndex = 3;
            this.coltuan.Width = 94;
            // 
            // colthu
            // 
            this.colthu.Caption = "Thứ";
            this.colthu.FieldName = "thu";
            this.colthu.MinWidth = 25;
            this.colthu.Name = "colthu";
            this.colthu.Visible = true;
            this.colthu.VisibleIndex = 4;
            this.colthu.Width = 94;
            // 
            // colngaythi
            // 
            this.colngaythi.Caption = "Ngày thi";
            this.colngaythi.FieldName = "ngaythi";
            this.colngaythi.MinWidth = 25;
            this.colngaythi.Name = "colngaythi";
            this.colngaythi.Visible = true;
            this.colngaythi.VisibleIndex = 5;
            this.colngaythi.Width = 94;
            // 
            // colsldk
            // 
            this.colsldk.Caption = "SLDK";
            this.colsldk.FieldName = "sldk";
            this.colsldk.MinWidth = 25;
            this.colsldk.Name = "colsldk";
            this.colsldk.Visible = true;
            this.colsldk.VisibleIndex = 6;
            this.colsldk.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Học kỳ";
            this.gridColumn1.FieldName = "Mahocky";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 94;
            // 
            // colMalop
            // 
            this.colMalop.Caption = "Lớp";
            this.colMalop.FieldName = "tenlop";
            this.colMalop.MinWidth = 25;
            this.colMalop.Name = "colMalop";
            this.colMalop.Visible = true;
            this.colMalop.VisibleIndex = 8;
            this.colMalop.Width = 94;
            // 
            // colkip
            // 
            this.colkip.Caption = "Kip";
            this.colkip.FieldName = "kip";
            this.colkip.MinWidth = 25;
            this.colkip.Name = "colkip";
            this.colkip.Visible = true;
            this.colkip.VisibleIndex = 9;
            this.colkip.Width = 94;
            // 
            // colphongthi
            // 
            this.colphongthi.Caption = "Phỏng thi";
            this.colphongthi.FieldName = "tenphong";
            this.colphongthi.MinWidth = 25;
            this.colphongthi.Name = "colphongthi";
            this.colphongthi.Visible = true;
            this.colphongthi.VisibleIndex = 10;
            this.colphongthi.Width = 94;
            // 
            // frTHONGTINLICHTHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 757);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frTHONGTINLICHTHI";
            this.Text = "frTHONGTINLICHTHI";
            this.Load += new System.EventHandler(this.frTHONGTINLICHTHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private phanmemquanlylichthiDataSet17 phanmemquanlylichthiDataSet17;
        private System.Windows.Forms.BindingSource hockyBindingSource;
        private phanmemquanlylichthiDataSet17TableAdapters.hockyTableAdapter hockyTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMahocky;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhocky;
        private DevExpress.XtraGrid.Columns.GridColumn colngaybatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colngayketthuc;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluongtuan;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colmalichthi;
        private DevExpress.XtraGrid.Columns.GridColumn colMahp;
        private DevExpress.XtraGrid.Columns.GridColumn colghichu;
        private DevExpress.XtraGrid.Columns.GridColumn coltuan;
        private DevExpress.XtraGrid.Columns.GridColumn colthu;
        private DevExpress.XtraGrid.Columns.GridColumn colngaythi;
        private DevExpress.XtraGrid.Columns.GridColumn colsldk;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colMalop;
        private DevExpress.XtraGrid.Columns.GridColumn colkip;
        private DevExpress.XtraGrid.Columns.GridColumn colphongthi;
    }
}