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
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
        }

        private void lblNext_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Play Next Level !");

            // Next Level için
            this.Hide();
            Maze2 level2 = new Maze2();
            level2.ShowDialog();
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats! You get out of the maze!");
            this.Close();
        }


        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Tomato;

            Point startPoint = lblStart.Location;
            Cursor.Position = PointToScreen(startPoint);
        }
    }
}
