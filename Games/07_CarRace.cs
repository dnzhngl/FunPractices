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
    public partial class CarRace : Form
    {
        public CarRace()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
            btnPlayAgain.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gameSpeed);
            otherCars(gameSpeed);
            gameOver();
        }
        //CREDITS : From miniprogrammers youtube channel - Car Racing Complete Game in C# : https://www.youtube.com/watch?v=xyggRDkoOwU 

        /* life ADINDA DEĞİŞKEN TANIMLA. Değeri 5 olsun. ONU DA lblLife'a ata.
         * her çarpışmada life'ı 1 azalt. Life 0'a eşit olunca. game over ve play ekranda çıksın.
         * Ayrıca lblScore'a scor adında bi dğeişken tanımlayıp ata. Arabanın geçtiği araba sayısına göre yada hızına göre scorun artmasını ve sürekli ekrana yazmasını sağla.
        */

        //Globalde tanımlı değişkenler

        int gameSpeed = 0;
        Random rnd = new Random();
        int x;

        // Diğer arabaların tekrardan random lokasyonlarda belirmesi
        // BİRBİRLERİNİN ÜSTLERİNDE OLUŞUYORLAR & BELLİ BİR DÜZEN OLUŞTURMALISIN!!
        // AYRICA ARAÇLARIN KENDİ AYRI RANDOM HIZLARI OLSA FENA OLMAZ
        void otherCars(int speed)
        {
            /* RESİMLERİN RANDOM OLARAK ORTAYA ÇIKMASI İÇİN YAZDIN. 
             * ANCAK ARABALAR ÜST ÜSTE ÇIKIYOR :D...
             * AMA OYUN ÇALIŞIYOR HATA YOK.
             
            String carPics = Application.StartupPath;
            Random rnd = new Random();

            Image imgCar;
            imgCar = Image.FromFile(carPics + @"\Cars\car" + rnd.Next(1, 10) + ".png");

            */

            if (picCar1.Top >= 500)
            {
                x = rnd.Next(13, 94);
                picCar1.Location = new Point(x, 0);
            }
            else
            { picCar1.Top += speed; }

            if (picCar2.Top >= 500)
            {
                x = rnd.Next(94, 192);
                picCar2.Location = new Point(x, 0);
            }
            else
            { picCar2.Top += speed; }

            if (picCar3.Top >= 700)
            {
                x = rnd.Next(13, 324);
                picCar3.Location = new Point(x, 0);
            }
            else
            { picCar3.Top += speed; }

            if (picCar4.Top >= 500)
            {
                x = rnd.Next(192, 283);
                picCar4.Location = new Point(x, 0);
            }
            else
            { picCar4.Top += speed; }

            if (picCar5.Top >= 600)
            {
                x = rnd.Next(283, 374);
                picCar5.Location = new Point(x, 0);
            }
            else
            { picCar5.Top += speed; }

            if (picCar6.Top >= 500)
            {
                x = rnd.Next(94, 192);
                picCar6.Location = new Point(x, 0);
            }
            else
            { picCar6.Top += speed; }

            if (picCar7.Top >= 600)
            {
                x = rnd.Next(13, 94);
                picCar7.Location = new Point(x, 0);
            }
            else
            { picCar7.Top += speed; }


        }

        // Oyunun bitişi & diğer arabalarla çarpışması
        void gameOver()
        {

            if (picMyCar.Bounds.IntersectsWith(picCar1.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnPlayAgain.Visible = true;
            }
            if (picMyCar.Bounds.IntersectsWith(picCar2.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnPlayAgain.Visible = true;
            }
            if (picMyCar.Bounds.IntersectsWith(picCar3.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnPlayAgain.Visible = true;
            }
            if (picMyCar.Bounds.IntersectsWith(picCar4.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnPlayAgain.Visible = true;
            }
            if (picMyCar.Bounds.IntersectsWith(picCar5.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnPlayAgain.Visible = true;
            }
            if (picMyCar.Bounds.IntersectsWith(picCar6.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnPlayAgain.Visible = true;
            }
            if (picMyCar.Bounds.IntersectsWith(picCar7.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnPlayAgain.Visible = true;
            }

            

        }

        // Şerit çizgilerinin tekrarlanmasını ve hızlarını ayarlayan fonksiyon
        void moveline(int speed)
        { //Mid section lines
            if (picLine1.Top >= 500)
            { picLine1.Top = 0; }
            else
            { picLine1.Top += speed; }

            if (picLine2.Top >= 500)
            { picLine2.Top = 0; }
            else
            { picLine2.Top += speed; }

            if (picLine3.Top >= 500)
            { picLine3.Top = 0; }
            else
            { picLine3.Top += speed; }

            if (picLine4.Top >= 500)
            { picLine4.Top = 0; }
            else
            { picLine4.Top += speed; }


            //Left section lines
            if (picLine5.Top >= 500)
            { picLine5.Top = 0; }
            else
            { picLine5.Top += speed; }

            if (picLine6.Top >= 500)
            { picLine6.Top = 0; }
            else
            { picLine6.Top += speed; }

            if (picLine7.Top >= 500)
            { picLine7.Top = 0; }
            else
            { picLine7.Top += speed; }

            if (picLine8.Top >= 500)
            { picLine8.Top = 0; }
            else
            { picLine8.Top += speed; }


            //Right section lines
            if (picLine9.Top >= 500)
            { picLine9.Top = 0; }
            else
            { picLine9.Top += speed; }

            if (picLine10.Top >= 500)
            { picLine10.Top = 0; }
            else
            { picLine10.Top += speed; }

            if (picLine11.Top >= 500)
            { picLine11.Top = 0; }
            else
            { picLine11.Top += speed; }

            if (picLine12.Top >= 500)
            { picLine12.Top = 0; }
            else
            { picLine12.Top += speed; }

        }

        // Yönlendirme tuşları ve formun dışına çıkmasını önleme
        // Speed'i güncelleme
        private void CarRace2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                if (picMyCar.Left > 13)
                    picMyCar.Left -= gameSpeed;

            }
            if (e.KeyCode == Keys.Right)
            {
                if (picMyCar.Left < 324)
                    picMyCar.Left += gameSpeed;

            }
            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21)
                {
                    gameSpeed++;
                    lblSpeed.Text = gameSpeed.ToString();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 1)
                {
                    gameSpeed--;
                    lblSpeed.Text = gameSpeed.ToString();

                }
            }
        }



        // Play Again butonu/Yeniden başlatma
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}
