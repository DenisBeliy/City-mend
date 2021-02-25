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
namespace City_mend.Forms
{
    public partial class Residents : Form
    {
        public Residents()
        {
            InitializeComponent();
        }
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Create_LVL.money >= 100f)
            {
                Create_LVL.money = Create_LVL.money - 1.623f;
                int colIndex = 0; //индекс столбца

                Random random_name = new Random();
                Random random_profession = new Random();
                Random random_temperament = new Random();
                Random random_endurance = new Random();
                Random random_meaning_of_life = new Random();


                Names print_random_name = (Names)random_name.Next(0, 100);
                Profession print_random_profession = (Profession)random_profession.Next(0, 8);
                Temperament print_random_temperament = (Temperament)random_temperament.Next(0, 3);
                Meaning_of_life print_random_meaning_of_life = (Meaning_of_life)random_meaning_of_life.Next(0, 3);

                dataGridView1.Rows.Add("", print_random_name, print_random_profession,
               print_random_meaning_of_life, print_random_temperament, random_endurance.Next(0, 101) + "%");



                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;

                }
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
            label3.Text = "button1";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button3";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button4";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button5";
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button6";
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button7";
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button8";
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "button9";
        }
    }
}
