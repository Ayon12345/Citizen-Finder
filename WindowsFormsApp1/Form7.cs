using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_MouseEnter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox2_MouseEnter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }

        private void bunifuMaterialTextbox3_MouseEnter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Text = "";
        }
    }
}
