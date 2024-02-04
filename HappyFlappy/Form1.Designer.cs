namespace HappyFlappy
{
    partial class topPlayerTxt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skorTxt = new System.Windows.Forms.Label();
            this.oyunZaman = new System.Windows.Forms.Timer(this.components);
            this.idTxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.topPlayer = new System.Windows.Forms.Label();
            this.TopPointLbl = new System.Windows.Forms.Label();
            this.enİyiLbl = new System.Windows.Forms.Label();
            this.oyuncuLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.altBoru = new System.Windows.Forms.PictureBox();
            this.üstBoru = new System.Windows.Forms.PictureBox();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.failBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.morning = new System.Windows.Forms.PictureBox();
            this.noon = new System.Windows.Forms.PictureBox();
            this.üst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.altBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.üstBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.üst)).BeginInit();
            this.SuspendLayout();
            // 
            // skorTxt
            // 
            this.skorTxt.AutoSize = true;
            this.skorTxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorTxt.Location = new System.Drawing.Point(12, 558);
            this.skorTxt.Name = "skorTxt";
            this.skorTxt.Size = new System.Drawing.Size(65, 32);
            this.skorTxt.TabIndex = 4;
            this.skorTxt.Text = "Skor";
            // 
            // oyunZaman
            // 
            this.oyunZaman.Enabled = true;
            this.oyunZaman.Interval = 20;
            this.oyunZaman.Tick += new System.EventHandler(this.oyunZamanEvent);
            // 
            // idTxt
            // 
            this.idTxt.AutoSize = true;
            this.idTxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTxt.Location = new System.Drawing.Point(516, 263);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(54, 32);
            this.idTxt.TabIndex = 10;
            this.idTxt.Text = "ID:";
            this.idTxt.Click += new System.EventHandler(this.idTxt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(587, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 40);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "t";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(620, 309);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(111, 40);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "OYNA";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPlayer
            // 
            this.topPlayer.AutoSize = true;
            this.topPlayer.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topPlayer.Location = new System.Drawing.Point(830, 671);
            this.topPlayer.Name = "topPlayer";
            this.topPlayer.Size = new System.Drawing.Size(75, 32);
            this.topPlayer.TabIndex = 13;
            this.topPlayer.Text = "Skor:";
            // 
            // TopPointLbl
            // 
            this.TopPointLbl.AutoSize = true;
            this.TopPointLbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopPointLbl.Location = new System.Drawing.Point(912, 671);
            this.TopPointLbl.Name = "TopPointLbl";
            this.TopPointLbl.Size = new System.Drawing.Size(28, 32);
            this.TopPointLbl.TabIndex = 14;
            this.TopPointLbl.Text = "0";
            // 
            // enİyiLbl
            // 
            this.enİyiLbl.AutoSize = true;
            this.enİyiLbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enİyiLbl.Location = new System.Drawing.Point(1014, 639);
            this.enİyiLbl.Name = "enİyiLbl";
            this.enİyiLbl.Size = new System.Drawing.Size(124, 32);
            this.enİyiLbl.TabIndex = 15;
            this.enİyiLbl.Text = "   .....   ";
            this.enİyiLbl.Click += new System.EventHandler(this.enİyiLbl_Click);
            // 
            // oyuncuLbl
            // 
            this.oyuncuLbl.AutoSize = true;
            this.oyuncuLbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncuLbl.Location = new System.Drawing.Point(12, 515);
            this.oyuncuLbl.Name = "oyuncuLbl";
            this.oyuncuLbl.Size = new System.Drawing.Size(54, 32);
            this.oyuncuLbl.TabIndex = 16;
            this.oyuncuLbl.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(830, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "En iyi oyuncu:";
            // 
            // altBoru
            // 
            this.altBoru.Image = global::HappyFlappy.Properties.Resources.pipe;
            this.altBoru.Location = new System.Drawing.Point(658, 500);
            this.altBoru.Name = "altBoru";
            this.altBoru.Size = new System.Drawing.Size(100, 105);
            this.altBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altBoru.TabIndex = 3;
            this.altBoru.TabStop = false;
            this.altBoru.Click += new System.EventHandler(this.altBoru_Click);
            // 
            // üstBoru
            // 
            this.üstBoru.Image = global::HappyFlappy.Properties.Resources.pipedown;
            this.üstBoru.Location = new System.Drawing.Point(825, 131);
            this.üstBoru.Name = "üstBoru";
            this.üstBoru.Size = new System.Drawing.Size(100, 116);
            this.üstBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.üstBoru.TabIndex = 2;
            this.üstBoru.TabStop = false;
            // 
            // flappy
            // 
            this.flappy.Image = global::HappyFlappy.Properties.Resources.bird;
            this.flappy.Location = new System.Drawing.Point(141, 241);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(63, 62);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 5;
            this.flappy.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = global::HappyFlappy.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(1, 605);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(1267, 186);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 0;
            this.zemin.TabStop = false;
            // 
            // failBox
            // 
            this.failBox.Image = global::HappyFlappy.Properties.Resources.y7;
            this.failBox.Location = new System.Drawing.Point(441, 219);
            this.failBox.Name = "failBox";
            this.failBox.Size = new System.Drawing.Size(378, 243);
            this.failBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.failBox.TabIndex = 9;
            this.failBox.TabStop = false;
            this.failBox.Visible = false;
            this.failBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyFlappy.Properties.Resources.ground;
            this.pictureBox1.Location = new System.Drawing.Point(1, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1250, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // morning
            // 
            this.morning.Image = global::HappyFlappy.Properties.Resources.Aesthetic_Theme_Sun_PNG;
            this.morning.Location = new System.Drawing.Point(1, 2);
            this.morning.Name = "morning";
            this.morning.Size = new System.Drawing.Size(199, 129);
            this.morning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.morning.TabIndex = 7;
            this.morning.TabStop = false;
            // 
            // noon
            // 
            this.noon.Image = global::HappyFlappy.Properties.Resources.noon;
            this.noon.Location = new System.Drawing.Point(523, 2);
            this.noon.Name = "noon";
            this.noon.Size = new System.Drawing.Size(199, 129);
            this.noon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noon.TabIndex = 6;
            this.noon.TabStop = false;
            this.noon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // üst
            // 
            this.üst.Image = global::HappyFlappy.Properties.Resources.moon;
            this.üst.Location = new System.Drawing.Point(1052, 2);
            this.üst.Name = "üst";
            this.üst.Size = new System.Drawing.Size(199, 129);
            this.üst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.üst.TabIndex = 1;
            this.üst.TabStop = false;
            // 
            // topPlayerTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1269, 728);
            this.Controls.Add(this.altBoru);
            this.Controls.Add(this.üstBoru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.oyuncuLbl);
            this.Controls.Add(this.enİyiLbl);
            this.Controls.Add(this.TopPointLbl);
            this.Controls.Add(this.topPlayer);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.failBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.morning);
            this.Controls.Add(this.noon);
            this.Controls.Add(this.üst);
            this.Controls.Add(this.skorTxt);
            this.Name = "topPlayerTxt";
            this.Text = "yf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.altBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.üstBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.üst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox üst;
        private System.Windows.Forms.PictureBox üstBoru;
        private System.Windows.Forms.PictureBox altBoru;
        private System.Windows.Forms.Label skorTxt;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.Timer oyunZaman;
        private System.Windows.Forms.PictureBox noon;
        private System.Windows.Forms.PictureBox morning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox failBox;
        private System.Windows.Forms.Label idTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label topPlayer;
        private System.Windows.Forms.Label TopPointLbl;
        private System.Windows.Forms.Label enİyiLbl;
        private System.Windows.Forms.Label oyuncuLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox zemin;
    }
}

