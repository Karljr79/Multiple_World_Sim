using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace CollisionWorld
{
    public class CollisionPair
    {
        public CollisionShell a;
        public CollisionShell b;
        public Vec2 userData;

        public CollisionPair(CollisionShell a, CollisionShell b)
        {
            this.a = a;
            this.b = b;
        }

        public CollisionPair(CollisionShell a, CollisionShell b, Vec2 force)
        {
            this.a = a;
            this.b = b;
            this.userData = force;
        } 
    }
}
