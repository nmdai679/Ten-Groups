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
    public partial class Anhnen : Form
    {
        public Anhnen()
        {
            InitializeComponent();
        }

        private void loadanh()
        {
            for (int i = 1; i <= 5; ++i)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(720, 1200); 
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                int y = 1200 * (i - 1);  
                pictureBox.Location = new Point(0, y);

                string tenanh = "hdh" + i.ToString() + ".png";
                string imagePath = Path.Combine(Application.StartupPath, tenanh);

                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh: " + imagePath);
                    continue;
                }

                this.Controls.Add(pictureBox);
            }
        }

        private void Anhnen_Load(object sender, EventArgs e)
        {
            loadanh();
        }
    }
}
