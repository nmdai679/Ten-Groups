using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDH
{
    public partial class NhapQt_RR : Form
    {
        #region khai bao bien
        public int Quantum;
        #endregion

        #region cac ham load
        public NhapQt_RR()
        {
            InitializeComponent();
        }

        private void NhapQt_RR_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region nut chuc nang
        private void btn_NhapQt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_NhapQt.Text.Trim(), out int q) && q > 0)
            {
                Quantum = q;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Quantum hợp lệ (số nguyên dương)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ham ho tro
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
