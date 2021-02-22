using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using City_mend;
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
            string text = "";
            StreamReader menu_stream = new StreamReader("файлы для отрисовки\\Menu.txt");
            Console.Clear();
            do
            {
                text = menu_stream.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            menu_stream.Close();
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
                    DirectoryInfo dirInfo = new DirectoryInfo("C:\\Сохранения игры City-mend\\");

                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                    Create_Files.Files();
                    //
                    break;
                }
                if (consoleKeyInfo.Key == ConsoleKey.D2)
                {

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
