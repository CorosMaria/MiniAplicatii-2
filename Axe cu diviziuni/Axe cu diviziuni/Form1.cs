using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Axe_cu_diviziuni
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_albastru;
        System.Drawing.Pen Creion_rosu;
        int n, i;
        public Form1()
        {
            InitializeComponent();
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.Red);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Desen.DrawLine(Creion_albastru, 10, 300, this.Width - 30, 300);
            Desen.DrawLine(Creion_albastru, 15, 20, 15, 310);
            for (i = 1; i <=this.Width-50; i++)
            {
                Desen.DrawLine(Creion_rosu, 15 + i, 295, 15 + i, 305);
                i = i + 10;
            }
            for (i = 1; i <= 280; i++)
            {
                Desen.DrawLine(Creion_rosu, 10, 300 - i, 20, 300 - i);
                i = i + 10;
            }
            Desen.DrawLine(Creion_albastru, this.Width - 50, 280, this.Width - 30, 300);
            Desen.DrawLine(Creion_albastru, this.Width - 50, 320, this.Width - 30, 300);
            Desen.DrawLine(Creion_albastru, 0, 40, 15, 20);
            Desen.DrawLine(Creion_albastru, 15, 20, 30, 40);
        }
    }
}
