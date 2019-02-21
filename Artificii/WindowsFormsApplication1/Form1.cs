using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_albastru;
            System.Random n;
            System.Drawing.Pen Radiera;
            int x0, y0, x1, y1, a, r, fel_c;
            double a_r;
       void deseneaza()
            {   if(fel_c==0)
            {
                //Desen.Clear(this.BackColor);
                x0 = n.Next(this.Width);
                y1 = n.Next(this.Height);
                for (a = 0; a <= 360; a += 6)
                    {
                        r =100+ n.Next(100);
                        a_r = a * Math.PI / 180;
                        x1 = x0 + System.Convert.ToInt16(r * Math.Cos(a_r));
                        y1 = y0 + System.Convert.ToInt16(r * Math.Sin(a_r));
                        Desen.DrawLine(Creion_albastru, x0, y0, x1, y1);
                    }
                fel_c=1;
            } 
           else
            {
                for (a = 0; a <= 360; a += 6)
                {
                    r = 100 + n.Next(100);
                    a_r = a * Math.PI / 180;
                    x1 = x0 + System.Convert.ToInt16(r * Math.Cos(a_r));
                    y1 = y0 + System.Convert.ToInt16(r * Math.Sin(a_r));
                    Desen.DrawLine(Radiera, x0, y0, x1, y1);
                }
                fel_c = 0;
            }
            }
        private void Form1_Load(object sender, EventArgs e)
        {
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Radiera = new System.Drawing.Pen(this.BackColor);
            n = new System.Random();
            a = 33;
            x0 = 100;
            y0 = 100;
            fel_c = 0;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            deseneaza();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            deseneaza();
        }
}       
}

