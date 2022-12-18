﻿using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTimKiemCuahang = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dOANDataSet = new GiaoDien.DOANDataSet();
            this.dOITACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOI_TACTableAdapter = new GiaoDien.DOANDataSetTableAdapters.DOI_TACTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongChiNhanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cbbTimKiemCuaHang = new System.Windows.Forms.ComboBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 169);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(442, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnTimKiemCuahang
            // 
            this.btnTimKiemCuahang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTimKiemCuahang.Location = new System.Drawing.Point(372, 220);
            this.btnTimKiemCuahang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiemCuahang.Name = "btnTimKiemCuahang";
            this.btnTimKiemCuahang.Size = new System.Drawing.Size(243, 45);
            this.btnTimKiemCuahang.TabIndex = 3;
            this.btnTimKiemCuahang.Text = "Tìm kiếm cửa hàng";
            this.btnTimKiemCuahang.UseVisualStyleBackColor = true;
            this.btnTimKiemCuahang.Click += new System.EventHandler(this.btnTimKiemCuahang_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1008, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 532);
            this.vScrollBar1.TabIndex = 4;
            // 
            // dOANDataSet
            // 
            this.dOANDataSet.DataSetName = "DOANDataSet";
            this.dOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOITACBindingSource
            // 
            this.dOITACBindingSource.DataMember = "DOI TAC";
            this.dOITACBindingSource.DataSource = this.dOANDataSet;
            // 
            // dOI_TACTableAdapter
            // 
            this.dOI_TACTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenQuanDataGridViewTextBoxColumn,
            this.thanhPhoQuanDataGridViewTextBoxColumn,
            this.soLuongChiNhanhDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOITACBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(854, 267);
            this.dataGridView1.TabIndex = 5;
            // 
            // tenQuanDataGridViewTextBoxColumn
            // 
            this.tenQuanDataGridViewTextBoxColumn.DataPropertyName = "Ten quan";
            this.tenQuanDataGridViewTextBoxColumn.HeaderText = "Ten quan";
            this.tenQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenQuanDataGridViewTextBoxColumn.Name = "tenQuanDataGridViewTextBoxColumn";
            this.tenQuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // thanhPhoQuanDataGridViewTextBoxColumn
            // 
            this.thanhPhoQuanDataGridViewTextBoxColumn.DataPropertyName = "Thanh pho/Quan";
            this.thanhPhoQuanDataGridViewTextBoxColumn.HeaderText = "Thanh pho/Quan";
            this.thanhPhoQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thanhPhoQuanDataGridViewTextBoxColumn.Name = "thanhPhoQuanDataGridViewTextBoxColumn";
            this.thanhPhoQuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhPhoQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongChiNhanhDataGridViewTextBoxColumn
            // 
            this.soLuongChiNhanhDataGridViewTextBoxColumn.DataPropertyName = "So luong chi nhanh";
            this.soLuongChiNhanhDataGridViewTextBoxColumn.HeaderText = "So luong chi nhanh";
            this.soLuongChiNhanhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongChiNhanhDataGridViewTextBoxColumn.Name = "soLuongChiNhanhDataGridViewTextBoxColumn";
            this.soLuongChiNhanhDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongChiNhanhDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "So dien thoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "So dien thoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1049, 34);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // cbbTimKiemCuaHang
            // 
            this.cbbTimKiemCuaHang.FormattingEnabled = true;
            this.cbbTimKiemCuaHang.Location = new System.Drawing.Point(279, 169);
            this.cbbTimKiemCuaHang.Name = "cbbTimKiemCuaHang";
            this.cbbTimKiemCuaHang.Size = new System.Drawing.Size(492, 28);
            this.cbbTimKiemCuaHang.TabIndex = 7;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(447, 578);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(125, 47);
            this.btnTroVe.TabIndex = 8;
            this.btnTroVe.Text = "TRỞ VỀ";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1049, 698);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.cbbTimKiemCuaHang);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnTimKiemCuahang);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "CỬA HÀNG";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnTimKiemCuahang;
        private VScrollBar vScrollBar1;
        private DOANDataSet dOANDataSet;
        private BindingSource dOITACBindingSource;
        private DOANDataSetTableAdapters.DOI_TACTableAdapter dOI_TACTableAdapter;
        private DataGridView dataGridView1;
        private ToolStrip fillByToolStrip;
        private ToolStripButton fillByToolStripButton;
        private DataGridViewTextBoxColumn tenQuanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhPhoQuanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongChiNhanhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private ComboBox cbbTimKiemCuaHang;
        private Button btnTroVe;
    }
}