
namespace WindowsFormsApp32
{
    partial class At_Yarisi
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
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.pbAt4 = new System.Windows.Forms.PictureBox();
            this.lBitisNoktasi = new System.Windows.Forms.Label();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.label_Yazı = new System.Windows.Forms.Label();
            this.btn_BaslatDurdur = new System.Windows.Forms.Button();
            this.timerOyun = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbAt6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbAt5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAt1
            // 
            this.pbAt1.Image = global::WindowsFormsApp32.Properties.Resources.at1;
            this.pbAt1.Location = new System.Drawing.Point(106, 100);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(100, 50);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt1.TabIndex = 0;
            this.pbAt1.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.Image = global::WindowsFormsApp32.Properties.Resources.at2;
            this.pbAt2.Location = new System.Drawing.Point(106, 177);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(100, 50);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt2.TabIndex = 1;
            this.pbAt2.TabStop = false;
            // 
            // pbAt3
            // 
            this.pbAt3.Image = global::WindowsFormsApp32.Properties.Resources.at3;
            this.pbAt3.Location = new System.Drawing.Point(106, 254);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(100, 50);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt3.TabIndex = 2;
            this.pbAt3.TabStop = false;
            // 
            // pbAt4
            // 
            this.pbAt4.Image = global::WindowsFormsApp32.Properties.Resources.at4;
            this.pbAt4.Location = new System.Drawing.Point(106, 331);
            this.pbAt4.Name = "pbAt4";
            this.pbAt4.Size = new System.Drawing.Size(100, 50);
            this.pbAt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt4.TabIndex = 3;
            this.pbAt4.TabStop = false;
            // 
            // lBitisNoktasi
            // 
            this.lBitisNoktasi.BackColor = System.Drawing.Color.Red;
            this.lBitisNoktasi.Location = new System.Drawing.Point(872, 81);
            this.lBitisNoktasi.Name = "lBitisNoktasi";
            this.lBitisNoktasi.Size = new System.Drawing.Size(17, 452);
            this.lBitisNoktasi.TabIndex = 4;
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Durum.Location = new System.Drawing.Point(421, 34);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(104, 15);
            this.lbl_Durum.TabIndex = 5;
            this.lbl_Durum.Text = "Atların durumu";
            // 
            // label_Yazı
            // 
            this.label_Yazı.AutoSize = true;
            this.label_Yazı.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Yazı.Location = new System.Drawing.Point(307, 34);
            this.label_Yazı.Name = "label_Yazı";
            this.label_Yazı.Size = new System.Drawing.Size(95, 15);
            this.label_Yazı.TabIndex = 6;
            this.label_Yazı.Text = "Yarıs Durumu";
            // 
            // btn_BaslatDurdur
            // 
            this.btn_BaslatDurdur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaslatDurdur.Location = new System.Drawing.Point(83, 18);
            this.btn_BaslatDurdur.Name = "btn_BaslatDurdur";
            this.btn_BaslatDurdur.Size = new System.Drawing.Size(158, 46);
            this.btn_BaslatDurdur.TabIndex = 7;
            this.btn_BaslatDurdur.Text = "Başlat/Durdur";
            this.btn_BaslatDurdur.UseVisualStyleBackColor = true;
            this.btn_BaslatDurdur.Click += new System.EventHandler(this.btnBaslatDurdur_Click);
            // 
            // timerOyun
            // 
            this.timerOyun.Tick += new System.EventHandler(this.timerOyun_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(850, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "           1 Numaralı at";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(850, 16);
            this.label9.TabIndex = 15;
            // 
            // pbAt6
            // 
            this.pbAt6.Image = global::WindowsFormsApp32.Properties.Resources.at2;
            this.pbAt6.Location = new System.Drawing.Point(106, 464);
            this.pbAt6.Name = "pbAt6";
            this.pbAt6.Size = new System.Drawing.Size(100, 50);
            this.pbAt6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt6.TabIndex = 18;
            this.pbAt6.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(850, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "           2 Numaralı at";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(850, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "           3 Numaralı at";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(850, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "           4 Numaralı at";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(850, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "           5 Numaralı at";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(16, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(850, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "           6 Numaralı at";
            // 
            // pbAt5
            // 
            this.pbAt5.Image = global::WindowsFormsApp32.Properties.Resources.at1;
            this.pbAt5.Location = new System.Drawing.Point(106, 392);
            this.pbAt5.Name = "pbAt5";
            this.pbAt5.Size = new System.Drawing.Size(100, 50);
            this.pbAt5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt5.TabIndex = 24;
            this.pbAt5.TabStop = false;
            // 
            // At_Yarisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(905, 570);
            this.Controls.Add(this.pbAt5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbAt6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BaslatDurdur);
            this.Controls.Add(this.label_Yazı);
            this.Controls.Add(this.lbl_Durum);
            this.Controls.Add(this.lBitisNoktasi);
            this.Controls.Add(this.pbAt4);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt1);
            this.Name = "At_Yarisi";
            this.Text = "At_Yarisi";
            this.Load += new System.EventHandler(this.At_Yarisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.PictureBox pbAt4;
        private System.Windows.Forms.Label lBitisNoktasi;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.Label label_Yazı;
        private System.Windows.Forms.Button btn_BaslatDurdur;
        private System.Windows.Forms.Timer timerOyun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbAt6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbAt5;
    }
}

