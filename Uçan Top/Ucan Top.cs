using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37
{
    public partial class Ucan_Top : Form
    {
        public Ucan_Top()
        {
            InitializeComponent();
            
        }
        //Topun hızı ,suresi tanımlanıyor.
        int hızX = 5, hızY = 5, sure = 0;
        int skor = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            btnRaket.Left = e.X;
        }


        private void timerOyun_Tick(object sender, EventArgs e)
        {
            sure++;
            lbl_sure.Text = Convert.ToString(sure / 10);
            carpmaKontrolu();
            yanmaKontrolu();
            btn_Top.Location = new Point(btn_Top.Location.X + hızX, btn_Top.Location.Y + hızY);//Top noktsı belirleniyor.
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "block")//PictureBox daki nesanelerin block oldugu tanımlanıyor.
                {
                    if (btn_Top.Bounds.IntersectsWith(x.Bounds))
                    {
                        skor += 1;
                        lSkor.Text = skor.ToString();
                        if (skor == 9)//Eger 9 tane picturebocks carparsa top , oyun kazanıldı diyor ve tekrar 
                        {
                            timerOyun.Stop();
                            MessageBox.Show("KAZANDINIZ!!");
                            Application.Restart();
                        }
                        if (skor == 5 || skor == 10 || skor == 20 || skor == 30 || skor==40 || skor==50|| skor==60||skor==70|| skor==80 || skor==90)
                        {
                            if (hızY < 0)
                            {
                                hızY -= 1;
                            }
                            else
                            {
                                hızY += 1;
                            }
                            if (hızX < 0)
                            {
                                hızX -= 1;
                            }
                            else
                            {
                                hızX += 1;
                            }
                        }
                        hızY = -hızY;
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void btnBaslaDevamEt_Click(object sender, EventArgs e)
        {
            timerOyun.Enabled = true;
            btn_Top.Location = new Point(415, 107);//ilk başlanan nokta
        }
        private void btn_Yavas_Click(object sender, EventArgs e)
        {
            hızX = 10;
            hızY = 10;
            label_HızDurum.Text = btn_Yavas.Text;
        }

        private void btn_Orta_Click(object sender, EventArgs e)
        {
            hızX = 20;
            hızY = 20;
            label_HızDurum.Text = btn_Orta.Text;
        }

        private void button_Hızlı_Click(object sender, EventArgs e)
        {
            hızX = 30;
            hızY = 30;
            label_HızDurum.Text = button_Hızlı.Text;
        }

        private void yanmaKontrolu()
        {
            int kalanHak = Convert.ToInt32(lbl_KalanHak.Text);
            if (btn_Top.Top >= lbl_Sagkenar.Bottom)//Topun yanması durumda nerede bulunacagı ve yanma hakkı sıfırlanırsada oyunu bitiriyor.
            {

                if (kalanHak > 0)
                {
                    kalanHak--;
                    lbl_KalanHak.Text = kalanHak.ToString();
                    timerOyun.Enabled = false;
                    btn_Top.Location = new Point(415, 107);//ilk başlanan nokta
                }
                else
                {
                    timerOyun.Enabled = false;
                    lbl_KalanHak.Text = "Kaybettiniz ... ";
                    MessageBox.Show("Game Over...");
                }
            }
        }
        private void carpmaKontrolu()
        {
            if (btn_Top.Top <= lbl_Ustkenar.Bottom)
                hızY = hızY * -1;
            else if (btn_Top.Bottom >= btnRaket.Top && btn_Top.Left >= btnRaket.Left && btn_Top.Right <= btnRaket.Right)
            {
                hızY = hızY * -1;
                int kurtarmaSayisi = Convert.ToInt32(lbl_Kurtarma.Text);
                lbl_Kurtarma.Text = Convert.ToString(kurtarmaSayisi + 1);
            }
            else if (btn_Top.Right >= lbl_Sagkenar.Left)
                hızX = hızX * -1;
            else if (btn_Top.Left <= lbl_Solkenar.Right)
                hızX = hızX * -1;
        }
    }
}
