using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_mend.Create_game;
namespace City_mend.Create_game
{
    class LVL_logics
    {
        public static void Level_logics()
        {
            Draw();
            timerStart();
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
            Console.WriteLine(Create_LVL.money.ToString());

            Console.SetCursorPosition(0,37);
        }

        static System.Timers.Timer timer1 = new System.Timers.Timer(1000);

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
            Create_LVL.food = Create_LVL.food+ Create_LVL.residents * 1;




            Draw();
        }
    }
}
