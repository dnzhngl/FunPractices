using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPractices
{
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }

        //Globaldeki değişkenler
        int score, totalScore;
        int counter = 0;

        private void btnDice_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            // stop tuşuna basıldıktan sonraki skor değeri ile eski skor değerini toplayıp total skora ekliyoruz.
            totalScore += score;

            lblScore.Text = score.ToString();
            lblTotalScore.Text = totalScore.ToString();

            // stop tuşuna her basıldığında counter'ı 1 artırıyoruz.
            counter++;
            lblCounter.Text = counter.ToString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            /* String türünde pathToDicePic diye bir değişken oluşturduk.
               Bu değişkene bu uygulamanın her bilgisayarda çalışabilmesi için application.startup path'i yani bu uygulamanın başlatıldığı dosyanın adresine atadık.
               Sonra resimlerin random olarak ekranda görünmelerini sağlamak için random türünde rnd değişkenini oluşturduk.
               Sonra imageBoxların içindeki resimleri, image.FromFile ile resmi şu dosyadan alacağımız göstermek istedik.
               Ve buraya önceden oluşturmuş olduğumuz resimlerin bulunduğu dosyanın adresini atadığımız pathToDicePic değişkenine 
               @"\zar diyerek zar resimlerinin isimlerinin ortak kısımlarını yazıp sonra 1 ile 6 arasında sayı randomlanmasını sağlayarak isimlerini tamamladık. 
               Ve resimlerin bu random sayılar aracılığı ile gelmelerini sağladık.

               picDice1.Image = Image.FromFile(pathToDicePic + @"\zar" + rnd.Next(1, 7) + ".png");

             * */
            string pathToDicePic = "../../MyResources/Dices/"; //Application.StartupPath;
            Random rnd = new Random();
            int leftDice = rnd.Next(1, 7);
            int rightDice = rnd.Next(1, 7);

            #region Önceki dosya yolu
            //picDice1.Image = Image.FromFile(pathToDicePic + @"\zar" + leftDice + ".png");
            //picDice2.Image = Image.FromFile(pathToDicePic + @"\zar" + rightDice + ".png");
            #endregion

            picDice1.Image = Image.FromFile(pathToDicePic + leftDice + ".png");
            picDice2.Image = Image.FromFile(pathToDicePic + rightDice + ".png");

            // O turndeki scoru burada hesaplıyoruz.
            score = leftDice + rightDice;

        }
    }
}
