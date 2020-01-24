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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void PUBGClick(object sender, EventArgs e)
        {
            GameInfoForm form = new GameInfoForm("PUBG");
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameInfoForm form = new GameInfoForm("Standoff2");
            form.Show();
        }

        private void buttonGTA_Click(object sender, EventArgs e)
        {
            GameInfoForm form = new GameInfoForm("GTA");
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GameInfoForm form = new GameInfoForm("Blitz");
            form.Show();
        }

        private void buttonTanks_Click(object sender, EventArgs e)
        {
            GameInfoForm form = new GameInfoForm("tank");
            form.Show();
        }

        private void buttonMario_Click(object sender, EventArgs e)
        {
            GameInfoForm form = new GameInfoForm("Mario");
            form.Show();
        }
    }
}
