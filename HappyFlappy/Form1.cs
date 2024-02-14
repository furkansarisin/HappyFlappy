﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyFlappy
{
    public partial class topPlayerTxt : Form
    {
        int boruHızı = 15;
        int yerÇekimi = 4;
        int skor = 0;
        int enİyi = 5;
        PictureBox[] pictureBoxes;
        int görünenPictureBoxIndex = 0;

<<<<<<< HEAD
      
=======
        private Timer soundTimer;
        private string soundPath = "C:\\My Codes\\HappyFlappy\\HappyFlappy\\bin\\Debug\\s2.wav";
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad

        public topPlayerTxt()
        {
            InitializeComponent();

            // PictureBox'ları diziye ekleyin
            pictureBoxes = new PictureBox[] { morning, noon, üst };

            pictureBoxes[görünenPictureBoxIndex].Visible = true;
            oyunZaman.Stop();
<<<<<<< HEAD
=======

            // Timer'ı başlatın
            soundTimer = new Timer();
            soundTimer.Interval = 10000; // 10 saniye
            soundTimer.Tick += SoundTimer_Tick;
            soundTimer.Start();
        }

        private void SoundTimer_Tick(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(soundPath);
            soundPlayer.Play();
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void oyunZamanEvent(object sender, EventArgs e)
        {
            //Flappy zamanla aşağı inecek
            flappy.Top += yerÇekimi;

            // Borular hareket edecek
            üstBoru.Left -= boruHızı;
            altBoru.Left -= boruHızı;
            skorTxt.Text = "Skor: " + skor;

            // Alt boru ekrandan çıkarsa
            if (altBoru.Left < -100)
            {
                altBoru.Left = 1000;
                skor++;
            }

            // Üst boru ekrandan çıkarsa
            if (üstBoru.Left < -160)
            {
                üstBoru.Left = 1100;
                skor++;
            }

            // En iyi skoru güncelle
            if (skor > enİyi)
            {
                enİyi = skor;
                TopPointLbl.Text = enİyi.ToString();
                enİyiLbl.Text = oyuncuLbl.Text;
            }

            // Çarpışma kontrolü
            if (flappy.Bounds.IntersectsWith(altBoru.Bounds) ||
                flappy.Bounds.IntersectsWith(üstBoru.Bounds) ||
                flappy.Bounds.IntersectsWith(zemin.Bounds) || flappy.Top < -25)
            {
                oyunSonu();
            }

            // Boru hızını artır
            if (DateTime.Now.Millisecond % 100 == 0)
            {
                int artisMiktarı = 1;
                boruHızı += artisMiktarı;
            }

            // Skorun ona bölümü 3'e göre renk değişikliği
            if (skor % 10 == 0)
            {
                if ((skor / 10) % 3 == 0)
                    this.BackColor = Color.MistyRose;
                else if ((skor / 10) % 3 == 1)
                    this.BackColor = Color.Yellow;
                else
                    this.BackColor = Color.DarkBlue;
            }

            // Skorun ona bölümü 10 ise arkaplan rengini ve PictureBox'ı değiştir
            if (skor % 10 == 0)
            {
                this.BackColor = GetBackgroundColor();
                SetVisiblePictureBox();
            }

<<<<<<< HEAD
            
            
             // 10 saniyede bir ses çal
           /* if (DateTime.Now.Millisecond % 1000 == 0)
=======
            // 10 saniyede bir ses çal
            if (DateTime.Now.Millisecond % 1000 == 0)
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
            {
                string dizin = "C:\\My Codes\\HappyFlappy\\HappyFlappy\\bin\\Debug\\s2.wav";
                SoundPlayer ses = new SoundPlayer(dizin);
                ses.Play();
            }
<<<<<<< HEAD
           */
            
=======
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
        }

        private Color GetBackgroundColor()
        {
            if ((skor / 10) % 3 == 0)
                return Color.MistyRose;
            else if ((skor / 10) % 3 == 1)
                return Color.Yellow;
            else
                return Color.DarkBlue;
        }

        private void SetVisiblePictureBox()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = false;
            }

            int visibleIndex = (skor / 10) % pictureBoxes.Length;
            pictureBoxes[visibleIndex].Visible = true;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
<<<<<<< HEAD
                yerÇekimi = -20;
            }
            else if (e.KeyCode == Keys.R)
            {
=======
                yerÇekimi = -15;
            }
            else if (e.KeyCode == Keys.R)
            {
                textBox1.Focus();
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
                btn1.Visible = true;
                idTxt.Visible = true;
                textBox1.Visible = true;
                yenidenBaslat();
<<<<<<< HEAD
                

=======
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
            }
        }

        private void yenidenBaslat()
        {
<<<<<<< HEAD
            oyuncuLbl.Text = textBox1.Text;
=======
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
            skor = 0;
            boruHızı = 15;
            yerÇekimi = 4;
            this.BackColor = Color.White;
            SetVisiblePictureBox();
<<<<<<< HEAD
            flappy.Location = new Point(141, 241);


=======
            failBox.Visible = false;
            flappy.Location = new Point(141, 241);
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerÇekimi = 15;
            }
        }

        private void oyunSonu()
        {
            oyunZaman.Stop();
            TopPointLbl.Text = enİyi.ToString();
            enİyiLbl.Text = oyuncuLbl.Text;
<<<<<<< HEAD

=======
            failBox.Visible = true;
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
            textBox1.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyuncuLbl.Text = textBox1.Text;
            oyunZaman.Start();

            // Odağı klavye tuşlarına ayarla
            this.KeyPreview = true;

            btn1.Visible = false;
            idTxt.Visible = false;
            textBox1.Visible = false;
        }

        private void idTxt_Click(object sender, EventArgs e)
        {
        }

        private void altBoru_Click(object sender, EventArgs e)
        {
        }

        private void enİyiLbl_Click(object sender, EventArgs e)
        {
        }
<<<<<<< HEAD

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> a824736d30459967491b0c8a79945426f7ff41ad
    }
}
