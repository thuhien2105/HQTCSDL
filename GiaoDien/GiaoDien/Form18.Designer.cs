
namespace GiaoDien
{
    partial class Form18
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSoThueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTramHoaHongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratetb = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dshopdongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOANDataSet5 = new GiaoDien.DOANDataSet5();
            this.dshopdongTableAdapter = new GiaoDien.DOANDataSet5TableAdapters.dshopdongTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.cbbDoiTac = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshopdongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 30;
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
            this.thoiGianHetHieuLucDataGridViewTextBoxColumn,
            this.ratetb});
            this.dataGridView1.DataSource = this.dshopdongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(961, 294);
            this.dataGridView1.TabIndex = 31;
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
            // ratetb
            // 
            this.ratetb.DataPropertyName = "ratetb";
            this.ratetb.HeaderText = "ratetb";
            this.ratetb.MinimumWidth = 8;
            this.ratetb.Name = "ratetb";
            this.ratetb.Width = 150;
            // 
            // dshopdongBindingSource
            // 
            this.dshopdongBindingSource.DataMember = "dshopdong";
            this.dshopdongBindingSource.DataSource = this.dOANDataSet5;
            // 
            // dOANDataSet5
            // 
            this.dOANDataSet5.DataSetName = "DOANDataSet5";
            this.dOANDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dshopdongTableAdapter
            // 
            this.dshopdongTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 59);
            this.button2.TabIndex = 33;
            this.button2.Text = "HĐ CHƯA ĐƯỢC XÉT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cbbDoiTac
            // 
            this.cbbDoiTac.FormattingEnabled = true;
            this.cbbDoiTac.Location = new System.Drawing.Point(272, 53);
            this.cbbDoiTac.Name = "cbbDoiTac";
            this.cbbDoiTac.Size = new System.Drawing.Size(438, 28);
            this.cbbDoiTac.TabIndex = 34;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(796, 54);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 27);
            this.btnChon.TabIndex = 35;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "THÔNG TIN CHI TIẾT";
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbDoiTac);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form18";
            this.Text = "DANH SÁCH HỢP ĐỒNG";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshopdongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DOANDataSet5 dOANDataSet5;
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
        private System.Windows.Forms.DataGridViewButtonColumn ratetb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbbDoiTac;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label2;
    }
}