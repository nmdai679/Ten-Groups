using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shooter
{
    public partial class frmNhap : Form
    {
        int dem = 2;
        public frmNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbeasy.Checked == false && cbmedium.Checked == false && cbhard.Checked == false && cbimpossible.Checked == false)
            {
                if (dem > 0)
                {
                    dem--;
                    MessageBox.Show("Vui lòng chọn một chế độ trò chơi!", "Error!!!");
                }
                else
                {
                    MessageBox.Show("Bạn đã chọn sai quá lần!", "Error!!!");
                    dem = 3;
                    Close();
                }
            }
            else if (cbeasy.Checked == true && cbmedium.Checked == false && cbhard.Checked == false && cbimpossible.Checked == false)
            {
                var form = new MainGame();
                form.ShowDialog();
            }
            else if (cbeasy.Checked == false && cbmedium.Checked == true && cbhard.Checked == false && cbimpossible.Checked == false)
            {
                var form = new MainGame(5, 2);
                form.ShowDialog();
            }
            else if (cbeasy.Checked == false && cbmedium.Checked == false && cbhard.Checked == true && cbimpossible.Checked == false)
            {
                var form = new MainGame(10, 2);
                form.ShowDialog();
            }
            else if (cbeasy.Checked == false && cbmedium.Checked == false && cbhard.Checked == false && cbimpossible.Checked == true)
            {
                var form = new MainGame(10, 5);
                form.ShowDialog();
            }
            else
            {
                if (dem > 0)
                {
                    dem--;
                    MessageBox.Show("Vui lòng chỉ chọn một chế độ chơi!", "Error!!!");
                }
                else
                {
                    MessageBox.Show("Bạn đã chọn sai quá lần!", "Error!!!");
                    dem = 3;
                    Close();
                }
            }
            cbeasy.Checked = false;
            cbmedium.Checked = false;
            cbhard.Checked = false;
            cbimpossible.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hướng dẫn cách chơi:\n+ Sử dụng các phím mũi tên để di chuyển\n+ Sử dụng phím space để bắn đạn\n+ Nhặt các biểu tượng đạn tên bản đồ để bổ sung đạn\n+ Nhặt các quả táo để hồi máu\n+ Bạn cũng có thể nhấn S để tạm thời dừng trò chơi và nhấn P để tiếp tục\nChỉ có như vậy thôi, chúc bạn chơi game vui vẻ.", "HOW TO PLAY???");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
