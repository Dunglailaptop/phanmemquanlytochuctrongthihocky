namespace phanmemquanlylichthi.formGiangvien
{
    partial class frTHONGTINTHISINH
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
            this.thisinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanmemquanlylichthiDataSet18 = new phanmemquanlylichthi.phanmemquanlylichthiDataSet18();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mathisnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thisinhTableAdapter = new phanmemquanlylichthi.phanmemquanlylichthiDataSet18TableAdapters.thisinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.thisinhBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1415, 766);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // thisinhBindingSource
            // 
            this.thisinhBindingSource.DataMember = "thisinh";
            this.thisinhBindingSource.DataSource = this.phanmemquanlylichthiDataSet18;
            // 
            // phanmemquanlylichthiDataSet18
            // 
            this.phanmemquanlylichthiDataSet18.DataSetName = "phanmemquanlylichthiDataSet18";
            this.phanmemquanlylichthiDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenganh,
            this.ngay,
            this.Mathisnh,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // tenganh
            // 
            this.tenganh.Caption = "Phòng thi";
            this.tenganh.FieldName = "Maphongthi";
            this.tenganh.MinWidth = 25;
            this.tenganh.Name = "tenganh";
            this.tenganh.Visible = true;
            this.tenganh.VisibleIndex = 0;
            this.tenganh.Width = 94;
            // 
            // ngay
            // 
            this.ngay.Caption = "STT";
            this.ngay.FieldName = "soghe";
            this.ngay.MinWidth = 25;
            this.ngay.Name = "ngay";
            this.ngay.Visible = true;
            this.ngay.VisibleIndex = 1;
            this.ngay.Width = 94;
            // 
            // Mathisnh
            // 
            this.Mathisnh.Caption = "Mã thí sinh";
            this.Mathisnh.FieldName = "Mathisinh";
            this.Mathisnh.MinWidth = 25;
            this.Mathisnh.Name = "Mathisnh";
            this.Mathisnh.Visible = true;
            this.Mathisnh.VisibleIndex = 2;
            this.Mathisnh.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã thí sinh";
            this.gridColumn1.FieldName = "Masinhvien";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Hình QRCODE";
            this.gridColumn2.FieldName = "ORCODE";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 94;
            // 
            // thisinhTableAdapter
            // 
            this.thisinhTableAdapter.ClearBeforeFill = true;
            // 
            // frTHONGTINTHISINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 766);
            this.Controls.Add(this.gridControl1);
            this.Name = "frTHONGTINTHISINH";
            this.Text = "frTHONGTINTHISINH";
            this.Load += new System.EventHandler(this.frTHONGTINTHISINH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanmemquanlylichthiDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn tenganh;
        private DevExpress.XtraGrid.Columns.GridColumn ngay;
        private DevExpress.XtraGrid.Columns.GridColumn Mathisnh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private phanmemquanlylichthiDataSet18 phanmemquanlylichthiDataSet18;
        private System.Windows.Forms.BindingSource thisinhBindingSource;
        private phanmemquanlylichthiDataSet18TableAdapters.thisinhTableAdapter thisinhTableAdapter;
    }
}