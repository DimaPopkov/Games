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
    public partial class Корзина : Form
    {

        public static List<Game> games = new List<Game>();

        public Корзина()
        {
            InitializeComponent();
            int x = 10;
            int y = 60;

            foreach (Game game in Корзина.games)
            {
                Button btn = new Button();
                btn.Text = game.btn.Text;
                btn.Location = new Point(x, y);
                btn.Size = game.btn.Size; 
                btn.Click += new EventHandler(Filter.openGame);
                Controls.Add(btn);

                Label stoimost = new Label();
                stoimost.Font = new Font("Microsoft Sans Serif", 9.75F);
                stoimost.Text = game.price.ToString() + " Р";
                stoimost.Location = new Point(x + 165, y + 20);
                stoimost.Size = new Size(100, 60);
                Controls.Add(stoimost);

                Label Shanr = new Label();
                Shanr.Font = new Font("Microsoft Sans Serif", 9.75F);
                Shanr.Text = game.shanr.ToString();
                Shanr.Location = new Point(x + 300, y + 20);
                Shanr.Size = new Size(100, 60);
                Controls.Add(Shanr);

                y = y + 60;
                
                


            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Корзина_Load(object sender, EventArgs e)
        {

        }
    }
}
