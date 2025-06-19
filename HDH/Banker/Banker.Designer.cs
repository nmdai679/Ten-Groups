namespace HDH
{
    partial class Banker
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
            this.dtgv_bk_max = new System.Windows.Forms.DataGridView();
            this.dtgv_bk_available = new System.Windows.Forms.DataGridView();
            this.lb_bk_allocation = new System.Windows.Forms.Label();
            this.lb_bk_available = new System.Windows.Forms.Label();
            this.dtgv_bk_allocation = new System.Windows.Forms.DataGridView();
            this.lb_bk_max = new System.Windows.Forms.Label();
            this.lb_bk_soprocess = new System.Windows.Forms.Label();
            this.lb_bk_soltn = new System.Windows.Forms.Label();
            this.txt_bk_soltn = new System.Windows.Forms.TextBox();
            this.txt_bk_soprocess = new System.Windows.Forms.TextBox();
            this.btn_bk_load = new System.Windows.Forms.Button();
            this.btn_bk_ktcat = new System.Windows.Forms.Button();
            this.btn_bk_df = new System.Windows.Forms.Button();
            this.cbb_bk_gtcptnpc = new System.Windows.Forms.ComboBox();
            this.pn_bk_gtcptn = new System.Windows.Forms.Panel();
            this.lb_bk_gtcptn = new System.Windows.Forms.Label();
            this.btn_bk_run = new System.Windows.Forms.Button();
            this.txt_bk_gtcptnyc = new System.Windows.Forms.TextBox();
            this.lb_bk_gtcptnyc = new System.Windows.Forms.Label();
            this.lb_bk_gtcptnpc = new System.Windows.Forms.Label();
            this.pn_bk_input = new System.Windows.Forms.Panel();
            this.btn_bk_ktdl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bk_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bk_available)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bk_allocation)).BeginInit();
            this.pn_bk_gtcptn.SuspendLayout();
            this.pn_bk_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_bk_max
            // 
            this.dtgv_bk_max.AllowUserToAddRows = false;
            this.dtgv_bk_max.AllowUserToDeleteRows = false;
            this.dtgv_bk_max.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_bk_max.Location = new System.Drawing.Point(675, 41);
            this.dtgv_bk_max.Name = "dtgv_bk_max";
            this.dtgv_bk_max.ReadOnly = true;
            this.dtgv_bk_max.RowHeadersWidth = 51;
            this.dtgv_bk_max.RowTemplate.Height = 24;
            this.dtgv_bk_max.Size = new System.Drawing.Size(295, 600);
            this.dtgv_bk_max.TabIndex = 1;
            this.dtgv_bk_max.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_bk_max_CellEndEdit);
            this.dtgv_bk_max.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dtgv_EditingControlShowing);
            // 
            // dtgv_bk_available
            // 
            this.dtgv_bk_available.AllowUserToAddRows = false;
            this.dtgv_bk_available.AllowUserToDeleteRows = false;
            this.dtgv_bk_available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_bk_available.Location = new System.Drawing.Point(12, 41);
            this.dtgv_bk_available.Name = "dtgv_bk_available";
            this.dtgv_bk_available.ReadOnly = true;
            this.dtgv_bk_available.RowHeadersWidth = 51;
            this.dtgv_bk_available.RowTemplate.Height = 24;
            this.dtgv_bk_available.Size = new System.Drawing.Size(302, 75);
            this.dtgv_bk_available.TabIndex = 2;
            this.dtgv_bk_available.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_bk_available_CellEndEdit);
            this.dtgv_bk_available.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dtgv_EditingControlShowing);
            // 
            // lb_bk_allocation
            // 
            this.lb_bk_allocation.AutoSize = true;
            this.lb_bk_allocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_allocation.Location = new System.Drawing.Point(447, 9);
            this.lb_bk_allocation.Name = "lb_bk_allocation";
            this.lb_bk_allocation.Size = new System.Drawing.Size(82, 20);
            this.lb_bk_allocation.TabIndex = 5;
            this.lb_bk_allocation.Text = "Allocation";
            // 
            // lb_bk_available
            // 
            this.lb_bk_available.AutoSize = true;
            this.lb_bk_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_available.Location = new System.Drawing.Point(114, 9);
            this.lb_bk_available.Name = "lb_bk_available";
            this.lb_bk_available.Size = new System.Drawing.Size(76, 20);
            this.lb_bk_available.TabIndex = 7;
            this.lb_bk_available.Text = "Available";
            // 
            // dtgv_bk_allocation
            // 
            this.dtgv_bk_allocation.AllowUserToAddRows = false;
            this.dtgv_bk_allocation.AllowUserToDeleteRows = false;
            this.dtgv_bk_allocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_bk_allocation.Location = new System.Drawing.Point(320, 41);
            this.dtgv_bk_allocation.Name = "dtgv_bk_allocation";
            this.dtgv_bk_allocation.ReadOnly = true;
            this.dtgv_bk_allocation.RowHeadersWidth = 51;
            this.dtgv_bk_allocation.RowTemplate.Height = 24;
            this.dtgv_bk_allocation.Size = new System.Drawing.Size(339, 600);
            this.dtgv_bk_allocation.TabIndex = 8;
            this.dtgv_bk_allocation.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_bk_allocation_CellEndEdit);
            this.dtgv_bk_allocation.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dtgv_EditingControlShowing);
            // 
            // lb_bk_max
            // 
            this.lb_bk_max.AutoSize = true;
            this.lb_bk_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_max.Location = new System.Drawing.Point(812, 9);
            this.lb_bk_max.Name = "lb_bk_max";
            this.lb_bk_max.Size = new System.Drawing.Size(40, 20);
            this.lb_bk_max.TabIndex = 9;
            this.lb_bk_max.Text = "Max";
            // 
            // lb_bk_soprocess
            // 
            this.lb_bk_soprocess.AutoSize = true;
            this.lb_bk_soprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_soprocess.Location = new System.Drawing.Point(3, 9);
            this.lb_bk_soprocess.Name = "lb_bk_soprocess";
            this.lb_bk_soprocess.Size = new System.Drawing.Size(99, 20);
            this.lb_bk_soprocess.TabIndex = 10;
            this.lb_bk_soprocess.Text = "Số process:";
            // 
            // lb_bk_soltn
            // 
            this.lb_bk_soltn.AutoSize = true;
            this.lb_bk_soltn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_soltn.Location = new System.Drawing.Point(3, 37);
            this.lb_bk_soltn.Name = "lb_bk_soltn";
            this.lb_bk_soltn.Size = new System.Drawing.Size(146, 20);
            this.lb_bk_soltn.TabIndex = 11;
            this.lb_bk_soltn.Text = "Số loại tài nguyên:";
            // 
            // txt_bk_soltn
            // 
            this.txt_bk_soltn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_soltn.Location = new System.Drawing.Point(177, 34);
            this.txt_bk_soltn.Name = "txt_bk_soltn";
            this.txt_bk_soltn.Size = new System.Drawing.Size(45, 27);
            this.txt_bk_soltn.TabIndex = 12;
            this.txt_bk_soltn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bk_soltn_KeyPress);
            // 
            // txt_bk_soprocess
            // 
            this.txt_bk_soprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_soprocess.Location = new System.Drawing.Point(177, 6);
            this.txt_bk_soprocess.Name = "txt_bk_soprocess";
            this.txt_bk_soprocess.Size = new System.Drawing.Size(45, 27);
            this.txt_bk_soprocess.TabIndex = 13;
            this.txt_bk_soprocess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bk_soprocess_KeyPress);
            // 
            // btn_bk_load
            // 
            this.btn_bk_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bk_load.Location = new System.Drawing.Point(228, 9);
            this.btn_bk_load.Name = "btn_bk_load";
            this.btn_bk_load.Size = new System.Drawing.Size(71, 56);
            this.btn_bk_load.TabIndex = 14;
            this.btn_bk_load.Text = "Load";
            this.btn_bk_load.UseVisualStyleBackColor = true;
            this.btn_bk_load.Click += new System.EventHandler(this.btn_bk_load_Click);
            // 
            // btn_bk_ktcat
            // 
            this.btn_bk_ktcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bk_ktcat.Location = new System.Drawing.Point(9, 557);
            this.btn_bk_ktcat.Name = "btn_bk_ktcat";
            this.btn_bk_ktcat.Size = new System.Drawing.Size(302, 39);
            this.btn_bk_ktcat.TabIndex = 15;
            this.btn_bk_ktcat.Text = "Kiểm tra chuỗi an toàn";
            this.btn_bk_ktcat.UseVisualStyleBackColor = true;
            this.btn_bk_ktcat.Click += new System.EventHandler(this.btn_bk_ktcat_Click);
            // 
            // btn_bk_df
            // 
            this.btn_bk_df.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bk_df.Location = new System.Drawing.Point(9, 512);
            this.btn_bk_df.Name = "btn_bk_df";
            this.btn_bk_df.Size = new System.Drawing.Size(302, 39);
            this.btn_bk_df.TabIndex = 16;
            this.btn_bk_df.Text = "Đọc file";
            this.btn_bk_df.UseVisualStyleBackColor = true;
            this.btn_bk_df.Click += new System.EventHandler(this.btn_bk_df_Click);
            // 
            // cbb_bk_gtcptnpc
            // 
            this.cbb_bk_gtcptnpc.FormattingEnabled = true;
            this.cbb_bk_gtcptnpc.Location = new System.Drawing.Point(125, 51);
            this.cbb_bk_gtcptnpc.Name = "cbb_bk_gtcptnpc";
            this.cbb_bk_gtcptnpc.Size = new System.Drawing.Size(172, 24);
            this.cbb_bk_gtcptnpc.TabIndex = 17;
            // 
            // pn_bk_gtcptn
            // 
            this.pn_bk_gtcptn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_bk_gtcptn.Controls.Add(this.lb_bk_gtcptn);
            this.pn_bk_gtcptn.Controls.Add(this.btn_bk_run);
            this.pn_bk_gtcptn.Controls.Add(this.txt_bk_gtcptnyc);
            this.pn_bk_gtcptn.Controls.Add(this.lb_bk_gtcptnyc);
            this.pn_bk_gtcptn.Controls.Add(this.lb_bk_gtcptnpc);
            this.pn_bk_gtcptn.Controls.Add(this.cbb_bk_gtcptnpc);
            this.pn_bk_gtcptn.Location = new System.Drawing.Point(12, 218);
            this.pn_bk_gtcptn.Name = "pn_bk_gtcptn";
            this.pn_bk_gtcptn.Size = new System.Drawing.Size(300, 159);
            this.pn_bk_gtcptn.TabIndex = 18;
            // 
            // lb_bk_gtcptn
            // 
            this.lb_bk_gtcptn.AutoSize = true;
            this.lb_bk_gtcptn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_gtcptn.Location = new System.Drawing.Point(27, 15);
            this.lb_bk_gtcptn.Name = "lb_bk_gtcptn";
            this.lb_bk_gtcptn.Size = new System.Drawing.Size(231, 20);
            this.lb_bk_gtcptn.TabIndex = 15;
            this.lb_bk_gtcptn.Text = "Giải thuật cấp phát tài nguyên";
            // 
            // btn_bk_run
            // 
            this.btn_bk_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bk_run.Location = new System.Drawing.Point(169, 114);
            this.btn_bk_run.Name = "btn_bk_run";
            this.btn_bk_run.Size = new System.Drawing.Size(128, 39);
            this.btn_bk_run.TabIndex = 19;
            this.btn_bk_run.Text = "Run";
            this.btn_bk_run.UseVisualStyleBackColor = true;
            this.btn_bk_run.Click += new System.EventHandler(this.btn_bk_run_Click);
            // 
            // txt_bk_gtcptnyc
            // 
            this.txt_bk_gtcptnyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_gtcptnyc.Location = new System.Drawing.Point(125, 81);
            this.txt_bk_gtcptnyc.Name = "txt_bk_gtcptnyc";
            this.txt_bk_gtcptnyc.Size = new System.Drawing.Size(172, 27);
            this.txt_bk_gtcptnyc.TabIndex = 19;
            // 
            // lb_bk_gtcptnyc
            // 
            this.lb_bk_gtcptnyc.AutoSize = true;
            this.lb_bk_gtcptnyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_gtcptnyc.Location = new System.Drawing.Point(3, 84);
            this.lb_bk_gtcptnyc.Name = "lb_bk_gtcptnyc";
            this.lb_bk_gtcptnyc.Size = new System.Drawing.Size(74, 20);
            this.lb_bk_gtcptnyc.TabIndex = 20;
            this.lb_bk_gtcptnyc.Text = "Yêu cầu:";
            // 
            // lb_bk_gtcptnpc
            // 
            this.lb_bk_gtcptnpc.AutoSize = true;
            this.lb_bk_gtcptnpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bk_gtcptnpc.Location = new System.Drawing.Point(3, 50);
            this.lb_bk_gtcptnpc.Name = "lb_bk_gtcptnpc";
            this.lb_bk_gtcptnpc.Size = new System.Drawing.Size(76, 20);
            this.lb_bk_gtcptnpc.TabIndex = 19;
            this.lb_bk_gtcptnpc.Text = "Process:";
            // 
            // pn_bk_input
            // 
            this.pn_bk_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_bk_input.Controls.Add(this.lb_bk_soprocess);
            this.pn_bk_input.Controls.Add(this.lb_bk_soltn);
            this.pn_bk_input.Controls.Add(this.btn_bk_load);
            this.pn_bk_input.Controls.Add(this.txt_bk_soprocess);
            this.pn_bk_input.Controls.Add(this.txt_bk_soltn);
            this.pn_bk_input.Location = new System.Drawing.Point(12, 122);
            this.pn_bk_input.Name = "pn_bk_input";
            this.pn_bk_input.Size = new System.Drawing.Size(302, 76);
            this.pn_bk_input.TabIndex = 19;
            // 
            // btn_bk_ktdl
            // 
            this.btn_bk_ktdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bk_ktdl.Location = new System.Drawing.Point(9, 602);
            this.btn_bk_ktdl.Name = "btn_bk_ktdl";
            this.btn_bk_ktdl.Size = new System.Drawing.Size(302, 39);
            this.btn_bk_ktdl.TabIndex = 20;
            this.btn_bk_ktdl.Text = "Kiểm tra deadlook";
            this.btn_bk_ktdl.UseVisualStyleBackColor = true;
            this.btn_bk_ktdl.Click += new System.EventHandler(this.btn_bk_ktdl_Click);
            // 
            // Banker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btn_bk_ktdl);
            this.Controls.Add(this.pn_bk_input);
            this.Controls.Add(this.pn_bk_gtcptn);
            this.Controls.Add(this.btn_bk_df);
            this.Controls.Add(this.btn_bk_ktcat);
            this.Controls.Add(this.lb_bk_max);
            this.Controls.Add(this.dtgv_bk_allocation);
            this.Controls.Add(this.lb_bk_available);
            this.Controls.Add(this.lb_bk_allocation);
            this.Controls.Add(this.dtgv_bk_available);
            this.Controls.Add(this.dtgv_bk_max);
            this.Name = "Banker";
            this.Text = "Banker";
            this.Load += new System.EventHandler(this.Banker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bk_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bk_available)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bk_allocation)).EndInit();
            this.pn_bk_gtcptn.ResumeLayout(false);
            this.pn_bk_gtcptn.PerformLayout();
            this.pn_bk_input.ResumeLayout(false);
            this.pn_bk_input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_bk_max;
        private System.Windows.Forms.DataGridView dtgv_bk_available;
        private System.Windows.Forms.Label lb_bk_allocation;
        private System.Windows.Forms.Label lb_bk_available;
        private System.Windows.Forms.DataGridView dtgv_bk_allocation;
        private System.Windows.Forms.Label lb_bk_max;
        private System.Windows.Forms.Label lb_bk_soprocess;
        private System.Windows.Forms.Label lb_bk_soltn;
        private System.Windows.Forms.TextBox txt_bk_soltn;
        private System.Windows.Forms.TextBox txt_bk_soprocess;
        private System.Windows.Forms.Button btn_bk_load;
        private System.Windows.Forms.Button btn_bk_ktcat;
        private System.Windows.Forms.Button btn_bk_df;
        private System.Windows.Forms.ComboBox cbb_bk_gtcptnpc;
        private System.Windows.Forms.Panel pn_bk_gtcptn;
        private System.Windows.Forms.Button btn_bk_run;
        private System.Windows.Forms.TextBox txt_bk_gtcptnyc;
        private System.Windows.Forms.Label lb_bk_gtcptnyc;
        private System.Windows.Forms.Label lb_bk_gtcptnpc;
        private System.Windows.Forms.Panel pn_bk_input;
        private System.Windows.Forms.Button btn_bk_ktdl;
        private System.Windows.Forms.Label lb_bk_gtcptn;
    }
}