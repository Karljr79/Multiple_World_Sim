using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace CollisionWorld
{
    public class CircleShell : CollisionShell
    {
        public float radius;

        public CircleShell(Vec2 p, float r, Object userData) : base(p, userData)
        {
            this.radius = r;
        }

        public CircleShell(Vec2 p, float r) : base(p)
        {
            this.radius = r;
        }

        public String getShell()
        {
            return "Circle";
        }

    }
}
