using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double xmin = double.Parse(textBox1.Text);//-0,73
            double xmax = double.Parse(textBox2.Text);//-1,73
            double step = double.Parse(textBox3.Text);//-0,1
            
            int count = (int)Math.Ceiling(Math.Abs((xmax - xmin) / step) + 1);
            double[] x = new double[count];
            double[] y = new double[count];
            
            for(int i=0;i<count;i++)
            {
                x[i] = xmin + step * i;
                y[i] = Math.Sqrt(Math.Abs(x[i] - 2)) / Math.Sqrt(Math.Abs(Math.Pow(-2, 3) - Math.Pow(x[i], 3))) + Math.Log(Math.Abs(x[i] - 2));
            }
            chart1.ChartAreas[0].AxisX.Minimum = xmax;
            chart1.ChartAreas[0].AxisX.Maximum = xmin;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval= -step;
            chart1.Series[0].Points.DataBindXY(x, y);
        }
    }
}
