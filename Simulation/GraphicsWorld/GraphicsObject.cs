﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsWorld
{
    public abstract class GraphicsObject
    {
        public float x, y;
        public abstract void drawSelf(Graphics g);
    }
}
