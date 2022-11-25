namespace HeQuanTri
{
    partial class DSDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSDonHang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSáchĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đãNhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đãChuẩnBịXongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đãNhậnMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đangGiaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đãGiaoXongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchĐơnHàngToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchĐơnHàngToolStripMenuItem
            // 
            this.danhSáchĐơnHàngToolStripMenuItem.Checked = true;
            this.danhSáchĐơnHàngToolStripMenuItem.CheckOnClick = true;
            this.danhSáchĐơnHàngToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.danhSáchĐơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đơnHàngAToolStripMenuItem,
            this.đơnHàngBToolStripMenuItem,
            this.đơnHàngCToolStripMenuItem});
            this.danhSáchĐơnHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.danhSáchĐơnHàngToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.danhSáchĐơnHàngToolStripMenuItem.Name = "danhSáchĐơnHàngToolStripMenuItem";
            this.danhSáchĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.danhSáchĐơnHàngToolStripMenuItem.Text = "Danh sách đơn hàng";
            // 
            // đơnHàngAToolStripMenuItem
            // 
            this.đơnHàngAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đãNhậnToolStripMenuItem,
            this.đãToolStripMenuItem,
            this.đãChuẩnBịXongToolStripMenuItem,
            this.đãNhậnMónToolStripMenuItem,
            this.đangGiaoToolStripMenuItem,
            this.đãGiaoXongToolStripMenuItem});
            this.đơnHàngAToolStripMenuItem.Name = "đơnHàngAToolStripMenuItem";
            this.đơnHàngAToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.đơnHàngAToolStripMenuItem.Text = "Đơn hàng A";
            // 
            // đãNhậnToolStripMenuItem
            // 
            this.đãNhậnToolStripMenuItem.CheckOnClick = true;
            this.đãNhậnToolStripMenuItem.Name = "đãNhậnToolStripMenuItem";
            this.đãNhậnToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.đãNhậnToolStripMenuItem.Text = "Đã nhận đơn hàng";
            // 
            // đãToolStripMenuItem
            // 
            this.đãToolStripMenuItem.CheckOnClick = true;
            this.đãToolStripMenuItem.Name = "đãToolStripMenuItem";
            this.đãToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.đãToolStripMenuItem.Text = "Đang đến nhà hàng";
            this.đãToolStripMenuItem.Click += new System.EventHandler(this.đãToolStripMenuItem_Click);
            // 
            // đãChuẩnBịXongToolStripMenuItem
            // 
            this.đãChuẩnBịXongToolStripMenuItem.CheckOnClick = true;
            this.đãChuẩnBịXongToolStripMenuItem.Name = "đãChuẩnBịXongToolStripMenuItem";
            this.đãChuẩnBịXongToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.đãChuẩnBịXongToolStripMenuItem.Text = "Đã đến nhà hàng";
            // 
            // đãNhậnMónToolStripMenuItem
            // 
            this.đãNhậnMónToolStripMenuItem.CheckOnClick = true;
            this.đãNhậnMónToolStripMenuItem.Name = "đãNhậnMónToolStripMenuItem";
            this.đãNhậnMónToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.đãNhậnMónToolStripMenuItem.Text = "Đã nhận món";
            // 
            // đangGiaoToolStripMenuItem
            // 
            this.đangGiaoToolStripMenuItem.CheckOnClick = true;
            this.đangGiaoToolStripMenuItem.Name = "đangGiaoToolStripMenuItem";
            this.đangGiaoToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.đangGiaoToolStripMenuItem.Text = "Đang giao";
            // 
            // đãGiaoXongToolStripMenuItem
            // 
            this.đãGiaoXongToolStripMenuItem.CheckOnClick = true;
            this.đãGiaoXongToolStripMenuItem.Name = "đãGiaoXongToolStripMenuItem";
            this.đãGiaoXongToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.đãGiaoXongToolStripMenuItem.Text = "Đã giao xong";
            // 
            // đơnHàngBToolStripMenuItem
            // 
            this.đơnHàngBToolStripMenuItem.Name = "đơnHàngBToolStripMenuItem";
            this.đơnHàngBToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.đơnHàngBToolStripMenuItem.Text = "Đơn hàng B";
            // 
            // đơnHàngCToolStripMenuItem
            // 
            this.đơnHàngCToolStripMenuItem.Name = "đơnHàngCToolStripMenuItem";
            this.đơnHàngCToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.đơnHàngCToolStripMenuItem.Text = "Đơn hàng C";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thôngTinCáNhânToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.đăngXuấtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(780, 323);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(783, 28);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 424);
            this.vScrollBar1.TabIndex = 3;
            // 
            // DSDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DSDonHang";
            this.Text = "DSDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhSáchĐơnHàngToolStripMenuItem;
        private ToolStripMenuItem đơnHàngAToolStripMenuItem;
        private ToolStripMenuItem đãNhậnToolStripMenuItem;
        private ToolStripMenuItem đãToolStripMenuItem;
        private ToolStripMenuItem đãChuẩnBịXongToolStripMenuItem;
        private ToolStripMenuItem đơnHàngBToolStripMenuItem;
        private ToolStripMenuItem đơnHàngCToolStripMenuItem;
        private ToolStripMenuItem đãNhậnMónToolStripMenuItem;
        private ToolStripMenuItem đangGiaoToolStripMenuItem;
        private ToolStripMenuItem đãGiaoXongToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private PictureBox pictureBox2;
        private VScrollBar vScrollBar1;
    }
}