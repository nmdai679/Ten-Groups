namespace HDH
{
    partial class Home
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
            this.Home_panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayThếTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điềuPhốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_ntn = new System.Windows.Forms.Label();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home_panel
            // 
            this.Home_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Home_panel.Location = new System.Drawing.Point(12, 31);
            this.Home_panel.Name = "Home_panel";
            this.Home_panel.Size = new System.Drawing.Size(977, 650);
            this.Home_panel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.pPCPUToolStripMenuItem,
            this.thayThếTrangToolStripMenuItem,
            this.bankerToolStripMenuItem,
            this.điềuPhốiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // pPCPUToolStripMenuItem
            // 
            this.pPCPUToolStripMenuItem.Name = "pPCPUToolStripMenuItem";
            this.pPCPUToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.pPCPUToolStripMenuItem.Text = "Điều phối tiến trình";
            this.pPCPUToolStripMenuItem.Click += new System.EventHandler(this.pPCPUToolStripMenuItem_Click);
            // 
            // thayThếTrangToolStripMenuItem
            // 
            this.thayThếTrangToolStripMenuItem.Name = "thayThếTrangToolStripMenuItem";
            this.thayThếTrangToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.thayThếTrangToolStripMenuItem.Text = "Thay thế trang";
            this.thayThếTrangToolStripMenuItem.Click += new System.EventHandler(this.thayThếTrangToolStripMenuItem_Click);
            // 
            // bankerToolStripMenuItem
            // 
            this.bankerToolStripMenuItem.Name = "bankerToolStripMenuItem";
            this.bankerToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.bankerToolStripMenuItem.Text = "Banker";
            this.bankerToolStripMenuItem.Click += new System.EventHandler(this.bankerToolStripMenuItem_Click);
            // 
            // điềuPhốiToolStripMenuItem
            // 
            this.điềuPhốiToolStripMenuItem.Name = "điềuPhốiToolStripMenuItem";
            this.điềuPhốiToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.điềuPhốiToolStripMenuItem.Text = "Điều phối đĩa";
            this.điềuPhốiToolStripMenuItem.Click += new System.EventHandler(this.điềuPhốiToolStripMenuItem_Click);
            // 
            // lb_ntn
            // 
            this.lb_ntn.AutoSize = true;
            this.lb_ntn.Location = new System.Drawing.Point(711, 686);
            this.lb_ntn.Name = "lb_ntn";
            this.lb_ntn.Size = new System.Drawing.Size(16, 16);
            this.lb_ntn.TabIndex = 2;
            this.lb_ntn.Text = "...";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(995, 708);
            this.Controls.Add(this.lb_ntn);
            this.Controls.Add(this.Home_panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xin chào!";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Home_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPCPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayThếTrangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankerToolStripMenuItem;
        private System.Windows.Forms.Label lb_ntn;
        private System.Windows.Forms.ToolStripMenuItem điềuPhốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
    }
}

