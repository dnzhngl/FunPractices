using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApps
{
    public partial class KdvHesaplama : Form
    {
        public KdvHesaplama()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Para miktarını integera çevirir.
            int para = Convert.ToInt32(txtPara.Text);
            // Kdv oranını integera çevirir.
            int kdv = Convert.ToInt32(txtKdvOrani.Text);
            //Kdv'sini bulur.
            int kdvSi = para * kdv / 100;
            // Kdv miktarı ve para toplanır.
            int toplam = para + (para * kdv / 100);


            //listViewe ekleme

            // String türünde ad, soyad, paraMiktari, kdvOrani, kdvsi ve toplami değişkenlerini tanımlıyoruz ve aynı zamanda değerlerini de atıyoruz.
            string ad = txtAd.Text,
                soyad = txtSoyad.Text,
                paraMiktari = txtPara.Text,
                kdvOrani = txtKdvOrani.Text,
                kdvsi = Convert.ToString(kdvSi),
                toplami = Convert.ToString(toplam);

            // değerleri atanan değişkenleri bilgiler adında oluşturduğumuz listeye ekliyoruz.
            string[] bilgiler = { ad, soyad, paraMiktari, kdvOrani, kdvsi, toplami };

            //Kdv ListView'a bilgiler listesini yeni liste olacak şekilde ekliyoruz.
            lvKdv.Items.Add(new ListViewItem(bilgiler));

            // text boxlarıyeni veri girişine hazır hale getirmek için temizliyoruz.
            txtAd.Clear();
            txtSoyad.Clear();
            txtPara.Clear();
            txtKdvOrani.Clear();
        }
    }
}
