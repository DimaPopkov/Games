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
        public Game(string name1,string shanr1, int price1, Button btn1)
        {
            name = name1;
            shanr = shanr1;
            price = price1;
            btn = btn1;
        }
    }









    public partial class Form2 : Form
    {
        Game[] games = new Game[50];

        public Form2()
        {
            InitializeComponent();

            games[0] = new Game("WoT", "action", 0, button0);
            games[1] = new Game("Mario", "arkade", 0, button1);
            games[2] = new Game("PUBG lite", "shuter,butle royal", 0, button2);
            games[3] = new Game("GTA V", "arkade,action", 1990, button3);
            games[4] = new Game("WoT blitz", "action", 0, button4);
            games[5] = new Game("Standoff2", "shuter", 0, button5);
            games[6] = new Game("War thunder", "action", 399, button6);
            games[7] = new Game("World of Warsips", "action", 0, button7);
           
            /*games[8] = new Game("PUBG", "shuter", 0);
              games[9] = new Game("PUBG", "shuter", 0);
              games[10] = new Game("PUBG", "shuter", 0);
              games[11] = new Game("PUBG", "shuter", 0);
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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

                if (!nadoSkryt)
                {
                    games[i].btn.Visible = true;
                    games[i].btn.Text = games[i].name +
                        " (" + games[i].price.ToString() +")";
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
    }
}
