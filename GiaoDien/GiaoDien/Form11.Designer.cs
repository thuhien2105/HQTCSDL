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
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaThôngTinToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(739, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // chỉnhSửaThôngTinToolStripMenuItem
            // 
            this.chỉnhSửaThôngTinToolStripMenuItem.Name = "chỉnhSửaThôngTinToolStripMenuItem";
            this.chỉnhSửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
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
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // quảnLíDToolStripMenuItem
            // 
            this.quảnLíDToolStripMenuItem.Name = "quảnLíDToolStripMenuItem";
            this.quảnLíDToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLíDToolStripMenuItem.Text = "Quản lí doanh thu";
            this.quảnLíDToolStripMenuItem.Click += new System.EventHandler(this.quảnLíDToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem1
            // 
            this.quảnLíToolStripMenuItem1.Name = "quảnLíToolStripMenuItem1";
            this.quảnLíToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.quảnLíToolStripMenuItem1.Text = "Quản lí chi nhánh";
            this.quảnLíToolStripMenuItem1.Click += new System.EventHandler(this.quảnLíToolStripMenuItem1_Click);
            // 
            // quảnLíThựcĐơnToolStripMenuItem
            // 
            this.quảnLíThựcĐơnToolStripMenuItem.Name = "quảnLíThựcĐơnToolStripMenuItem";
            this.quảnLíThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLíThựcĐơnToolStripMenuItem.Text = "Quản lí thực đơn";
            this.quảnLíThựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíThựcĐơnToolStripMenuItem_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 399);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
    }
}