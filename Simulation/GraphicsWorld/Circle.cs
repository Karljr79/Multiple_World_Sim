using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphicsWorld
{
    public class Circle : GraphicsObject
    {
        float radius = 5;
        System.Drawing.Pen p;

        public Circle(float x, float y, float r)
        {
            this.x = x;
            this.y = y;
            this.radius = r;
            this.p = new System.Drawing.Pen(Color.Black, 3.0f);
        }

        public Circle(float x, float y, float r, Color color)
        {
            this.x = x;
            this.y = y;
            this.radius = r;
            this.p = new System.Drawing.Pen(color, 3.5f);
        }

        public override void drawSelf(System.Drawing.Graphics g)
        {
            g.DrawEllipse(p, x, y, radius, radius);
        }
    }
}
