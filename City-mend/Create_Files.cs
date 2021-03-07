using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace City_mend
{
    class Create_Files
    {
        public static void Files()
        {
            Residents();
            Village();
            Food();
            Money();
            Residents_dataGrid();
            Residents_age();
        }

        private static void Residents()
        {
            FileStream residents_stream = new FileStream(@"C://Сохранения игры City-mend//"+ "Save_residents.D&D", FileMode.OpenOrCreate);
            residents_stream.Close();
        }
        private static void Village()
        {
            FileStream village_stream = new FileStream(@"C://Сохранения игры City-mend//" + "Save_villageLevel.D&D", FileMode.OpenOrCreate);
            village_stream.Close();
        }
        private static void Food()
        {
            FileStream food_stream = new FileStream(@"C://Сохранения игры City-mend//" + "Save_food.D&D", FileMode.OpenOrCreate);
            food_stream.Close();
        }
        private static void Money()
        {
            FileStream money_stream = new FileStream(@"C://Сохранения игры City-mend//" + "Save_money.D&D", FileMode.OpenOrCreate);
            money_stream.Close();
        }
        private static void Residents_dataGrid()
        {
            FileStream money_stream = new FileStream(@"C://Сохранения игры City-mend//" + "Save_residents_dataGrid.D&D", FileMode.OpenOrCreate);
            money_stream.Close();
        }

        private static void Residents_age()
        {
            FileStream money_stream = new FileStream(@"C://Сохранения игры City-mend//" + "Save_residents_age.D&D", FileMode.OpenOrCreate);
            money_stream.Close();
        }
    }
}
