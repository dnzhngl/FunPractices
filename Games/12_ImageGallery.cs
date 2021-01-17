using Games.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class ImageGallery : Form
    {
        public ImageGallery()
        {
            InitializeComponent();
        }

        //Image Array'i
        Image[] pbImageArray = new Image[24];
        int cIndex = 0;


        private void ImageGallery_Load(object sender, EventArgs e)
        {

            for (int i = 1; i < 25; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Height = pb.Width = 63;
                pb.Margin = new Padding(1);
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = Image.FromFile("../../MyResources/ImageGallery/Abstract Wallpaper (" + i + ").jpg"); //pb.Image = Image.FromFile( string.Format("../../MyResources/Abstract Wallpaper ({0}).jpg", i));
                pb.Click += Pb_Click;

                pb.Tag = i - 1;

                FlowLayoutPanelImg.Controls.Add(pb);

                pbImageArray[i - 1] = pb.Image;
            }
        }


        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pbBuyukResim.Image = pb.Image;

            cIndex = (int)(pb.Tag);

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cIndex = rnd.Next(0, pbImageArray.Length);
            pbBuyukResim.Image = pbImageArray[cIndex];

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Baştan başlayarak slayt gösterisi yapıyor. Ama bulunduğu resimden itibaren slayt gösterisi yapmasını istersen napcaksın onu bul!
            if (cIndex < pbImageArray.Length)
            {
                pbBuyukResim.Image = pbImageArray[cIndex];
                cIndex++;
            }
            else
            {
                cIndex = 0;
            }

        }

        private void btnFirstImg_Click(object sender, EventArgs e)
        {

            pbBuyukResim.Image = pbImageArray[0];
        }

        private void btnLastImg_Click(object sender, EventArgs e)
        {
            pbBuyukResim.Image = pbImageArray[pbImageArray.Length - 1];
        }

        private void btnPreviousImg_Click(object sender, EventArgs e)
        {
            cIndex--;

            if (cIndex <= 0)
            {
                cIndex = pbImageArray.Length - 1;
            }
            pbBuyukResim.Image = pbImageArray[cIndex];

        }

        private void btnNextImg_Click(object sender, EventArgs e)
        {
            cIndex++;

            if (cIndex >= pbImageArray.Length)
            {
                cIndex = 0;
            }
            pbBuyukResim.Image = pbImageArray[cIndex];

        }


    }
}
