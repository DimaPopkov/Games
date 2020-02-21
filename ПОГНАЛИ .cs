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
    public struct Game
    {
        public string name;
        public string shanr;
        public int price;
        public Button btn;
        public Game(string name1,string shanr1, int price1)
        {
            name = name1;
            shanr = shanr1;
            price = price1;
            btn = new Button();
        }
    }









    public partial class Form2 : Form
    {
        Game[] games = new Game[50];

        public Form2()
        {
            InitializeComponent();

            games[0] = new Game("WoT", "action", 0);
            games[1] = new Game("Mario", "arkade", 0);
            games[2] = new Game("PUBG lite", "shooter,butle royal", 0);
            games[3] = new Game("GTA V", "arkade,action", 1990);
            games[4] = new Game("WoT blitz", "action", 0);
            games[5] = new Game("Standoff2", "shooter", 0);
            games[6] = new Game("War thunder", "action", 399);
            games[7] = new Game("World of Warships", "action", 0);

            /*games[8] = new Game("PUBG", "shuter", 0);
              games[9] = new Game("PUBG", "shuter", 0);
              games[10] = new Game("PUBG", "shuter", 0);
              games[11] = new Game("PUBG", "shuter", 0);
            */

            int x = 10;
            int y = 200;
            for (int i = 0; i < 8; i++)
            {
                games[i].btn.Text = games[i].name;
                games[i].btn.Tag = games[i].name;
                games[i].btn.Location = new Point(x, y);
                games[i].btn.Size = new Size(100, 50);
                games[i].btn.Click += new EventHandler(button1_Click);
                Controls.Add(games[i].btn);
                x = x + 110;

                if (x > Width - 100)
                {
                    x = 10;
                    y = y + 60;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GameInfoForm form = new GameInfoForm(btn.Tag.ToString());
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 10;
            int y = 200;
            for (int i = 0; i < 8; i++)
            {
                bool nadoSkryt = false;
                games[i].btn.Visible = false;


                if (maxText.Text != "" &&
                    games[i].price > Convert.ToInt32(maxText.Text))
                {
                    nadoSkryt = true;
                }
                else if (minText.Text != "" &&
                    games[i].price < Convert.ToInt32(minText.Text))
                {
                    nadoSkryt = true;
                }

                else if (Shanr.CheckedItems.Count > 0)
                {
                    nadoSkryt = true;
                    if (Shanr.CheckedItems.Contains(games[i].shanr))
                    {
                        nadoSkryt = false;
                    }
                }

                if (!nadoSkryt)
                {
                    games[i].btn.Location = new Point(x, y);
                    games[i].btn.Visible = true;
                    games[i].btn.Text = games[i].name +
                        " (" + games[i].price.ToString() +")"; 
                    
                    x = x + 110;

                    if (x > Width - 100)
                    {
                        x = 10;
                        y = y + 60;
                    }
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(null, null);
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void Shanr_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            button1_Click_1(null, null);

        }

        private void Shanr_MouseClick(object sender, MouseEventArgs e)
        {
            button1_Click_1(null, null);

        }
    }
}
