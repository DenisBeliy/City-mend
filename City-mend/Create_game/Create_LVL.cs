using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace City_mend.Create_game
{
    class Create_LVL
    {
        //поля
        public static int village_level;
        public static int residents = 1;
        public static int food;
        public static float money;
        
        //конструктор
        public Create_LVL()
        {
            village_level = 1;
            residents = 0;
            food = 100;
            money = 100.423f;
        }

        //методы

        public static void Create_level()
        {
            LoadContent();
            Draw();


        }


        private static void LoadContent()
        {
            //residents
            try
            {
                residents = int.Parse(File.ReadAllText(@"C://Сохранения игры City-mend//" + "Save_residents.D&D").ToString());
            }
            catch
            {

                residents = 0;
            }

            //village_level
            try
            {
                village_level = int.Parse(File.ReadAllText(@"C://Сохранения игры City-mend//" + "Save_villageLevel.D&D").ToString());
            }
            catch
            {

                village_level = 0;
            }

            //food
            try
            {
                food = int.Parse(File.ReadAllText(@"C://Сохранения игры City-mend//" + "Save_food.D&D").ToString());
            }
            catch
            {

                food = 100;
            }


            //money
            try
            {
                money = float.Parse(File.ReadAllText(@"C://Сохранения игры City-mend//" + "Save_money.D&D").ToString());
            }
            catch
            {

                money = 100.4256f;
            }
  
      /*      Console.WriteLine();
            Console.WriteLine(village_level);
            Console.WriteLine(residents);
            Console.WriteLine(food);
            Console.WriteLine(money);*/
        }



        private static void Draw()
        {
            Console.Clear();
            //village
            string village_draw = Properties.Resources.деревня_1_lvl_;//!
            Console.WriteLine(village_draw);


            //base_values
            Console.SetCursorPosition(125, 0);
            string[] base_values = Properties.Resources.базовые_показатели.Split('\n');
            for (int i = 0; i < base_values.Length; i++)
            {
                Console.Write(base_values[i]);
                Console.SetCursorPosition(135, i);
            }



        }
    }
}
