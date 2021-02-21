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
            string text = "";
            StreamReader logo_stream = new StreamReader("файлы для отрисовки\\logo.txt");
        
            do
            {
                text = logo_stream.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            logo_stream.Close();
            Thread.Sleep(2000);
            StreamReader present_stream = new StreamReader("файлы для отрисовки\\present.txt");
           /* string present_text = "";*/
            do
            {
                text = present_stream.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            present_stream.Close();
            Thread.Sleep(2000);
            Console.Clear();
            StreamReader logoGame_stream = new StreamReader("файлы для отрисовки\\логотип игры\\вар5.txt");
            /* string present_text = "";*/
            do
            {
                text = logoGame_stream.ReadLine();
                Console.WriteLine("                         "+text);
            } while (text != null);
            logoGame_stream.Close();
        }
        private static void Music()
        {
            SoundPlayer player = new SoundPlayer("музыка\\фон музыка(меню).wav");
            player.PlayLooping();
        }
    }
}
