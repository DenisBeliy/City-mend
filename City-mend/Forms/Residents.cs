using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
