using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dOANDataSet1 = new GiaoDien.DOANDataSet1();
            this.dOITACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOI_TACTableAdapter = new GiaoDien.DOANDataSet1TableAdapters.DOI_TACTableAdapter();
            this.tenQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongChiNhanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITACBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(267, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(483, 520);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Những quán có món ăn bạn tìm kiếm ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenQuanDataGridViewTextBoxColumn,
            this.thanhPhoQuanDataGridViewTextBoxColumn,
            this.soLuongChiNhanhDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOITACBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(127, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(859, 306);
            this.dataGridView1.TabIndex = 6;
            // 
            // dOANDataSet1
            // 
            this.dOANDataSet1.DataSetName = "DOANDataSet1";
            this.dOANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOITACBindingSource
            // 
            this.dOITACBindingSource.DataMember = "DOI TAC";
            this.dOITACBindingSource.DataSource = this.dOANDataSet1;
            // 
            // dOI_TACTableAdapter
            // 
            this.dOI_TACTableAdapter.ClearBeforeFill = true;
            // 
            // tenQuanDataGridViewTextBoxColumn
            // 
            this.tenQuanDataGridViewTextBoxColumn.DataPropertyName = "Ten quan";
            this.tenQuanDataGridViewTextBoxColumn.HeaderText = "Ten quan";
            this.tenQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenQuanDataGridViewTextBoxColumn.Name = "tenQuanDataGridViewTextBoxColumn";
            this.tenQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // thanhPhoQuanDataGridViewTextBoxColumn
            // 
            this.thanhPhoQuanDataGridViewTextBoxColumn.DataPropertyName = "Thanh pho/Quan";
            this.thanhPhoQuanDataGridViewTextBoxColumn.HeaderText = "Thanh pho/Quan";
            this.thanhPhoQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thanhPhoQuanDataGridViewTextBoxColumn.Name = "thanhPhoQuanDataGridViewTextBoxColumn";
            this.thanhPhoQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongChiNhanhDataGridViewTextBoxColumn
            // 
            this.soLuongChiNhanhDataGridViewTextBoxColumn.DataPropertyName = "So luong chi nhanh";
            this.soLuongChiNhanhDataGridViewTextBoxColumn.HeaderText = "So luong chi nhanh";
            this.soLuongChiNhanhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongChiNhanhDataGridViewTextBoxColumn.Name = "soLuongChiNhanhDataGridViewTextBoxColumn";
            this.soLuongChiNhanhDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "So dien thoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "So dien thoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn quán ở đây";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Location = new System.Drawing.Point(415, 111);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(308, 28);
            this.cbbTimKiem.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(827, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.Text = "ĐỊA CHỈ GIAO HÀNG";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITACBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView1;
        private DOANDataSet1 dOANDataSet1;
        private BindingSource dOITACBindingSource;
        private DOANDataSet1TableAdapters.DOI_TACTableAdapter dOI_TACTableAdapter;
        private DataGridViewTextBoxColumn tenQuanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhPhoQuanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongChiNhanhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private Label label2;
        private ComboBox cbbTimKiem;
        private Button button2;
    }
}