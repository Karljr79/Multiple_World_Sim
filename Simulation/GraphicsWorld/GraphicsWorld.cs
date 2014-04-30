using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsWorld
{
    public class GraphicsWorld
    {
        ArrayList gobjects = new ArrayList();

        public void Add(GraphicsObject gobj)
        {
            gobjects.Add(gobj);
        }

        public void Delete(GraphicsObject gobj)
        {
            gobjects.Remove(gobj);
        }

        public void drawAll(Graphics g)
        {
            foreach(object obj in gobjects)
            {
                GraphicsObject gobj = (GraphicsObject) obj; //needed to cast because we used arraylist which can store mixed items
                gobj.drawSelf(g);
            }
        }
    }
}
