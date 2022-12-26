
namespace WindowsFormsApp37
{
    partial class Ucan_Top
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
            this.lbl_Solkenar = new System.Windows.Forms.Label();
            this.lbl_Ustkenar = new System.Windows.Forms.Label();
            this.lbl_Sagkenar = new System.Windows.Forms.Label();
            this.btnRaket = new System.Windows.Forms.Button();
            this.btn_Top = new System.Windows.Forms.Button();
            this.btnBaslaDevamEt = new System.Windows.Forms.Button();
            this.label_Sure = new System.Windows.Forms.Label();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.label_Kalanhak = new System.Windows.Forms.Label();
            this.lbl_KalanHak = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Kurtarma = new System.Windows.Forms.Label();
            this.timerOyun = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lSkor = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_HızDurum = new System.Windows.Forms.Label();
            this.btn_Yavas = new System.Windows.Forms.Button();
            this.btn_Orta = new System.Windows.Forms.Button();
            this.button_Hızlı = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Solkenar
            // 
            this.lbl_Solkenar.BackColor = System.Drawing.Color.Black;
            this.lbl_Solkenar.Location = new System.Drawing.Point(3, 9);
            this.lbl_Solkenar.Name = "lbl_Solkenar";
            this.lbl_Solkenar.Size = new System.Drawing.Size(32, 420);
            this.lbl_Solkenar.TabIndex = 0;
            // 
            // lbl_Ustkenar
            // 
            this.lbl_Ustkenar.BackColor = System.Drawing.Color.Black;
            this.lbl_Ustkenar.Location = new System.Drawing.Point(6, 9);
            this.lbl_Ustkenar.Name = "lbl_Ustkenar";
            this.lbl_Ustkenar.Size = new System.Drawing.Size(793, 21);
            this.lbl_Ustkenar.TabIndex = 1;
            // 
            // lbl_Sagkenar
            // 
            this.lbl_Sagkenar.BackColor = System.Drawing.Color.Black;
            this.lbl_Sagkenar.Location = new System.Drawing.Point(770, 9);
            this.lbl_Sagkenar.Name = "lbl_Sagkenar";
            this.lbl_Sagkenar.Size = new System.Drawing.Size(29, 420);
            this.lbl_Sagkenar.TabIndex = 2;
            // 
            // btnRaket
            // 
            this.btnRaket.BackColor = System.Drawing.Color.Black;
            this.btnRaket.Location = new System.Drawing.Point(345, 406);
            this.btnRaket.Name = "btnRaket";
            this.btnRaket.Size = new System.Drawing.Size(75, 23);
            this.btnRaket.TabIndex = 3;
            this.btnRaket.UseVisualStyleBackColor = false;
            // 
            // btn_Top
            // 
            this.btn_Top.BackColor = System.Drawing.Color.Red;
            this.btn_Top.Location = new System.Drawing.Point(371, 103);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(23, 23);
            this.btn_Top.TabIndex = 4;
            this.btn_Top.UseVisualStyleBackColor = false;
            // 
            // btnBaslaDevamEt
            // 
            this.btnBaslaDevamEt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslaDevamEt.Location = new System.Drawing.Point(817, 223);
            this.btnBaslaDevamEt.Name = "btnBaslaDevamEt";
            this.btnBaslaDevamEt.Size = new System.Drawing.Size(248, 45);
            this.btnBaslaDevamEt.TabIndex = 5;
            this.btnBaslaDevamEt.Text = "Başla / Devam Et";
            this.btnBaslaDevamEt.UseVisualStyleBackColor = true;
            this.btnBaslaDevamEt.Click += new System.EventHandler(this.btnBaslaDevamEt_Click);
            // 
            // label_Sure
            // 
            this.label_Sure.AutoSize = true;
            this.label_Sure.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sure.Location = new System.Drawing.Point(822, 32);
            this.label_Sure.Name = "label_Sure";
            this.label_Sure.Size = new System.Drawing.Size(53, 22);
            this.label_Sure.TabIndex = 6;
            this.label_Sure.Text = "Süre";
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sure.Location = new System.Drawing.Point(984, 32);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(21, 22);
            this.lbl_sure.TabIndex = 7;
            this.lbl_sure.Text = "0";
            // 
            // label_Kalanhak
            // 
            this.label_Kalanhak.AutoSize = true;
            this.label_Kalanhak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Kalanhak.Location = new System.Drawing.Point(822, 81);
            this.label_Kalanhak.Name = "label_Kalanhak";
            this.label_Kalanhak.Size = new System.Drawing.Size(145, 22);
            this.label_Kalanhak.TabIndex = 8;
            this.label_Kalanhak.Text = "Kalan Hakkınız";
            // 
            // lbl_KalanHak
            // 
            this.lbl_KalanHak.AutoSize = true;
            this.lbl_KalanHak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KalanHak.Location = new System.Drawing.Point(984, 81);
            this.lbl_KalanHak.Name = "lbl_KalanHak";
            this.lbl_KalanHak.Size = new System.Drawing.Size(21, 22);
            this.lbl_KalanHak.TabIndex = 9;
            this.lbl_KalanHak.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(822, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kurtarma Sayısı";
            // 
            // lbl_Kurtarma
            // 
            this.lbl_Kurtarma.AutoSize = true;
            this.lbl_Kurtarma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kurtarma.Location = new System.Drawing.Point(984, 129);
            this.lbl_Kurtarma.Name = "lbl_Kurtarma";
            this.lbl_Kurtarma.Size = new System.Drawing.Size(21, 22);
            this.lbl_Kurtarma.TabIndex = 11;
            this.lbl_Kurtarma.Text = "0";
            // 
            // timerOyun
            // 
            this.timerOyun.Tick += new System.EventHandler(this.timerOyun_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Location = new System.Drawing.Point(345, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 31);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(345, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 31);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "block";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Magenta;
            this.pictureBox3.Location = new System.Drawing.Point(519, 129);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 31);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "block";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.Location = new System.Drawing.Point(345, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 31);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "block";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Skor";
            // 
            // lSkor
            // 
            this.lSkor.AutoSize = true;
            this.lSkor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSkor.Location = new System.Drawing.Point(984, 178);
            this.lSkor.Name = "lSkor";
            this.lSkor.Size = new System.Drawing.Size(21, 22);
            this.lSkor.TabIndex = 17;
            this.lSkor.Text = "0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox5.Location = new System.Drawing.Point(186, 311);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 31);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "block";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox6.Location = new System.Drawing.Point(186, 129);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(71, 31);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "block";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Blue;
            this.pictureBox7.Location = new System.Drawing.Point(519, 311);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(71, 31);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "block";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Red;
            this.pictureBox8.Location = new System.Drawing.Point(644, 223);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(71, 31);
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "block";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(65, 223);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(71, 31);
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "block";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "HIZ AYARI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "HIZ DURUMU=";
            // 
            // label_HızDurum
            // 
            this.label_HızDurum.AutoSize = true;
            this.label_HızDurum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HızDurum.Location = new System.Drawing.Point(953, 404);
            this.label_HızDurum.Name = "label_HızDurum";
            this.label_HızDurum.Size = new System.Drawing.Size(124, 22);
            this.label_HızDurum.TabIndex = 28;
            this.label_HızDurum.Text = "COK YAVAS";
            // 
            // btn_Yavas
            // 
            this.btn_Yavas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yavas.Location = new System.Drawing.Point(957, 288);
            this.btn_Yavas.Name = "btn_Yavas";
            this.btn_Yavas.Size = new System.Drawing.Size(86, 27);
            this.btn_Yavas.TabIndex = 29;
            this.btn_Yavas.Text = "YAVAS";
            this.btn_Yavas.UseVisualStyleBackColor = true;
            this.btn_Yavas.Click += new System.EventHandler(this.btn_Yavas_Click);
            // 
            // btn_Orta
            // 
            this.btn_Orta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orta.Location = new System.Drawing.Point(957, 322);
            this.btn_Orta.Name = "btn_Orta";
            this.btn_Orta.Size = new System.Drawing.Size(86, 27);
            this.btn_Orta.TabIndex = 30;
            this.btn_Orta.Text = "ORTA";
            this.btn_Orta.UseVisualStyleBackColor = true;
            this.btn_Orta.Click += new System.EventHandler(this.btn_Orta_Click);
            // 
            // button_Hızlı
            // 
            this.button_Hızlı.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Hızlı.Location = new System.Drawing.Point(957, 355);
            this.button_Hızlı.Name = "button_Hızlı";
            this.button_Hızlı.Size = new System.Drawing.Size(86, 27);
            this.button_Hızlı.TabIndex = 31;
            this.button_Hızlı.Text = "HIZLI";
            this.button_Hızlı.UseVisualStyleBackColor = true;
            this.button_Hızlı.Click += new System.EventHandler(this.button_Hızlı_Click);
            // 
            // Ucan_Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.button_Hızlı);
            this.Controls.Add(this.btn_Orta);
            this.Controls.Add(this.btn_Yavas);
            this.Controls.Add(this.label_HızDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lSkor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Kurtarma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_KalanHak);
            this.Controls.Add(this.label_Kalanhak);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.label_Sure);
            this.Controls.Add(this.btnBaslaDevamEt);
            this.Controls.Add(this.btn_Top);
            this.Controls.Add(this.btnRaket);
            this.Controls.Add(this.lbl_Sagkenar);
            this.Controls.Add(this.lbl_Ustkenar);
            this.Controls.Add(this.lbl_Solkenar);
            this.Name = "Ucan_Top";
            this.Text = "Ucan Top Oyunu";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Solkenar;
        private System.Windows.Forms.Label lbl_Ustkenar;
        private System.Windows.Forms.Label lbl_Sagkenar;
        private System.Windows.Forms.Button btnRaket;
        private System.Windows.Forms.Button btn_Top;
        private System.Windows.Forms.Button btnBaslaDevamEt;
        private System.Windows.Forms.Label label_Sure;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label label_Kalanhak;
        private System.Windows.Forms.Label lbl_KalanHak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Kurtarma;
        private System.Windows.Forms.Timer timerOyun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lSkor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_HızDurum;
        private System.Windows.Forms.Button btn_Yavas;
        private System.Windows.Forms.Button btn_Orta;
        private System.Windows.Forms.Button button_Hızlı;
    }
}

