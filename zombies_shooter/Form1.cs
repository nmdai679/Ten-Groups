using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Resources;
using WMPLib;

namespace shooter
{
    public partial class MainGame : Form
    {
        SoundPlayer soundbuocchan = new SoundPlayer(Application.StartupPath + @"\bg\buocchan.wav");
        
        bool isgo = false;

        int countdown = 10;
        int bestcore = 0;
        bool goleft, goright, goup, godown;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombiespeed = 3;
        Random random = new Random();
        bool gameover = false;
        int score = 0;
        int eathp = 0;
        int eatbullet = 100;
        int sozombie = 0;
        bool stopGame = false;

        List<PictureBox> zombieslist = new List<PictureBox>();
        List<PictureBox> ammolist = new List<PictureBox>();
        List<PictureBox> HPlist = new List<PictureBox>();

        public MainGame(int x = 3, int y = 1)
        {
            this.DoubleBuffered = true;
                        
            InitializeComponent();

            ketqua.Hide();
            zombiespeed = y;
            sozombie = x;

            countdowntimer.Interval = 1000;
            countdowntimer.Tick += countdown_tk;
            StartCountdown();
        }

        

        private void StartCountdown()
        {
            lblCountdown.Text = countdown.ToString();
            lblCountdown.Visible = true;
            countdowntimer.Start(); 
        }
        private void countdown_tk(object sender, EventArgs e)
        {
            countdown--;
            lblCountdown.Text = countdown.ToString();
            if (countdown <= 0)
            {
                countdowntimer.Stop();
                lblCountdown.Visible = false;
                RestartGame(); 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        
        private void Timergame(object sender, EventArgs e)
        {
            
            if ((godown || goleft || goright || goup) && gameover == false)
            {
                if (isgo == false)
                {
                    soundbuocchan.Play();
                    isgo = true;
                }
            }
            else
            {
                soundbuocchan.Stop();
                isgo = false;
            }

            
            if(playerHealth<100 && eathp == 0)
            {
                drophp();
                eathp = 200;
            }

            if(eathp > 0)
            {
                eathp--;
            }
            
            if(eatbullet == 0)
            {
                DropAmmo();
                eatbullet += 100;
            }

            if(eatbullet > 0)
            {
                eatbullet--;
            }


            if (playerHealth > 1)
            {
                if(playerHealth > 100)
                {
                    playerHealth = 100;
                }
                healthBar.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                gameover = true;
                player.Image = Properties.Resources.dead;
                Gametimer.Stop();
                ketqua.BringToFront();
                ketqua.BackColor = Color.Transparent;
                if (bestcore == 0)
                {
                    ketqua.Text = "Xin chúc mừng bạn đã kill được " + score.ToString() + " zombie\nNhấn 'R' để chơi lại, nhấn 'Esc' để thoát \nhoặc 'N' để đổi chế độ";
                    ketqua.Show();
                    bestcore = score;
                }
                else
                {
                    if (score < bestcore)
                    {
                        ketqua.Text = "Tiếc quá lần cao nhất bạn kill được tận " + bestcore.ToString() + " zombies\nKill đạt được:  " +score.ToString() + "\nNhấn 'R' để chơi lại, nhấn 'Esc' để thoát \nhoặc 'N' để đổi chế độ";
                        ketqua.Show();
                    }
                    else if (score > bestcore)
                    {
                        bestcore = score;
                        ketqua.Text = "Tuyệt vời! Bạn đã vượt kĩ lục\nKill đạt được: " + score.ToString() + "\nNhấn 'R' để chơi lại, nhấn 'Esc' để thoát \nhoặc 'N' để đổi chế độ";
                        ketqua.Show();
                    }
                    else
                    {
                        ketqua.Text = "Phong độ bạn vẫn ko đổi :_)\nKill đạt được: " + score.ToString() + "\nNhấn 'R' để chơi lại, nhấn 'Esc' để thoát \nhoặc 'N' để đổi chế độ";
                        ketqua.Show();
                    }
                }
            }

            txtammo.Text = "   Ammo:  " + ammo;
            txtkill.Text = "Kills: " + score;

            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goright && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goup && player.Top > 0)
            {
                player.Top -= speed;
            }
            if (godown && player.Top + player.Height < this.ClientSize.Height - 1.25 * Thanhcongcu.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammolist.Remove(((PictureBox)x));
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie" )
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombieslist.Remove(((PictureBox)x));
                            Makezombies();
                        }
                    }
                }

                foreach (Control k in Controls)
                {
                    if(k is PictureBox && (string)k.Tag == "hp")
                    {
                        if(player.Bounds.IntersectsWith(k.Bounds))
                        {
                            this.Controls.Remove(k);
                            ((PictureBox)k).Dispose();
                            HPlist.Remove(((PictureBox)k));
                            playerHealth += 10;
                        }
                    }
                }
            }
        }

        
        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (gameover) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right"; 
                player.Image = Properties.Resources.right;
            }
            
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }
            
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                facing = "down";
                player.Image = Properties.Resources.down; 
            }

        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameover == false)
            {
                ammo--;
                ShootBullet(facing);
            }

            if(e.KeyCode == Keys.R && gameover == true)
            {
                khoitao();
                countdown = 10;
                countdowntimer.Interval = 1000;
                countdowntimer.Tick += countdown_tk;
                StartCountdown();
            }

            if (e.KeyCode == Keys.Escape && gameover == true)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.N && gameover == true)
            {
                Close();
            }

            if (e.KeyCode == Keys.S && gameover == false && stopGame == false)
            {
                Gametimer.Stop();
                stopGame = true;
                MessageBox.Show("Sau khi nhấn OK.\nNhấn P để tiếp tục.", "Stop!");
            }

            if (e.KeyCode == Keys.P && gameover == false && stopGame == true)
            {
                Gametimer.Start();
                stopGame = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShootBullet(string direction)
        {
            Bullet bulletshoot = new Bullet();
            bulletshoot.direction = direction;
            bulletshoot.bulletLeft = player.Left + (player.Width / 2); 
            bulletshoot.bulletTop = player.Top + (player.Height / 2);
            bulletshoot.mkBullet(this);
        }

        private void ketqua_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drophp()
        {
            PictureBox hp = new PictureBox();
            hp.Image = Properties.Resources.ItemApple;
            hp.BackColor = Color.Transparent;
            hp.Tag = "hp";
            hp.SizeMode = PictureBoxSizeMode.AutoSize;
            hp.Left = random.Next(10, this.ClientSize.Width - hp.Width);
            hp.Top = random.Next(50, this.ClientSize.Height - hp.Height - Thanhcongcu.Height);
            this.Controls.Add(hp);
            hp.BringToFront();
            player.BringToFront();
            HPlist.Add(hp);
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void skillBar_Click(object sender, EventArgs e)
        {

        }

        private void healthBar_Click(object sender, EventArgs e)
        {

        }

        

        private void Makezombies()
        {
            PictureBox zombie = new PictureBox(); 
            zombie.Tag = "zombie"; 
            zombie.Image = Properties.Resources.zdown;
            zombie.BackColor = Color.Transparent;
            zombie.Left = random.Next(0, 900); 
            zombie.Top = random.Next(0, 800); 
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombieslist.Add(zombie); 
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void lblCountdown_Click(object sender, EventArgs e)
        {

        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize; 
            ammo.Left = random.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = random.Next(50, this.ClientSize.Height - ammo.Height - Thanhcongcu.Height); 
            ammo.Tag = "ammo"; 
            this.Controls.Add(ammo); 
            ammo.BringToFront();
            player.BringToFront();
            ammolist.Add(ammo);
        }

        private void khoitao()
        {

            ketqua.Hide();

            foreach (PictureBox i in zombieslist)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox i in ammolist)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox i in HPlist)
            {
                this.Controls.Remove(i);
            }

            zombieslist.Clear();
            ammolist.Clear();
            HPlist.Clear();

            goright = false;
            goleft = false;
            goup = false;
            godown = false;

            gameover = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            Gametimer.Start();
        }
        private void RestartGame()
        {
            player.Image = Properties.Resources.right;
            
            for (int i = 0; i < sozombie; i++)
            {
                Makezombies();
            }
            
        }
    }
}
