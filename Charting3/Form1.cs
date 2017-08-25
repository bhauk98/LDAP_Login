using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charting3
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
            Random rdn = new Random();
            for (int i = 0; i < 10; i++)
            {
                chart1.Series["Series1"].Points.AddXY
                                (rdn.Next(0, 10), rdn.Next(0, 10));
                chart1.Series["Series2"].Points.AddXY
                                (rdn.Next(0, 10), rdn.Next(0, 10));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
        }
    }
}
