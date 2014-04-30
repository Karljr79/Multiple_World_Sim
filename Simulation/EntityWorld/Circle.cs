using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhysicsWorld;
using GraphicsWorld;
using CollisionWorld;
using Utilities;
using System.Drawing;

namespace EntityWorld
{
    public class Circle : Entity
    {
        public Circle(EWorld ew, Vec2 pos, Vec2 vel, float radius, float mass, Color color)
        {
            this.eworld = ew;

            this.cshell = new CircleShell(pos, radius);
            this.pm = new PhysicsWorld.PointMass(mass, pos, vel);
            this.gobj = new GraphicsWorld.Circle(pos.x, pos.y, radius, color);
            this.cshell.userData = this;
            this.pm.userData = this;

            eworld.Gworld.Add(this.gobj);
            eworld.Cworld.Add(this.cshell);
            eworld.Pworld.Add(this.pm);
        }
    }
}
