namespace HDH
{
    partial class PPCPU
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
            this.ppcpu_dtgv = new System.Windows.Forms.DataGridView();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_ppcpu_chucnangprocess = new System.Windows.Forms.Panel();
            this.txt_ppcpu_bursttime = new System.Windows.Forms.TextBox();
            this.txt_ppcpu_arrivingtime = new System.Windows.Forms.TextBox();
            this.lb_ppcpu_bursttime = new System.Windows.Forms.Label();
            this.lb_ppcpu_arrivingtime = new System.Windows.Forms.Label();
            this.lb_ppcpu_nameprocess = new System.Windows.Forms.Label();
            this.txt_ppcpu_nameprocess = new System.Windows.Forms.TextBox();
            this.btn_ppcup_delete = new System.Windows.Forms.Button();
            this.btn_ppcup_add = new System.Windows.Forms.Button();
            this.pn_ppcpu_GianDoGantt = new System.Windows.Forms.Panel();
            this.btn_PPCPU_FCFS = new System.Windows.Forms.Button();
            this.btn_PPCPU_SJF = new System.Windows.Forms.Button();
            this.btn_PPCPU_SRTF = new System.Windows.Forms.Button();
            this.btn_PPCPU_RR = new System.Windows.Forms.Button();
            this.lb_ppcpu_AVGWT = new System.Windows.Forms.Label();
            this.lb_ppcpu_AVGTAT = new System.Windows.Forms.Label();
            this.lb_ppcpu_Thongnang = new System.Windows.Forms.Label();
            this.lb_ppcpu_loai = new System.Windows.Forms.Label();
            this.btn_ppcpu_ss = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ppcpu_dtgv)).BeginInit();
            this.pn_ppcpu_chucnangprocess.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ppcpu_dtgv
            // 
            this.ppcpu_dtgv.AllowUserToAddRows = false;
            this.ppcpu_dtgv.AllowUserToDeleteRows = false;
            this.ppcpu_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ppcpu_dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN,
            this.AT,
            this.BT,
            this.WT,
            this.TAT});
            this.ppcpu_dtgv.Location = new System.Drawing.Point(319, 12);
            this.ppcpu_dtgv.Name = "ppcpu_dtgv";
            this.ppcpu_dtgv.ReadOnly = true;
            this.ppcpu_dtgv.RowHeadersWidth = 51;
            this.ppcpu_dtgv.RowTemplate.Height = 24;
            this.ppcpu_dtgv.Size = new System.Drawing.Size(651, 394);
            this.ppcpu_dtgv.TabIndex = 0;
            this.ppcpu_dtgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ppcpu_dtgv_CellBeginEdit);
            this.ppcpu_dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ppcpu_dtgv_CellClick);
            this.ppcpu_dtgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ppcpu_dtgv_CellEndEdit);
            this.ppcpu_dtgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ppcpu_dtgv_EditingControlShowing);
            // 
            // TEN
            // 
            this.TEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN.HeaderText = "Name process";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // AT
            // 
            this.AT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AT.HeaderText = "Arriving Time";
            this.AT.MinimumWidth = 6;
            this.AT.Name = "AT";
            this.AT.ReadOnly = true;
            // 
            // BT
            // 
            this.BT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BT.HeaderText = "Burst Time";
            this.BT.MinimumWidth = 6;
            this.BT.Name = "BT";
            this.BT.ReadOnly = true;
            // 
            // WT
            // 
            this.WT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WT.HeaderText = "Waiting Time";
            this.WT.MinimumWidth = 6;
            this.WT.Name = "WT";
            this.WT.ReadOnly = true;
            // 
            // TAT
            // 
            this.TAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TAT.HeaderText = "Turnaround Time";
            this.TAT.MinimumWidth = 6;
            this.TAT.Name = "TAT";
            this.TAT.ReadOnly = true;
            // 
            // pn_ppcpu_chucnangprocess
            // 
            this.pn_ppcpu_chucnangprocess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.txt_ppcpu_bursttime);
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.txt_ppcpu_arrivingtime);
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.lb_ppcpu_bursttime);
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.lb_ppcpu_arrivingtime);
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.lb_ppcpu_nameprocess);
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.txt_ppcpu_nameprocess);
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.btn_ppcup_delete);
            this.pn_ppcpu_chucnangprocess.Controls.Add(this.btn_ppcup_add);
            this.pn_ppcpu_chucnangprocess.Location = new System.Drawing.Point(12, 12);
            this.pn_ppcpu_chucnangprocess.Name = "pn_ppcpu_chucnangprocess";
            this.pn_ppcpu_chucnangprocess.Size = new System.Drawing.Size(301, 198);
            this.pn_ppcpu_chucnangprocess.TabIndex = 7;
            this.pn_ppcpu_chucnangprocess.Tag = "";
            // 
            // txt_ppcpu_bursttime
            // 
            this.txt_ppcpu_bursttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ppcpu_bursttime.Location = new System.Drawing.Point(166, 96);
            this.txt_ppcpu_bursttime.Name = "txt_ppcpu_bursttime";
            this.txt_ppcpu_bursttime.Size = new System.Drawing.Size(107, 27);
            this.txt_ppcpu_bursttime.TabIndex = 8;
            this.txt_ppcpu_bursttime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ppcpu_bursttime_KeyPress);
            // 
            // txt_ppcpu_arrivingtime
            // 
            this.txt_ppcpu_arrivingtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ppcpu_arrivingtime.Location = new System.Drawing.Point(166, 50);
            this.txt_ppcpu_arrivingtime.Name = "txt_ppcpu_arrivingtime";
            this.txt_ppcpu_arrivingtime.Size = new System.Drawing.Size(107, 27);
            this.txt_ppcpu_arrivingtime.TabIndex = 7;
            this.txt_ppcpu_arrivingtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ppcpu_arrivingtime_KeyPress);
            // 
            // lb_ppcpu_bursttime
            // 
            this.lb_ppcpu_bursttime.AutoSize = true;
            this.lb_ppcpu_bursttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ppcpu_bursttime.Location = new System.Drawing.Point(12, 99);
            this.lb_ppcpu_bursttime.Name = "lb_ppcpu_bursttime";
            this.lb_ppcpu_bursttime.Size = new System.Drawing.Size(92, 20);
            this.lb_ppcpu_bursttime.TabIndex = 6;
            this.lb_ppcpu_bursttime.Text = "Burst time:";
            // 
            // lb_ppcpu_arrivingtime
            // 
            this.lb_ppcpu_arrivingtime.AutoSize = true;
            this.lb_ppcpu_arrivingtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ppcpu_arrivingtime.Location = new System.Drawing.Point(12, 53);
            this.lb_ppcpu_arrivingtime.Name = "lb_ppcpu_arrivingtime";
            this.lb_ppcpu_arrivingtime.Size = new System.Drawing.Size(108, 20);
            this.lb_ppcpu_arrivingtime.TabIndex = 5;
            this.lb_ppcpu_arrivingtime.Text = "Arriving time:";
            // 
            // lb_ppcpu_nameprocess
            // 
            this.lb_ppcpu_nameprocess.AutoSize = true;
            this.lb_ppcpu_nameprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ppcpu_nameprocess.Location = new System.Drawing.Point(12, 9);
            this.lb_ppcpu_nameprocess.Name = "lb_ppcpu_nameprocess";
            this.lb_ppcpu_nameprocess.Size = new System.Drawing.Size(123, 20);
            this.lb_ppcpu_nameprocess.TabIndex = 4;
            this.lb_ppcpu_nameprocess.Text = "Name process:";
            // 
            // txt_ppcpu_nameprocess
            // 
            this.txt_ppcpu_nameprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ppcpu_nameprocess.Location = new System.Drawing.Point(166, 9);
            this.txt_ppcpu_nameprocess.Name = "txt_ppcpu_nameprocess";
            this.txt_ppcpu_nameprocess.Size = new System.Drawing.Size(107, 27);
            this.txt_ppcpu_nameprocess.TabIndex = 3;
            // 
            // btn_ppcup_delete
            // 
            this.btn_ppcup_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ppcup_delete.Location = new System.Drawing.Point(166, 145);
            this.btn_ppcup_delete.Name = "btn_ppcup_delete";
            this.btn_ppcup_delete.Size = new System.Drawing.Size(101, 30);
            this.btn_ppcup_delete.TabIndex = 2;
            this.btn_ppcup_delete.Text = "Delete";
            this.btn_ppcup_delete.UseVisualStyleBackColor = true;
            this.btn_ppcup_delete.Click += new System.EventHandler(this.btn_ppcup_delete_Click);
            // 
            // btn_ppcup_add
            // 
            this.btn_ppcup_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ppcup_add.Location = new System.Drawing.Point(16, 145);
            this.btn_ppcup_add.Name = "btn_ppcup_add";
            this.btn_ppcup_add.Size = new System.Drawing.Size(108, 30);
            this.btn_ppcup_add.TabIndex = 1;
            this.btn_ppcup_add.Text = "Add";
            this.btn_ppcup_add.UseVisualStyleBackColor = true;
            this.btn_ppcup_add.Click += new System.EventHandler(this.btn_ppcup_add_Click);
            // 
            // pn_ppcpu_GianDoGantt
            // 
            this.pn_ppcpu_GianDoGantt.AutoScroll = true;
            this.pn_ppcpu_GianDoGantt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ppcpu_GianDoGantt.Location = new System.Drawing.Point(12, 426);
            this.pn_ppcpu_GianDoGantt.Name = "pn_ppcpu_GianDoGantt";
            this.pn_ppcpu_GianDoGantt.Size = new System.Drawing.Size(958, 180);
            this.pn_ppcpu_GianDoGantt.TabIndex = 8;
            // 
            // btn_PPCPU_FCFS
            // 
            this.btn_PPCPU_FCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PPCPU_FCFS.Location = new System.Drawing.Point(16, 12);
            this.btn_PPCPU_FCFS.Name = "btn_PPCPU_FCFS";
            this.btn_PPCPU_FCFS.Size = new System.Drawing.Size(124, 49);
            this.btn_PPCPU_FCFS.TabIndex = 9;
            this.btn_PPCPU_FCFS.Text = "FCFS";
            this.btn_PPCPU_FCFS.UseVisualStyleBackColor = true;
            this.btn_PPCPU_FCFS.Click += new System.EventHandler(this.btn_PPCPU_FCFS_Click);
            // 
            // btn_PPCPU_SJF
            // 
            this.btn_PPCPU_SJF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PPCPU_SJF.Location = new System.Drawing.Point(16, 75);
            this.btn_PPCPU_SJF.Name = "btn_PPCPU_SJF";
            this.btn_PPCPU_SJF.Size = new System.Drawing.Size(124, 49);
            this.btn_PPCPU_SJF.TabIndex = 10;
            this.btn_PPCPU_SJF.Text = "SJF";
            this.btn_PPCPU_SJF.UseVisualStyleBackColor = true;
            this.btn_PPCPU_SJF.Click += new System.EventHandler(this.btn_PPCPU_SJF_Click);
            // 
            // btn_PPCPU_SRTF
            // 
            this.btn_PPCPU_SRTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PPCPU_SRTF.Location = new System.Drawing.Point(159, 12);
            this.btn_PPCPU_SRTF.Name = "btn_PPCPU_SRTF";
            this.btn_PPCPU_SRTF.Size = new System.Drawing.Size(124, 49);
            this.btn_PPCPU_SRTF.TabIndex = 11;
            this.btn_PPCPU_SRTF.Text = "SRTF";
            this.btn_PPCPU_SRTF.UseVisualStyleBackColor = true;
            this.btn_PPCPU_SRTF.Click += new System.EventHandler(this.btn_PPCPU_SRTF_Click);
            // 
            // btn_PPCPU_RR
            // 
            this.btn_PPCPU_RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PPCPU_RR.Location = new System.Drawing.Point(159, 75);
            this.btn_PPCPU_RR.Name = "btn_PPCPU_RR";
            this.btn_PPCPU_RR.Size = new System.Drawing.Size(124, 49);
            this.btn_PPCPU_RR.TabIndex = 12;
            this.btn_PPCPU_RR.Text = "RR";
            this.btn_PPCPU_RR.UseVisualStyleBackColor = true;
            this.btn_PPCPU_RR.Click += new System.EventHandler(this.btn_PPCPU_RR_Click);
            // 
            // lb_ppcpu_AVGWT
            // 
            this.lb_ppcpu_AVGWT.AutoSize = true;
            this.lb_ppcpu_AVGWT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ppcpu_AVGWT.Location = new System.Drawing.Point(261, 624);
            this.lb_ppcpu_AVGWT.Name = "lb_ppcpu_AVGWT";
            this.lb_ppcpu_AVGWT.Size = new System.Drawing.Size(80, 20);
            this.lb_ppcpu_AVGWT.TabIndex = 9;
            this.lb_ppcpu_AVGWT.Text = "AVG WT:";
            // 
            // lb_ppcpu_AVGTAT
            // 
            this.lb_ppcpu_AVGTAT.AutoSize = true;
            this.lb_ppcpu_AVGTAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ppcpu_AVGTAT.Location = new System.Drawing.Point(514, 624);
            this.lb_ppcpu_AVGTAT.Name = "lb_ppcpu_AVGTAT";
            this.lb_ppcpu_AVGTAT.Size = new System.Drawing.Size(85, 20);
            this.lb_ppcpu_AVGTAT.TabIndex = 10;
            this.lb_ppcpu_AVGTAT.Text = "AVG TAT:";
            // 
            // lb_ppcpu_Thongnang
            // 
            this.lb_ppcpu_Thongnang.AutoSize = true;
            this.lb_ppcpu_Thongnang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ppcpu_Thongnang.Location = new System.Drawing.Point(760, 624);
            this.lb_ppcpu_Thongnang.Name = "lb_ppcpu_Thongnang";
            this.lb_ppcpu_Thongnang.Size = new System.Drawing.Size(101, 20);
            this.lb_ppcpu_Thongnang.TabIndex = 11;
            this.lb_ppcpu_Thongnang.Text = "Thông năng:";
            // 
            // lb_ppcpu_loai
            // 
            this.lb_ppcpu_loai.AutoSize = true;
            this.lb_ppcpu_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ppcpu_loai.Location = new System.Drawing.Point(8, 624);
            this.lb_ppcpu_loai.Name = "lb_ppcpu_loai";
            this.lb_ppcpu_loai.Size = new System.Drawing.Size(46, 20);
            this.lb_ppcpu_loai.TabIndex = 9;
            this.lb_ppcpu_loai.Text = "Loai:";
            // 
            // btn_ppcpu_ss
            // 
            this.btn_ppcpu_ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ppcpu_ss.Location = new System.Drawing.Point(16, 134);
            this.btn_ppcpu_ss.Name = "btn_ppcpu_ss";
            this.btn_ppcpu_ss.Size = new System.Drawing.Size(267, 41);
            this.btn_ppcpu_ss.TabIndex = 13;
            this.btn_ppcpu_ss.Text = "SS";
            this.btn_ppcpu_ss.UseVisualStyleBackColor = true;
            this.btn_ppcpu_ss.Click += new System.EventHandler(this.btn_ppcpu_ss_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_PPCPU_SJF);
            this.panel2.Controls.Add(this.btn_PPCPU_FCFS);
            this.panel2.Controls.Add(this.btn_ppcpu_ss);
            this.panel2.Controls.Add(this.btn_PPCPU_SRTF);
            this.panel2.Controls.Add(this.btn_PPCPU_RR);
            this.panel2.Location = new System.Drawing.Point(12, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 184);
            this.panel2.TabIndex = 14;
            // 
            // PPCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_ppcpu_loai);
            this.Controls.Add(this.lb_ppcpu_AVGWT);
            this.Controls.Add(this.lb_ppcpu_AVGTAT);
            this.Controls.Add(this.lb_ppcpu_Thongnang);
            this.Controls.Add(this.pn_ppcpu_GianDoGantt);
            this.Controls.Add(this.pn_ppcpu_chucnangprocess);
            this.Controls.Add(this.ppcpu_dtgv);
            this.Name = "PPCPU";
            this.Text = "Phan phoi CPU";
            this.Load += new System.EventHandler(this.Xinchao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ppcpu_dtgv)).EndInit();
            this.pn_ppcpu_chucnangprocess.ResumeLayout(false);
            this.pn_ppcpu_chucnangprocess.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ppcpu_dtgv;
        private System.Windows.Forms.Panel pn_ppcpu_chucnangprocess;
        private System.Windows.Forms.TextBox txt_ppcpu_bursttime;
        private System.Windows.Forms.TextBox txt_ppcpu_arrivingtime;
        private System.Windows.Forms.Label lb_ppcpu_bursttime;
        private System.Windows.Forms.Label lb_ppcpu_arrivingtime;
        private System.Windows.Forms.Label lb_ppcpu_nameprocess;
        private System.Windows.Forms.TextBox txt_ppcpu_nameprocess;
        private System.Windows.Forms.Button btn_ppcup_delete;
        private System.Windows.Forms.Button btn_ppcup_add;
        private System.Windows.Forms.Panel pn_ppcpu_GianDoGantt;
        private System.Windows.Forms.Button btn_PPCPU_FCFS;
        private System.Windows.Forms.Button btn_PPCPU_SJF;
        private System.Windows.Forms.Button btn_PPCPU_SRTF;
        private System.Windows.Forms.Button btn_PPCPU_RR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAT;
        private System.Windows.Forms.Label lb_ppcpu_AVGWT;
        private System.Windows.Forms.Label lb_ppcpu_AVGTAT;
        private System.Windows.Forms.Label lb_ppcpu_Thongnang;
        private System.Windows.Forms.Label lb_ppcpu_loai;
        private System.Windows.Forms.Button btn_ppcpu_ss;
        private System.Windows.Forms.Panel panel2;
    }
}