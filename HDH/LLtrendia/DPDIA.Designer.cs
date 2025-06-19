namespace HDH
{
    partial class DPDIA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart_dpdia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_dpdia_fifo = new System.Windows.Forms.Button();
            this.btn_dpdia_sstf = new System.Windows.Forms.Button();
            this.btn_dpdia_scan = new System.Windows.Forms.Button();
            this.btn_dpdia_cscan = new System.Windows.Forms.Button();
            this.btn_dpdia_rf = new System.Windows.Forms.Button();
            this.dtgv_cylinder = new System.Windows.Forms.DataGridView();
            this.lb_dpdia_add = new System.Windows.Forms.Label();
            this.txt_dpdia_add = new System.Windows.Forms.TextBox();
            this.btn_dpdia_add = new System.Windows.Forms.Button();
            this.cbb_dpdia_chieu = new System.Windows.Forms.ComboBox();
            this.lb_dpdia_chieu = new System.Windows.Forms.Label();
            this.lb_dpdia_gioihan = new System.Windows.Forms.Label();
            this.txt_dpdia_gioihan = new System.Windows.Forms.TextBox();
            this.btn_dpdia_reset = new System.Windows.Forms.Button();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_dpdia_start = new System.Windows.Forms.Label();
            this.txt_dpdia_start = new System.Windows.Forms.TextBox();
            this.btn_dpdia_set = new System.Windows.Forms.Button();
            this.btn_dpdia_clook = new System.Windows.Forms.Button();
            this.btn_dpdia_look = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_dpdia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cylinder)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_dpdia
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_dpdia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_dpdia.Legends.Add(legend1);
            this.chart_dpdia.Location = new System.Drawing.Point(12, 0);
            this.chart_dpdia.Name = "chart_dpdia";
            this.chart_dpdia.Size = new System.Drawing.Size(958, 469);
            this.chart_dpdia.TabIndex = 0;
            this.chart_dpdia.Text = "chart_dpdia";
            // 
            // btn_dpdia_fifo
            // 
            this.btn_dpdia_fifo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_fifo.Location = new System.Drawing.Point(739, 521);
            this.btn_dpdia_fifo.Name = "btn_dpdia_fifo";
            this.btn_dpdia_fifo.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_fifo.TabIndex = 17;
            this.btn_dpdia_fifo.Text = "FIFO";
            this.btn_dpdia_fifo.UseVisualStyleBackColor = true;
            this.btn_dpdia_fifo.Click += new System.EventHandler(this.btn_dpdia_fifo_Click);
            // 
            // btn_dpdia_sstf
            // 
            this.btn_dpdia_sstf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_sstf.Location = new System.Drawing.Point(862, 521);
            this.btn_dpdia_sstf.Name = "btn_dpdia_sstf";
            this.btn_dpdia_sstf.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_sstf.TabIndex = 18;
            this.btn_dpdia_sstf.Text = "SSTF";
            this.btn_dpdia_sstf.UseVisualStyleBackColor = true;
            this.btn_dpdia_sstf.Click += new System.EventHandler(this.btn_dpdia_sstf_Click);
            // 
            // btn_dpdia_scan
            // 
            this.btn_dpdia_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_scan.Location = new System.Drawing.Point(739, 564);
            this.btn_dpdia_scan.Name = "btn_dpdia_scan";
            this.btn_dpdia_scan.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_scan.TabIndex = 19;
            this.btn_dpdia_scan.Text = "SCAN";
            this.btn_dpdia_scan.UseVisualStyleBackColor = true;
            this.btn_dpdia_scan.Click += new System.EventHandler(this.btn_dpdia_scan_Click);
            // 
            // btn_dpdia_cscan
            // 
            this.btn_dpdia_cscan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_cscan.Location = new System.Drawing.Point(862, 564);
            this.btn_dpdia_cscan.Name = "btn_dpdia_cscan";
            this.btn_dpdia_cscan.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_cscan.TabIndex = 20;
            this.btn_dpdia_cscan.Text = "C-SCAN";
            this.btn_dpdia_cscan.UseVisualStyleBackColor = true;
            this.btn_dpdia_cscan.Click += new System.EventHandler(this.btn_dpdia_cscan_Click);
            // 
            // btn_dpdia_rf
            // 
            this.btn_dpdia_rf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_rf.Location = new System.Drawing.Point(476, 521);
            this.btn_dpdia_rf.Name = "btn_dpdia_rf";
            this.btn_dpdia_rf.Size = new System.Drawing.Size(182, 30);
            this.btn_dpdia_rf.TabIndex = 21;
            this.btn_dpdia_rf.Text = "Read file";
            this.btn_dpdia_rf.UseVisualStyleBackColor = true;
            this.btn_dpdia_rf.Click += new System.EventHandler(this.btn_dpdia_rf_Click);
            // 
            // dtgv_cylinder
            // 
            this.dtgv_cylinder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_cylinder.Location = new System.Drawing.Point(103, 475);
            this.dtgv_cylinder.Name = "dtgv_cylinder";
            this.dtgv_cylinder.RowHeadersWidth = 51;
            this.dtgv_cylinder.RowTemplate.Height = 24;
            this.dtgv_cylinder.Size = new System.Drawing.Size(867, 35);
            this.dtgv_cylinder.TabIndex = 22;
            this.dtgv_cylinder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_cylinder_CellEndEdit);
            this.dtgv_cylinder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgv_cylinder_EditingControlShowing_1);
            this.dtgv_cylinder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgv_cylinder_KeyDown);
            // 
            // lb_dpdia_add
            // 
            this.lb_dpdia_add.AutoSize = true;
            this.lb_dpdia_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dpdia_add.Location = new System.Drawing.Point(12, 553);
            this.lb_dpdia_add.Name = "lb_dpdia_add";
            this.lb_dpdia_add.Size = new System.Drawing.Size(116, 20);
            this.lb_dpdia_add.TabIndex = 23;
            this.lb_dpdia_add.Text = "Nhập cylinder:";
            // 
            // txt_dpdia_add
            // 
            this.txt_dpdia_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dpdia_add.Location = new System.Drawing.Point(176, 550);
            this.txt_dpdia_add.Name = "txt_dpdia_add";
            this.txt_dpdia_add.Size = new System.Drawing.Size(107, 27);
            this.txt_dpdia_add.TabIndex = 24;
            // 
            // btn_dpdia_add
            // 
            this.btn_dpdia_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_add.Location = new System.Drawing.Point(310, 548);
            this.btn_dpdia_add.Name = "btn_dpdia_add";
            this.btn_dpdia_add.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_add.TabIndex = 25;
            this.btn_dpdia_add.Text = "ADD";
            this.btn_dpdia_add.UseVisualStyleBackColor = true;
            this.btn_dpdia_add.Click += new System.EventHandler(this.btn_dpdia_add_Click);
            // 
            // cbb_dpdia_chieu
            // 
            this.cbb_dpdia_chieu.FormattingEnabled = true;
            this.cbb_dpdia_chieu.Location = new System.Drawing.Point(312, 586);
            this.cbb_dpdia_chieu.Name = "cbb_dpdia_chieu";
            this.cbb_dpdia_chieu.Size = new System.Drawing.Size(107, 24);
            this.cbb_dpdia_chieu.TabIndex = 26;
            // 
            // lb_dpdia_chieu
            // 
            this.lb_dpdia_chieu.AutoSize = true;
            this.lb_dpdia_chieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dpdia_chieu.Location = new System.Drawing.Point(12, 586);
            this.lb_dpdia_chieu.Name = "lb_dpdia_chieu";
            this.lb_dpdia_chieu.Size = new System.Drawing.Size(265, 20);
            this.lb_dpdia_chieu.TabIndex = 27;
            this.lb_dpdia_chieu.Text = "Chọn hướng chạy (c)scan, (c)look:";
            // 
            // lb_dpdia_gioihan
            // 
            this.lb_dpdia_gioihan.AutoSize = true;
            this.lb_dpdia_gioihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dpdia_gioihan.Location = new System.Drawing.Point(12, 617);
            this.lb_dpdia_gioihan.Name = "lb_dpdia_gioihan";
            this.lb_dpdia_gioihan.Size = new System.Drawing.Size(156, 20);
            this.lb_dpdia_gioihan.TabIndex = 28;
            this.lb_dpdia_gioihan.Text = "Nhập giới hạn chạy:";
            // 
            // txt_dpdia_gioihan
            // 
            this.txt_dpdia_gioihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dpdia_gioihan.Location = new System.Drawing.Point(311, 617);
            this.txt_dpdia_gioihan.Name = "txt_dpdia_gioihan";
            this.txt_dpdia_gioihan.Size = new System.Drawing.Size(107, 27);
            this.txt_dpdia_gioihan.TabIndex = 29;
            this.txt_dpdia_gioihan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dpdia_gioihan_KeyPress);
            // 
            // btn_dpdia_reset
            // 
            this.btn_dpdia_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_reset.Location = new System.Drawing.Point(476, 564);
            this.btn_dpdia_reset.Name = "btn_dpdia_reset";
            this.btn_dpdia_reset.Size = new System.Drawing.Size(182, 30);
            this.btn_dpdia_reset.TabIndex = 30;
            this.btn_dpdia_reset.Text = "RESET";
            this.btn_dpdia_reset.UseVisualStyleBackColor = true;
            this.btn_dpdia_reset.Click += new System.EventHandler(this.btn_dpdia_reset_Click);
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_start.ForeColor = System.Drawing.Color.Red;
            this.lb_start.Location = new System.Drawing.Point(16, 483);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(20, 20);
            this.lb_start.TabIndex = 32;
            this.lb_start.Text = "X";
            // 
            // lb_dpdia_start
            // 
            this.lb_dpdia_start.AutoSize = true;
            this.lb_dpdia_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dpdia_start.Location = new System.Drawing.Point(12, 521);
            this.lb_dpdia_start.Name = "lb_dpdia_start";
            this.lb_dpdia_start.Size = new System.Drawing.Size(83, 20);
            this.lb_dpdia_start.TabIndex = 33;
            this.lb_dpdia_start.Text = "Đổi start :";
            // 
            // txt_dpdia_start
            // 
            this.txt_dpdia_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dpdia_start.Location = new System.Drawing.Point(176, 518);
            this.txt_dpdia_start.Name = "txt_dpdia_start";
            this.txt_dpdia_start.Size = new System.Drawing.Size(107, 27);
            this.txt_dpdia_start.TabIndex = 34;
            this.txt_dpdia_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dpdia_start_KeyPress);
            // 
            // btn_dpdia_set
            // 
            this.btn_dpdia_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_set.Location = new System.Drawing.Point(310, 516);
            this.btn_dpdia_set.Name = "btn_dpdia_set";
            this.btn_dpdia_set.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_set.TabIndex = 35;
            this.btn_dpdia_set.Text = "SET";
            this.btn_dpdia_set.UseVisualStyleBackColor = true;
            this.btn_dpdia_set.Click += new System.EventHandler(this.btn_dpdia_set_Click);
            // 
            // btn_dpdia_clook
            // 
            this.btn_dpdia_clook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_clook.Location = new System.Drawing.Point(862, 607);
            this.btn_dpdia_clook.Name = "btn_dpdia_clook";
            this.btn_dpdia_clook.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_clook.TabIndex = 36;
            this.btn_dpdia_clook.Text = "C-LOOK";
            this.btn_dpdia_clook.UseVisualStyleBackColor = true;
            this.btn_dpdia_clook.Click += new System.EventHandler(this.btn_dpdia_clook_Click);
            // 
            // btn_dpdia_look
            // 
            this.btn_dpdia_look.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dpdia_look.Location = new System.Drawing.Point(739, 607);
            this.btn_dpdia_look.Name = "btn_dpdia_look";
            this.btn_dpdia_look.Size = new System.Drawing.Size(108, 30);
            this.btn_dpdia_look.TabIndex = 37;
            this.btn_dpdia_look.Text = "LOOK";
            this.btn_dpdia_look.UseVisualStyleBackColor = true;
            this.btn_dpdia_look.Click += new System.EventHandler(this.btn_dpdia_look_Click);
            // 
            // DPDIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btn_dpdia_look);
            this.Controls.Add(this.btn_dpdia_clook);
            this.Controls.Add(this.btn_dpdia_rf);
            this.Controls.Add(this.btn_dpdia_sstf);
            this.Controls.Add(this.btn_dpdia_reset);
            this.Controls.Add(this.btn_dpdia_cscan);
            this.Controls.Add(this.btn_dpdia_fifo);
            this.Controls.Add(this.btn_dpdia_scan);
            this.Controls.Add(this.btn_dpdia_set);
            this.Controls.Add(this.txt_dpdia_start);
            this.Controls.Add(this.lb_dpdia_start);
            this.Controls.Add(this.lb_start);
            this.Controls.Add(this.txt_dpdia_gioihan);
            this.Controls.Add(this.lb_dpdia_gioihan);
            this.Controls.Add(this.lb_dpdia_chieu);
            this.Controls.Add(this.cbb_dpdia_chieu);
            this.Controls.Add(this.btn_dpdia_add);
            this.Controls.Add(this.txt_dpdia_add);
            this.Controls.Add(this.lb_dpdia_add);
            this.Controls.Add(this.dtgv_cylinder);
            this.Controls.Add(this.chart_dpdia);
            this.Name = "DPDIA";
            this.Text = "DPDIA";
            this.Load += new System.EventHandler(this.DPDIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_dpdia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cylinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_dpdia;
        private System.Windows.Forms.Button btn_dpdia_fifo;
        private System.Windows.Forms.Button btn_dpdia_sstf;
        private System.Windows.Forms.Button btn_dpdia_scan;
        private System.Windows.Forms.Button btn_dpdia_cscan;
        private System.Windows.Forms.Button btn_dpdia_rf;
        private System.Windows.Forms.DataGridView dtgv_cylinder;
        private System.Windows.Forms.Label lb_dpdia_add;
        private System.Windows.Forms.TextBox txt_dpdia_add;
        private System.Windows.Forms.Button btn_dpdia_add;
        private System.Windows.Forms.ComboBox cbb_dpdia_chieu;
        private System.Windows.Forms.Label lb_dpdia_chieu;
        private System.Windows.Forms.Label lb_dpdia_gioihan;
        private System.Windows.Forms.TextBox txt_dpdia_gioihan;
        private System.Windows.Forms.Button btn_dpdia_reset;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_dpdia_start;
        private System.Windows.Forms.TextBox txt_dpdia_start;
        private System.Windows.Forms.Button btn_dpdia_set;
        private System.Windows.Forms.Button btn_dpdia_clook;
        private System.Windows.Forms.Button btn_dpdia_look;
    }
}