namespace HDH
{
    partial class ReplacePage
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
            this.pn_repa_vungthuchien = new System.Windows.Forms.Panel();
            this.btn_repa_readfile = new System.Windows.Forms.Button();
            this.btn_repa_opt = new System.Windows.Forms.Button();
            this.btn_repa_lru = new System.Windows.Forms.Button();
            this.btn_repa_fifo = new System.Windows.Forms.Button();
            this.btn_repa_clock = new System.Windows.Forms.Button();
            this.dtgv_repa = new System.Windows.Forms.DataGridView();
            this.btn_repa_ss = new System.Windows.Forms.Button();
            this.btn_repa_add = new System.Windows.Forms.Button();
            this.txt_repa_add = new System.Windows.Forms.TextBox();
            this.lb_repa_set = new System.Windows.Forms.Label();
            this.btn_repa_set = new System.Windows.Forms.Button();
            this.txt_repa_set = new System.Windows.Forms.TextBox();
            this.lb_repa_add = new System.Windows.Forms.Label();
            this.lb_fr = new System.Windows.Forms.Label();
            this.btn_repa_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_repa)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_repa_vungthuchien
            // 
            this.pn_repa_vungthuchien.AutoScroll = true;
            this.pn_repa_vungthuchien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_repa_vungthuchien.Location = new System.Drawing.Point(12, 172);
            this.pn_repa_vungthuchien.Name = "pn_repa_vungthuchien";
            this.pn_repa_vungthuchien.Size = new System.Drawing.Size(958, 469);
            this.pn_repa_vungthuchien.TabIndex = 9;
            // 
            // btn_repa_readfile
            // 
            this.btn_repa_readfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_readfile.Location = new System.Drawing.Point(449, 17);
            this.btn_repa_readfile.Name = "btn_repa_readfile";
            this.btn_repa_readfile.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_readfile.TabIndex = 13;
            this.btn_repa_readfile.Text = "Read file";
            this.btn_repa_readfile.UseVisualStyleBackColor = true;
            this.btn_repa_readfile.Click += new System.EventHandler(this.btn_repa_readfile_Click);
            // 
            // btn_repa_opt
            // 
            this.btn_repa_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_opt.Location = new System.Drawing.Point(649, 17);
            this.btn_repa_opt.Name = "btn_repa_opt";
            this.btn_repa_opt.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_opt.TabIndex = 14;
            this.btn_repa_opt.Text = "OPT";
            this.btn_repa_opt.UseVisualStyleBackColor = true;
            this.btn_repa_opt.Click += new System.EventHandler(this.btn_repa_opt_Click);
            // 
            // btn_repa_lru
            // 
            this.btn_repa_lru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_lru.Location = new System.Drawing.Point(776, 17);
            this.btn_repa_lru.Name = "btn_repa_lru";
            this.btn_repa_lru.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_lru.TabIndex = 15;
            this.btn_repa_lru.Text = "LRU";
            this.btn_repa_lru.UseVisualStyleBackColor = true;
            this.btn_repa_lru.Click += new System.EventHandler(this.btn_repa_lru_Click);
            // 
            // btn_repa_fifo
            // 
            this.btn_repa_fifo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_fifo.Location = new System.Drawing.Point(649, 65);
            this.btn_repa_fifo.Name = "btn_repa_fifo";
            this.btn_repa_fifo.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_fifo.TabIndex = 16;
            this.btn_repa_fifo.Text = "FIFO";
            this.btn_repa_fifo.UseVisualStyleBackColor = true;
            this.btn_repa_fifo.Click += new System.EventHandler(this.btn_repa_fifo_Click);
            // 
            // btn_repa_clock
            // 
            this.btn_repa_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_clock.Location = new System.Drawing.Point(776, 65);
            this.btn_repa_clock.Name = "btn_repa_clock";
            this.btn_repa_clock.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_clock.TabIndex = 17;
            this.btn_repa_clock.Text = "Clock";
            this.btn_repa_clock.UseVisualStyleBackColor = true;
            this.btn_repa_clock.Click += new System.EventHandler(this.btn_repa_clock_Click);
            // 
            // dtgv_repa
            // 
            this.dtgv_repa.AllowUserToAddRows = false;
            this.dtgv_repa.AllowUserToDeleteRows = false;
            this.dtgv_repa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_repa.Location = new System.Drawing.Point(93, 112);
            this.dtgv_repa.Name = "dtgv_repa";
            this.dtgv_repa.ReadOnly = true;
            this.dtgv_repa.RowHeadersWidth = 51;
            this.dtgv_repa.RowTemplate.Height = 24;
            this.dtgv_repa.Size = new System.Drawing.Size(877, 54);
            this.dtgv_repa.TabIndex = 19;
            this.dtgv_repa.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_repa_CellEndEdit);
            this.dtgv_repa.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgv_repa_EditingControlShowing);
            this.dtgv_repa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgv_repa_KeyDown);
            // 
            // btn_repa_ss
            // 
            this.btn_repa_ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_ss.Location = new System.Drawing.Point(902, 19);
            this.btn_repa_ss.Name = "btn_repa_ss";
            this.btn_repa_ss.Size = new System.Drawing.Size(68, 73);
            this.btn_repa_ss.TabIndex = 20;
            this.btn_repa_ss.Text = "SS";
            this.btn_repa_ss.UseVisualStyleBackColor = true;
            this.btn_repa_ss.Click += new System.EventHandler(this.btn_repa_ss_Click);
            // 
            // btn_repa_add
            // 
            this.btn_repa_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_add.Location = new System.Drawing.Point(321, 17);
            this.btn_repa_add.Name = "btn_repa_add";
            this.btn_repa_add.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_add.TabIndex = 28;
            this.btn_repa_add.Text = "ADD";
            this.btn_repa_add.UseVisualStyleBackColor = true;
            this.btn_repa_add.Click += new System.EventHandler(this.btn_repa_add_Click);
            // 
            // txt_repa_add
            // 
            this.txt_repa_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repa_add.Location = new System.Drawing.Point(183, 19);
            this.txt_repa_add.Name = "txt_repa_add";
            this.txt_repa_add.Size = new System.Drawing.Size(107, 27);
            this.txt_repa_add.TabIndex = 27;
            this.txt_repa_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_repa_add_KeyPress);
            // 
            // lb_repa_set
            // 
            this.lb_repa_set.AutoSize = true;
            this.lb_repa_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_repa_set.Location = new System.Drawing.Point(23, 22);
            this.lb_repa_set.Name = "lb_repa_set";
            this.lb_repa_set.Size = new System.Drawing.Size(138, 20);
            this.lb_repa_set.TabIndex = 26;
            this.lb_repa_set.Text = "Input chuoi trang:";
            // 
            // btn_repa_set
            // 
            this.btn_repa_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_set.Location = new System.Drawing.Point(321, 65);
            this.btn_repa_set.Name = "btn_repa_set";
            this.btn_repa_set.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_set.TabIndex = 31;
            this.btn_repa_set.Text = "SET";
            this.btn_repa_set.UseVisualStyleBackColor = true;
            this.btn_repa_set.Click += new System.EventHandler(this.btn_repa_set_Click);
            // 
            // txt_repa_set
            // 
            this.txt_repa_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repa_set.Location = new System.Drawing.Point(183, 67);
            this.txt_repa_set.Name = "txt_repa_set";
            this.txt_repa_set.Size = new System.Drawing.Size(107, 27);
            this.txt_repa_set.TabIndex = 30;
            this.txt_repa_set.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_repa_set_KeyPress);
            // 
            // lb_repa_add
            // 
            this.lb_repa_add.AutoSize = true;
            this.lb_repa_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_repa_add.Location = new System.Drawing.Point(23, 70);
            this.lb_repa_add.Name = "lb_repa_add";
            this.lb_repa_add.Size = new System.Drawing.Size(110, 20);
            this.lb_repa_add.TabIndex = 29;
            this.lb_repa_add.Text = "Set số frame:";
            // 
            // lb_fr
            // 
            this.lb_fr.AutoSize = true;
            this.lb_fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fr.ForeColor = System.Drawing.Color.Red;
            this.lb_fr.Location = new System.Drawing.Point(22, 124);
            this.lb_fr.Name = "lb_fr";
            this.lb_fr.Size = new System.Drawing.Size(31, 29);
            this.lb_fr.TabIndex = 32;
            this.lb_fr.Text = "X";
            // 
            // btn_repa_reset
            // 
            this.btn_repa_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repa_reset.Location = new System.Drawing.Point(449, 64);
            this.btn_repa_reset.Name = "btn_repa_reset";
            this.btn_repa_reset.Size = new System.Drawing.Size(108, 30);
            this.btn_repa_reset.TabIndex = 33;
            this.btn_repa_reset.Text = "RESET";
            this.btn_repa_reset.UseVisualStyleBackColor = true;
            this.btn_repa_reset.Click += new System.EventHandler(this.btn_repa_reset_Click);
            // 
            // ReplacePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btn_repa_reset);
            this.Controls.Add(this.lb_fr);
            this.Controls.Add(this.btn_repa_set);
            this.Controls.Add(this.txt_repa_set);
            this.Controls.Add(this.lb_repa_add);
            this.Controls.Add(this.btn_repa_add);
            this.Controls.Add(this.txt_repa_add);
            this.Controls.Add(this.lb_repa_set);
            this.Controls.Add(this.btn_repa_ss);
            this.Controls.Add(this.dtgv_repa);
            this.Controls.Add(this.btn_repa_clock);
            this.Controls.Add(this.btn_repa_fifo);
            this.Controls.Add(this.btn_repa_lru);
            this.Controls.Add(this.btn_repa_opt);
            this.Controls.Add(this.btn_repa_readfile);
            this.Controls.Add(this.pn_repa_vungthuchien);
            this.Name = "ReplacePage";
            this.Text = "ReplacePage";
            this.Load += new System.EventHandler(this.ReplacePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_repa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_repa_vungthuchien;
        private System.Windows.Forms.Button btn_repa_readfile;
        private System.Windows.Forms.Button btn_repa_opt;
        private System.Windows.Forms.Button btn_repa_lru;
        private System.Windows.Forms.Button btn_repa_fifo;
        private System.Windows.Forms.Button btn_repa_clock;
        private System.Windows.Forms.DataGridView dtgv_repa;
        private System.Windows.Forms.Button btn_repa_ss;
        private System.Windows.Forms.Button btn_repa_add;
        private System.Windows.Forms.TextBox txt_repa_add;
        private System.Windows.Forms.Label lb_repa_set;
        private System.Windows.Forms.Button btn_repa_set;
        private System.Windows.Forms.TextBox txt_repa_set;
        private System.Windows.Forms.Label lb_repa_add;
        private System.Windows.Forms.Label lb_fr;
        private System.Windows.Forms.Button btn_repa_reset;
    }
}