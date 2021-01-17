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
    public partial class primeFactors : Form
    {
        public primeFactors()
        {
            InitializeComponent();
        }


        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum.Clear();
            lstPrimeFactors.Items.Clear();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);

            if (num >= 2)
            {
                while (num % 2 == 0)
                {
                    lstPrimeFactors.Items.Add(2);
                    num /= 2;

                }

                for (int i = 3; i <= num; i += 2)
                {
                    while (num % i == 0)
                    {
                        lstPrimeFactors.Items.Add(i);
                        num /= i;
                    }
                }
            }

            else
            {
                MessageBox.Show("Please enter a number greater than 1.");
            }






        }


    }
}
