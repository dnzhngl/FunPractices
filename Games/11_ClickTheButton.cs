using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class ClickTheButton : Form
    {
        public ClickTheButton()
        {
            InitializeComponent();
        }


        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            button1.Left = rnd.Next(5, 550);
            button1.Top = rnd.Next(5, 550);
        }
    }
}
