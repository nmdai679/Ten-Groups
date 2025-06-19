using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDH
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Hàm tạo form con
        private void Formchild(Form childForm)
        {
            Home_panel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Home_panel.Controls.Add(childForm);
            childForm.Show();
        }
        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            string iconPath = Path.Combine(Application.StartupPath, "icon.ico");
            iconPath = Path.GetFullPath(iconPath);
            this.Icon = new Icon(iconPath);
            Formchild(new Anhnen());
        }        

        private void pPCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formchild(new PPCPU());
        }

        private void thayThếTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formchild(new ReplacePage());
        }

        private void bankerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formchild(new Banker());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formchild(new Anhnen());
        }

        private void điềuPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formchild(new DPDIA());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lb_ntn.Text = DateTime.Now.ToString("HH:mm:ss     dddd, dd MMMM yyyy");
        }
    }
}
