using WindowsFormsApp1.Properties;
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
using Tulpep.NotificationWindow;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
  
        public Form2()
        {
            InitializeComponent();

            locationpanel.Visible = false;
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            profilesetting ins = new profilesetting();
            ins.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Form1 ins = new Form1();
            this.Close(); 
            ins.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 ins = new Form9();
            ins.Visible = true;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            calander ins = new calander();
            ins.Show();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com");
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com");
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            PopupNotifier ins = new PopupNotifier();
            ins.Image = Properties.Resources.msg;
            ins.TitleText = "New Notification";
            ins.ContentText = "Visual studio is hacked";
            ins.Popup();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            emailsend ins = new emailsend();
            ins.Show();
        }

        private void src_Click(object sender, EventArgs e)
        {
            string Street = strt.Text;
            string City = city.Text;
            string State = state.Text;
            string Zip = zip.Text;
            try
            {
                StringBuilder queryadd = new StringBuilder();
                queryadd.Append("https://www.google.com/maps/@23.7747523,90.3654215,15z");

                if(Street != string.Empty) 
                {
                    queryadd.Append(Street + "," + "+");
                }
                if (City != string.Empty)
                {
                    queryadd.Append(City + "," + "+");
                }
                if (State != string.Empty)
                {
                    queryadd.Append(State + "," + "+");
                }
                if (Zip != string.Empty)
                {
                    queryadd.Append(Zip + "," + "+");
                }
                webBrowser1.Navigate(queryadd.ToString());
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            locationpanel.Visible = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            showacc ins = new showacc();
            ins.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            locationpanel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

       
 }
