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
    public partial class PerfectNumber : Form
    {
        public PerfectNumber()
        {
            InitializeComponent();
        }

        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum.Clear();
            lblResults.Text = "";
            lstPozitiveDivisors.Items.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            /*
             1. Kendisinden farklı, pozitif bölenleri bulunacak. (int i = 1; i < num) 
             2. Bu bölenlerin toplamı bulunacak.
             3. Bölenlerinin toplamı, girilen sayının kendisine eşit mi bakılacak.
             
             */

            try
            {
                int num = int.Parse(txtNum.Text);

                // Sayı pozitif sayı olmalı.
                if (num > 0)
                {
                    int sumOfDivisors = 0;
                    List<int> positiveDividers = new List<int>();

                    // 1. Kendisinden farklı, pozitif bölenleri bulunacak. (int i = 1; i < num)
                    int numCopy = num;

                    int i = 1;
                    while (i < numCopy)
                    {
                        if (numCopy % i == 0)
                        {
                            lstPozitiveDivisors.Items.Add(i);
                            positiveDividers.Add(i);

                            // 2. Bu bölenlerin toplamı bulunacak.
                            sumOfDivisors += i;
                        }
                        i++;
                    }

                    lblResults.Text = "1. Pozitif bölenleri soldaki listededir.";
                    lblResults.Text += "\n\n2. Pozitif Bölenleri Toplamı: " + sumOfDivisors.ToString();

                    // 3.Bölenlerinin toplamı, girilen sayının kendisine eşit mi bakılacak.
                    if (num == sumOfDivisors)
                    {
                        lblResults.Text += "\n\n3. Sayı mükemmel sayıdır. \n" + num.ToString() + " = " + sumOfDivisors.ToString();
                    }
                    else
                    {
                        lblResults.Text += "\n\n3. Sayı mükemmel sayı değildir. \n" + num.ToString() + " != " + sumOfDivisors.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen pozitif bir sayı giriniz.");
                    txtNum.Clear();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.");
                txtNum.Clear();
            }


        }
    }
}
