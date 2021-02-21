using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace City_mend
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C://Сохранения игры City-mend//" + "");
            Create_Files.Files();
            Console.ReadLine();
        }
    }
}
