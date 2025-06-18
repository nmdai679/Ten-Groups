namespace HDH
{
    partial class NhapQt_RR
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
            this.btn_NhapQt_run = new System.Windows.Forms.Button();
            this.lb_NhapQt = new System.Windows.Forms.Label();
            this.txt_NhapQt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_NhapQt_run
            // 
            this.btn_NhapQt_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapQt_run.ForeColor = System.Drawing.Color.Lime;
            this.btn_NhapQt_run.Location = new System.Drawing.Point(431, 18);
            this.btn_NhapQt_run.Name = "btn_NhapQt_run";
            this.btn_NhapQt_run.Size = new System.Drawing.Size(106, 34);
            this.btn_NhapQt_run.TabIndex = 0;
            this.btn_NhapQt_run.Text = "RUN";
            this.btn_NhapQt_run.UseVisualStyleBackColor = true;
            this.btn_NhapQt_run.Click += new System.EventHandler(this.btn_NhapQt_Click);
            // 
            // lb_NhapQt
            // 
            this.lb_NhapQt.AutoSize = true;
            this.lb_NhapQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhapQt.ForeColor = System.Drawing.Color.Lime;
            this.lb_NhapQt.Location = new System.Drawing.Point(12, 21);
            this.lb_NhapQt.Name = "lb_NhapQt";
            this.lb_NhapQt.Size = new System.Drawing.Size(233, 29);
            this.lb_NhapQt.TabIndex = 1;
            this.lb_NhapQt.Text = "Nhập Quanturn time:";
            // 
            // txt_NhapQt
            // 
            this.txt_NhapQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapQt.ForeColor = System.Drawing.Color.Lime;
            this.txt_NhapQt.Location = new System.Drawing.Point(251, 18);
            this.txt_NhapQt.Name = "txt_NhapQt";
            this.txt_NhapQt.Size = new System.Drawing.Size(159, 34);
            this.txt_NhapQt.TabIndex = 2;
            this.txt_NhapQt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // NhapQt_RR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 72);
            this.Controls.Add(this.txt_NhapQt);
            this.Controls.Add(this.lb_NhapQt);
            this.Controls.Add(this.btn_NhapQt_run);
            this.Name = "NhapQt_RR";
            this.Text = "NhapQt_RR";
            this.Load += new System.EventHandler(this.NhapQt_RR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NhapQt_run;
        private System.Windows.Forms.Label lb_NhapQt;
        private System.Windows.Forms.TextBox txt_NhapQt;
    }
}