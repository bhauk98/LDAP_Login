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
using System.Data.OleDb;

namespace charting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=localhost;Database=chart;Uid=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("Select *from info", connection);
            MySqlDataReader myReader;
            connection.Open();
            myReader = cmd.ExecuteReader();
            while (myReader.Read()) { 
             this.chart1.Series["Phones"].Points.AddXY(myReader.GetString("names"), myReader.GetInt32("phones"));
             this.chart1.Series["Tablets"].Points.AddXY(myReader.GetString("names"), myReader.GetInt32("tablets"));
        }
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 100;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void agetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Phones"].Points.Clear();
            this.chart1.Series["Tablets"].Points.Clear();
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=localhost;Database=chart;Uid=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("Select *from info2", connection);
            MySqlDataReader myReader;
            connection.Open();
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                this.chart1.Series["Phones"].Points.AddXY(myReader.GetString("Name"), myReader.GetInt32("Phones"));
                this.chart1.Series["Tablets"].Points.AddXY(myReader.GetString("Name"), myReader.GetInt32("Tablets"));
            }

            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
