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




        private void buttonTanks_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GameInfoForm form = new GameInfoForm(btn.Tag.ToString(), btn.AccessibleName, Convert.ToInt32(btn.AccessibleDescription));
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

        }
    }
}
