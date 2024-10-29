using System.Drawing;

namespace shooter
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.txtammo = new System.Windows.Forms.Label();
            this.txtkill = new System.Windows.Forms.Label();
            this.txthealth = new System.Windows.Forms.Label();
            this.Thanhcongcu = new System.Windows.Forms.Panel();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.ketqua = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.countdowntimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.Thanhcongcu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtammo
            // 
            this.txtammo.AutoSize = true;
            this.txtammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtammo.ForeColor = System.Drawing.Color.Lime;
            this.txtammo.Location = new System.Drawing.Point(19, 17);
            this.txtammo.Name = "txtammo";
            this.txtammo.Size = new System.Drawing.Size(121, 29);
            this.txtammo.TabIndex = 0;
            this.txtammo.Text = "Ammo : 0";
            // 
            // txtkill
            // 
            this.txtkill.AutoSize = true;
            this.txtkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkill.ForeColor = System.Drawing.Color.Lime;
            this.txtkill.Location = new System.Drawing.Point(302, 17);
            this.txtkill.Name = "txtkill";
            this.txtkill.Size = new System.Drawing.Size(86, 29);
            this.txtkill.TabIndex = 1;
            this.txtkill.Text = "Kill : 0";
            // 
            // txthealth
            // 
            this.txthealth.AutoSize = true;
            this.txthealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthealth.ForeColor = System.Drawing.Color.Lime;
            this.txthealth.Location = new System.Drawing.Point(558, 17);
            this.txthealth.Name = "txthealth";
            this.txthealth.Size = new System.Drawing.Size(102, 29);
            this.txthealth.TabIndex = 2;
            this.txthealth.Text = "Health :";
            this.txthealth.Click += new System.EventHandler(this.label3_Click);
            // 
            // Thanhcongcu
            // 
            this.Thanhcongcu.BackColor = System.Drawing.Color.Gray;
            this.Thanhcongcu.Controls.Add(this.healthBar);
            this.Thanhcongcu.Controls.Add(this.txtammo);
            this.Thanhcongcu.Controls.Add(this.txthealth);
            this.Thanhcongcu.Controls.Add(this.txtkill);
            this.Thanhcongcu.Location = new System.Drawing.Point(12, 580);
            this.Thanhcongcu.Name = "Thanhcongcu";
            this.Thanhcongcu.Size = new System.Drawing.Size(958, 61);
            this.Thanhcongcu.TabIndex = 3;
            this.Thanhcongcu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.DimGray;
            this.healthBar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.healthBar.Location = new System.Drawing.Point(680, 17);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(237, 29);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            this.healthBar.Click += new System.EventHandler(this.healthBar_Click);
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.Timergame);
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.ForeColor = System.Drawing.Color.Cyan;
            this.ketqua.Location = new System.Drawing.Point(146, 114);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(106, 32);
            this.ketqua.TabIndex = 5;
            this.ketqua.Text = "ketqua";
            this.ketqua.Click += new System.EventHandler(this.ketqua_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblCountdown.Location = new System.Drawing.Point(425, 250);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(121, 20);
            this.lblCountdown.TabIndex = 6;
            this.lblCountdown.Text = "lblCountdown";
            this.lblCountdown.Click += new System.EventHandler(this.lblCountdown_Click);
            // 
            // countdowntimer
            // 
            this.countdowntimer.Tick += new System.EventHandler(this.countdown_tk);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::shooter.Properties.Resources.right;
            this.player.Location = new System.Drawing.Point(12, 256);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 35);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Thanhcongcu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGame";
            this.Text = "zombie shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            this.Thanhcongcu.ResumeLayout(false);
            this.Thanhcongcu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtammo;
        private System.Windows.Forms.Label txtkill;
        private System.Windows.Forms.Label txthealth;
        private System.Windows.Forms.Panel Thanhcongcu;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer countdowntimer;
    }
}

