namespace GiaoDien
{
    partial class Form10_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dOANDataSet4 = new GiaoDien.DOANDataSet4();
            this.dsdonhangdanhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsdonhangdanhanTableAdapter = new GiaoDien.DOANDataSet4TableAdapters.dsdonhangdanhanTableAdapter();
            this.iddonhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiVanChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangdanhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddonhangDataGridViewTextBoxColumn,
            this.hinhThucThanhToanDataGridViewTextBoxColumn,
            this.phiVanChuyenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dsdonhangdanhanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(997, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH SỬ ĐƠN HÀNG MÀ TÀI XẾ ĐÃ NHẬN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Chỉ tính 5 ngày gần nhất)";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(490, 585);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(173, 49);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "TRỜ VỀ";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dOANDataSet4
            // 
            this.dOANDataSet4.DataSetName = "DOANDataSet4";
            this.dOANDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsdonhangdanhanBindingSource
            // 
            this.dsdonhangdanhanBindingSource.DataMember = "dsdonhangdanhan";
            this.dsdonhangdanhanBindingSource.DataSource = this.dOANDataSet4;
            // 
            // dsdonhangdanhanTableAdapter
            // 
            this.dsdonhangdanhanTableAdapter.ClearBeforeFill = true;
            // 
            // iddonhangDataGridViewTextBoxColumn
            // 
            this.iddonhangDataGridViewTextBoxColumn.DataPropertyName = "id_donhang";
            this.iddonhangDataGridViewTextBoxColumn.HeaderText = "id_donhang";
            this.iddonhangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iddonhangDataGridViewTextBoxColumn.Name = "iddonhangDataGridViewTextBoxColumn";
            this.iddonhangDataGridViewTextBoxColumn.Width = 150;
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
            // Form10_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 720);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10_2";
            this.Text = "Form10_2";
            this.Load += new System.EventHandler(this.Form10_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangdanhanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddonhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhThucThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phiVanChuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dsdonhangdanhanBindingSource;
        private DOANDataSet4 dOANDataSet4;
        private DOANDataSet4TableAdapters.dsdonhangdanhanTableAdapter dsdonhangdanhanTableAdapter;
    }
}