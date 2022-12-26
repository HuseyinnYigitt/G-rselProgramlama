
namespace WindowsFormsApp35
{
    partial class SehirBulmaca
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
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btn_HarfGir = new System.Windows.Forms.Button();
            this.btn_TahminEt = new System.Windows.Forms.Button();
            this.lbl_AktifHarfPuam = new System.Windows.Forms.Label();
            this.lAktifHarfPuani = new System.Windows.Forms.Label();
            this.lbl_TopalmP = new System.Windows.Forms.Label();
            this.lbl_ToplamPuan = new System.Windows.Forms.Label();
            this.pnl_OyunAlanı = new System.Windows.Forms.Panel();
            this.lbl_Girilenler = new System.Windows.Forms.Label();
            this.lbl_GirilenHarf = new System.Windows.Forms.Label();
            this.lbl_kalanH = new System.Windows.Forms.Label();
            this.lbl_KalanHak = new System.Windows.Forms.Label();
            this.txtb_Harf = new System.Windows.Forms.TextBox();
            this.txtb_Tahmin = new System.Windows.Forms.TextBox();
            this.listBox_SorulanSehirler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.White;
            this.btnBaslat.Location = new System.Drawing.Point(518, 102);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(142, 48);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Oyunu Baslat ";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btn_HarfGir
            // 
            this.btn_HarfGir.BackColor = System.Drawing.Color.White;
            this.btn_HarfGir.Enabled = false;
            this.btn_HarfGir.Location = new System.Drawing.Point(59, 53);
            this.btn_HarfGir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_HarfGir.Name = "btn_HarfGir";
            this.btn_HarfGir.Size = new System.Drawing.Size(100, 41);
            this.btn_HarfGir.TabIndex = 1;
            this.btn_HarfGir.Text = "Harfi Onayla";
            this.btn_HarfGir.UseVisualStyleBackColor = false;
            this.btn_HarfGir.Click += new System.EventHandler(this.btnHarf_Click);
            // 
            // btn_TahminEt
            // 
            this.btn_TahminEt.BackColor = System.Drawing.Color.White;
            this.btn_TahminEt.Enabled = false;
            this.btn_TahminEt.Location = new System.Drawing.Point(59, 64);
            this.btn_TahminEt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_TahminEt.Name = "btn_TahminEt";
            this.btn_TahminEt.Size = new System.Drawing.Size(100, 46);
            this.btn_TahminEt.TabIndex = 2;
            this.btn_TahminEt.Text = "Tahmini Onayla";
            this.btn_TahminEt.UseVisualStyleBackColor = false;
            this.btn_TahminEt.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lbl_AktifHarfPuam
            // 
            this.lbl_AktifHarfPuam.AutoSize = true;
            this.lbl_AktifHarfPuam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AktifHarfPuam.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_AktifHarfPuam.Location = new System.Drawing.Point(23, 57);
            this.lbl_AktifHarfPuam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AktifHarfPuam.Name = "lbl_AktifHarfPuam";
            this.lbl_AktifHarfPuam.Size = new System.Drawing.Size(107, 15);
            this.lbl_AktifHarfPuam.TabIndex = 3;
            this.lbl_AktifHarfPuam.Text = "Aktif Harf Puanı";
            // 
            // lAktifHarfPuani
            // 
            this.lAktifHarfPuani.AutoSize = true;
            this.lAktifHarfPuani.BackColor = System.Drawing.Color.Transparent;
            this.lAktifHarfPuani.ForeColor = System.Drawing.Color.DarkBlue;
            this.lAktifHarfPuani.Location = new System.Drawing.Point(152, 57);
            this.lAktifHarfPuani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAktifHarfPuani.Name = "lAktifHarfPuani";
            this.lAktifHarfPuani.Size = new System.Drawing.Size(15, 15);
            this.lAktifHarfPuani.TabIndex = 4;
            this.lAktifHarfPuani.Text = "0";
            // 
            // lbl_TopalmP
            // 
            this.lbl_TopalmP.AutoSize = true;
            this.lbl_TopalmP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TopalmP.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_TopalmP.Location = new System.Drawing.Point(23, 90);
            this.lbl_TopalmP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TopalmP.Name = "lbl_TopalmP";
            this.lbl_TopalmP.Size = new System.Drawing.Size(91, 15);
            this.lbl_TopalmP.TabIndex = 5;
            this.lbl_TopalmP.Text = "Toplam Puan";
            // 
            // lbl_ToplamPuan
            // 
            this.lbl_ToplamPuan.AutoSize = true;
            this.lbl_ToplamPuan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ToplamPuan.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_ToplamPuan.Location = new System.Drawing.Point(152, 90);
            this.lbl_ToplamPuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ToplamPuan.Name = "lbl_ToplamPuan";
            this.lbl_ToplamPuan.Size = new System.Drawing.Size(15, 15);
            this.lbl_ToplamPuan.TabIndex = 6;
            this.lbl_ToplamPuan.Text = "0";
            // 
            // pnl_OyunAlanı
            // 
            this.pnl_OyunAlanı.BackColor = System.Drawing.Color.White;
            this.pnl_OyunAlanı.Location = new System.Drawing.Point(120, 81);
            this.pnl_OyunAlanı.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_OyunAlanı.Name = "pnl_OyunAlanı";
            this.pnl_OyunAlanı.Size = new System.Drawing.Size(350, 110);
            this.pnl_OyunAlanı.TabIndex = 7;
            // 
            // lbl_Girilenler
            // 
            this.lbl_Girilenler.AutoSize = true;
            this.lbl_Girilenler.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Girilenler.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Girilenler.Location = new System.Drawing.Point(23, 143);
            this.lbl_Girilenler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Girilenler.Name = "lbl_Girilenler";
            this.lbl_Girilenler.Size = new System.Drawing.Size(100, 15);
            this.lbl_Girilenler.TabIndex = 8;
            this.lbl_Girilenler.Text = "Girilen Harfler";
            // 
            // lbl_GirilenHarf
            // 
            this.lbl_GirilenHarf.AutoSize = true;
            this.lbl_GirilenHarf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GirilenHarf.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_GirilenHarf.Location = new System.Drawing.Point(152, 143);
            this.lbl_GirilenHarf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GirilenHarf.Name = "lbl_GirilenHarf";
            this.lbl_GirilenHarf.Size = new System.Drawing.Size(0, 15);
            this.lbl_GirilenHarf.TabIndex = 9;
            // 
            // lbl_kalanH
            // 
            this.lbl_kalanH.AutoSize = true;
            this.lbl_kalanH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kalanH.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_kalanH.Location = new System.Drawing.Point(23, 115);
            this.lbl_kalanH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kalanH.Name = "lbl_kalanH";
            this.lbl_kalanH.Size = new System.Drawing.Size(73, 15);
            this.lbl_kalanH.TabIndex = 10;
            this.lbl_kalanH.Text = "Kalan Hak";
            // 
            // lbl_KalanHak
            // 
            this.lbl_KalanHak.AutoSize = true;
            this.lbl_KalanHak.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KalanHak.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_KalanHak.Location = new System.Drawing.Point(152, 115);
            this.lbl_KalanHak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KalanHak.Name = "lbl_KalanHak";
            this.lbl_KalanHak.Size = new System.Drawing.Size(15, 15);
            this.lbl_KalanHak.TabIndex = 11;
            this.lbl_KalanHak.Text = "0";
            // 
            // txtb_Harf
            // 
            this.txtb_Harf.BackColor = System.Drawing.Color.White;
            this.txtb_Harf.Enabled = false;
            this.txtb_Harf.Location = new System.Drawing.Point(18, 22);
            this.txtb_Harf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtb_Harf.Name = "txtb_Harf";
            this.txtb_Harf.Size = new System.Drawing.Size(178, 23);
            this.txtb_Harf.TabIndex = 12;
            // 
            // txtb_Tahmin
            // 
            this.txtb_Tahmin.BackColor = System.Drawing.Color.White;
            this.txtb_Tahmin.Enabled = false;
            this.txtb_Tahmin.Location = new System.Drawing.Point(18, 35);
            this.txtb_Tahmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtb_Tahmin.Name = "txtb_Tahmin";
            this.txtb_Tahmin.Size = new System.Drawing.Size(178, 23);
            this.txtb_Tahmin.TabIndex = 13;
            // 
            // listBox_SorulanSehirler
            // 
            this.listBox_SorulanSehirler.BackColor = System.Drawing.Color.White;
            this.listBox_SorulanSehirler.FormattingEnabled = true;
            this.listBox_SorulanSehirler.ItemHeight = 15;
            this.listBox_SorulanSehirler.Location = new System.Drawing.Point(864, 53);
            this.listBox_SorulanSehirler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_SorulanSehirler.Name = "listBox_SorulanSehirler";
            this.listBox_SorulanSehirler.Size = new System.Drawing.Size(88, 304);
            this.listBox_SorulanSehirler.TabIndex = 14;
            this.listBox_SorulanSehirler.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_AktifHarfPuam);
            this.groupBox1.Controls.Add(this.lAktifHarfPuani);
            this.groupBox1.Controls.Add(this.lbl_TopalmP);
            this.groupBox1.Controls.Add(this.lbl_ToplamPuan);
            this.groupBox1.Controls.Add(this.lbl_KalanHak);
            this.groupBox1.Controls.Add(this.lbl_Girilenler);
            this.groupBox1.Controls.Add(this.lbl_kalanH);
            this.groupBox1.Controls.Add(this.lbl_GirilenHarf);
            this.groupBox1.Location = new System.Drawing.Point(418, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 177);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Alanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(207, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "SEHIR BULMACA OYUNU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_HarfGir);
            this.groupBox2.Controls.Add(this.txtb_Harf);
            this.groupBox2.Location = new System.Drawing.Point(120, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 113);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Harf Gir ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtb_Tahmin);
            this.groupBox3.Controls.Add(this.btn_TahminEt);
            this.groupBox3.Location = new System.Drawing.Point(120, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 137);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tahmin Ettiğin Yeri Gir ";
            // 
            // SehirBulmaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 519);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_SorulanSehirler);
            this.Controls.Add(this.pnl_OyunAlanı);
            this.Controls.Add(this.btnBaslat);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SehirBulmaca";
            this.Text = "Sehir Bulamca Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btn_HarfGir;
        private System.Windows.Forms.Button btn_TahminEt;
        private System.Windows.Forms.Label lbl_AktifHarfPuam;
        private System.Windows.Forms.Label lAktifHarfPuani;
        private System.Windows.Forms.Label lbl_TopalmP;
        private System.Windows.Forms.Label lbl_ToplamPuan;
        private System.Windows.Forms.Panel pnl_OyunAlanı;
        private System.Windows.Forms.Label lbl_Girilenler;
        private System.Windows.Forms.Label lbl_GirilenHarf;
        private System.Windows.Forms.Label lbl_kalanH;
        private System.Windows.Forms.Label lbl_KalanHak;
        private System.Windows.Forms.TextBox txtb_Harf;
        private System.Windows.Forms.TextBox txtb_Tahmin;
        private System.Windows.Forms.ListBox listBox_SorulanSehirler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

