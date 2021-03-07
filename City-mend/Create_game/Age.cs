using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_mend.Create_game
{
    class Age
    {
        public static List<string> ageList = new List<string>();
        
        public static void PlusAge()
        {
            Import_ageList();
            timerStart();
         //  Console.WriteLine(123);
        }



        //Загрузка данных в lists
        private static void Import_ageList()
        {
            FileStream age_stream = new FileStream(@"C://Сохранения игры City-mend//" + "Save_residents_age.D&D", FileMode.Open);

            StreamReader age_reader = new StreamReader(age_stream);
            for (int i = 0; i < age_stream.Length; i++)
            {
                string txt = age_reader.ReadLine();
                if (txt == null)
                {
                    break;
                }
                ageList.Add(txt);
            }
    

            age_stream.Close();
            age_reader.Close();
         
        }

        public static void Save_ageList()
        {
            File.WriteAllLines("C://Сохранения игры City-mend//" + "Save_residents_age.D&D", ageList);
        }

        public static void Update()
        {

            for (int i = 0; i < ageList.Count; i++)
            {
                int a = int.Parse(ageList[i]);
                a = a + 1;
                ageList[i] = a.ToString();
            }
            Save_ageList();

            Console.WriteLine();
        }


        private static System.Timers.Timer timer1 = new System.Timers.Timer(1000);
        private static void timerStart()
        {
            timer1.Elapsed += Timer1_AgeElapsed;
            timer1.Enabled = true;
            timer1.Start();

        }

        private static void Timer1_AgeElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            Update();
            Random random = new Random();
            for (int i = 0; i < ageList.Count; i++)
            {
                
                int b = int.Parse(ageList[i]);
                if (b >random.Next(61,101))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show("Житель умер." + " Он был " +".", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.OK)
                    {
                        ageList.RemoveAt(i);

                        Save_ageList();

                        timer1.Start();
                        Console.WriteLine();
                    }
                
                }
            }
        }
    }
}
