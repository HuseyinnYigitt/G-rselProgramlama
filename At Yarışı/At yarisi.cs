using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp32
{
    public partial class At_Yarisi : Form
    {
        public At_Yarisi()
        {
            InitializeComponent();
        }
        //Kullanacagım veriler programmda tanımlanıyor.
        int atGenisligi, bitisuzakligi, konumBirinciAt;
        Random rastgeleAtHizi = new Random();

        int[] konumlar = new int[6];


        private void At_Yarisi_Load(object sender, EventArgs e)
        {
            //At görüntülerinin genişlikleri eşit hale getirilir.
            atGenisligi = pbAt1.Width;
            
            pbAt2.Width = atGenisligi;
            pbAt3.Width = atGenisligi;
            pbAt4.Width = atGenisligi;
            pbAt5.Width = atGenisligi;
            pbAt6.Width = atGenisligi;
            timerOyun.Interval = 100;

            bitisuzakligi = lBitisNoktasi.Left - atGenisligi;
        }


        private void btnBaslatDurdur_Click(object sender, EventArgs e)
        {   //Timerların başlaması
            if (timerOyun.Enabled == false)
                timerOyun.Start();
            else
                timerOyun.Stop();
        }
        private void timerOyun_Tick(object sender, EventArgs e)
        {  //Atların başlangıç konumları eşitleniyor.
            konumlar[0] = pbAt1.Left;
            konumlar[1] = pbAt2.Left;
            konumlar[2] = pbAt3.Left;
            konumlar[3] = pbAt4.Left;
            konumlar[4] = pbAt5.Left;
            konumlar[5] = pbAt6.Left;


            int birinciAtNo = atNoDondur();
            lbl_Durum.Text = birinciAtNo + " numaralı at önde";
            konumBirinciAt = konumlar[birinciAtNo-1];
            //Kazanan atı belirleyip kullanıcıya gösteriyor.
            if (konumBirinciAt > bitisuzakligi)
            {
                timerOyun.Enabled = false;
                MessageBox.Show(birinciAtNo + " numaralı at yarışı kazandı. ");
            }

            // At görüntülerinin eski konumunu 1 ile 20 arasında rastgele kadar arttırılır.
            pbAt1.Left += rastgeleAtHizi.Next(1, 20);
            pbAt2.Left += rastgeleAtHizi.Next(1, 20);
            pbAt3.Left += rastgeleAtHizi.Next(1, 20);
            pbAt4.Left += rastgeleAtHizi.Next(1, 20);
            pbAt5.Left += rastgeleAtHizi.Next(1, 20);
            pbAt6.Left += rastgeleAtHizi.Next(1, 20);
        }

        private int atNoDondur()
        {
            Array.Sort(konumlar);
            if (pbAt1.Left == konumlar[5]) return 1;
            else if (pbAt2.Left == konumlar[5]) return 2;
            else if (pbAt3.Left == konumlar[5]) return 3;
            else if (pbAt4.Left == konumlar[5]) return 4;
            else if (pbAt5.Left == konumlar[5]) return 5;
            else if (pbAt6.Left == konumlar[5]) return 6;

            else return 0;
        }
    }
}
