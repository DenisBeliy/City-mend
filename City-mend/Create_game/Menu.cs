using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using City_mend;
using City_mend.Create_game;
using City_mend.Create_game;
using System.Windows.Forms;
using City_mend.Forms;

namespace City_mend.Create_game
{
    class Menu
    {
        public static void Menu_create()
        {
            Menu_print();
            Choice();
        }

        private static void Menu_print()
        {
           // Thread.Sleep(2000);
            Console.Clear();
            string menu_stream = Properties.Resources.Menu;
            Console.WriteLine("     " + menu_stream);
        }
        private static void Choice()
        {
            Console.Write("Выберите пункт меню: ");
            ConsoleKeyInfo consoleKeyInfo;
           
            do
            {
                consoleKeyInfo = Console.ReadKey(true);
                /*       Console.Write("1");
                       Thread.Sleep(700);*/
                if (consoleKeyInfo.Key == ConsoleKey.D1)
                {
                    /* DirectoryInfo dirInfo = new DirectoryInfo("C:\\Сохранения игры City-mend\\");

                     foreach (FileInfo file in dirInfo.GetFiles())
                     {
                         file.Delete();
                     }
                     Create_Files.Files();
                     //*/

                    Residents frm = new Residents();
                    frm.ShowDialog();
                    


                    break;
                }
                if (consoleKeyInfo.Key == ConsoleKey.D2)
                {
                    Create_LVL.Create_level();
                    LVL_logics.Level_logics();
                    break;
                }
                if (consoleKeyInfo.Key == ConsoleKey.D3)
                {
                    Console.Write("Выход....");
                    Thread.Sleep(700);
                    Environment.Exit(0);
                    break;
                }
                Console.Clear();
                Menu_print();
                Console.Write("Выберите пункт меню: ");
            } while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 || consoleKeyInfo.Key != ConsoleKey.D3);
        }
    }
}
