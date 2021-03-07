using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using City_mend.Create_game;
using City_mend.Create_game;

namespace City_mend.Forms
{
    public partial class Residents : Form
    {

        public Residents()
        {
            InitializeComponent();
        }

        public float price1 = 10.9f;
        public float price2 = 10.7f;
        public float price3 = 11.9f;
        public float price4 = 10.0f;
        public float price5 = 10.0f;
        public float price6 = 10.5f;
        public float price7 = 10.6f;
        public float price8 = 10.4f;
        public float price9 = 10.8f;
        enum Names
        {
            Август, Августин, Авраам, Аврора, Агата, Агафон, Агнесса,
            Агния, Ада, Аделаида, Аделина, Адонис, Акайо, Акулина,
            Алан, Алевтина, Александр, Александра, Алексей, Алена,

            Беатрис, Белла, Бенедикт, Берта, Богдан, Божена, Болеслав,
            Борис, Борислав, Бронислав, Бронислава, Булат,

            Габриэлла, Гавриил, Галина, Гарри, Гелла, Геннадий, Генриетта,
            Георгий, Герман, Гертруда, Глафира, Глеб, Глория, Гордей, Грейс,
            Грета, Григорий, Гульмира,

            Магдалина, Майя, Макар, Максим, Марат, Маргарита, Марианна, Марина,
            Мария, Марк, Марта, Мартин, Марфа, Матвей, Мелания, Мелисса, Милана,
            Милена,

            Оксана, Олег, Олеся, Оливер, Оливия, Ольга, Оскар,

            Эдгар, Эдита, Эдуард, Элеонора, Элина, Элла, Эльвира, Эльдар, Эльза,
            Эмили, Эмилия, Эмма, Эрик, Эрика,


            Сабина, Савва, Савелий, Саки, Сакура, Самсон, Самуил, Сарра, Светлана,
            Святослав, Севастьян, Семен
        }

        enum Profession
        {
            Сталкер, Охотник_за_головами, Ученый, Пастух, Каменщик, Кузнец,
            Священник, Монах, Торговец
        }

        enum Temperament
        {
            Сангвини, Флегматик, Холерик, Меланхолик
        }

        enum Meaning_of_life
        {
            Я_хороший__ты_хороший, Я_плохой__ты_хорший, Я_плохой__ты_плохой, Я_хороший__ты_плохой
        }



        private void Residents_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            label2.Text = Create_LVL.money.ToString() + " D/Dcoins";

            //активность кнопок
            if (Create_LVL.village_level <= 2)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
     


            //загрузка данных в dataGrid

            try
            {
                foreach (var line in File.ReadLines(@"C://Сохранения игры City-mend//" + "Save_residents_dataGrid.D&D"))
                {
                    var array = line.Split();
                    dataGridView1.Rows.Add(array);

                }
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
            }
            catch
            {
                /*MessageBox.Show("eror");*/
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerMoney_Tick(object sender, EventArgs e)
        {
            label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
            label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
         
            
          
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money >= 2)
            {
                Create_LVL.money = Create_LVL.money - 1.623f;
                int colIndex = 0; //индекс столбца

                Random random_name = new Random();
                Random random_profession = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();
                Random random_age = new Random();

                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = (Profession)random_profession.Next(0, 8);
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
               print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
               random_age.Next(5, 41));



                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }
                int a = 0;
                StreamReader reader1 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                a = int.Parse(reader1.ReadLine());

                reader1.Close();

                StreamWriter writer1 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer1.Write(a + 1);
                writer1.Close();
                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
            }
        }
       

        private void Residents_FormClosed(object sender, FormClosedEventArgs e)
        {
            //сохранение dataGrid
            int rows = dataGridView1.Rows.Count;

            StreamWriter streamWriter_dataGrid = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents_dataGrid.D&D");

            try
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    int a = j;
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter_dataGrid.Write(dataGridView1.Rows[j].Cells[i].Value + " ");
                        // Console.Write(" ");
                    }

                    streamWriter_dataGrid.WriteLine();
                }
                streamWriter_dataGrid.Close();
            }
            catch { MessageBox.Show("Ошибка при сохранении файла!"); }

        }

       private void button1_Leave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
         
            label3.Text = "цена: " + price1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {

                Create_LVL.money = Create_LVL.money - price1;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Сталкер;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
               print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
               random_age.Next(63,91));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }


                int a = 0;
                StreamReader reader1 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                try
                {
                    a = int.Parse(reader1.ReadLine());
                }
                catch
                {
                    a = 0;
                }
                reader1.Close();

                StreamWriter writer1 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer1.Write(a + 1);
                writer1.Close();


                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
                
                Create_LVL.money = Create_LVL.money - price2;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Охотник_за_головами;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                               print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                               random_age.Next(5, 41));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }

                int a = 0;
                StreamReader reader2 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader2.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader2.Close();

                StreamWriter writer2 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer2.Write(a + 1);
                writer2.Close();


                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
                
                Create_LVL.money = Create_LVL.money - price3;
                Random random_name = new Random();
                 Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Ученый;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                               print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                               random_age.Next(20, 51)); 
                
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }


                int a = 0;
                StreamReader reader3 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader3.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader3.Close();

                StreamWriter writer3 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer3.Write(a + 1);
                writer3.Close();

                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price3;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price4;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price5;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price6;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price7;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price8;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "цена: " + price9;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void информацияОКлассеToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           LVL_logics.timer1.Stop();
            timerAge.Stop();
           DialogResult result1 = MessageBox.Show("buton1", "     Сталкер", MessageBoxButtons.OK);
            if (result1 == DialogResult.OK )
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void информацияОКлассеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
           
            DialogResult result2 = MessageBox.Show("buton2", "     Охотник за головами", MessageBoxButtons.OK);
            if (result2 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void информацияОКлассеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
            DialogResult result3 = MessageBox.Show("buton3", "     Ученый", MessageBoxButtons.OK);
            if (result3 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void информацияОКлассеToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
            DialogResult result3 = MessageBox.Show("buton4", "     Пастух", MessageBoxButtons.OK);
            if (result3 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void информацияОКлассеToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
            DialogResult result3 = MessageBox.Show("buton5", "     Каменщик", MessageBoxButtons.OK);
            if (result3 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void contextMenuStrip6_Opening(object sender, CancelEventArgs e)
        {

        }

        private void информацияОКлассеToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
            timerAge.Stop();
            DialogResult result3 = MessageBox.Show("buton6", "     Кузнец", MessageBoxButtons.OK);
            if (result3 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void информацияОКлассеToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
            DialogResult result3 = MessageBox.Show("buton7", "     Священник", MessageBoxButtons.OK);
            if (result3 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void информацияОКлассеToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
            DialogResult result3 = MessageBox.Show("buton8", "     Монах", MessageBoxButtons.OK);
            if (result3 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void информацияОКлассеToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            LVL_logics.timer1.Stop();
            timerAge.Stop();
            DialogResult result3 = MessageBox.Show("buton9", "     Торговец", MessageBoxButtons.OK);
            if (result3 == DialogResult.OK)
            {
                LVL_logics.timer1.Start();
                timerAge.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
                
                Create_LVL.money = Create_LVL.money -price4 ;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Пастух;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                                print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                                random_age.Next(5, 41));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }

                int a = 0;
                StreamReader reader4 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader4.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader4.Close();

                StreamWriter writer4 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer4.Write(a + 1);
                writer4.Close();

                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
                
                Create_LVL.money = Create_LVL.money - price5;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Каменщик;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                                     print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                                     random_age.Next(5, 41));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }

                int a = 0;
                StreamReader reader5 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader5.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader5.Close();

                StreamWriter writer5 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer5.Write(a + 1);
                writer5.Close();

                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
                
                Create_LVL.money = Create_LVL.money - price6;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Кузнец;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                                 print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                                 random_age.Next(12, 41));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }

                int a = 0;
                StreamReader reader6 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader6.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader6.Close();

                StreamWriter writer6 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer6.Write(a + 1);
                writer6.Close();

                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
               
                Create_LVL.money = Create_LVL.money - price7;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Священник;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                                     print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                                     random_age.Next(5, 41));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }

                int a = 0;
                StreamReader reader7 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader7.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader7.Close();

                StreamWriter writer7 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer7.Write(a + 1);
                writer7.Close();

                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
                
                Create_LVL.money = Create_LVL.money - price8;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Монах;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                               print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                               random_age.Next(5, 41));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }

                int a = 0;
                StreamReader reader8 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader8.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader8.Close();

                StreamWriter writer8 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer8.Write(a + 1);
                writer8.Close();

                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money > 50)
            {
               
                Create_LVL.money = Create_LVL.money - price9;
                Random random_name = new Random();
                Random random_age = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = Profession.Торговец;
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
                                print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%",
                                random_age.Next(15, 41));
                int colIndex = 0;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }

                int a = 0;
                StreamReader reader9 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");

                try
                {
                    a = int.Parse(reader9.ReadLine());
                }
                catch
                {
                    a = 0;
                }

                reader9.Close();

                StreamWriter writer9 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                writer9.Write(a + 1);
                writer9.Close();

                label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
                label2.Text = Math.Round(Create_LVL.money, 2).ToString() + " D/Dcoins";
            }
            else
            {
                MessageBox.Show("У вас нет денег!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timerAge_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int colIndex = 6;
            int a = 0;
            int b = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
            
                b = Convert.ToInt32(dataGridView1[6, i].Value);
                if (b > random.Next(65, 101))
                {
                    timerAge.Enabled = false;
             
                    string m = dataGridView1[1, i].Value.ToString();
                    string n = dataGridView1[2, i].Value.ToString();
                    DialogResult dialog = MessageBox.Show(m + ". Житель умер." + " Он был " + n + ".", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.OK)
                    {
                        StreamReader reader1 = new StreamReader(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                        try
                        {
                            a = int.Parse(reader1.ReadLine());
                        }
                        catch
                        {
                            a = 0;
                        }
                        reader1.Close();

                        StreamWriter writer1 = new StreamWriter(@"C://Сохранения игры City-mend//" + "Save_residents.D&D");
                        try
                        {
                            writer1.Write(a - 1);
                        }
                        catch { }
                        writer1.Close();

                        dataGridView1.Rows.RemoveAt(i);
                        timerAge.Enabled = true;

                    }

                }
                else
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = b + 1;
                }
            }
        }

        private void contextMenuStrip10_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip5_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Residents_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Residents_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            contextMenuStrip10.Show(button11.Location);
        }
    }

}
