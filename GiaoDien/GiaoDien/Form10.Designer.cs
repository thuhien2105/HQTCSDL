using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbbDSDonHang = new System.Windows.Forms.ComboBox();
            this.btnChonDonHang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dOANDataSet2 = new GiaoDien.DOANDataSet2();
            this.dsdonhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsdonhangTableAdapter = new GiaoDien.DOANDataSet2TableAdapters.dsdonhangTableAdapter();
            this.iddonhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiVanChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDonHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiNguoiNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chọn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1006, 37);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 565);
            this.vScrollBar1.TabIndex = 3;
            // 
            // cbbDSDonHang
            // 
            this.cbbDSDonHang.FormattingEnabled = true;
            this.cbbDSDonHang.Location = new System.Drawing.Point(37, 203);
            this.cbbDSDonHang.Name = "cbbDSDonHang";
            this.cbbDSDonHang.Size = new System.Drawing.Size(750, 28);
            this.cbbDSDonHang.TabIndex = 5;
            // 
            // btnChonDonHang
            // 
            this.btnChonDonHang.Location = new System.Drawing.Point(811, 198);
            this.btnChonDonHang.Name = "btnChonDonHang";
            this.btnChonDonHang.Size = new System.Drawing.Size(176, 37);
            this.btnChonDonHang.TabIndex = 6;
            this.btnChonDonHang.Text = "CHỌN ĐƠN HÀNG";
            this.btnChonDonHang.UseVisualStyleBackColor = true;
            this.btnChonDonHang.Click += new System.EventHandler(this.btnChonDonHang_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddonhangDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.hinhThucThanhToanDataGridViewTextBoxColumn,
            this.phiVanChuyenDataGridViewTextBoxColumn,
            this.tongDonHangDataGridViewTextBoxColumn,
            this.tinhTrangDonHangDataGridViewTextBoxColumn,
            this.diaChiNguoiNhanDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.chọn});
            this.dataGridView1.DataSource = this.dsdonhangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(950, 237);
            this.dataGridView1.TabIndex = 7;
            // 
            // dOANDataSet2
            // 
            this.dOANDataSet2.DataSetName = "DOANDataSet2";
            this.dOANDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsdonhangBindingSource
            // 
            this.dsdonhangBindingSource.DataMember = "dsdonhang";
            this.dsdonhangBindingSource.DataSource = this.dOANDataSet2;
            // 
            // dsdonhangTableAdapter
            // 
            this.dsdonhangTableAdapter.ClearBeforeFill = true;
            // 
            // iddonhangDataGridViewTextBoxColumn
            // 
            this.iddonhangDataGridViewTextBoxColumn.DataPropertyName = "id_donhang";
            this.iddonhangDataGridViewTextBoxColumn.HeaderText = "id_donhang";
            this.iddonhangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iddonhangDataGridViewTextBoxColumn.Name = "iddonhangDataGridViewTextBoxColumn";
            this.iddonhangDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "Ngay lap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngay lap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 150;
            // 
            // hinhThucThanhToanDataGridViewTextBoxColumn
            // 
            this.hinhThucThanhToanDataGridViewTextBoxColumn.DataPropertyName = "Hinh thuc thanh toan";
            this.hinhThucThanhToanDataGridViewTextBoxColumn.HeaderText = "Hinh thuc thanh toan";
            this.hinhThucThanhToanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hinhThucThanhToanDataGridViewTextBoxColumn.Name = "hinhThucThanhToanDataGridViewTextBoxColumn";
            this.hinhThucThanhToanDataGridViewTextBoxColumn.Width = 150;
            // 
            // phiVanChuyenDataGridViewTextBoxColumn
            // 
            this.phiVanChuyenDataGridViewTextBoxColumn.DataPropertyName = "Phi van chuyen";
            this.phiVanChuyenDataGridViewTextBoxColumn.HeaderText = "Phi van chuyen";
            this.phiVanChuyenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phiVanChuyenDataGridViewTextBoxColumn.Name = "phiVanChuyenDataGridViewTextBoxColumn";
            this.phiVanChuyenDataGridViewTextBoxColumn.Width = 150;
            // 
            // tongDonHangDataGridViewTextBoxColumn
            // 
            this.tongDonHangDataGridViewTextBoxColumn.DataPropertyName = "Tong don hang";
            this.tongDonHangDataGridViewTextBoxColumn.HeaderText = "Tong don hang";
            this.tongDonHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongDonHangDataGridViewTextBoxColumn.Name = "tongDonHangDataGridViewTextBoxColumn";
            this.tongDonHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // tinhTrangDonHangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDonHangDataGridViewTextBoxColumn.DataPropertyName = "Tinh trang don hang";
            this.tinhTrangDonHangDataGridViewTextBoxColumn.HeaderText = "Tinh trang don hang";
            this.tinhTrangDonHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tinhTrangDonHangDataGridViewTextBoxColumn.Name = "tinhTrangDonHangDataGridViewTextBoxColumn";
            this.tinhTrangDonHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiNguoiNhanDataGridViewTextBoxColumn
            // 
            this.diaChiNguoiNhanDataGridViewTextBoxColumn.DataPropertyName = "Dia chi nguoi nhan";
            this.diaChiNguoiNhanDataGridViewTextBoxColumn.HeaderText = "Dia chi nguoi nhan";
            this.diaChiNguoiNhanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiNguoiNhanDataGridViewTextBoxColumn.Name = "diaChiNguoiNhanDataGridViewTextBoxColumn";
            this.diaChiNguoiNhanDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "Dia chi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Dia chi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 150;
            // 
            // chọn
            // 
            this.chọn.DataPropertyName = "id_donhang";
            this.chọn.HeaderText = "chọn";
            this.chọn.MinimumWidth = 8;
            this.chọn.Name = "chọn";
            this.chọn.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(471, 546);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 42);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChonDonHang);
            this.Controls.Add(this.cbbDSDonHang);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form10";
            this.Text = "DANH SÁCH ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private VScrollBar vScrollBar1;
        private ComboBox cbbDSDonHang;
        private Button btnChonDonHang;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iddonhangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhThucThanhToanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phiVanChuyenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongDonHangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhTrangDonHangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiNguoiNhanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private BindingSource dsdonhangBindingSource;
        private DOANDataSet2 dOANDataSet2;
        private DOANDataSet2TableAdapters.dsdonhangTableAdapter dsdonhangTableAdapter;
        private DataGridViewButtonColumn chọn;
        private Button btnThoat;
    }
}