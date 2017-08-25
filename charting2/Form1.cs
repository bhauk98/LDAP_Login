using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace charting2
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
            this.chart1.Series["Price"].Points.AddXY("JAN",75);
            this.chart1.Series["Price"].Points.AddXY("FEB",45);
            this.chart1.Series["Price"].Points.AddXY("MAR",55);
            this.chart1.Series["Price"].Points.AddXY("APR",65);
            this.chart1.Series["Price"].Points.AddXY("MAY",89);
            this.chart1.Series["Price"].Points.AddXY("JUN",89);
            this.chart1.Series["Price"].Points.AddXY("JUL",89);
            this.chart1.Series["Price"].Points.AddXY("AUG",53);
            this.chart1.Series["Price"].Points.AddXY("SEP",65);
            this.chart1.Series["Price"].Points.AddXY("OCT",56);
            this.chart1.Series["Price"].Points.AddXY("NOV",67);
            this.chart1.Series["Price"].Points.AddXY("DEC",70);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 12;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 10;
        }
    }
}
