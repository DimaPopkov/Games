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
        public string Silka;
        public string name;
        public string shanr;
        public int price;
        public Button btn;
        public Game(string name1,string shanr1, int price1, string Silka1)
        {
            Silka = Silka1;
            name = name1;
            shanr = shanr1;
            price = price1;
            btn = new Button();
        }
    }









    public partial class Filter : Form
    {
        Game[] games = new Game[12];

        public Filter()
        {
            InitializeComponent();

            games[0] = new Game("WoT", "action", 499, "https://worldoftanks.ru");
            games[1] = new Game("Mario", "arkade", 20000, "");
            games[2] = new Game("PUBG lite", "butle royal", 299, "https://store.steampowered.com/app/578080/PLAYERUNKNOWNS_BATTLEGROUNDS/");
            games[3] = new Game("GTA V", "arkade", 1990, "https://store.steampowered.com/app/271590/Grand_Theft_Auto_V/");
            games[4] = new Game("WoT blitz", "action", 0, "https://store.steampowered.com/app/444200/World_of_Tanks_Blitz/");
            games[5] = new Game("Standoff2", "shooter", 0, "");
            games[6] = new Game("War thunder", "action", 399, "");
            games[7] = new Game("World of Warships", "action", 10, "https://store.steampowered.com/app/552990/World_of_Warships/");
            games[8] = new Game("World of Warplanes", "action", 20, "https://store.steampowered.com/app/790710/World_of_Warplanes/");
            games[9] = new Game("Rocket League", "shuter", 133, "https://store.steampowered.com/app/848820/Rocket_League_x_Monstercat_Vol_3/");
            games[10]= new Game("Rust", "action", 0, "https://store.steampowered.com/app/252490/Rust/");
            games[11]= new Game("CHtoto", "shooter,action,butle royal,arkade", 100, "https://yandex.kz/search/?lr=210707&clid=9403&oprnd=4525458819&text=вопросительный%20знак%20картинка");
            

            int x = 10;
            int y = 150;
            for (int i = 0; i < games.Length; i++)
            {
                games[i].btn.AccessibleDescription = games[i].price.ToString();
                games[i].btn.AccessibleName = games[i].Silka;
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
            GameInfoForm form = new GameInfoForm(btn.Tag.ToString(), btn.AccessibleName, Convert.ToInt32(btn.AccessibleDescription));
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 10;
            int y = 150;
            for (int i = 0; i < games.Length; i++)
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
