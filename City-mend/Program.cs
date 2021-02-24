using System;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using City_mend.Create_game;
using City_mend.Create_game;
using City_mend.Create_game;
namespace City_mend
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C://Сохранения игры City-mend//" + "");
            Create_Files.Files();
            FullWindow();//открытие на весь экран
          //  Login_to_game.Welcome();//при входе в игру
            Menu.Menu_create();


           
            Console.ReadLine();
        }
        
        private static void FullWindow()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
        }
    }
}
