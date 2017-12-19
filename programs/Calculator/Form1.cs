using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication14
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double j = Convert.ToDouble(textBox2.Text);
            double a1 = i + j;
            label1.Text = a1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double j = Convert.ToDouble(textBox2.Text);
            double a2 = i - j;
            label1.Text = a2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double j = Convert.ToDouble(textBox2.Text);
            double a3 = i * j;
            label1.Text = a3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double j = Convert.ToDouble(textBox2.Text);
            if (j != 0)
            {
                double a4 = i / j;
                label1.Text = a4.ToString();
            }
            else
            {
                label1.Text = "Error";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            //double j = Convert.ToDouble(textBox2.Text);
            if (i >= 0)
            {
                double a5 = Math.Sqrt(i);
                label1.Text = a5.ToString();
            }
            else
            {
                label1.Text = "Error";
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            //double j = Convert.ToDouble(textBox2.Text);
            double a6 = Math.Cos(i * Math.PI / 180);
            label1.Text = a6.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double a7 = (Math.Sin(i * Math.PI / 180));
            label1.Text = a7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double a = Math.Abs(i / 90);
            if (a == Math.Floor(a))
            {
                if (a % 2 == 1)
                {
                    label1.Text = "Error";
                }
            }
            else
            {
                double a8 = (Math.Tan(i * Math.PI / 180));
                label1.Text = a8.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label1.Text = "";
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double a9 = (Math.Acos(i)) * 180 / Math.PI;
            label1.Text = a9.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double a10 = (Math.Asin(i)) * 180 / Math.PI;
            label1.Text = a10.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double a11 = (Math.Atan(i)) * 180 / Math.PI;
            label1.Text = a11.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            if (i > 0)
            {
                double a12 = Math.Log(i);
                label1.Text = a12.ToString();
            }
            else
            {
                label1.Text = "Error";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            if (i > 0)
            {
                double a13 = Math.Log10(i);
                label1.Text = a13.ToString();
            }
            else
            {
                label1.Text = "Error";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            if (i == 0)
            {
                label1.Text = "1";
            }
            else if (i < 0)
            {
                label1.Text = "Error";
            }
            else
            {
                int k;
                int A = 1;
                for (k = 1; k <= i; k++)
                {
                    A = A * k;
                }
                label1.Text = A.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double j = Convert.ToDouble(textBox2.Text);
            double a14 = Math.Pow(i, j);
            label1.Text = a14.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = 0;
            double m = 0;
            while (a > 0)
            {
                c = c + (a % 8) * Math.Pow(10, m);
                a = Math.Floor(a / 8);
                m++;
            }
            label1.Text = c.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = 0;
            double m = 0;
            while (a > 0)
            {
                c = c + (a % 2) * Math.Pow(10, m);
                a = Math.Floor(a / 2);
                m++;
            }
            label1.Text = c.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = 0;
            double m = 0;
            while (a > 0)
            {
                c = c + (a % 4) * Math.Pow(10, m);
                a = Math.Floor(a / 4);
                m++;
            }
            label1.Text = c.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt((Math.Pow(b, 2)) - 4 * a * c)) / (2 * a);
                double x2 = (-b - Math.Sqrt((Math.Pow(b, 2)) - 4 * a * c)) / (2 * a);
                label1.Text = "x1= " + x1.ToString() + " , x2= " + x2.ToString();
            }
            else
            {
                double m = Math.Sqrt(Math.Abs(d)) / (2 * a);
                double n =- Math.Sqrt(Math.Abs(d)) / (2 * a);
                double o =-b/2;
                if (o != 0)
                {
                    label1.Text = "x1= " + m.ToString() + "i + " + o.ToString() + " ,x2= " + n.ToString() + "i + " + o.ToString();
                }
                else
                {
                    label1.Text = "x1= " + m.ToString() + "i" + " ,x2= " + n.ToString() + "i";
                }
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double n = Convert.ToDouble(textBox4.Text);
            double m = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x = x1;
            double y;
            double s = 0;
            while (x < x2)
            {
                y = a * Math.Pow((Math.Sin(b * (Math.Pow(x, m)) + c)), n);
                s = s + y * 0.00001;
                x += 0.00001;
            }
            if (Math.Abs(s) < Math.Pow(10, -3.6))
            {
                s = 0;
            }
            else if (Math.Abs(Math.Ceiling(s) - s) < Math.Pow(10, -3.6))
            {
                s = Math.Ceiling(s);
            }
            else if (Math.Abs(Math.Floor(s) - s) < Math.Pow(10, -3.6))
            {
                s = Math.Floor(s);
            }
            label1.Text = s.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double n = Convert.ToDouble(textBox4.Text);
            double m = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x = x1;
            double y;
            double s = 0;
            while (x < x2)
            {
                y = a * Math.Pow((Math.Cos(b * (Math.Pow(x, m)) + c)), n);
                s = s + y * 0.00001;
                x += 0.00001;
            }
            if (Math.Abs(s) < Math.Pow(10, -3.6))
            {
                s = 0;
            }
            else if (Math.Abs(Math.Ceiling(s) - s) < Math.Pow(10, -3.6))
            {
                s = Math.Ceiling(s);
            }
            else if (Math.Abs(Math.Floor(s) - s) < Math.Pow(10, -3.6))
            {
                s = Math.Floor(s);
            }
            label1.Text = s.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double n = Convert.ToDouble(textBox4.Text);
            double m = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x = x1;
            double y;
            double s = 0;
            while (x < x2)
            {
                y = a * Math.Pow((Math.Tan(b * (Math.Pow(x, m)) + c)), n);
                s = s + y * 0.00001;
                x += 0.00001;
            }
            if (Math.Abs(s) < Math.Pow(10, -3.6))
            {
                s = 0;
            }
            else if (Math.Abs(Math.Ceiling(s) - s) < Math.Pow(10, -3.6))
            {
                s = Math.Ceiling(s);
            }
            else if (Math.Abs(Math.Floor(s) - s) < Math.Pow(10, -3.6))
            {
                s = Math.Floor(s);
            }
            label1.Text = s.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Math.Pow(Math.E, a);
            label1.Text = c.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = Convert.ToDouble(textBox4.Text);
            double f = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x;
            double y;
            double s;
            double n = 4;
            double M;
            double N;
            x = x1;
            y = a * Math.Pow(x, n+1)/(n+1) + b * Math.Pow(x, n )/n + c * Math.Pow(x, n - 1)/(n-1) + d * Math.Pow(x, n - 2)/(n-2) + f * Math.Pow(x, n - 3)/(n-3);
            M = y;
            x = x2;
            y = a * Math.Pow(x, n + 1) / (n + 1) + b * Math.Pow(x, n) / n + c * Math.Pow(x, n - 1) / (n - 1) + d * Math.Pow(x, n - 2) / (n - 2) + f * Math.Pow(x, n - 3) / (n - 3);
            N = y;
            s = N - M;
            label1.Text = s.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double n = 0;
            double i;
            while (true)
            {
                n++;
                i = a / Math.Pow(10, n);
                if (i > 0 && i < 10)
                {
                    break;
                }
            }
            label1.Text = i.ToString() + "E" + n.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double s = 1;
            double m = 1;
            double o = 1;
            double c, i, j, k;
            if (a<b)
            {
               label1.Text="Error";
            }
            else
            {
            for (i = 1; i <= a; i++)
            {
                s = s * i;
            }
            for (j = 1; j <= b; j++)
            {
                m = m * j;
            }
            for (k = 1; k <= a - b; k++)
            {
                o = o * k;
            }
            c = s / (m * o);
            label1.Text = c.ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double s = 1;
            double m = 1;
            double c, i, j;
            if (a < b)
            {
                label1.Text = "Error";
            }
            else
            {
                for (i = 1; i <= a; i++)
                {
                    s = s * i;
                }
                for (j = 1; j <= a - b; j++)
                {
                    m = m * j;
                }
                c = s / m;
                label1.Text = c.ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double s = Math.Sinh(a);
            label1.Text = s.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double s = Math.Cosh(a);
            label1.Text = s.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double s = Math.Tanh(a);
            label1.Text = s.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //g.DrawEllipse(new Pen(Color.Blue), 20, 20, 150, 150);
            //g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, 10, 20);
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double n = Convert.ToDouble(textBox5.Text);
            double x1= Convert.ToDouble(textBox6.Text);
            double x2 =Convert.ToDouble(textBox7.Text);
            double A;
            double B;
            double x = x1;
            double y;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
            while (x < x2)
            {
                y = a * Math.Pow((Math.Sin(b * (Math.Pow(x, m)) + c)), n)+100;
                A = x + Math.Abs(x1);
                y = -y + 300;
                float firstpointq;
                float firstpointp;
                firstpointq = Convert.ToSingle(A);
                firstpointp = Convert.ToSingle(y);
                x += 0.01;
                y = a * Math.Pow((Math.Sin(b * (Math.Pow(x, m)) + c)), n)+100;
                B = x + Math.Abs(x1);
                y = -y + 300;
                float secondpointq;
                float secondpointp;
                secondpointq = Convert.ToSingle(B);
                secondpointp = Convert.ToSingle(y);
                g.DrawLine(new Pen(Color.Blue),
                firstpointq,
                firstpointp,
                secondpointq,
                secondpointp);
            }
            label1.Text = "End";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = Convert.ToDouble(textBox4.Text);
            double f= Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x = x1;
            double y;
            double n = 4;
            double A;
            double B;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
            while (x < x2)
            {
                if (a == 0 && b != 0)
                {
                    y = a *
                    Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    A = x + Math.Abs(x1);
                    y = -y + 160;
                    PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                    x += 0.01;
                    y = a * Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    B = x + Math.Abs(x1);
                    y = -y + 160;
                    PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y));
                    g.DrawLine(new Pen(Color.Blue), p1, p2);
                }
                else if (a < 0)
                {
                    y = a *
                    Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    A = x + Math.Abs(x1);
                    y = -y + 50;
                    PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                    x += 0.01;
                    y = a * Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    B = x + Math.Abs(x1);
                    y = -y + 50;
                    PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y));
                    g.DrawLine(new Pen(Color.Blue), p1, p2);
                }
                else if (a == 0 && c < 0)
                {
                    y = a *
                    Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    A = x + Math.Abs(x1);
                    y = -y + 50;
                    PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                    x += 0.01;
                    y = a * Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    B = x + Math.Abs(x1);
                    y = -y + 50;
                    PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y));
                    g.DrawLine(new Pen(Color.Blue), p1, p2);
                }
                else
                {
                    y = a *
Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    A = x + Math.Abs(x1);
                    y = -y + 310;
                    PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                    x += 0.01;
                    y = a * Math.Pow(x, n) + b * Math.Pow(x, n - 1) + c * Math.Pow(x, n - 2) + d * Math.Pow(x, n - 3) + f * Math.Pow(x, n - 4);
                    B = x + Math.Abs(x1);
                    y = -y + 310;
                    PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y));
                    g.DrawLine(new Pen(Color.Blue), p1, p2);
                }
            }
            label1.Text = "End";

        }

        private void button34_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x;
            double y;
            double M;
            double N;
            double s;
            x = x1;
            y = a * Math.Pow(x, n + 1) / (n + 1);
            M = y;
            x = x2;
            y = a * Math.Pow(x, n + 1) / (n + 1);
            N = y;
            s = N - M;
            label1.Text = s.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double n = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double A;
            double B;
            double x = x1;
            double y;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
            while (x < x2)
            {
                y = a * Math.Pow((Math.Cos(b * (Math.Pow(x, m)) + c)), n)+100 ;
                A = x + Math.Abs(x1);
                y = -y + 300;
                float firstpointq;
                float firstpointp;
                firstpointq = Convert.ToSingle(A);
                firstpointp = Convert.ToSingle(y);
                x += 0.01;
                y = a * Math.Pow((Math.Cos(b * (Math.Pow(x, m)) + c)), n)+100 ;
                B = x + Math.Abs(x1);
                y = -y + 300;
                float secondpointq;
                float secondpointp;
                secondpointq = Convert.ToSingle(B);
                secondpointp = Convert.ToSingle(y);
                g.DrawLine(new Pen(Color.Blue),
                firstpointq,
                firstpointp,
                secondpointq,
                secondpointp);
            }
            label1.Text = "End";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x = x1;
            double y;
            double A;
            double B;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
            while (x < x2)
            {
                if (n % 2 == 1)
                {
                    y = a * Math.Pow(x, n);
                    A = x + Math.Abs(x1);
                    y = -y + 170;
                    PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                    x += 0.01;
                    y = a * Math.Pow(x, n);
                    B = x + Math.Abs(x1);
                    y = -y + 170;
                    PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y));
                    g.DrawLine(new Pen(Color.Blue), p1, p2);
                }
                else if (n < 0)
                {
                    if (x1 * x2 <= 0)
                    {
                        label1.Text = "Error";
                        break;
                    }
                    else if (a < 0 && x1 > 0)
                    {
                        y = a * Math.Pow(x, n);
                        A = x + Math.Abs(x1);
                        y = -y + 50;
                        PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                        x += 0.01;
                        y = a * Math.Pow(x, n);
                        B = x + Math.Abs(x1);
                        y = -y + 50;
                        PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                        g.DrawLine(new Pen(Color.Blue), p1, p2);
                    }
                    else if (a > 0 && x1 > 0)
                    {
                        y = a * Math.Pow(x, n);
                        A = x + Math.Abs(x1);
                        y = -y + 300;
                        PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                        x += 0.01;
                        y = a * Math.Pow(x, n);
                        B = x + Math.Abs(x1);
                        y = -y + 300;
                        PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                        g.DrawLine(new Pen(Color.Blue), p1, p2);
                    }
                    else if (x1 < 0)
                    {
                        if (a > 0)
                        {
                            y = a * Math.Pow(x, n);
                            A = x + Math.Abs(x1);
                            y = -y + 100;
                            PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                            x += 0.01;
                            y = a * Math.Pow(x, n);
                            B = x + Math.Abs(x1);
                            y = -y + 100;
                            PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                            g.DrawLine(new Pen(Color.Blue), p1, p2);
                        }
                        else
                        {
                            y = a * Math.Pow(x, n);
                            A = x + Math.Abs(x1);
                            y = -y + 300;
                            PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                            x += 0.01;
                            y = a * Math.Pow(x, n);
                            B = x + Math.Abs(x1);
                            y = -y + 300;
                            PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                            g.DrawLine(new Pen(Color.Blue), p1, p2);
                        }
                    }
                    else
                    {
                        if (a > 0)
                        {

                            y = a * Math.Pow(x, n);
                            A = x + Math.Abs(x1);
                            y = -y + 300;
                            PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                            x += 0.01;
                            y = a * Math.Pow(x, n);
                            B = x + Math.Abs(x1);
                            y = -y + 300;
                            PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                            g.DrawLine(new Pen(Color.Blue), p1, p2);
                        }
                        else
                        {
                            y = a * Math.Pow(x, n);
                            A = x + Math.Abs(x1);
                            y = -y + 50;
                            PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                            x += 0.01;
                            y = a * Math.Pow(x, n);
                            B = x + Math.Abs(x1);
                            y = -y + 50;
                            PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                            g.DrawLine(new Pen(Color.Blue), p1, p2);
                        }
                    }
                }
                else if (a < 0)
                {
                    y = a * Math.Pow(x, n);
                    A = x + Math.Abs(x1);
                    y = -y + 50;
                    PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                    x += 0.01;
                    y = a * Math.Pow(x, n);
                    B = x + Math.Abs(x1);
                    y = -y + 50;
                    PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                    g.DrawLine(new Pen(Color.Blue), p1, p2);
                }
                else
                {
                    y = a * Math.Pow(x, n);
                    A = x + Math.Abs(x1);
                    y = -y + 300;
                    PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                    x += 0.01;
                    y = a * Math.Pow(x, n);
                    B = x + Math.Abs(x1);
                    y = -y + 300;
                    PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                    g.DrawLine(new Pen(Color.Blue), p1, p2);
                }


            }
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double s;
            if (a <= 0 || b <= 0)
            {
                label1.Text = "Error";
            }
            else
            {
                s = Math.Log10(a) / Math.Log10(b);
                label1.Text = s.ToString();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double n = Convert.ToDouble(textBox5.Text);
            double x1 =Convert.ToDouble(textBox6.Text);
            double x2 =Convert.ToDouble(textBox7.Text);
            double x;
            x=x1;
            double y;
            double A;
            double B;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
            while (x < x2)
            {
                if (a > 0)
                {
                    y = a * Math.Pow((Math.Log10(b * Math.Pow(x, m) + c)), n);
                    if (b * Math.Pow(x, m) + c <= 0)
                    {
                        label1.Text = "Error";
                        break;
                    }
                    else
                    {
                        A = x + Math.Abs(x1);
                        y = -y + 280;
                        PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                        x += 0.01;
                        y = a * Math.Pow((Math.Log10(b * Math.Pow(x, m) + c)), n);
                        B = x + Math.Abs(x1);
                        y = -y + 280;
                        PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                        g.DrawLine(new Pen(Color.Blue), p1, p2);
                    }
                }
                else
                {
                    y = a * Math.Pow((Math.Log10(b * Math.Pow(x, m) + c)), n);
                    if (b * Math.Pow(x, m) + c <= 0)
                    {
                        label1.Text = "Error";
                        break;
                    }
                    else
                    {
                        A = x + Math.Abs(x1);
                        y = -y + 50;
                        PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                        x += 0.01;
                        y = a * Math.Pow((Math.Log10(b * Math.Pow(x, m) + c)), n);
                        B = x + Math.Abs(x1);
                        y = -y + 50;
                        PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                        g.DrawLine(new Pen(Color.Blue), p1, p2);
                    }
                }
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double n = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double x;
            x = x1;
            double y;
            double A;
            double B;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
            while (x < x2)
            {
                if (a > 0)
                {
                        y = a * Math.Pow((Math.Pow(Math.E,(b * Math.Pow(x, m) + c))), n);
                        A = x + Math.Abs(x1);
                        y = -y + 280;
                        PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                        x += 0.01;
                        y = a * Math.Pow((Math.Pow(Math.E,(b * Math.Pow(x, m) + c))), n);
                        B = x + Math.Abs(x1);
                        y = -y + 280;
                        PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                        g.DrawLine(new Pen(Color.Blue), p1, p2);
                    
                }
                else
                {
                        y = a * Math.Pow((Math.Pow(Math.E,(b * Math.Pow(x, m) + c))), n);
                        A = x + Math.Abs(x1);
                        y = -y + 50;
                        PointF p1 = new PointF(Convert.ToSingle(A), Convert.ToSingle(y));
                        x += 0.01;
                        y = a * Math.Pow((Math.Pow(Math.E,(b * Math.Pow(x, m) + c))), n);
                        B = x + Math.Abs(x1);
                        y = -y + 50;
                        PointF p2 = new PointF(Convert.ToSingle(B), Convert.ToSingle(y)); g.DrawLine(new Pen(Color.Blue), p1, p2);
                        g.DrawLine(new Pen(Color.Blue), p1, p2);
                    
                }
            }
            label1.Text = "End";
        }

        private void button41_Click(object sender, EventArgs e)
        {       
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double n = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox6.Text);
            double x2 = Convert.ToDouble(textBox7.Text);
            double A;
            double B;
            double x = x1;
            double y;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.SkyBlue);
            while (x < x2)
            {
                y = a * Math.Pow((Math.Atan(b * (Math.Pow(x, m)) + c)), n);
                A = x + Math.Abs(x1);
                y = -y + 170;
                float firstpointq;
                float firstpointp;
                firstpointq = Convert.ToSingle(A);
                firstpointp = Convert.ToSingle(y);
                x += 0.01;
                y = a * Math.Pow((Math.Atan(b * (Math.Pow(x, m)) + c)), n);
                B = x + Math.Abs(x1);
                y = -y + 170;
                float secondpointq;
                float secondpointp;
                secondpointq = Convert.ToSingle(B);
                secondpointp = Convert.ToSingle(y);
                g.DrawLine(new Pen(Color.Blue),
                firstpointq,
                firstpointp,
                secondpointq,
                secondpointp);
            }
            label1.Text = "End";
        }
       
    }
}


