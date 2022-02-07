using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource = localhost; username = root; password =; database = general");
        public Form1()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "select * from information where Email='" + bunifuMaterialTextbox1.Text + "' and Password = '" + bunifuMaterialTextbox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0) 
            {
                MessageBox.Show("Invalid Email Or Password");
            }
            else 
            {
                this.Hide();
                Form2 ins = new Form2();
                ins.Show();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form7 obj = new Form7();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catagory ins = new catagory();

            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.linkedin.com");
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
