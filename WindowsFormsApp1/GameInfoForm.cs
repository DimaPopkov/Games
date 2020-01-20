using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameInfoForm : Form
    {
        public GameInfoForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Без_названия;
            textBox1.Text = "Pubg Lite";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.standoff_2;
            textBox1.Text = "Standoff2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.нон;
            textBox1.Text = "Gta V";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Super_Mario_Wallpaper_HD;
            textBox1.Text = "Mario";
        }



        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.news_wotb_windows_10_artwork;
            textBox1.Text = "World Of Tanks Blits";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._323007_alexfas01;
            textBox1.Text = "World Of Tanks";
        }
    }
}
