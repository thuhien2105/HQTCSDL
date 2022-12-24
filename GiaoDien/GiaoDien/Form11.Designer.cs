namespace GiaoDien
{
    partial class Form11
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.chỉnhSửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltenquan = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblrate = new System.Windows.Forms.Label();
            this.lbltennganhang = new System.Windows.Forms.Label();
            this.lblstk = new System.Windows.Forms.Label();
            this.lblsochinhanh = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaThôngTinToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1129, 33);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // chỉnhSửaThôngTinToolStripMenuItem
            // 
            this.chỉnhSửaThôngTinToolStripMenuItem.Name = "chỉnhSửaThôngTinToolStripMenuItem";
            this.chỉnhSửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.chỉnhSửaThôngTinToolStripMenuItem.Text = "Chỉnh sửa thông tin";
            this.chỉnhSửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaThôngTinToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíDToolStripMenuItem,
            this.quảnLíToolStripMenuItem1,
            this.quảnLíThựcĐơnToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // quảnLíDToolStripMenuItem
            // 
            this.quảnLíDToolStripMenuItem.Name = "quảnLíDToolStripMenuItem";
            this.quảnLíDToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.quảnLíDToolStripMenuItem.Text = "Quản lí doanh thu";
            this.quảnLíDToolStripMenuItem.Click += new System.EventHandler(this.quảnLíDToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem1
            // 
            this.quảnLíToolStripMenuItem1.Name = "quảnLíToolStripMenuItem1";
            this.quảnLíToolStripMenuItem1.Size = new System.Drawing.Size(257, 34);
            this.quảnLíToolStripMenuItem1.Text = "Quản lí chi nhánh";
            this.quảnLíToolStripMenuItem1.Click += new System.EventHandler(this.quảnLíToolStripMenuItem1_Click);
            // 
            // quảnLíThựcĐơnToolStripMenuItem
            // 
            this.quảnLíThựcĐơnToolStripMenuItem.Name = "quảnLíThựcĐơnToolStripMenuItem";
            this.quảnLíThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.quảnLíThựcĐơnToolStripMenuItem.Text = "Quản lí thực đơn";
            this.quảnLíThựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíThựcĐơnToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÊN QUÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "THÀNH PHỐ/QUẬN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SỐ ĐIỆN THOẠI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "RATE ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "TÊN NGÂN HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "SỐ TÀI KHOẢN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "SỐ CHI NHÁNH";
            // 
            // lbltenquan
            // 
            this.lbltenquan.AutoSize = true;
            this.lbltenquan.Location = new System.Drawing.Point(517, 84);
            this.lbltenquan.Name = "lbltenquan";
            this.lbltenquan.Size = new System.Drawing.Size(51, 20);
            this.lbltenquan.TabIndex = 19;
            this.lbltenquan.Text = "label9";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(517, 134);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(60, 20);
            this.lbldiachi.TabIndex = 20;
            this.lbldiachi.Text = "label10";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(508, 202);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(60, 20);
            this.lblsdt.TabIndex = 21;
            this.lblsdt.Text = "label11";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(508, 270);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(60, 20);
            this.lblemail.TabIndex = 22;
            this.lblemail.Text = "label12";
            // 
            // lblrate
            // 
            this.lblrate.AutoSize = true;
            this.lblrate.Location = new System.Drawing.Point(533, 337);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(60, 20);
            this.lblrate.TabIndex = 23;
            this.lblrate.Text = "label13";
            // 
            // lbltennganhang
            // 
            this.lbltennganhang.AutoSize = true;
            this.lbltennganhang.Location = new System.Drawing.Point(517, 403);
            this.lbltennganhang.Name = "lbltennganhang";
            this.lbltennganhang.Size = new System.Drawing.Size(60, 20);
            this.lbltennganhang.TabIndex = 24;
            this.lbltennganhang.Text = "label14";
            // 
            // lblstk
            // 
            this.lblstk.AutoSize = true;
            this.lblstk.Location = new System.Drawing.Point(517, 473);
            this.lblstk.Name = "lblstk";
            this.lblstk.Size = new System.Drawing.Size(60, 20);
            this.lblstk.TabIndex = 25;
            this.lblstk.Text = "label15";
            // 
            // lblsochinhanh
            // 
            this.lblsochinhanh.AutoSize = true;
            this.lblsochinhanh.Location = new System.Drawing.Point(517, 554);
            this.lblsochinhanh.Name = "lblsochinhanh";
            this.lblsochinhanh.Size = new System.Drawing.Size(60, 20);
            this.lblsochinhanh.TabIndex = 26;
            this.lblsochinhanh.Text = "label16";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 634);
            this.Controls.Add(this.lblsochinhanh);
            this.Controls.Add(this.lblstk);
            this.Controls.Add(this.lbltennganhang);
            this.Controls.Add(this.lblrate);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsdt);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lbltenquan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form11";
            this.RightToLeftLayout = true;
            this.Text = "Đối Tác";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltenquan;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.Label lbltennganhang;
        private System.Windows.Forms.Label lblstk;
        private System.Windows.Forms.Label lblsochinhanh;
    }
}