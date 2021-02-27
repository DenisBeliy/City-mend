using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_mend.Create_game;
using City_mend.Forms;

namespace City_mend.Create_game
{
    class LVL_logics
    {
        public static void Level_logics()
        {
            Draw();
            timerStart();
            Update();
        }

        private static void Draw()
        {
            //village_level

            Console.SetCursorPosition(156, 13);
            Console.Write(Create_LVL.village_level);

            //residents

            Console.SetCursorPosition(147, 17);
            Console.Write(Create_LVL.residents);

            //food

            Console.SetCursorPosition(144, 21);
            Console.Write(Create_LVL.food);

            //money

            Console.SetCursorPosition(150, 25);
            Create_LVL.money = (float)Math.Round(Create_LVL.money, 2);
            Console.WriteLine(Create_LVL.money.ToString());

            Console.SetCursorPosition(0, 37);
        }

        public static System.Timers.Timer timer1 = new System.Timers.Timer(3000);

        private static void timerStart()
        {
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Enabled = true;
            timer1.Start();
        
        }

        private static void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            //village_level
            if (Create_LVL.residents >= 50 && Create_LVL.food >= 500 && Create_LVL.money >= 500)
            {
                Create_LVL.village_level = Create_LVL.village_level + 1;
            }


            //food
            Create_LVL.food = Create_LVL.food + Create_LVL.residents * 2;

            //money
            Create_LVL.money = Create_LVL.money + Create_LVL.residents * 1.531f;




            Draw();
        
        }

        private static void Choice()
        {
            ConsoleKeyInfo consoleKeyInfo;
           
            while (true)
            {
                
                do
                {

                    consoleKeyInfo = Console.ReadKey(true);
                    if (consoleKeyInfo.Key == ConsoleKey.F)
                    {
                     
                        Console.WriteLine("Good");
                        
                        break;
                    }
                    if (consoleKeyInfo.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                        break;
                    }

                } while (consoleKeyInfo.Key == ConsoleKey.D0);
                 
            }
        }

        private static void Update()
        {
            ConsoleKeyInfo consoleKeyInfo;
            while (true)
            {
                do
                {
                    consoleKeyInfo = Console.ReadKey(true);
                    
                } while (consoleKeyInfo.Key != ConsoleKey.R);
                Residents frm = new Residents();
                frm.ShowDialog();

            }
        }
    }
}
