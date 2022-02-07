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
    public partial class Form6 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            studentform ins = new studentform();
            ins.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO general.police(`First Name`, `Last Name`, `Email`, `Phone`, `Police Id`, `Region`, `Rank`, `Date Of Birth`, `National Id`, `Blood Group`, `Age`, `Gender`, `Password`) VALUES('" + textBox10.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'," + textBox13.Text + ")";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Your Registration Is Complete");
                }
                else
                {
                    MessageBox.Show("Unsuccesfull");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
