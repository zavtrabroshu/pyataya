﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace построение_графика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Add("cos");
        }

        
       

        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBox2.Text);
            double Xmax = double.Parse(textBox1.Text);
            double Step = double.Parse(textBox3.Text);
            double R = double.Parse(textBox4.Text);
            
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
          
            double[] x = new double[count];
            
            double[] y1 = new double[count];
            double[] y2 = new double[count];


            
            for (int i = 0; i < count; i++)
            {
               
                x[i] = Xmin + Step * i;
                y1[i] = Math.Sin(x[i]);
                y2[i] = Math.Cos(x[i]);
            }
            
           



            {
            }

            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);

        }

       
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

