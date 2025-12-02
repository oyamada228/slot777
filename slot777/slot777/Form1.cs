using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Image[] reelImages = {
          
              imo.png


            }

        }

        Image[] numberImages = new Image[10];

public void LoadImages()
{
    numberImages[0] = Properties.Resources.num0;
    numberImages[1] = Properties.Resources.num1;
    numberImages[2] = Properties.Resources.num2;
    numberImages[3] = Properties.Resources.num3;
    numberImages[4] = Properties.Resources.num4;
    numberImages[5] = Properties.Resources.num5;
    numberImages[6] = Properties.Resources.num6;
    numberImages[7] = Properties.Resources.num7;
    numberImages[8] = Properties.Resources.num8;
    numberImages[9] = Properties.Resources.num9;
}








        int index = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % Image;
            pictureBox1.Image = Image[index];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"images/reel1.png");

        }
    }
}
    
