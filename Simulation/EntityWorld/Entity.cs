using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphicsWorld;
using PhysicsWorld;
using CollisionWorld;
using Utilities;


namespace EntityWorld
{
    public class Entity
    {
        public EWorld eworld;
        public GraphicsObject gobj;
        public PointMass pm;
        public CollisionShell cshell;

        public Entity() { } 

        internal void UpdateGraphics()
        {
            gobj.x = pm.Pos.x;
            gobj.y = pm.Pos.y;
        }

        internal void UpdateCollisionShell()
        {
            cshell.position.x = pm.Pos.x;
            cshell.position.y = pm.Pos.y;
        }
    }
}
