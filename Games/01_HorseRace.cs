using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FunPractices
{
    public partial class HorseRace : Form
    {
        public HorseRace()
        {
            InitializeComponent();
        }

        

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1, x2, x3, xF;
            Random rnd = new Random();

            //At resimlerinin sol x değerine, random sayılar eklenerek hızları ayarlanıyor.
            txtName1.Left = x1 = picHorse1.Left += rnd.Next(3, 10);
            txtName2.Left = x2 = picHorse2.Left += rnd.Next(3, 10);
            txtName3.Left = x3 = picHorse3.Left += rnd.Next(3, 10);

            // Bitiş çizgisinin sol x değeri ve genişliği.
            xF = lblFinish.Left;            

            // At resimlerinin genişlikleri
            int w1 = picHorse1.Width;
            int w2 = picHorse2.Width;
            int w3 = picHorse3.Width;


            // Kimin önde olduğuna dair anlık yorumlar.
            if (x1 > x2 && x1 > x3)
            {
                lblWinner.Text = (txtName1.Text + " gets off to a running start!");
            }
            if (x2 > x1 && x2 > x3)
            {
                lblWinner.Text = (txtName2.Text + " runs like the wind!!");
            }
            if (x3 > x1 && x3 > x2)
            {
                lblWinner.Text = (txtName3.Text + " takes the lead! ");
            }
            
            // Sonuc kazananı bulur.
            // Resimlerin sol kenarları + random atılan hızları ile resimlerin genişliğinin toplamının bitiş çizgisine eşit yada büyük olmasına göre bakılır. 
            if (x1 + w1 >= xF)
            {
                lblWinner.Text = (txtName1.Text + " is the Winner !!");
               timer1.Enabled = false;
            }
            if (x2 + w2 >= xF)
            {
                lblWinner.Text = (txtName2.Text + " is the Winner !!");
                timer1.Enabled = false;
            }
            if (x3 + w3 >= xF)
            {
                lblWinner.Text = (txtName3.Text +  " is the Winner !!");
                timer1.Enabled = false;
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
