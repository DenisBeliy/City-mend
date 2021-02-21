using System;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

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
            FullWindow();
            Console.ReadLine();
        }
        
        private static void FullWindow()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
        }
    }
}
