namespace shooter
{
    partial class frmNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbeasy = new System.Windows.Forms.CheckBox();
            this.cbmedium = new System.Windows.Forms.CheckBox();
            this.cbhard = new System.Windows.Forms.CheckBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnhtp = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbimpossible = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn chế độ !!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbeasy
            // 
            this.cbeasy.AutoSize = true;
            this.cbeasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeasy.ForeColor = System.Drawing.Color.Lime;
            this.cbeasy.Location = new System.Drawing.Point(30, 323);
            this.cbeasy.Name = "cbeasy";
            this.cbeasy.Size = new System.Drawing.Size(72, 24);
            this.cbeasy.TabIndex = 4;
            this.cbeasy.Text = "Easy";
            this.cbeasy.UseVisualStyleBackColor = true;
            this.cbeasy.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbmedium
            // 
            this.cbmedium.AutoSize = true;
            this.cbmedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbmedium.Location = new System.Drawing.Point(30, 363);
            this.cbmedium.Name = "cbmedium";
            this.cbmedium.Size = new System.Drawing.Size(96, 24);
            this.cbmedium.TabIndex = 5;
            this.cbmedium.Text = "Medium";
            this.cbmedium.UseVisualStyleBackColor = true;
            this.cbmedium.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbhard
            // 
            this.cbhard.AutoSize = true;
            this.cbhard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhard.ForeColor = System.Drawing.Color.Blue;
            this.cbhard.Location = new System.Drawing.Point(148, 323);
            this.cbhard.Name = "cbhard";
            this.cbhard.Size = new System.Drawing.Size(72, 24);
            this.cbhard.TabIndex = 6;
            this.cbhard.Text = "Hard";
            this.cbhard.UseVisualStyleBackColor = true;
            this.cbhard.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Black;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnstart.Location = new System.Drawing.Point(293, 268);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(250, 40);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhtp
            // 
            this.btnhtp.BackColor = System.Drawing.Color.Black;
            this.btnhtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnhtp.Location = new System.Drawing.Point(293, 323);
            this.btnhtp.Name = "btnhtp";
            this.btnhtp.Size = new System.Drawing.Size(250, 40);
            this.btnhtp.TabIndex = 8;
            this.btnhtp.Text = "HOW TO PLAY";
            this.btnhtp.UseVisualStyleBackColor = false;
            this.btnhtp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnexit.Location = new System.Drawing.Point(293, 382);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(250, 40);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cbimpossible
            // 
            this.cbimpossible.AutoSize = true;
            this.cbimpossible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbimpossible.ForeColor = System.Drawing.Color.Red;
            this.cbimpossible.Location = new System.Drawing.Point(148, 363);
            this.cbimpossible.Name = "cbimpossible";
            this.cbimpossible.Size = new System.Drawing.Size(121, 24);
            this.cbimpossible.TabIndex = 10;
            this.cbimpossible.Text = "Impossible";
            this.cbimpossible.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::shooter.Properties.Resources.nenkhoitao;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbimpossible);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnhtp);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.cbhard);
            this.Controls.Add(this.cbmedium);
            this.Controls.Add(this.cbeasy);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhap";
            this.Text = "Chọn chế độ thôi nào /////////";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbeasy;
        private System.Windows.Forms.CheckBox cbmedium;
        private System.Windows.Forms.CheckBox cbhard;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnhtp;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox cbimpossible;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}