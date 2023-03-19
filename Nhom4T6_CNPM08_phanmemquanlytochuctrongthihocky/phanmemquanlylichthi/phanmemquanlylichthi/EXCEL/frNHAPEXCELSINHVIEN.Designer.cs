namespace phanmemquanlylichthi.EXCEL
{
    partial class frNHAPEXCELSINHVIEN
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
            this.thisinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSet1 = new phanmemquanlylichthi.phanmemquanlylichthiDataSet1();
            this.thisinhTableAdapter = new phanmemquanlylichthi.phanmemquanlylichthiDataSet1TableAdapters.thisinhTableAdapter();
            this.cbsheet = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.canbocanhthiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSet = new phanmemquanlylichthi.phanmemquanlylichthiDataSet();
            this.txtfilename = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.canbocanhthiTableAdapter = new phanmemquanlylichthi.phanmemquanlylichthiDataSetTableAdapters.canbocanhthiTableAdapter();
            this.canbocanhthiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canbocanhthiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.canbocanhthiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSet2 = new phanmemquanlylichthi.phanmemquanlylichthiDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquequan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sinhvienTableAdapter = new phanmemquanlylichthi.phanmemquanlylichthiDataSet2TableAdapters.sinhvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thisinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfilename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // thisinhBindingSource
            // 
            this.thisinhBindingSource.DataMember = "thisinh";
            this.thisinhBindingSource.DataSource = this.phanmemquanlylichthiDataSet1;
            // 
            // phanmemquanlylichthiDataSet1
            // 
            this.phanmemquanlylichthiDataSet1.DataSetName = "phanmemquanlylichthiDataSet1";
            this.phanmemquanlylichthiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thisinhTableAdapter
            // 
            this.thisinhTableAdapter.ClearBeforeFill = true;
            // 
            // cbsheet
            // 
            this.cbsheet.FormattingEnabled = true;
            this.cbsheet.Location = new System.Drawing.Point(120, 553);
            this.cbsheet.Name = "cbsheet";
            this.cbsheet.Size = new System.Drawing.Size(424, 34);
            this.cbsheet.TabIndex = 21;
            this.cbsheet.SelectedIndexChanged += new System.EventHandler(this.cbsheet_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 553);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 26);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Sheet:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 515);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 26);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "File name:";
            // 
            // canbocanhthiBindingSource1
            // 
            this.canbocanhthiBindingSource1.DataMember = "canbocanhthi";
            this.canbocanhthiBindingSource1.DataSource = this.phanmemquanlylichthiDataSet;
            // 
            // phanmemquanlylichthiDataSet
            // 
            this.phanmemquanlylichthiDataSet.DataSetName = "phanmemquanlylichthiDataSet";
            this.phanmemquanlylichthiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(120, 512);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(922, 32);
            this.txtfilename.TabIndex = 18;
            this.txtfilename.EditValueChanged += new System.EventHandler(this.txtfilename_EditValueChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(550, 555);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(127, 32);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Import ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // canbocanhthiTableAdapter
            // 
            this.canbocanhthiTableAdapter.ClearBeforeFill = true;
            // 
            // canbocanhthiBindingSource2
            // 
            this.canbocanhthiBindingSource2.DataMember = "canbocanhthi";
            this.canbocanhthiBindingSource2.DataSource = this.phanmemquanlylichthiDataSet;
            // 
            // phanmemquanlylichthiDataSetBindingSource
            // 
            this.phanmemquanlylichthiDataSetBindingSource.DataSource = this.phanmemquanlylichthiDataSet;
            this.phanmemquanlylichthiDataSetBindingSource.Position = 0;
            // 
            // canbocanhthiBindingSource3
            // 
            this.canbocanhthiBindingSource3.DataMember = "canbocanhthi";
            this.canbocanhthiBindingSource3.DataSource = this.phanmemquanlylichthiDataSet;
            // 
            // phanmemquanlylichthiDataSetBindingSource1
            // 
            this.phanmemquanlylichthiDataSetBindingSource1.DataSource = this.phanmemquanlylichthiDataSet;
            this.phanmemquanlylichthiDataSetBindingSource1.Position = 0;
            // 
            // canbocanhthiBindingSource
            // 
            this.canbocanhthiBindingSource.DataMember = "canbocanhthi";
            this.canbocanhthiBindingSource.DataSource = this.phanmemquanlylichthiDataSet;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1048, 512);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 32);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = " ...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sinhvienBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1462, 486);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.phanmemquanlylichthiDataSet2;
            // 
            // phanmemquanlylichthiDataSet2
            // 
            this.phanmemquanlylichthiDataSet2.DataSetName = "phanmemquanlylichthiDataSet2";
            this.phanmemquanlylichthiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colhoten,
            this.colngaysinh,
            this.colsdt,
            this.coldiachi,
            this.colquequan,
            this.colMakhoa,
            this.colMaCN,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colhoten
            // 
            this.colhoten.Caption = "Họ tên";
            this.colhoten.FieldName = "hoten";
            this.colhoten.MinWidth = 25;
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 0;
            this.colhoten.Width = 94;
            // 
            // colngaysinh
            // 
            this.colngaysinh.Caption = "Ngày sinh";
            this.colngaysinh.FieldName = "ngaysinh";
            this.colngaysinh.MinWidth = 25;
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.Visible = true;
            this.colngaysinh.VisibleIndex = 1;
            this.colngaysinh.Width = 94;
            // 
            // colsdt
            // 
            this.colsdt.Caption = "SĐT";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 25;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 2;
            this.colsdt.Width = 94;
            // 
            // coldiachi
            // 
            this.coldiachi.Caption = "Địa chỉ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.MinWidth = 25;
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 3;
            this.coldiachi.Width = 94;
            // 
            // colquequan
            // 
            this.colquequan.Caption = "Quê quán";
            this.colquequan.FieldName = "quequan";
            this.colquequan.MinWidth = 25;
            this.colquequan.Name = "colquequan";
            this.colquequan.Visible = true;
            this.colquequan.VisibleIndex = 4;
            this.colquequan.Width = 94;
            // 
            // colMakhoa
            // 
            this.colMakhoa.Caption = "Mã khóa";
            this.colMakhoa.FieldName = "Makhoa";
            this.colMakhoa.MinWidth = 25;
            this.colMakhoa.Name = "colMakhoa";
            this.colMakhoa.Visible = true;
            this.colMakhoa.VisibleIndex = 5;
            this.colMakhoa.Width = 94;
            // 
            // colMaCN
            // 
            this.colMaCN.Caption = "Mã chuyên ngành";
            this.colMaCN.FieldName = "MaCN";
            this.colMaCN.MinWidth = 25;
            this.colMaCN.Name = "colMaCN";
            this.colMaCN.Visible = true;
            this.colMaCN.VisibleIndex = 6;
            this.colMaCN.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã lớp";
            this.gridColumn1.FieldName = "malop";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 94;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // frNHAPEXCELSINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 611);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cbsheet);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frNHAPEXCELSINHVIEN";
            this.Text = "frNHAPEXCELSINHVIEN";
            this.Load += new System.EventHandler(this.frNHAPEXCELSINHVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thisinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfilename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource thisinhBindingSource;
        private phanmemquanlylichthiDataSet1 phanmemquanlylichthiDataSet1;
        private phanmemquanlylichthiDataSet1TableAdapters.thisinhTableAdapter thisinhTableAdapter;
        private System.Windows.Forms.ComboBox cbsheet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource1;
        private phanmemquanlylichthiDataSet phanmemquanlylichthiDataSet;
        private DevExpress.XtraEditors.TextEdit txtfilename;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private phanmemquanlylichthiDataSetTableAdapters.canbocanhthiTableAdapter canbocanhthiTableAdapter;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource2;
        private System.Windows.Forms.BindingSource phanmemquanlylichthiDataSetBindingSource;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource3;
        private System.Windows.Forms.BindingSource phanmemquanlylichthiDataSetBindingSource1;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private phanmemquanlylichthiDataSet2 phanmemquanlylichthiDataSet2;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private phanmemquanlylichthiDataSet2TableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colquequan;
        private DevExpress.XtraGrid.Columns.GridColumn colMakhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}