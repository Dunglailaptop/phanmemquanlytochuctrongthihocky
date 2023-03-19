namespace phanmemquanlylichthi.FormQuanly
{
    partial class FileExcel
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.canbocanhthiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSet = new phanmemquanlylichthi.phanmemquanlylichthiDataSet();
            this.txtfilename = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbsheet = new System.Windows.Forms.ComboBox();
            this.canbocanhthiTableAdapter = new phanmemquanlylichthi.phanmemquanlylichthiDataSetTableAdapters.canbocanhthiTableAdapter();
            this.canbocanhthiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.canbocanhthiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.canbocanhthiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbomon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaphonglamviec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maquyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phanmemquanlylichthiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfilename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1039, 476);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 32);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = " ...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(541, 515);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(127, 32);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Import ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // canbocanhthiBindingSource
            // 
            this.canbocanhthiBindingSource.DataMember = "canbocanhthi";
            this.canbocanhthiBindingSource.DataSource = this.phanmemquanlylichthiDataSet;
            // 
            // phanmemquanlylichthiDataSet
            // 
            this.phanmemquanlylichthiDataSet.DataSetName = "phanmemquanlylichthiDataSet";
            this.phanmemquanlylichthiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(111, 476);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(922, 32);
            this.txtfilename.TabIndex = 3;
            this.txtfilename.EditValueChanged += new System.EventHandler(this.txtfilename_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 479);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 26);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "File name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 517);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 26);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Sheet:";
            // 
            // cbsheet
            // 
            this.cbsheet.FormattingEnabled = true;
            this.cbsheet.Location = new System.Drawing.Point(111, 514);
            this.cbsheet.Name = "cbsheet";
            this.cbsheet.Size = new System.Drawing.Size(424, 34);
            this.cbsheet.TabIndex = 7;
            this.cbsheet.SelectedIndexChanged += new System.EventHandler(this.cbsheet_SelectedIndexChanged);
            // 
            // canbocanhthiTableAdapter
            // 
            this.canbocanhthiTableAdapter.ClearBeforeFill = true;
            // 
            // canbocanhthiBindingSource1
            // 
            this.canbocanhthiBindingSource1.DataMember = "canbocanhthi";
            this.canbocanhthiBindingSource1.DataSource = this.phanmemquanlylichthiDataSet;
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.canbocanhthiBindingSource3;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1287, 470);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // canbocanhthiBindingSource3
            // 
            this.canbocanhthiBindingSource3.DataMember = "canbocanhthi";
            this.canbocanhthiBindingSource3.DataSource = this.phanmemquanlylichthiDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.hoten,
            this.colemail,
            this.colbomon,
            this.colsdt,
            this.colMaphonglamviec,
            this.Maquyen,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // hoten
            // 
            this.hoten.Caption = "Họ tên";
            this.hoten.FieldName = "hoten";
            this.hoten.MinWidth = 25;
            this.hoten.Name = "hoten";
            this.hoten.Visible = true;
            this.hoten.VisibleIndex = 0;
            this.hoten.Width = 94;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 25;
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 1;
            this.colemail.Width = 94;
            // 
            // colbomon
            // 
            this.colbomon.Caption = "Bộ môn";
            this.colbomon.FieldName = "bomon";
            this.colbomon.MinWidth = 25;
            this.colbomon.Name = "colbomon";
            this.colbomon.Visible = true;
            this.colbomon.VisibleIndex = 2;
            this.colbomon.Width = 94;
            // 
            // colsdt
            // 
            this.colsdt.Caption = "SĐT";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 25;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 3;
            this.colsdt.Width = 94;
            // 
            // colMaphonglamviec
            // 
            this.colMaphonglamviec.Caption = "Mã phòng làm việc";
            this.colMaphonglamviec.FieldName = "Maphonglamviec";
            this.colMaphonglamviec.MinWidth = 25;
            this.colMaphonglamviec.Name = "colMaphonglamviec";
            this.colMaphonglamviec.Visible = true;
            this.colMaphonglamviec.VisibleIndex = 4;
            this.colMaphonglamviec.Width = 94;
            // 
            // Maquyen
            // 
            this.Maquyen.Caption = "Mã quyền";
            this.Maquyen.FieldName = "Maquyen";
            this.Maquyen.MinWidth = 25;
            this.Maquyen.Name = "Maquyen";
            this.Maquyen.Visible = true;
            this.Maquyen.VisibleIndex = 5;
            this.Maquyen.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "hinhanh";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 94;
            // 
            // phanmemquanlylichthiDataSetBindingSource1
            // 
            this.phanmemquanlylichthiDataSetBindingSource1.DataSource = this.phanmemquanlylichthiDataSet;
            this.phanmemquanlylichthiDataSetBindingSource1.Position = 0;
            // 
            // FileExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 550);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cbsheet);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "FileExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileExcel";
            this.Load += new System.EventHandler(this.FileExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfilename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canbocanhthiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit txtfilename;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbsheet;
        private phanmemquanlylichthiDataSet phanmemquanlylichthiDataSet;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource;
        private phanmemquanlylichthiDataSetTableAdapters.canbocanhthiTableAdapter canbocanhthiTableAdapter;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource1;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource2;
        private System.Windows.Forms.BindingSource phanmemquanlylichthiDataSetBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource canbocanhthiBindingSource3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colbomon;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraGrid.Columns.GridColumn colMaphonglamviec;
        private System.Windows.Forms.BindingSource phanmemquanlylichthiDataSetBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn hoten;
        private DevExpress.XtraGrid.Columns.GridColumn Maquyen;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}