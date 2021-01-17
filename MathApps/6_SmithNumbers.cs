using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPractices
{
    public partial class SmithNumber : Form
    {
        public SmithNumber()
        {
            InitializeComponent();
        }
        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum.Clear();
            lblResults.Text = "";
            lstPrimeFactors.Items.Clear();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            /*Smith sayısı:
             1’den büyük, 
             asal olmayan bir tam sayının rakamlarının toplamı, 
             bu sayının asal çarpanlarına ayrılarak yazıldığında, 
             bu yazılışta bulunan tüm asal sayıların rakamlarının toplamına eşit oluyorsa bu sayılara smith sayısı denilmektedir.
             
            728 sayısı Smith sayısıdır. 
            asal çarpanları => 2.2.2.7.13 
            bir de bu sayıların toplamı => 2 + 2 + 2 + 7 + 1 + 3 = 17, 
            728 sayısının rakamları toplamı =>   7 + 2 + 8 = 17

            121’in asal çarpanları = 11.11 
            Bunları toplarsak 1 + 1 + 1 + 1 = 4 olur, 
            121’in rakamları toplamı da 1 + 2 + 1 = 4 şeklindedir
            
             */

            /*
           1. Girilen sayı 1'den büyük olacak  +
           2. Girilen sayı asal olmayacak +
           3. Girilen sayının rakamları toplamı bulunacak. +
           4. Girilen sayının asal çarpanları bulunacak. +
           5. Asal çarpanların rakamları toplamı bulunacak. ??--
           6. 3. ile 5. adımın sonuçları birbine eşit mi bakılacak. +
           7. Sonuçlar eşitse smith sayıdır yazdırılacak. +

           */

            try
            {
                int num = int.Parse(txtNum.Text);


                //  1. Girilen sayı 1'den büyük olacak.
                if (num > 1)
                {
                    int sumOfDigitsNum = 0;
                    int sumOfPrimeFactorsDigits = 0;
                    List<int> primeDivisors = new List<int>();


                    //  2. Girilen sayı asal olmayacak
                    #region
                    bool primeNumber = true;

                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            primeNumber = false;
                            break;
                        }

                    }
                    if (primeNumber)
                    {// "1. It is a prime number."
                        lblResults.Text = "1. " + num.ToString() + " asal sayıdır. \n  Asal sayılar Smith sayı olamazlar.\n  Başka bir sayı giriniz.";
                        txtNum.Clear();
                    }
                    else
                    {// "1. It is not a prime number."
                        lblResults.Text = "1. " + num.ToString() + " asal sayı değildir.";




                        // 3. Girilen sayı asal değilse, rakamları toplamı bulunacak.
                        #region
                        int numCopy = num;
                        // sumOfDigitsNum = 0;

                        while (numCopy > 0)
                        {
                            sumOfDigitsNum += numCopy % 10;
                            numCopy /= 10;
                        }

                        lblResults.Text += "\n\n2. Rakamları toplamı: " + sumOfDigitsNum.ToString();
                        #endregion




                        // 4. Girilen sayının asal çarpanları bulunacak.
                        #region
                        int numCopy1 = num;
                        while (numCopy1 % 2 == 0)
                        {
                            primeDivisors.Add(2);
                            lstPrimeFactors.Items.Add(2);
                            numCopy1 /= 2;
                        }
                        for (int i = 3; i <= numCopy1; i += 2)
                        {
                            while (numCopy1 % i == 0)
                            {
                                primeDivisors.Add(i);
                                lstPrimeFactors.Items.Add(i);
                                numCopy1 /= i;
                            }
                        }

                        lblResults.Text += "\n\n3. Asal çarpanları: Soldaki listede.";
                        #endregion




                        // 5. Girilen sayının asal çarpanlarının rakamları toplamı bulunacak.
                        #region
                        // sumOfPrimeFactorsDigits = 0;

                        foreach (int divisor in primeDivisors)
                        {
                            int clonedDivisor = divisor;
                            while (clonedDivisor > 0)
                            {
                                sumOfPrimeFactorsDigits += clonedDivisor % 10;
                                clonedDivisor /= 10;
                            }
                        }

                        lblResults.Text += "\n\n4. Asal çarpanlarının rakamları toplamı: " + sumOfPrimeFactorsDigits.ToString();
                        #endregion


                        // 6. 4. ile 5.adımın sonuçları birbine eşit mi bakılacak ve sonuç yazdırılacak.
                        #region
                        if (sumOfDigitsNum == sumOfPrimeFactorsDigits)
                        {
                            lblResults.Text += "\n\n 5. Rakamları toplamı= " + sumOfDigitsNum.ToString() + "\n = Asal çarpanlarının rakamları toplamı= " + sumOfPrimeFactorsDigits.ToString() + "\n  SMITH SAYIDIR.";
                        }
                        else
                        {
                            lblResults.Text += "\n\n 5. Rakamları toplamı= " + sumOfDigitsNum.ToString() + "\n != Asal çarpanlarının rakamları toplamı= " + sumOfPrimeFactorsDigits.ToString() + "\n SMITH SAYI DEĞİLDİR.";
                        }
                        #endregion
                    }
                    #endregion


                }
                else
                {
                    MessageBox.Show("Lütfen 1'den büyük bir sayı giriniz.");
                    txtNum.Clear();
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen bir sayı giriniz.");
                txtNum.Clear();
            }

        }
    }
}
