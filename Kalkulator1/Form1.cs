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


namespace Kalkulator1
{
    public partial class Form1 : Form
    {
        public double first;
        public double second;
        private string calculate;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button1.Text;
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
                textBox1.Text = button10.Text;
            else
                textBox1.Text += button10.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
            first = 0;
            second = 0;
        }
        public void operation()
        {
            second = double.Parse((textBox1.Text));
           
            switch(calculate)
            {
                case "+":
                    first = first + second;
                    textBox1.Text = first.ToString();
                    break;
                case "-":
                    first = first - second;
                    break;
                case "*":
                    first = first * second;
                    break;
                case "/":
                    first = first / second;
                    break;
                case "sin":
                    first = Math.Sin(second);
                    break;
                case "cos":
                    first = Math.Cos(second);
                    break;
                case "tan":
                    first = Math.Tan(second);
                    break;

            }
            textBox1.Text = first.ToString();
        }
        private void zero()
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = double.Parse(textBox1.Text);
                calculate = "+";
            textBox1.Text = "0";
            label1.Text = first.ToString() + "+";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation();
            label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            first = double.Parse(textBox1.Text);
            calculate = "-";
            label1.Text = first.ToString() + "-";
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            first = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            calculate = "*";
            label1.Text = first.ToString() + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            first = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            calculate = "/";
            label1.Text = first.ToString();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
                if (textBox1.Text == "")
                    textBox1.Text = "0,";
                else
                    textBox1.Text = textBox1.Text + ",";
           
        }

        private void button18_Click(object sender, EventArgs e)
        {

            string plusminus = textBox1.Text;
            double minusplus = Convert.ToDouble(plusminus);
            minusplus = minusplus * -1;
            textBox1.Text = minusplus.ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            first = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            calculate = "sin";
            textBox1.Text = first.ToString();
            operation();
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            var tupla = new List<Tuple<double, double>>();
            for (double x = 0; x < Math.PI * 2; x += Math.PI / 180.0)
            {
                tupla.Add(Tuple.Create(x, Math.Sin(x)));
            }
            chart2.ChartAreas.Add("pole");
            var series = chart2.Series.Add("Sin()");
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "pole";
            series.XValueMember = "Item1";
            series.YValueMembers = "Item2";
            chart2.DataSource = tupla;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
            if (textBox1.Text == "")
                textBox1.Text = "0";
  
        }

        private void button21_Click(object sender, EventArgs e)
        {

            first = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            calculate = "cos";
            textBox1.Text = first.ToString();
            operation();
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            var tupla = new List<Tuple<double, double>>();
            for (double x = 0; x < Math.PI * 2; x += Math.PI / 180.0)
            {
                tupla.Add(Tuple.Create(x, Math.Cos(x)));
            }
            chart2.ChartAreas.Add("pole");
            var series = chart2.Series.Add("Cos()");
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "pole";
            series.XValueMember = "Item1";
            series.YValueMembers = "Item2";
            chart2.DataSource = tupla;

        }

        private void button23_Click(object sender, EventArgs e)
        {

            first = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            calculate = "tan";
            textBox1.Text = first.ToString();
            operation();
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
        }
    }
}
