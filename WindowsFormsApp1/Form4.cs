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
    public partial class Form4 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO general.information(`FirstName`, `LastName`, `Email`, `PhoneNo`, `PresentAddress`, `PermanentAddress`, `NationalID`, `DateOfBirth`, `PassportNumber`, `BloodGroup`, `Age`, `Gender`, `Password`) VALUES('" + textBoxfname.Text + "','" + textBoxlname.Text + "','" + textBoxemail.Text + "','" + textBoxphone.Text +  "','" + textBoxpa.Text +  "','" + textBoxpresent.Text +  "','" + textBoxnid.Text +  "','" + dateTimePicker1.Value.Date+  "','" + textBoxpn.Text +  "','" + textBoxbg.Text +  "','" + textBoxage.Text +  "','" + textBoxgender.Text + "'," + textBoxpass.Text + ")";
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            catagory ins = new catagory();
            ins.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
