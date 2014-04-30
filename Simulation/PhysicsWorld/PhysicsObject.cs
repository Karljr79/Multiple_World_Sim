using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace PhysicsWorld
{
    public abstract class PhysicsObject
    {
        PhysicsWorld pworld; //a pointer to the world itself so the object knows where it is
        protected Vec2 pos;

        public Vec2 Pos
        {
            get { return pos; }
        }
        public abstract void Step(float dt); //because all physics obj are different we only declare it here
    }
}