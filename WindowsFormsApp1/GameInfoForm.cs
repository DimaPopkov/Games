﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameInfoForm : Form
    {
        public GameInfoForm(string game, string Sylka, int price)
        {
            InitializeComponent();

            textBox1.Text = "Игра: " + game;
            label2.Tag = Sylka;
            label3.Text = price.ToString() + "Р.";
            try
            {
                pictureBox1.Load("../../Resources/" + game + ".jpg");
            }
            catch (Exception) { }

            if (game == "PUBG lite")
            {
                textBox1.Text =
                    "Pubg Lite PlayerUnknown’s Battlegrounds (сокр. PUBG) — многопользовательская онлайн-игра в жанре королевской битвы, разрабатываемая и издаваемая студией PUBG Corporation, дочерней компанией корейского издателя Bluehole. Официальной дистрибьюцией игры на территории России занимается Mail.Ru Group[3][4]. Игра основана на предыдущих модификациях для других игр, созданных Бренданом Грином (англ. Brendan Greene) под псевдонимом «PlayerUnknown», концепция которых была вдохновлена японским фильмом «Королевская битва» 2000 года. В итоге это привело к созданию самостоятельной игры, где Грин выступил в качестве ведущего геймдизайнера. В игре до 100 игроков, которые десантируются на остров, после чего ищут снаряжение и оружие, чтобы убить других участников и при этом самим остаться в живых. Доступная безопасная зона на внутриигровой карте со временем начинает уменьшаться, делая доступное пространство более тесным, чтобы сталкивать их между собой. Последний выживший игрок или команда побеждает в раунде." +
                    Environment.NewLine +
                    "PlayerUnknown’s Battlegrounds была выпущена в Steam по программе раннего доступа 23 марта 2017 года для операционной системы Windows[5].В течение первых семи месяцев после выхода было продано более 13 млн копий игры, а пиковое количество игроков достигло более 2 миллионов человек к концу года, что сделало её одной из самых популярных игр в Steam[6]. 31 октября продажи PUBG превысили 18 млн копий. Полная версия игры была выпущена 21 декабря 2017 года.Выход для Xbox One под издательством Microsoft Studios состоялся 12 декабря по программе раннего доступа[7], но уже 4 сентября 2018 года состоялся официальный релиз. 19 марта 2018 года была выпущена мобильная версия для Android и iOS по модели free-to - play.Версия для PlayStation 4 была анонсирована в ноябре 2018 года, и выпущена 7 декабря 2018 года";
            }

            if (game == "Mario")
            {
                textBox1.Text =
                    "Pubg Lite PlayerUnknown’s Battlegrounds (сокр. PUBG) — многопользовательская онлайн-игра в жанре королевской битвы, разрабатываемая и издаваемая студией PUBG Corporation, дочерней компанией корейского издателя Bluehole. Официальной дистрибьюцией игры на территории России занимается Mail.Ru Group[3][4]. Игра основана на предыдущих модификациях для других игр, созданных Бренданом Грином (англ. Brendan Greene) под псевдонимом «PlayerUnknown», концепция которых была вдохновлена японским фильмом «Королевская битва» 2000 года. В итоге это привело к созданию самостоятельной игры, где Грин выступил в качестве ведущего геймдизайнера. В игре до 100 игроков, которые десантируются на остров, после чего ищут снаряжение и оружие, чтобы убить других участников и при этом самим остаться в живых. Доступная безопасная зона на внутриигровой карте со временем начинает уменьшаться, делая доступное пространство более тесным, чтобы сталкивать их между собой. Последний выживший игрок или команда побеждает в раунде." +
                    Environment.NewLine +
                    "PlayerUnknown’s Battlegrounds была выпущена в Steam по программе раннего доступа 23 марта 2017 года для операционной системы Windows[5].В течение первых семи месяцев после выхода было продано более 13 млн копий игры, а пиковое количество игроков достигло более 2 миллионов человек к концу года, что сделало её одной из самых популярных игр в Steam[6]. 31 октября продажи PUBG превысили 18 млн копий. Полная версия игры была выпущена 21 декабря 2017 года.Выход для Xbox One под издательством Microsoft Studios состоялся 12 декабря по программе раннего доступа[7], но уже 4 сентября 2018 года состоялся официальный релиз. 19 марта 2018 года была выпущена мобильная версия для Android и iOS по модели free-to - play.Версия для PlayStation 4 была анонсирована в ноябре 2018 года, и выпущена 7 декабря 2018 года";
            }

            if (game == "Gta V")
            {
                textBox1.Text =
                    "Pubg Lite PlayerUnknown’s Battlegrounds (сокр. PUBG) — многопользовательская онлайн-игра в жанре королевской битвы, разрабатываемая и издаваемая студией PUBG Corporation, дочерней компанией корейского издателя Bluehole. Официальной дистрибьюцией игры на территории России занимается Mail.Ru Group[3][4]. Игра основана на предыдущих модификациях для других игр, созданных Бренданом Грином (англ. Brendan Greene) под псевдонимом «PlayerUnknown», концепция которых была вдохновлена японским фильмом «Королевская битва» 2000 года. В итоге это привело к созданию самостоятельной игры, где Грин выступил в качестве ведущего геймдизайнера. В игре до 100 игроков, которые десантируются на остров, после чего ищут снаряжение и оружие, чтобы убить других участников и при этом самим остаться в живых. Доступная безопасная зона на внутриигровой карте со временем начинает уменьшаться, делая доступное пространство более тесным, чтобы сталкивать их между собой. Последний выживший игрок или команда побеждает в раунде." +
                    Environment.NewLine +
                    "PlayerUnknown’s Battlegrounds была выпущена в Steam по программе раннего доступа 23 марта 2017 года для операционной системы Windows[5].В течение первых семи месяцев после выхода было продано более 13 млн копий игры, а пиковое количество игроков достигло более 2 миллионов человек к концу года, что сделало её одной из самых популярных игр в Steam[6]. 31 октября продажи PUBG превысили 18 млн копий. Полная версия игры была выпущена 21 декабря 2017 года.Выход для Xbox One под издательством Microsoft Studios состоялся 12 декабря по программе раннего доступа[7], но уже 4 сентября 2018 года состоялся официальный релиз. 19 марта 2018 года была выпущена мобильная версия для Android и iOS по модели free-to - play.Версия для PlayStation 4 была анонсирована в ноябре 2018 года, и выпущена 7 декабря 2018 года";
            }


            if (game == "pubg")
            {
                textBox1.Text = 
                    "Pubg Lite PlayerUnknown’s Battlegrounds (сокр. PUBG) — многопользовательская онлайн-игра в жанре королевской битвы, разрабатываемая и издаваемая студией PUBG Corporation, дочерней компанией корейского издателя Bluehole. Официальной дистрибьюцией игры на территории России занимается Mail.Ru Group[3][4]. Игра основана на предыдущих модификациях для других игр, созданных Бренданом Грином (англ. Brendan Greene) под псевдонимом «PlayerUnknown», концепция которых была вдохновлена японским фильмом «Королевская битва» 2000 года. В итоге это привело к созданию самостоятельной игры, где Грин выступил в качестве ведущего геймдизайнера. В игре до 100 игроков, которые десантируются на остров, после чего ищут снаряжение и оружие, чтобы убить других участников и при этом самим остаться в живых. Доступная безопасная зона на внутриигровой карте со временем начинает уменьшаться, делая доступное пространство более тесным, чтобы сталкивать их между собой. Последний выживший игрок или команда побеждает в раунде." +
                    Environment.NewLine + 
                    "PlayerUnknown’s Battlegrounds была выпущена в Steam по программе раннего доступа 23 марта 2017 года для операционной системы Windows[5].В течение первых семи месяцев после выхода было продано более 13 млн копий игры, а пиковое количество игроков достигло более 2 миллионов человек к концу года, что сделало её одной из самых популярных игр в Steam[6]. 31 октября продажи PUBG превысили 18 млн копий. Полная версия игры была выпущена 21 декабря 2017 года.Выход для Xbox One под издательством Microsoft Studios состоялся 12 декабря по программе раннего доступа[7], но уже 4 сентября 2018 года состоялся официальный релиз. 19 марта 2018 года была выпущена мобильная версия для Android и iOS по модели free-to - play.Версия для PlayStation 4 была анонсирована в ноябре 2018 года, и выпущена 7 декабря 2018 года";
            }

            if (game == "WoT Blitz")
            {
                textBox1.Text =
                    "World of Tanks Blitz — массовая многопользовательская онлайн-игра для смартфонов, планшетов на базе платформ iOS и Android, а также для компьютеров на платформе Windows 10 и Mac OS, в том числе игра доступна для скачивания в игровом магазине Steam. Разработчиками данной игры является белорусская компания Wargaming.net. Как World of Tanks и многие другие проекты компании, игра выдержана в стиле Второй мировой войны. Концепция World of Tanks Blitz базируется на массовых командных танковых сражениях в режиме встречного боя с единственной базой для обеих команд. Международный релиз игры для устройств на базе платформы iOS состоялся 26 июня 2014 года[1], Android-версия игры вышла 4 декабря 2014 года[2], затем 16 Декабря 2015 года игра стала доступна на Windows 10, 9 марта 2016 года игра появилась на платформе Mac OS в странах СНГ и острова Кипр, после чего 24 марта игра стала доступна всем обладателям Mac OS в мире, 9 ноября 2016 года появилась в игровом магазине Steam.";
            }


            if (game == "tanks")
            {
                textBox1.Text =
                    "World of Tanks(с англ.— «Мир танков»; сокр.WoT) — " +
                    "клиентская массовая многопользовательская онлайн-игра в " +
                    "реальном времени в жанре аркадного танкового симулятора в " +
                    "историческом сеттинге Второй мировой войны, разработанная " +
                    "белорусской студией Wargaming.net. Разработчиками игра " +
                    "позиционируется как массовая многопользовательская онлайн - игра" +
                    " в жанре action с элементами ролевой игры, шутера и стратегии. " +
                    "Концепция World of Tanks базируется на командных танковых сражениях " +
                    "в режиме PvP.Игра вышла 12 августа 2010 года и имела только " +
                    "русскоязычную версию. Выпуск локализованной игры World of Tanks в " +
                    "Европе и в Северной Америке состоялся 12 апреля 2011 года" +
                    Environment.NewLine +
                    "Игра использует бизнес - модель free - to - play. " +
                    "Изначально декларировалось только бесплатное скачивание клиента " +
                    "и бесплатный вход в игру, но в июне 2013 года объявлено, что " +
                    "стратегией для всех действующих и будущих игр является" +
                    " «free - to - win» — полное отсутствие каких-либо преимуществ" +
                    " в бою для платящих игроков.";
            }
        }

        private void GameInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Tag != null &&
                label2.Tag.ToString() != "")
            {
                Process.Start(label2.Tag.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
