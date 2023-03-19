namespace phanmemquanlylichthi.formGiangvien
{
    partial class FRTHONGTINSINHVIENTHEOLOP
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSet20 = new phanmemquanlylichthi.phanmemquanlylichthiDataSet20();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMalop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenlop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluongsv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quequan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenkhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phanmemquanlylichthiDataSet19 = new phanmemquanlylichthi.phanmemquanlylichthiDataSet19();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new phanmemquanlylichthi.phanmemquanlylichthiDataSet19TableAdapters.lopTableAdapter();
            this.lopTableAdapter1 = new phanmemquanlylichthi.phanmemquanlylichthiDataSet20TableAdapters.lopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.lopBindingSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(535, 827);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "lop";
            this.lopBindingSource1.DataSource = this.phanmemquanlylichthiDataSet20;
            // 
            // phanmemquanlylichthiDataSet20
            // 
            this.phanmemquanlylichthiDataSet20.DataSetName = "phanmemquanlylichthiDataSet20";
            this.phanmemquanlylichthiDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMalop,
            this.coltenlop,
            this.colsoluongsv});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colMalop
            // 
            this.colMalop.FieldName = "Malop";
            this.colMalop.MinWidth = 25;
            this.colMalop.Name = "colMalop";
            this.colMalop.Visible = true;
            this.colMalop.VisibleIndex = 0;
            this.colMalop.Width = 94;
            // 
            // coltenlop
            // 
            this.coltenlop.FieldName = "tenlop";
            this.coltenlop.MinWidth = 25;
            this.coltenlop.Name = "coltenlop";
            this.coltenlop.Visible = true;
            this.coltenlop.VisibleIndex = 1;
            this.coltenlop.Width = 94;
            // 
            // colsoluongsv
            // 
            this.colsoluongsv.FieldName = "soluongsv";
            this.colsoluongsv.MinWidth = 25;
            this.colsoluongsv.Name = "colsoluongsv";
            this.colsoluongsv.Visible = true;
            this.colsoluongsv.VisibleIndex = 2;
            this.colsoluongsv.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(535, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(892, 827);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MSSV,
            this.hoten,
            this.SDT,
            this.diachi,
            this.quequan,
            this.tenkhoa,
            this.tenganh,
            this.ngay,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MSSV
            // 
            this.MSSV.Caption = "MSSV";
            this.MSSV.FieldName = "MSSV";
            this.MSSV.MinWidth = 25;
            this.MSSV.Name = "MSSV";
            this.MSSV.Visible = true;
            this.MSSV.VisibleIndex = 0;
            this.MSSV.Width = 94;
            // 
            // hoten
            // 
            this.hoten.Caption = "Họ tên";
            this.hoten.FieldName = "hoten";
            this.hoten.MinWidth = 25;
            this.hoten.Name = "hoten";
            this.hoten.Visible = true;
            this.hoten.VisibleIndex = 1;
            this.hoten.Width = 94;
            // 
            // SDT
            // 
            this.SDT.Caption = "SĐT";
            this.SDT.FieldName = "sdt";
            this.SDT.MinWidth = 25;
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 2;
            this.SDT.Width = 94;
            // 
            // diachi
            // 
            this.diachi.Caption = "Địa chỉ";
            this.diachi.FieldName = "diachi";
            this.diachi.MinWidth = 25;
            this.diachi.Name = "diachi";
            this.diachi.Visible = true;
            this.diachi.VisibleIndex = 3;
            this.diachi.Width = 94;
            // 
            // quequan
            // 
            this.quequan.Caption = "Quê quán";
            this.quequan.FieldName = "quequan";
            this.quequan.MinWidth = 25;
            this.quequan.Name = "quequan";
            this.quequan.Visible = true;
            this.quequan.VisibleIndex = 4;
            this.quequan.Width = 94;
            // 
            // tenkhoa
            // 
            this.tenkhoa.Caption = "Khóa";
            this.tenkhoa.FieldName = "tenkhoa";
            this.tenkhoa.MinWidth = 25;
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Visible = true;
            this.tenkhoa.VisibleIndex = 5;
            this.tenkhoa.Width = 94;
            // 
            // tenganh
            // 
            this.tenganh.Caption = "Chuyên ngành";
            this.tenganh.FieldName = "tenchuyennganh";
            this.tenganh.MinWidth = 25;
            this.tenganh.Name = "tenganh";
            this.tenganh.Visible = true;
            this.tenganh.VisibleIndex = 6;
            this.tenganh.Width = 94;
            // 
            // ngay
            // 
            this.ngay.Caption = "Ngày sinh";
            this.ngay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ngay.FieldName = "ngaysinh";
            this.ngay.MinWidth = 25;
            this.ngay.Name = "ngay";
            this.ngay.Visible = true;
            this.ngay.VisibleIndex = 7;
            this.ngay.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lớp";
            this.gridColumn1.FieldName = "tenlop";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 94;
            // 
            // phanmemquanlylichthiDataSet19
            // 
            this.phanmemquanlylichthiDataSet19.DataSetName = "phanmemquanlylichthiDataSet19";
            this.phanmemquanlylichthiDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.phanmemquanlylichthiDataSet19;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter1
            // 
            this.lopTableAdapter1.ClearBeforeFill = true;
            // 
            // FRTHONGTINSINHVIENTHEOLOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 827);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.Name = "FRTHONGTINSINHVIENTHEOLOP";
            this.Text = "FRTHONGTINSINHVIENTHEOLOP";
            this.Load += new System.EventHandler(this.FRTHONGTINSINHVIENTHEOLOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MSSV;
        private DevExpress.XtraGrid.Columns.GridColumn hoten;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn diachi;
        private DevExpress.XtraGrid.Columns.GridColumn quequan;
        private DevExpress.XtraGrid.Columns.GridColumn tenkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn tenganh;
        private DevExpress.XtraGrid.Columns.GridColumn ngay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private phanmemquanlylichthiDataSet19 phanmemquanlylichthiDataSet19;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private phanmemquanlylichthiDataSet19TableAdapters.lopTableAdapter lopTableAdapter;
        private phanmemquanlylichthiDataSet20 phanmemquanlylichthiDataSet20;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private phanmemquanlylichthiDataSet20TableAdapters.lopTableAdapter lopTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colMalop;
        private DevExpress.XtraGrid.Columns.GridColumn coltenlop;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluongsv;
    }
}