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
        private static int village_level;
        private static int residents;
        private static int food;
        private static float money;
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
        }


        private static void LoadContent()
        {
            try
            {

                StreamReader village_reader = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_villageLevel.D&D");
                village_level = int.Parse(village_reader.ReadToEnd());
                village_reader.Close();

                StreamReader residents_reader = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                residents = int.Parse(residents_reader.ReadToEnd());
                residents_reader.Close();

                StreamReader food_reader = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_food.D&D");
                food = int.Parse(food_reader.ReadToEnd());
                food_reader.Close();

                StreamReader money_reader = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_food.D&D");
                money = int.Parse(money_reader.ReadToEnd());
                money_reader.Close();
            }
            catch 
            { 
            village_level = 1;
            residents = 0;
            food = 100;
            money = 100.423f;
            }
      /*      Console.WriteLine();
            Console.WriteLine(village_level);
            Console.WriteLine(residents);
            Console.WriteLine(food);
            Console.WriteLine(money);*/
        }
    }
}
