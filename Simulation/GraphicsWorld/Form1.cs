using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicsWorld
{
    public partial class Form1 : Form
    {
        GraphicsWorld world = new GraphicsWorld();
        GraphicsObject movingobj = new Circle(0, 0, 10);
        public Form1()
        {
            InitializeComponent();
            GraphicsObject gobj = new Circle(200, 200, 30);
            world.Add(gobj);
            gobj = new Circle(100, 100, 20);
            world.Add(gobj);
            world.Add(movingobj);
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 5);
            world.drawAll(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movingobj.x = movingobj.x + 1;
            movingobj.y = movingobj.y + 1;
            panel1.Refresh();
        }
    }
}
