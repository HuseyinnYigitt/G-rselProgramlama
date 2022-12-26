using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class SehirBulmaca : Form
    {
        public SehirBulmaca()
        {
            InitializeComponent();
        }
        //Şehirleri tanımladım
        string sehirler =
            "ADANA,ADIYAMAN,AFYONKARAHİSAR,AĞRI,AKSARAY,AMASYA,ANKARA,ANTALYA,ARDAHAN," +
            "ARTVİN,AYDIN,BALIKESİR,BARTIN,BATMAN,BAYBURT,BİLECİK,BİNGÖL,BİTLİS,BOLU," +
            "BURDUR,BURSA,ÇANAKKALE,ÇANKIRI,ÇORUM,DENİZLİ,DİYARBAKIR,DÜZCE,EDİRNE," +
            "ELAZIĞ,ERZİNCAN,ERZURUM,ESKİŞEHİR,GAZİANTEP,GİRESUN,GÜMÜŞHANE,HAKKARİ," +
            "HATAY,IĞDIR,ISPARTA,İSTANBUL,İZMİR,KAHRAMANMARAŞ,KARABÜK,KARAMAN,KARS," +
            "KASTAMONU,KAYSERİ,KIRIKKALE,KIRKLARELİ,KIRŞEHİR,KİLİS,KOCAELİ,KONYA," +
            "KÜTAHYA,MALATYA,MANİSA,MARDİN,MERSİN,MUĞLA,MUŞ,NEVŞEH1R,NİĞDE,ORDU," +
            "OSMANİYE,RİZE,SAKARYA,SAMSUN,SİİRT,SİNOP,SİVAS,ŞIRNAK,TEKİRDAĞ,TOKAT," +
            "TRABZON,TUNCELİ,ŞANLIURFA,UŞAK,VAN,YALOVA,YOZGAT,ZONGULDAK";
        //Değişkenleri tanımladım.
        string[] sehirlerlistesi;
        string sehirismi = "";
        int harfSayisi = 0;
        int kalanHak = 4;
        Random rnd = new Random();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sehirlerlistesi = sehirler.Split(',');
            txtb_Harf.MaxLength = 1;
            btn_HarfGir.Enabled = false;
            btn_TahminEt.Enabled = false;
        }
       
        private void btnBaslat_Click(object sender, EventArgs e)
            //baslat tuşuna basıldıgında toplam puan, kalan hak,harf sayısını gösteren textboxlara ve labellara veri girişi yapıyoruz.
        {
            kalanHak = 4;
            lbl_ToplamPuan.Text = "0";
            lAktifHarfPuani.Text = rnd.Next(1, 20).ToString();
            harfSayisi = 0;
            btn_HarfGir.Enabled = true;
            btn_TahminEt.Enabled = true;
            txtb_Harf.Enabled = true;
            txtb_Tahmin.Enabled = true;
            lbl_GirilenHarf.Text = "";
            int rastgelesayi = rnd.Next(0, sehirlerlistesi.Length);
            sehirismi = sehirlerlistesi[rastgelesayi];
            lbl_KalanHak.Text = kalanHak.ToString();
            pnl_OyunAlanı.Controls.Clear();
            txtb_Harf.Text = "";
            txtb_Tahmin.Text = "";
            
            if (listBox_SorulanSehirler.Items.Contains(rastgelesayi.ToString()))
            {
                //Şehirleri rasgele sordurtmak için while döngüsü kullandım
                while (true)
                {
                    rastgelesayi = rnd.Next(0, sehirler.Length);
                    sehirismi = sehirlerlistesi[rastgelesayi];

                    if (false == listBox_SorulanSehirler.Items.Contains(rastgelesayi.ToString()))
                    {
                        break;
                    }
                }
            }
            if (false == listBox_SorulanSehirler.Items.Contains(rastgelesayi.ToString()))
            {
                //kelime uzunluguna göre label ayarladım ve renk verdim.
                listBox_SorulanSehirler.Items.Add(rastgelesayi.ToString());
                for (int i = 0; i < sehirismi.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(20 * i + 30, 20);
                    lbl.Text = sehirismi[i].ToString();
                    lbl.Size = new System.Drawing.Size(15, 20);
                    lbl.BackColor = Color.Red;
                    lbl.ForeColor = Color.Red;
                    pnl_OyunAlanı.Controls.Add(lbl);

                }
            }
        }

        private void btnHarf_Click(object sender, EventArgs e)
        {
            
            if (lbl_GirilenHarf.Text.Contains(txtb_Harf.Text))
            {
                //Aynı harf tekrar girilirse uyarı veriliyor.
                MessageBox.Show("Bu harfi daha önce girmiştiniz");
                txtb_Harf.Text = "";
                txtb_Harf.Focus();
            }
            bool harfDurumu = false;
            foreach (Control item in pnl_OyunAlanı.Controls)
            {
                if (item is Label)
                {
                    Label label = item as Label;
                    if (label.Text == txtb_Harf.Text.ToUpper())
                    {
                        label.ForeColor = Color.White;
                        label.BackColor = Color.Lime;
                        harfDurumu = true;
                        harfSayisi++;
                        lbl_ToplamPuan.Text = Convert.ToString(Convert.ToInt32(lbl_ToplamPuan.Text) + Convert.ToInt32(lAktifHarfPuani.Text));
                    }
                }
            }
            lAktifHarfPuani.Text = rnd.Next(1, 20).ToString();
            if (!harfDurumu)
            {
                kalanHak--;
                lbl_KalanHak.Text = kalanHak.ToString();
                if (kalanHak == 0)
                {
                    btn_HarfGir.Enabled = false;
                    btn_TahminEt.Enabled = false;
                    MessageBox.Show("Üzgünüz kaybettiniz. Cevap: " + sehirismi);
                }
            }
            lbl_GirilenHarf.Text += txtb_Harf.Text + " ";
            if (harfSayisi == sehirismi.Length)
            {

                btn_HarfGir.Enabled = false;
                btn_TahminEt.Enabled = false;
                MessageBox.Show("Tebrikler kazandınız.");
            }
            txtb_Harf.Text = "";
            txtb_Harf.Focus();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            //Burada Kullanıcının tahmin ettiği Sehir dogru ise Kazandınız diyor değilse Kaybettiniz diyor.
            //Labellarında renkleri ayarlanıyor.
            if (sehirismi == txtb_Tahmin.Text.ToUpper())
            {
                foreach (Control item in pnl_OyunAlanı.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;
                    }
                }

                MessageBox.Show("Tebrikler Dogru Tahmin.");
            }
            else
            {
                MessageBox.Show("Üzgünüz kaybettiniz . Cevap:" + sehirismi);
            }

            btn_HarfGir.Enabled = false;
            btn_TahminEt.Enabled = false;
        }
    }
}
