
namespace GiaoDien
{
    partial class Form17
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dOANDataSet5 = new GiaoDien.DOANDataSet5();
            this.dOANDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbDuyetHopDong = new System.Windows.Forms.ComboBox();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.dshopdongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dshopdongTableAdapter = new GiaoDien.DOANDataSet5TableAdapters.dshopdongTableAdapter();
            this.tenQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSoThueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTramHoaHongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshopdongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenQuanDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.thanhPhoQuanDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.maSoThueDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.phanTramHoaHongDataGridViewTextBoxColumn,
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dshopdongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(927, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // dOANDataSet5
            // 
            this.dOANDataSet5.DataSetName = "DOANDataSet5";
            this.dOANDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOANDataSet5BindingSource
            // 
            this.dOANDataSet5BindingSource.DataSource = this.dOANDataSet5;
            this.dOANDataSet5BindingSource.Position = 0;
            // 
            // cbbDuyetHopDong
            // 
            this.cbbDuyetHopDong.FormattingEnabled = true;
            this.cbbDuyetHopDong.Location = new System.Drawing.Point(124, 69);
            this.cbbDuyetHopDong.Name = "cbbDuyetHopDong";
            this.cbbDuyetHopDong.Size = new System.Drawing.Size(589, 28);
            this.cbbDuyetHopDong.TabIndex = 1;
            // 
            // btnDuyet
            // 
            this.btnDuyet.Location = new System.Drawing.Point(798, 61);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(145, 42);
            this.btnDuyet.TabIndex = 2;
            this.btnDuyet.Text = "Duyệt hợp đồng";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // dshopdongBindingSource
            // 
            this.dshopdongBindingSource.DataMember = "dshopdong";
            this.dshopdongBindingSource.DataSource = this.dOANDataSet5BindingSource;
            // 
            // dshopdongTableAdapter
            // 
            this.dshopdongTableAdapter.ClearBeforeFill = true;
            // 
            // tenQuanDataGridViewTextBoxColumn
            // 
            this.tenQuanDataGridViewTextBoxColumn.DataPropertyName = "Ten quan";
            this.tenQuanDataGridViewTextBoxColumn.HeaderText = "Ten quan";
            this.tenQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenQuanDataGridViewTextBoxColumn.Name = "tenQuanDataGridViewTextBoxColumn";
            this.tenQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "So dien thoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "So dien thoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // thanhPhoQuanDataGridViewTextBoxColumn
            // 
            this.thanhPhoQuanDataGridViewTextBoxColumn.DataPropertyName = "Thanh pho/Quan";
            this.thanhPhoQuanDataGridViewTextBoxColumn.HeaderText = "Thanh pho/Quan";
            this.thanhPhoQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thanhPhoQuanDataGridViewTextBoxColumn.Name = "thanhPhoQuanDataGridViewTextBoxColumn";
            this.thanhPhoQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "Ten nhan vien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Ten nhan vien";
            this.tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // maSoThueDataGridViewTextBoxColumn
            // 
            this.maSoThueDataGridViewTextBoxColumn.DataPropertyName = "Ma so thue";
            this.maSoThueDataGridViewTextBoxColumn.HeaderText = "Ma so thue";
            this.maSoThueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSoThueDataGridViewTextBoxColumn.Name = "maSoThueDataGridViewTextBoxColumn";
            this.maSoThueDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "Ngay lap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngay lap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 150;
            // 
            // phanTramHoaHongDataGridViewTextBoxColumn
            // 
            this.phanTramHoaHongDataGridViewTextBoxColumn.DataPropertyName = "Phan tram hoa hong";
            this.phanTramHoaHongDataGridViewTextBoxColumn.HeaderText = "Phan tram hoa hong";
            this.phanTramHoaHongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phanTramHoaHongDataGridViewTextBoxColumn.Name = "phanTramHoaHongDataGridViewTextBoxColumn";
            this.phanTramHoaHongDataGridViewTextBoxColumn.Width = 150;
            // 
            // thoiGianHetHieuLucDataGridViewTextBoxColumn
            // 
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn.DataPropertyName = "Thoi gian het hieu luc";
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn.HeaderText = "Thoi gian het hieu luc";
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn.Name = "thoiGianHetHieuLucDataGridViewTextBoxColumn";
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(469, 522);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(135, 47);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "TRỞ VỀ";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 579);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.cbbDuyetHopDong);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form17";
            this.Text = "XÉT DUYỆT HỢP ĐỒNG";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshopdongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dOANDataSet5BindingSource;
        private DOANDataSet5 dOANDataSet5;
        private System.Windows.Forms.ComboBox cbbDuyetHopDong;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.BindingSource dshopdongBindingSource;
        private DOANDataSet5TableAdapters.dshopdongTableAdapter dshopdongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoThueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanTramHoaHongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianHetHieuLucDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTroVe;
    }
}