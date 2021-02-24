using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Residents_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            label2.Text = Create_LVL.money.ToString() + " D/Dcoins";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerMoney_Tick(object sender, EventArgs e)
        {
            label2.Text = Create_LVL.money.ToString() + " D/Dcoins"; 
        }
    }
}
