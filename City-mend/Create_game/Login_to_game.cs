using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Media;

namespace City_mend.Create_game
{
    class Login_to_game
    {
        public static void Welcome()
        {
            Music();
            Files();
        }

        private static void Files()
        {        

            string logo_stream = Properties.Resources.logo;
            Console.WriteLine(logo_stream);

            Thread.Sleep(2000);
            string present_stream = Properties.Resources.present;
            Console.WriteLine("     "+present_stream);

            Thread.Sleep(2000);
            Console.Clear();
            string logoGame_stream = Properties.Resources.вар5;
            Console.WriteLine("             " + logoGame_stream);

        }
        private static void Music()
        {
            SoundPlayer player = new SoundPlayer(City_mend.Properties.Resources.фон_музыка_меню_);
            player.PlayLooping();
        }
    }
}
