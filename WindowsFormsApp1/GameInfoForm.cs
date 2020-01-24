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
        public GameInfoForm(string game)
        {
            InitializeComponent();

            if (game == "PUBG")
            {
                pictureBox1.Image = Properties.Resources.pubg;
                textBox1.Text = "Pubg Lite";
            }

            if (game == "Blitz")
            {
                pictureBox1.Image = Properties.Resources.news_wotb_windows_10_artwork;
                textBox1.Text = "World of Tanks Blits";
            }

            if (game == "Standoff2")
            {
                pictureBox1.Image = Properties.Resources.standoff_2;
                textBox1.Text = "Standoff_2";
            }

            if (game == "GTA")
            {
                pictureBox1.Image = Properties.Resources.нон;
                textBox1.Text = "Gta V";
            }

            if (game == "Mario")
            {
                pictureBox1.Image = Properties.Resources.Super_Mario_Wallpaper_HD;
                textBox1.Text = "Mario";
            }

            if (game == "tank")
            {
                pictureBox1.Image = Properties.Resources.tanks;
                textBox1.Text = "Tanks";
            }
        }
    }
}
