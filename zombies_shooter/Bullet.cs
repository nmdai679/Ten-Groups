using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace shooter
{
    internal class Bullet
    {
        public string direction; 

        private int speed = 20; 
        private PictureBox bullet = new PictureBox(); 
        private Timer tm = new Timer(); 

        public int bulletLeft;
        public int bulletTop;

        public void mkBullet(Form form)
        {
            bullet.BackColor = Color.Transparent;
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 5); 
            bullet.Tag = "bullet"; 
            bullet.Left = bulletLeft; 
            bullet.Top = bulletTop;
            bullet.BringToFront(); 
            form.Controls.Add(bullet); 
            tm.Interval = speed; 
            tm.Tick += new EventHandler(tm_Tick); 
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed; 
            }
            if (direction == "right")
            {
                bullet.Left += speed; 
            }
            if (direction == "up")
            {
                bullet.Top -= speed; 
            }
            if (direction == "down")
            {
                bullet.Top += speed; 
            }
            
            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                tm.Stop(); 
                tm.Dispose(); 
                bullet.Dispose();
                tm = null; 
                bullet = null; 
            }
        }
    }
}
