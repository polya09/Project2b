using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2b
{
    public partial class Form1 : Form
    {
        
        Circles circles;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                circles = new Circles(Int32.Parse(NumberTextBox.Text));
                RtextBox.Enabled = true;
                SaveBtn.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Double.Parse(RtextBox.Text));
            circles.addCircle(circle);
            MessageBox.Show(circle.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show(circles.ToString());
            richTextBox1.Text = Convert.ToString("Tast 1 (Quantity S < S cp)" + Environment.NewLine);
            double Scp = 0;
            int k = 0;
            double S = circles.GetCircleAt(0).Radius * circles.GetCircleAt(0).Radius * 3.14;
            for (int i = 0; i < circles.getCirclesNumber(); i++)
            {
                S = circles.GetCircleAt(i).Radius * circles.GetCircleAt(i).Radius * 3.14;
                Scp = Scp + S;
            }
            Scp = Scp / circles.getCirclesNumber();
            for (int i = 0; i < circles.getCirclesNumber(); i++)
            {
                if ((circles.GetCircleAt(i).Radius * circles.GetCircleAt(i).Radius * 3.14) < Scp)
                {
                    k = k + 1;
                    richTextBox1.Text = richTextBox1.Text + Convert.ToString("№ " + (i+1) + "   " + circles.GetCircleAt(i)).ToString() + Environment.NewLine;
                }
            }
            richTextBox1.Text = richTextBox1.Text + Convert.ToString("Quantity = " + k); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Cone cone = new Cone(Double.Parse(R2textBox.Text), Double.Parse(HtextBox.Text));
            circles.addCircle(cone);
            MessageBox.Show(cone.ToString());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                circles = new Circles(Int32.Parse(MtextBox.Text));
                R2textBox.Enabled = true;
                HtextBox.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(circles.ToString());
            richTextBox2.Text = Convert.ToString("Tast 2 (Quantity Vmax)" + Environment.NewLine);
            double Vmax = 0, V;
            for (int i = 0; i < circles.getCirclesNumber(); i++)
            {
                V = 0.3 * circles.GetCircleAt(i).Radius * circles.GetCircleAt(i).Radius /* circles.GetCircleAt(i).Height*/;
                if (V > Vmax)
                {
                    Vmax = V; 
                }
            }  
            richTextBox2.Text +=  Convert.ToString("Vmax = " + Vmax + Environment.NewLine);
        }
    }
}
